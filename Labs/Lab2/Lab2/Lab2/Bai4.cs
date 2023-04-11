using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters;

namespace Lab2
{
    public partial class Bai4 : Form
    {
        List<SinhVien> dssv = new List<SinhVien>();
        public Bai4()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string _name = inputName.Text;
                string _id = inputID.Text;
                string _phone = inputPhone.Text;
                double _course1 = double.Parse(inputC1.Text);
                double _course2 = double.Parse(inputC2.Text);
                double _course3 = double.Parse(inputC3.Text);
                double[] score = new double[3] { _course1, _course2, _course3 };
                validateInput(_id,_phone,score);

                SinhVien sv = new SinhVien(_name,_id,_phone,_course1,_course2,_course3);
                dssv.Add(sv);
                inputResult.AppendText(sv.ToString());

            }
            catch(InputException ex)
            {
                MessageBox.Show(ex.Message,"ERROR");
            }
            catch(FormatException)
            {
                MessageBox.Show("Invalid Score");
            }
        }

        private void validateInput(string id, string phone, double[] score )
        {
            if(id.Length < 8 || id.Length > 8)
            {
                throw new InputException("Invalid ID");
            }
            if(phone.Length < 10 || phone.Length > 10)
            {
                throw new InputException("Invalid Phone Number");
            }
            else
            {
                if(phone[0] != '0') throw new InputException("Invalid Phone Number");   
            }
            foreach(int s in score)
            {
                if (s < 0 || s > 10) throw new InputException("Invalid Score");
            }
        }

        private void ClearScreen()
        {
            foreach(Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    control.ResetText();
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        public class InputException : Exception
        {
            public InputException(string msg) : base(msg) { }
        }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            try
            {

                string path = Application.StartupPath + "\\input4.txt";
                bool checkSave = MyData.SaveFile(dssv,path);
                if (checkSave)
                {
                    MessageBox.Show($"Saved file at {path}");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }
        int current_idx;
        private void readBtn_Click(object sender, EventArgs e)
        {
            try
            {
                backBtn.Enabled = false;
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                dssv = MyData.ReadFile(ofd.FileName);
                current_idx = 0;
                ShowResult(dssv[current_idx]);
                idx.Text = (current_idx + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void ShowResult(SinhVien sv)
        {
            outName.Text = sv.name;
            outID.Text = sv.id;
            outPhone.Text = sv.phone;
            outC1.Text = sv.course1.ToString();
            outC2.Text = sv.course2.ToString();
            outC3.Text = sv.course3.ToString();
            averageBox.Text = sv.avg.ToString();
        }
        // ===================================== Class SinhVien =====================================//
        [Serializable]
        public class SinhVien 
        {
            public string name { get; set; }
            public string id { get; set; }
            public string phone { get; set; }
            public double course1 { get; set; }
            public double course2 { get; set; }
            public double course3 { get; set; }
            public double avg;

            public override string ToString()
            {
                string output = $"Name : {name}\r\n" +
                $"ID : {id}\r\n" +
                $"Phone : {phone}\r\n" +
                $"Course 1 : {course1}\r\n" +
                $"Course 2 : {course2}\r\n" +
                $"Course 3 : {course3}\r\n";
                return output;
            }

            public SinhVien(string _name, string _id, string _phone, double _course1, double _course2, double _course3)
            {
                this.name = _name;
                this.id = _id;
                this.phone = _phone;
                this.course1 = _course1;
                this.course2 = _course2;
                this.course3 = _course3;
                this.avg = (_course1 + _course2 + _course3)/3;
            }
        }
        // ===================================== Class MyData =====================================//

        public class MyData
        {
            public static bool SaveFile(List<SinhVien> dssv, string path)
            {
                try
                {
                    FileStream fs = new FileStream(path, FileMode.Create);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, dssv);
                    fs.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return false;
            }

            public static List<SinhVien> ReadFile(string path)
            {

                List<SinhVien> _dssv = new List<SinhVien>();
                FileStream fs = new FileStream(path, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                object data = bf.Deserialize(fs);
                fs.Close();
                return data as List<SinhVien>;
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (current_idx == dssv.Count - 1)
            {
                nextBtn.Enabled = false;
                return;
            }
            if (current_idx <= dssv.Count && current_idx >= 0)
            {
                nextBtn.Enabled = true;
                backBtn.Enabled = true;
                current_idx++;
                ShowResult(dssv[current_idx]);
                idx.Text = (current_idx + 1).ToString();
                if(current_idx == dssv.Count - 1)
                {
                    nextBtn.Enabled = false;
                    backBtn.Enabled = true;
                    return;
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if(current_idx == 0)
            {
                backBtn.Enabled = false;
            }
            if(current_idx <= dssv.Count && current_idx > 0)
            {
                backBtn.Enabled=true;
                nextBtn.Enabled = true;
                current_idx--;
                ShowResult(dssv[current_idx]);
                idx.Text = (current_idx + 1).ToString();
                if(current_idx == 0)
                {
                    backBtn.Enabled = false;
                    nextBtn.Enabled = true;
                    return;
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath + "\\input4.txt";
                string out_path = Application.StartupPath + "\\output4.txt";
                dssv = MyData.ReadFile(path);
                FileStream fs = new FileStream(out_path, FileMode.Create);
                StreamWriter writter = new StreamWriter(fs);
                foreach (SinhVien sv in dssv)
                {
                    string res = sv.ToString() + $"Average : {sv.avg}\n";
                    writter.Write(res);
                }
                MessageBox.Show($"Saved result at {out_path}");
                writter.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR");
            }

        }
    }
}
