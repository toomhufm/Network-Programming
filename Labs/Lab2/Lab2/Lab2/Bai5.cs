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
using System.IO.Compression;

namespace Lab2
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
            progressBar.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string path;
        string name;
        private void chooseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                path = ofd.FileName;
                var bytes = System.IO.File.ReadAllBytes(path);
                FileInfo fi = new FileInfo(path);
                name = fi.Name;
                filePath.Text = fi.Name;
                if (fi.Extension == ".gz")
                {
                    compressBtn.Text = "Decompress";
                }
                else
                {
                    compressBtn.Text = "Compress";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }

        }

        internal class Compressor
        {
            public static byte[] Compress(byte[] file)
            {
                using (var outputStream = new MemoryStream())
                {
                    using (var compressionStream = new GZipStream(outputStream, CompressionLevel.Optimal))
                    {
                        compressionStream.Write(file, 0, file.Length);
                    }
                    return outputStream.ToArray();
                }
            }

            public static byte[] Decompress(byte[] file)
            {
                using (var inputStream = new MemoryStream(file))
                {
                    using (var outputStream = new MemoryStream())
                    {
                        using (var compressionStream = new GZipStream((Stream)inputStream, CompressionMode.Decompress))
                        {
                            compressionStream.CopyTo(outputStream);
                        }
                        return outputStream.ToArray();
                    }
                }
            }
        }

        private void compressBtn_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bytes = System.IO.File.ReadAllBytes(path);
                if (compressBtn.Text == "Compress")
                {
                    bytes = Compressor.Compress(bytes);
                    string new_path = path.Replace(name, $"{name.Split('.')[0]}.gz");
                    System.IO.File.WriteAllBytes(new_path, bytes);
                    outputFilePath.Text = new_path;
                    MessageBox.Show("Compressed File");
                }
                else
                {
                    bytes = Compressor.Decompress(bytes);
                    string new_path = path.Replace(name, $"{name.Split('.')[0]}.txt");
                    System.IO.File.WriteAllBytes(new_path, bytes);
                    outputFilePath.Text = new_path;
                    MessageBox.Show("Decompressed File");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }
    }
}
