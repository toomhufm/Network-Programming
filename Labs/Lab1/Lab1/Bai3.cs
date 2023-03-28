using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void spellBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Int32.Parse(textBox1.Text);
                if(n > 10 || n < 0)
                {
                    throw new NumberException("Number must in range [0,10]");
                }
                switch (n)
                {
                    case 0:
                        textBox2.Text = "Không";
                        break;
                    case 1:
                        textBox2.Text = "Một";
                        break;
                    case 2:
                        textBox2.Text = "Hai";
                        break;
                    case 3:
                        textBox2.Text = "Ba";
                        break;
                    case 4:
                        textBox2.Text = "Bốn";
                        break;
                    case 5:
                        textBox2.Text = "Năm";
                        break;
                    case 6:
                        textBox2.Text = "Sáu";
                        break;
                    case 7:
                        textBox2.Text = "Bảy";
                        break;
                    case 8:
                        textBox2.Text = "Tám";
                        break;
                    case 9:
                        textBox2.Text = "Chín";
                        break;
                    case 10:
                        textBox2.Text = "Mười";
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter number only!");
            }
            catch (NumberException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public class NumberException : Exception
        {
            public NumberException(string msg) : base(msg) { }
        }
    }
}
