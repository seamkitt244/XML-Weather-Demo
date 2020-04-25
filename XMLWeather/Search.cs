using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml;
using System.Net;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class Search : UserControl
    {
        public static string city;
        List<string> cities = new List<string>();
        public Search()
        {
            InitializeComponent();
            if (Form1.days[0].condition.Contains("cloud"))
            {
                this.BackgroundImage = (Properties.Resources.cloudy);
            }
            if (Form1.days[0].condition.Contains("sun"))
            {
                this.BackgroundImage = (Properties.Resources.sunny);
            }
            if (Form1.days[0].condition.Contains("rain"))
            {
                this.BackgroundImage = (Properties.Resources.rain);
            }
            if (Form1.days[0].condition.Contains("cloud"))
            {
                this.BackgroundImage = (Properties.Resources.cloudy);
            }
        }
        #region search term or city click
        private void button1_Click(object sender, EventArgs e)
        {
            city = searchTextBox.Text;
            Searching();
        }
        private void toronto_Click(object sender, EventArgs e)
        {
            city = "Toronto";
            Searching();
        }
        private void kitchener_Click(object sender, EventArgs e)
        {
            city = "Kitchener";
            Searching();
        }
        private void london_Click(object sender, EventArgs e)
        {
            city = "London";
            Searching();
        }
        private void vancouver_Click(object sender, EventArgs e)
        {
            city = "Vancouver";
            Searching();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            city = "Calgary";
            Searching();
        }
        #endregion
        private void Searching()
        {
            Form1.urlCur = "http://api.openweathermap.org/data/2.5/weather?q=" + city + ",CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0";
            Form1.urlFore = "http://api.openweathermap.org/data/2.5/forecast/daily?q=" + city + ",CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0";
            Form1.days.Clear();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
        #region Top label clicks
        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
        private void todayLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
        #endregion
    }
}
