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

namespace Lab2
{
    public partial class Bai3 : Form
    {
        string filePath;
        public Bai3()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                filePath = ofd.FileName;
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                fs.Seek(0, SeekOrigin.Begin);
                textBox1.Text = sr.ReadToEnd();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            string[] equation = textBox1.Text.Split('\n');
            string result = "";
            foreach(string eq in equation)
            {
                double res = Evaluate(eq);
                result += $"{eq.TrimEnd()} = {res}\n";
            }
            var _fileName = filePath.Split('\\');
            string input = _fileName[_fileName.Length - 1];
            string outPath = filePath.Replace(input, "output3.txt");
            FileStream fs = new FileStream(outPath, FileMode.CreateNew);
            StreamWriter writter = new StreamWriter(fs);
            writter.Write(result);
            MessageBox.Show($"Calculated, output is saved at {outPath}");
            writter.Close();
        }

        public static double Evaluate(string expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expression, String.Empty));
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
