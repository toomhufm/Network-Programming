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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                fs.Seek(0, SeekOrigin.Begin);
                resultBox.Text = sr.ReadToEnd();
                //================== FILE PATH ================//
                pathBox.Text = ofd.FileName.ToString();
                //================== FILE NAME ================//
                var fileName = ofd.FileName.ToString().Split('\\');
                fileNameBox.Text = fileName[fileName.Length - 1];
                //================== FILE SIZE ================//
                FileInfo fi = new FileInfo(ofd.FileName);
                sizeBox.Text = fi.Length.ToString() + " bytes";
                //================== LINES COUNT ================//
                int lines = 0;
                fs.Seek(0, SeekOrigin.Begin);
                while (sr.ReadLine() != null)
                {
                    lines++;
                }
                //================== WORDS COUNT ================//
                fs.Seek(0, SeekOrigin.Begin);
                char[] delimiters = new char[] { ' ', '\r', '\n' ,'\\','/',':','-','?','%','.',','};
                lineBox.Text = lines.ToString();
                string[] words = sr.ReadToEnd().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                wordBox.Text = words.Length.ToString();
                //================== CHAR COUNT ================//
                charBox.Text = fi.Length.ToString();


                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            resultBox.Clear();
            fileNameBox.Clear();
            sizeBox.Clear();
            pathBox.Clear();
            charBox.Clear();
            wordBox.Clear();
            pathBox.Clear();
            lineBox.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
