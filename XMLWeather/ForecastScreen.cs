using System;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }
        /// <summary>
        /// This method displays forecast information. The information in days at 
        /// </summary>
        public void displayForecast()
        {
            date1.Text = DateTime.Now.AddDays(1).ToString("dddd" + ", " + "MMMM" + " dd");

            max1.Text = Form1.days[1].tempLow + " °C";
            min1.Text = Form1.days[1].tempHigh + " °C";

            condition1.Text = Form1.days[0].conditionFore;

            date2.Text = DateTime.Now.AddDays(2).ToString("dddd" + ", " + "MMMM" + " dd");

            min2.Text = Form1.days[2].tempLow + " °C";
            max2.Text = Form1.days[2].tempHigh + " °C";

            condition2.Text = Form1.days[1].conditionFore;

            date3.Text = DateTime.Now.AddDays(3).ToString("dddd" + ", " + "MMMM" + " dd");

            min3.Text = Form1.days[3].tempLow + " °C";
            max3.Text = Form1.days[3].tempHigh + " °C";

            condition3.Text = Form1.days[2].conditionFore;

            //condition3.Text = Form1.days[3].conditionFore;
            #region image changes
            if (Form1.days[0].conditionFore.Contains("cloud"))
            {
                this.BackgroundImage = (Properties.Resources.cloudy);
                pictureBox1.BackgroundImage = (Properties.Resources.cloudy);
            }
            if (Form1.days[0].conditionFore.Contains("sun"))
            {
                this.BackgroundImage = (Properties.Resources.sunny);
                pictureBox1.BackgroundImage = (Properties.Resources.sun);
            }
            if (Form1.days[0].conditionFore.Contains("rain"))
            {
                this.BackgroundImage = (Properties.Resources.rain);
                pictureBox1.BackgroundImage = (Properties.Resources.rainy);
            }
            if (Form1.days[0].conditionFore.Contains("fog"))
            {
                this.BackgroundImage = (Properties.Resources.foggy);
                pictureBox1.BackgroundImage = (Properties.Resources.fog);
            }
            if (Form1.days[0].conditionFore.Contains("clear"))
            {
                this.BackgroundImage = (Properties.Resources.clear);
                pictureBox1.BackgroundImage = (Properties.Resources.sun);
            }
            if (Form1.days[0].conditionFore.Contains("snow"))
            {
                this.BackgroundImage = (Properties.Resources.snowy);
                pictureBox1.BackgroundImage = (Properties.Resources.snow);
            }


            if (Form1.days[1].conditionFore.Contains("cloud"))
            {
                pictureBox2.BackgroundImage = (Properties.Resources.cloudy);
            }
            if (Form1.days[1].conditionFore.Contains("sun"))
            {
                pictureBox2.BackgroundImage = (Properties.Resources.sun);
            }
            if (Form1.days[1].conditionFore.Contains("rain"))
            {
                pictureBox2.BackgroundImage = (Properties.Resources.rainy);
            }
            if (Form1.days[1].conditionFore.Contains("fog"))
            {
                pictureBox2.BackgroundImage = (Properties.Resources.fog);
            }
            if (Form1.days[1].conditionFore.Contains("clear"))
            {
                pictureBox2.BackgroundImage = (Properties.Resources.sun);
            }
            if (Form1.days[1].conditionFore.Contains("snow"))
            {
                pictureBox2.BackgroundImage = (Properties.Resources.snow);
            }

            if (Form1.days[2].conditionFore.Contains("cloud"))
            {
                pictureBox3.BackgroundImage = (Properties.Resources.cloudy);
            }
            if (Form1.days[2].conditionFore.Contains("sun"))
            {
                pictureBox3.BackgroundImage = (Properties.Resources.sun);
            }
            if (Form1.days[2].conditionFore.Contains("rain"))
            {
                pictureBox3.BackgroundImage = (Properties.Resources.rainy);
            }
            if (Form1.days[2].conditionFore.Contains("fog"))
            {
                pictureBox3.BackgroundImage = (Properties.Resources.fog);
            }
            if (Form1.days[2].conditionFore.Contains("clear"))
            {
                pictureBox3.BackgroundImage = (Properties.Resources.sun);
            }
            if (Form1.days[2].conditionFore.Contains("snow"))
            {
                pictureBox3.BackgroundImage = (Properties.Resources.snow);
            }
            #endregion
        }

        /// <summary>
        /// When the Today label is clicked, this user control is removed from the form
        /// and the CurrentScreen user control is added to the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void todayLabel_Click(object sender, EventArgs e)//sends user to desiered page
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            Search ss = new Search();
            f.Controls.Add(ss);
        }
    }
}
