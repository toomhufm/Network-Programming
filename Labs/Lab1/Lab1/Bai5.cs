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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numA.Clear();
            numB.Clear();
            resultBox.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Int32.Parse(numA.Text);
                int b = Int32.Parse(numB.Text);
                int facA = factorial(a);
                int facB = factorial(b);
                if(facA < 0 || facB < 0)
                {
                    throw new OverflowException("Integer Overflow!");
                }
                resultBox.Text = $"A!= {facA.ToString()}" + "\r\n"
                    + $"B!= {facB.ToString()}" + "\r\n"
                    + $"S1 = 1 + 2 + 3 + 4 + ... + A = {sumToNum(a)}" + "\r\n"
                    + $"S2 = 1 + 2 + 3 + 4 + ... + B = {sumToNum(b)}" + "\r\n"
                    + $"S3 = A^1 + A^2 + A^3 + A^4 + ... + A^B = {sumToAPowB(a, b)}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter integer!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Integer Overflow!");
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        public int factorial(int a)
        {

            int res = 1;
            for(int i = 1; i <= a; i++)
            {
                res *= i;
            }
            return res;
        }

        public int sumToNum(int a)
        {
            int res = 0;
            for(int i = 1; i<= a; i++)
            {
                res += i;
            }
            return res;
        }

        public int sumToAPowB(int a, int b)
        {
            int res = 0;
            for(int i = 1; i <= b; i++)
            {
                res += Convert.ToInt32(Math.Pow(a, i));
            }
            return res;
        }
    }
}
