using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurantreserve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void avail_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string price;
            string timeprice;


            // Day price

            if (Daybox.Text == "Monday")
            {
                price = "cheap";
            }
            else if (Daybox.Text == "Tuesday")
            {
                price = "cheap";
            }
            else if (Daybox.Text == "Wednesday")
            {
                price = "cheap";
            }
            else if (Daybox.Text == "Thursday")
            {
                price = "cheap";
            }
            else if (Daybox.Text == "Friday")
            {
                price = "expensive";
            }
            else if (Daybox.Text == "Saturday")
            {
                price = "medium";
            }
            else if (Daybox.Text == "Sunday")
            {
                price = "cheap";
            }




            // Time price

            timeprice = "cheap";
            price = "cheap";

            if (Timebox.Text == "5.00pm")
            {
                timeprice = "cheap";
            }
            else if (Timebox.Text == "5.30pm")
            {
                timeprice = "cheap";
            }
            else if (Timebox.Text == "6.00pm")
            {
                timeprice = "cheap";
            }
            else if (Timebox.Text == "6.30pm")
            {
                timeprice = "cheap";
            }
            else if (Timebox.Text == "7.00pm")
            {
                timeprice = "expensive";
            }
            else if (Timebox.Text == "7.30pm")
            {
                timeprice = "expensive";
            }
            else if (Timebox.Text == "8.00pm")
            {
                timeprice = "expensive";
            }
            else if (Timebox.Text == "8.30pm")
            {
                timeprice = "expensive";
            }
            else if (Timebox.Text == "9.00pm")
            {
                timeprice = "medium";
            }
            else if (Timebox.Text == "9.30pm")
            {
                timeprice = "medium";
            }
            else if (Timebox.Text == "10.00pm")
            {
                timeprice = "medium";
            }

            double seatprice;
            double overallprice;
            overallprice = 0.00;
            if (timeprice == "cheap" && price == "cheap" )
            {
                overallprice = 2.00;
            }
            else if (timeprice == "cheap" && price == "medium")
            {
                overallprice = 2.50;
            }
            else if (timeprice == "cheap" && price == "expensive")
            {
                overallprice = 3.00;
            }
            else if (timeprice == "medium" && price == "cheap")
            {
                overallprice = 2.50;
            }
            else if (timeprice == "medium" && price == "medium")
            {
                overallprice = 3.00;
            }
            else if (timeprice == "medium" && price == "expensive")
            {
                overallprice = 3.50;
            }
            else if (timeprice == "expensive" && price == "cheap")
            {
                overallprice = 3.00;
            }
            else if (timeprice == "expensive" && price == "medium")
            {
                overallprice = 3.50;
            }
            else if (timeprice == "expensive" && price == "expensive")
            {
                overallprice = 4.00;
            }
            
            seatprice = (overallprice * Convert.ToDouble(Seatdrop.Value));
            Convert.ToDouble(seatprice);

            label6.Text = Convert.ToString(seatprice);
            avail.Text = "Available";

        }



        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
