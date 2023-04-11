using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GongSolutions.Shell;
using System.IO;
namespace Lab2
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void shellView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ShellItem item = shellView1.SelectedItems[0];
                string path = item.FileSystemPath;
                FileInfo fi = new FileInfo(path);
                string[] img_ext = new string[] { ".png", ".jpg" };
                fileContent.Controls.Clear();
                if(fi.Extension == img_ext[0] || fi.Extension == img_ext[1])
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(370, 417);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Location = new Point(3, 3);
                    fileContent.Controls.Add(pictureBox);
                    pictureBox.ImageLocation = path;
                    pictureBox.Show();
                }
                else
                {
                    TextBox textBox = new TextBox();
                    textBox.Size = new Size(370, 417);
                    textBox.Multiline = true;
                    textBox.ReadOnly = true;
                    textBox.ScrollBars = ScrollBars.Both;
                    fileContent.Controls.Add(textBox);
                    StreamReader sr = new StreamReader(path);
                    textBox.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
