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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            string vehicle = vehicleBox.Text;
            string fuel = fuelBox.Text;

            try
            {
                switch (vehicle)
                {
                    case "Wave Alpha":
                        if(fuel == "DO")
                        {
                            throw new FuelException("Wrong type of fuel!");
                        }
                        else
                        {
                            double fpk = 1.6;
                            double capacity = 3.7;
                            resultBox.Text = distanceCalculation(fpk, capacity, fuel) + "\r\n" + costCalculation(fuel,capacity);   
                        }
                        break;
                    case "Sirius":
                        if (fuel == "DO")
                        {
                            throw new FuelException("Wrong type of fuel!");
                        }
                        else
                        {
                            double fpk = 1.99;
                            double capacity = 3.8;
                            resultBox.Text = distanceCalculation(fpk, capacity, fuel) + "\r\n" + costCalculation(fuel, capacity);
                        }
                        break;
                    case "Vision":
                        if (fuel == "DO")
                        {
                            throw new FuelException("Wrong type of fuel!");
                        }
                        else
                        {
                            double fpk = 1.87;
                            double capacity = 5.2;
                            double volume = capacity / fpk;
                            resultBox.Text = distanceCalculation(fpk, capacity, fuel) + "\r\n" + costCalculation(fuel, volume);
                        }
                        break;
                    case "Lead":
                        if (fuel == "DO")
                        {
                            throw new FuelException("Wrong type of fuel!");
                        }
                        else if (fuel == "RON 92-II")
                        {
                            throw new FuelException("Wrong type of fuel!");
                        }
                        else
                        {
                            double fpk = 2.02;
                            double capacity = 6.0;
                            resultBox.Text = distanceCalculation(fpk, capacity, fuel) + "\r\n" + costCalculation(fuel, capacity);
                        }
                        break;
                    case "Winner":
                        if (fuel == "DO")
                        {
                            throw new FuelException("Wrong type of fuel!");
                        }
                        else if (fuel == "RON 92-II")
                        {
                            throw new FuelException("Wrong type of fuel!");
                        }
                        else
                        {
                            double fpk = 1.7;
                            double capacity = 4.5;
                            resultBox.Text = distanceCalculation(fpk, capacity, fuel) + "\r\n" + costCalculation(fuel, capacity);
                        }
                        break;
                    case "AirBlade":
                        if (fuel == "DO")
                        {
                            throw new FuelException("Wrong type of fuel!");
                        }
                        else if (fuel == "RON 92-II")
                        {
                            throw new FuelException("Wrong type of fuel!");
                        }
                        else
                        {
                            double fpk = 2.17;
                            double capacity = 4.4;
                            resultBox.Text = distanceCalculation(fpk, capacity, fuel) + "\r\n" + costCalculation(fuel, capacity);
                        }
                        break;
                    case "9 Tons Truck":
                        if (fuel == "RON 95-III")
                        {
                            throw new FuelException("Wrong type of fuel!");
                        }
                        else if (fuel == "RON 92-II")
                        {
                            throw new FuelException("Wrong type of fuel!");
                        }
                        else
                        {
                            double fpk = 13;
                            double capacity = 70;
                            resultBox.Text = distanceCalculation(fpk, capacity, fuel) + "\r\n" + costCalculation(fuel, capacity);
                        }
                        break;


                }
            }
            catch(FuelException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        public class FuelException : Exception
        {
            public FuelException(string msg) : base(msg) { }
        }

        public string distanceCalculation(double fpk, double capacity, string fuel)
        {
            double distance = (capacity * 100) / fpk;
            return $"Distance : {Math.Round(distance)}km";

        }
        public string costCalculation(string fuel, double capacity)
        {
            string[] fuelType = new string[] { "RON 95-III", "RON 92-II", "DO" };
            double price = 1;
            if(fuel == fuelType[0]) { price = 26830; }
            else if(fuel == fuelType[1]) { price = 26070; }
            else { price = 21310; }
            return $"Cost : {Math.Round(capacity * price)} VND";
        }
    }
}
