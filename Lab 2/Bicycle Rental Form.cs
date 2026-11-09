using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class BicycleForm : Form
    {
        public BicycleForm()
        {
            InitializeComponent();
        }

        private void BicycleForm_Load(object sender, EventArgs e)
        {

        }

        private void lblRentalCost_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int startTime = Convert.ToInt32(txtStartHour.Text);
            int endTime = Convert.ToInt32(txtEndHour.Text);

            int total = 0;
            int rate = 0;

            if (startTime < 0 || startTime > 23 ||
                endTime < 1 || endTime > 24 || endTime <= startTime)
            {
                MessageBox.Show("Invalid time");
            }
            else
            {
                for (int hour = startTime; hour < endTime; hour++)
                {
                    if ((hour >= 0 && hour < 7) || (hour >= 21 && hour < 24))
                    {
                        rate = 500;
                    }
                    else if ((hour >= 7 && hour < 14) || (hour >= 19 && hour < 21))
                    {
                        rate = 1000;
                    }
                    else
                    {
                        rate = 1500;
                    }

                    total = total + rate;
                }

                lblRentalCost.Text = "Rental Cost: " + total + " RWF";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChooseForm choose = new ChooseForm();
            choose.Show();
            this.Hide();
        }
    }
}
