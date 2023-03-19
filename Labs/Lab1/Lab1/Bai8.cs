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
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            infoBox.Clear();
            resultBox.Clear();
            avgBox.Clear();
            highBox.Clear();
            lowBox.Clear();
            dataBox.Clear();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string[] info = infoBox.Text.Split('\u002C');
                double[] score = new double[info.Length - 1];
                for(int i = 0; i < score.Length; i++)
                {
                    score[i] = Double.Parse(info[i+1]);
                }
                scoreValidiation(score);
                double[] result = scoreCalculate(score);
                avgBox.Text = String.Format("{0:0.00}", result[0]);
                lowBox.Text = result[1].ToString();
                highBox.Text = result[2].ToString();

                dataBox.Text = infoToString(info) + passCheck(score);

                resultBox.Text = rating(score, result[0]);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid value for score!");
            }
            catch (scoreException ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public double[] scoreCalculate(double[] score)
        {
            double[] result = new double[3];
            Array.Sort(score);
            double avg = 0;
            for (int i = 0; i < score.Length; i++)
            {
                avg += score[i];
            }
            result[0] = avg/score.Length; // Average
            result[1] = score[0]; // Lowest
            result[2] = score[score.Length - 1]; // Highest
            return result;
        }

        public void scoreValidiation(double[] score)
        {
            foreach(double i in score)
            {
                if(i < 0 || i > 10)
                {
                    throw new scoreException("Invalid value for score!");
                }
            }
        }

        public string infoToString(string[] info)
        {
            string result = $"Full Name : {info[0]}\r\n";
            for (int i = 1; i < info.Length; i++)
            {
                result += $"Subject {i} : {info[i]}\r\n";
            }
            return result;
        }

        public string passCheck(double[] score)
        {
            int pass = 0, fail = 0;
            for(int i = 0; i < score.Length; i++)
            {
                if(score[i] >= 5)
                {
                    pass++;
                }
                else
                {
                    fail++;
                }
            }
            string cross = "==================\r\n";
            return cross + $"Pass : {pass} Subjects\r\nFail : {fail} Subjects";
        }

        public string rating(double[] score, double avg)
        {
            string rate = "";
            bool lessThan6_5 = false;
            bool lessThan5 = false;
            bool lessThan3_5 = false;
            bool lessThan2 = false;

            foreach(double i in score)
            {
                if(i < 6.5) { lessThan6_5 = true; }
                if(i < 5) { lessThan5 = true; }
                if(i < 3.5) { lessThan3_5= true; }
                if(i < 2) { lessThan2 = true; }
            }

            if(avg >= 8 && !lessThan6_5)
            {
                rate = "Excelent";
            }
            else if(avg >= 6.5 && !lessThan5)
            {
                rate = "Good";
            }
            else if(avg >= 5 && !lessThan3_5)
            {
                rate = "Fair";
            }
            else if(avg >= 3.5 && !lessThan2)
            {
                rate = "Poor";
            }
            else
            {
                rate = "Very Poor";
            }
            return rate;
        }


        public class scoreException : Exception
        {
            public scoreException(string msg) : base(msg) { }
        }
    }
}
