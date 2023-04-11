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
    public partial class Bai1 : Form
    {
        string filePath;
        public Bai1()
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
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs,Encoding.UTF8);
                filePath = ofd.FileName;
                fs.Seek(0, SeekOrigin.Begin);
                textBox1.Text += sr.ReadToEnd();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR");
            }
        }

        private void writeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var _fileName = filePath.Split('\\');
                string input = _fileName[_fileName.Length - 1];
                string outPath = filePath.Replace(input, "output1.txt"); 
                FileStream fs = new FileStream(outPath, FileMode.CreateNew);
                StreamWriter writter = new StreamWriter(fs);
                writter.Write(textBox1.Text.ToUpper());
                MessageBox.Show("Write Success");
                writter.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
