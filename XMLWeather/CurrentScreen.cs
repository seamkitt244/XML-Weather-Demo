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
            dateLabel.Text = DateTime.Now.ToString("dddd" + ", " + "MMMM" + " dd");//printing the date
            timeLabel.Text = DateTime.Now.ToString("h:mm tt");//printing the time where the user is
            
            cityOutput.Text = Form1.days[0].location;

            currentOutput.Text = Form1.days[0].currentTemp + " °C";
            minOutput.Text = Form1.days[0].tempLow + " °C";
            maxOutput.Text = Form1.days[0].tempHigh + " °C";
            eveTemp.Text = Form1.days[1].eveTemp + " °C";
            nightTemp.Text = Form1.days[1].nightTemp + " °C";

            conditionOutput.Text = Form1.days[0].condition;
            
            #region images
            if (Form1.days[0].condition.Contains("cloud"))
            {
                this.BackgroundImage=(Properties.Resources.cloudy);
                day.BackgroundImage = (Properties.Resources.cloudy1);
            }
            if (Form1.days[0].condition.Contains("sun"))
            {
                this.BackgroundImage = (Properties.Resources.sunny);
                day.BackgroundImage = (Properties.Resources.sun);
            }
            if (Form1.days[0].condition.Contains("rain"))
            {
                this.BackgroundImage = (Properties.Resources.rain);
                day.BackgroundImage = (Properties.Resources.rainy);
            }
            if (Form1.days[0].condition.Contains("clear"))
            {
                this.BackgroundImage = (Properties.Resources.clear);
                day.BackgroundImage = (Properties.Resources.sun);
            }
            if (Form1.days[0].conditionFore.Contains("fog"))
            {
                this.BackgroundImage = (Properties.Resources.foggy);
                day.BackgroundImage = (Properties.Resources.fog);
            }
            if (Form1.days[0].conditionFore.Contains("snow"))
            {
                this.BackgroundImage = (Properties.Resources.snowy);
                day.BackgroundImage = (Properties.Resources.snow);
            }
            #endregion
        }

        /// <summary>
        /// When the forecast label is clicked this user control is removed from the form
        /// and the ForecastScreen user control is added to the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void forecastLabel_Click(object sender, EventArgs e)//sends user to desiered page
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
        }//
    }
}
