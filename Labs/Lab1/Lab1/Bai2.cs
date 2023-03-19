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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            try
            {
            double n1 = Double.Parse(num1.Text);
            double n2 = Double.Parse(num2.Text);
            double n3 = Double.Parse(num3.Text);
            double min = getMin(n1,n2, n3);
            double max = getMax(n1,n2, n3);
            minBox.Text = min.ToString();
            maxBox.Text = max.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter number");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public double getMin(double a, double b, double c)
        {
            double min = a;
            if(b < min && b < c) { return b; }
            if(c < min && c < b) { return c; }
            return min;
        }

        public double getMax(double a, double b, double c)
        {
            double max = a;
            if(b > max && b > c) { return b; }
            if(c > max && c > b) { return c; }
            return max;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            num1.Clear();
            num2.Clear();
            num3.Clear();
            minBox.Clear();
            maxBox.Clear();
        }
    }
}
