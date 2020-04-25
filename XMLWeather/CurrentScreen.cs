using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            // the current information is in index 0, thus why all information is retreived from there
            dateLabel.Text = DateTime.Now.ToString("dddd" + ", " + "MMMM" + " dd");
            timeLabel.Text = DateTime.Now.ToString("h:mm tt");
            cityOutput.Text = Form1.days[0].location;
            currentOutput.Text = Form1.days[0].currentTemp + " °C";
            minOutput.Text = Form1.days[0].tempLow + " °C";
            maxOutput.Text = Form1.days[0].tempHigh + " °C";
            conditionOutput.Text = Form1.days[0].condition;
            eveTemp.Text = Form1.days[1].eveTemp+" °C";
                nightTemp.Text = Form1.days[1].nightTemp + " °C";
            if (Form1.days[0].condition.Contains("cloud"))
            {
                this.BackgroundImage=(Properties.Resources.cloudy);
                day.BackgroundImage = (Properties.Resources.cloudy1);
            }
            if (Form1.days[0].condition.Contains("sun"))
            {
                this.BackgroundImage = (Properties.Resources.sunny);}
            if (Form1.days[0].condition.Contains("rain"))
            {
                this.BackgroundImage = (Properties.Resources.rain); }
            if (Form1.days[0].condition.Contains("cloud"))
            {
                this.BackgroundImage = (Properties.Resources.cloudy);}
        }

        /// <summary>
        /// When the forecast label is clicked this user control is removed from the form
        /// and the ForecastScreen user control is added to the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            Search ss = new Search();
            f.Controls.Add(ss);
        }
    }
}
