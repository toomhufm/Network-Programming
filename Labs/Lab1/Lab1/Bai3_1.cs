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
    public partial class Bai3_1 : Form
    {
        public Bai3_1()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numBox.Clear();
            resultBox.Clear();
        }

        public class NumException : Exception
        {
            public NumException(string msg) : base(msg) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double n = Double.Parse(numBox.Text);
                if(n.ToString().Length > 12)
                {
                    throw new NumException("Number must be less than 12 digits");
                }
                NumberToText(n);

            }
            catch (OverflowException)
            {
                MessageBox.Show("Number must be less than 12 digits!");
            }
            catch (NumException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter number only!");
            }

        }

        public string NumberToText(double num)
        {
            
            string[] singleDigits = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] places = new string[] { "", "nghìn", "triệu", "tỷ" };

            string result = "";
            bool isNegative = false;
            string snum = num.ToString();

            if(num < 0)
            {
                num = -num;
                snum = num.ToString();
                isNegative = true;
            }

            // hàng đơn vị, hàng chục, hàng trăm
            int one, ten, hundred;
            int position = snum.Length;

            if(position == 0)
            {
                result += singleDigits[0];
            }
            else
            {
                // Do later
                return result;
            }

            return result;

        }
    }
}
