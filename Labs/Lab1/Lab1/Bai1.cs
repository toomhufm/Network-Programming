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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }


        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
            long n1 = Int64.Parse(num1.Text);
            long n2 = Int64.Parse(num2.Text);
            Result.Text = (n1 + n2).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Integer overflow!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
