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
                long n = Int64.Parse(numBox.Text);
                if(n.ToString().Length > 12)
                {
                    throw new NumException("Number must be less than 12 digits");
                }
                resultBox.Text = NumberToText(n);

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

        public string NumberToText(Int64 number)
        {
            string[] ones = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] tens = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
            string[] groups = { "", "nghìn", "triệu", "tỷ" };
            string result = "";

            // Xử lý trường hợp số bằng 0
            if (number == 0)
                return "không";

            // Xử lý trường hợp số âm
            if (number < 0)
            {
                result += "âm ";
                number = -number;
            }

            int groupIndex = 0;

            // Chia số thành các nhóm 3 chữ số, từ phải sang trái
            while (number > 0)
            {
                long groupValue = number % 1000;
                number /= 1000;

                if (groupValue > 0)
                {
                    string groupString = "";

                    long hundredsDigit = groupValue / 100;
                    long tensDigit = groupValue % 100 / 10;
                    long onesDigit = groupValue % 10;

                    // Xử lý chữ số hàng trăm
                    if (hundredsDigit > 0)
                        groupString += ones[hundredsDigit] + " trăm ";

                    // Xử lý chữ số hàng chục và hàng đơn vị
                    if (tensDigit > 0)
                    {
                        if (tensDigit == 1)
                            groupString += "mười ";
                        else
                            groupString += tens[tensDigit] + " ";
                    }

                    if (onesDigit > 0)
                    {
                        if (tensDigit == 0 && hundredsDigit > 0)
                            groupString += "lẻ ";
                        if (onesDigit == 1 && tensDigit > 1)
                            groupString += "mốt ";
                        else if (onesDigit == 5 && (tensDigit > 0 || hundredsDigit > 0))
                            groupString += "lăm ";
                        else
                            groupString += ones[onesDigit] + " ";
                    }

                    // Thêm đơn vị nhóm vào chuỗi kết quả
                    groupString += groups[groupIndex];

                    // Nếu chuỗi kết quả đã có giá trị, thêm khoảng trắng trước
                    if (result.Length > 0)
                        result = " " + result;

                    // Thêm chuỗi nhóm vào chuỗi kết quả
                    result = groupString + result;
                }

                groupIndex++;
            }

            // Trả về chuỗi kết quả
            return result.Trim();
        }
    }
}
