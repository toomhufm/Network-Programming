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
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int year = Int32.Parse(yearBox.Text);
                int month = Int32.Parse(monthBox.Text);
                int day = Int32.Parse(dayBox.Text);

                bool isLeap = isLeapYear(year);
                Validiation(day, month, year, isLeap);
                signBox.Text = zodiacSign(day, month,year);
                dayofweekBox.Text = dayOfWeek(day,month,year,isLeap);

            }
            catch (DateException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool isLeapYear(int year)
        {
            if(year % 4 == 0 && year % 100 != 0 || year % 400 == 0) { return true; }
            return false;
        }

        public void Validiation(int day, int month, int year, bool isLeap)
        {
            if (isLeap)
            {
                if(month == 2 && day > 29)
                {
                    throw new DateException("Invalid Date!");
                }
            }
            else
            {
                if(month == 2 && day > 28)
                {
                    throw new DateException("Invalid Date!");
                }
            }

            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    if(day > 30)
                    {
                        throw new DateException("Invalid Date!");
                    }
                    break;
            }
        }

        public class DateException : Exception
        {
            public DateException(string msg) : base(msg) { }
        }

        public string zodiacSign(int day, int month,int year)
        {
            string[] signs = new string[] {
            "Aries", "Taurus", "Gemini", "Cancer",
            "Leo", "Virgo", "Libra", "Scorpio",
            "Sagittarius", "Capricorn", "Aquarius", "Pisces"
            };
            DateTime birth = new DateTime(year, month, day);
            // Aries Check
            DateTime signStart = new DateTime(year, 3, 21);
            DateTime signEnd = new DateTime(year, 4, 20);
            if (birth >= signStart && birth <= signEnd) { return signs[0]; }
            // Taurus Check
            signStart = new DateTime(year, 4, 21);
            signEnd = new DateTime(year, 5, 21);
            if (birth >= signStart && birth <= signEnd) { return signs[1]; }
            // Gemini Check
            signStart = new DateTime(year, 5, 22);
            signEnd = new DateTime(year, 6, 21);
            if (birth >= signStart && birth <= signEnd) { return signs[2]; }
            // Cancer Check
            signStart = new DateTime(year, 6, 22);
            signEnd = new DateTime(year, 7, 22);
            if (birth >= signStart && birth <= signEnd) { return signs[3]; }
            // Leo Check
            signStart = new DateTime(year, 7, 23);
            signEnd = new DateTime(year, 8, 22);
            if (birth >= signStart && birth <= signEnd) { return signs[4]; }
            // Virgo Check
            signStart = new DateTime(year, 8, 23);
            signEnd = new DateTime(year, 9, 23);
            if (birth >= signStart && birth <= signEnd) { return signs[5]; }
            // Libra Check
            signStart = new DateTime(year, 9, 24);
            signEnd = new DateTime(year, 10, 23);
            if (birth >= signStart && birth <= signEnd) { return signs[6]; }
            // Scropio Check
            signStart = new DateTime(year, 10, 24);
            signEnd = new DateTime(year, 11, 22);
            if (birth >= signStart && birth <= signEnd) { return signs[7]; }
            // Sagittarius Check
            signStart = new DateTime(year, 11, 23);
            signEnd = new DateTime(year, 12, 21);
            if (birth >= signStart && birth <= signEnd) { return signs[8]; }
            // Capricorn Check
            if (month == 12)
            {
                signStart = new DateTime(year, 12, 22);
                signEnd = new DateTime(year + 1, 1, 20);
                if (birth >= signStart && birth <= signEnd) { return signs[9]; }
            }
            if (month == 1)
            {
                DateTime _birth = new DateTime(year + 1, month, day);
                signStart = new DateTime(year, 12, 22);
                signEnd = new DateTime(year + 1, 1, 20);
                if (_birth >= signStart && _birth <= signEnd) { return signs[9]; }
            }
            // Aquarius Check
            signStart = new DateTime(year, 1, 21);
            signEnd = new DateTime(year, 2, 19);
            if (birth >= signStart && birth <= signEnd) { return signs[10]; }
            // Pisces Check
            signStart = new DateTime(year, 2, 20);
            signEnd = new DateTime(year, 3, 20);
            if (birth >= signStart && birth <= signEnd) { return signs[11]; }

            return "Error!";
        }

        public string dayOfWeek(int day, int month, int year, bool isLeap)
        {
            string[] days = new string[]
            {
                "Sunday","Monday","Tuesday","Wednesday","Thursday",
                "Friday","Saturday"
            };

            // Formula : (Year Code + Month Code + Century Code + Date Number) mod 7
            // If Jan or Feb in leap year, subtract leap year code
            // Year Code Formula : (YY + (YY div 4)) mod 7

            /* https://artofmemory.com/blog/how-to-calculate-the-day-of-the-week/ */

            int yearCode = ((year % 100) + ((year % 100) / 4)) % 7;
            int[] monthCodeList = new int[] { 0,3,3,6,1,4,6,2,5,0,3,5 };
            int[] centuryCode = new int[] { 0, 6 };
            int monthCode = monthCodeList[month - 1];

            int leapCode = isLeap ? 1 : 0;
            int res = 0;
            if(year >= 1920 && year <= 1999)
            {
                if (isLeap)
                {
                    if (month == 1 || month == 2)
                    {
                        res = (yearCode + monthCode + centuryCode[0] + day - leapCode ) % 7;
                    }
                    else
                    {
                        res = (yearCode + monthCode + centuryCode[0] + day) % 7;
                    }
                }
                else
                {
                    res = (yearCode + monthCode + centuryCode[0] + day) % 7;
                }
            }
            else if(year >= 2000)
            {
                if (isLeap)
                {
                    if(month == 1 || month == 2)
                    {
                        res = (yearCode + monthCode + centuryCode[1] + day - leapCode) % 7 ;
                    }
                    else
                    {
                        res = (yearCode + monthCode + centuryCode[1] + day ) % 7;
                    }
                }
                else
                {
                    res = (yearCode + monthCode + centuryCode[1] + day ) % 7;
                }
            }
            return days[res];
        }
    }
}
