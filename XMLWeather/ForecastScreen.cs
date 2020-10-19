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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            date1.Text = Form1.days[1].date;
            min1.Text = Form1.days[1].tempLow;
            max1.Text = Form1.days[1].tempHigh;
            if (Form1.days[1].condition.Contains("cloud"))
                pictureBoxD1.BackgroundImage = Properties.Resources.cloud;
            if (Form1.days[1].condition.Contains("rain"))
                pictureBoxD1.BackgroundImage = (Properties.Resources.Rain3);
            if (Form1.days[1].condition.Contains("sun"))
                pictureBoxD1.BackgroundImage = (Properties.Resources.sun);
            if (Form1.days[1].condition.Contains("clear"))
                pictureBoxD1.BackgroundImage = (Properties.Resources.clear);
            if (Form1.days[1].condition.Contains("fog"))
                pictureBoxD1.BackgroundImage = (Properties.Resources.fog);
            if (Form1.days[1].condition.Contains("snow"))
                pictureBoxD1.BackgroundImage = (Properties.Resources.snow1);

            label1.Text = Form1.days[2].date;
            min2.Text = Form1.days[2].tempLow;
            max2.Text = Form1.days[2].tempHigh;
            if (Form1.days[2].condition.Contains("cloud"))
                pictureBoxD2.BackgroundImage = Properties.Resources.cloud;
            if (Form1.days[2].condition.Contains("rain"))
                pictureBoxD2.BackgroundImage = (Properties.Resources.Rain3);
            if (Form1.days[2].condition.Contains("sun"))
                pictureBoxD2.BackgroundImage = (Properties.Resources.sun);
            if (Form1.days[2].condition.Contains("clear"))
                pictureBoxD2.BackgroundImage = (Properties.Resources.clear);
            if (Form1.days[2].condition.Contains("fog"))
                pictureBoxD2.BackgroundImage = (Properties.Resources.fog);
            if (Form1.days[2].condition.Contains("snow"))
                pictureBoxD2.BackgroundImage = (Properties.Resources.snow1);

            date3.Text = Form1.days[3].date;
            min3.Text = Form1.days[3].tempLow;
            max3.Text = Form1.days[3].tempHigh;
            if (Form1.days[3].condition.Contains("cloud"))
                pictureBoxD3.BackgroundImage = Properties.Resources.cloud;
            if (Form1.days[3].condition.Contains("rain"))
                pictureBoxD3.BackgroundImage = (Properties.Resources.Rain3);
            if (Form1.days[3].condition.Contains("sun"))
                pictureBoxD3.BackgroundImage = (Properties.Resources.sun);
            if (Form1.days[3].condition.Contains("clear"))
                pictureBoxD3.BackgroundImage = (Properties.Resources.clear);
            if (Form1.days[3].condition.Contains("fog"))
                pictureBoxD3.BackgroundImage = (Properties.Resources.fog);
            if (Form1.days[3].condition.Contains("snow"))
                pictureBoxD3.BackgroundImage = (Properties.Resources.snow1);

            date4.Text = Form1.days[4].date;
            max4.Text = Form1.days[4].tempLow;
            max44.Text = Form1.days[4].tempHigh;
            if (Form1.days[4].condition.Contains("cloud"))
                pictureBoxD4.BackgroundImage = Properties.Resources.cloud;
            if (Form1.days[4].condition.Contains("rain"))
                pictureBoxD4
                    .BackgroundImage = (Properties.Resources.Rain3);
            if (Form1.days[4].condition.Contains("sun"))
                pictureBoxD4.BackgroundImage = (Properties.Resources.sun);
            if (Form1.days[4].condition.Contains("clear"))
                pictureBoxD4.BackgroundImage = (Properties.Resources.clear);
            if (Form1.days[4].condition.Contains("fog"))
                pictureBoxD4.BackgroundImage = (Properties.Resources.fog);
            if (Form1.days[4].condition.Contains("snow"))
                pictureBoxD4.BackgroundImage = (Properties.Resources.snow1);

            date5.Text = Form1.days[5].date;
            min5.Text = Form1.days[5].tempLow;
            max5.Text = Form1.days[5].tempHigh;
            if (Form1.days[5].condition.Contains("cloud"))
                pictureBoxD5.BackgroundImage = Properties.Resources.cloud;
            if (Form1.days[5].condition.Contains("rain"))
                pictureBoxD5.BackgroundImage = (Properties.Resources.Rain3);
            if (Form1.days[5].condition.Contains("sun"))
                pictureBoxD5.BackgroundImage = (Properties.Resources.sun);
            if (Form1.days[5].condition.Contains("clear"))
                pictureBoxD5.BackgroundImage = (Properties.Resources.clear);
            if (Form1.days[5].condition.Contains("fog"))
                pictureBoxD5.BackgroundImage = (Properties.Resources.fog);
            if (Form1.days[5].condition.Contains("snow"))
                pictureBoxD5.BackgroundImage = (Properties.Resources.snow1);

            date6.Text = Form1.days[6].date;
            min6.Text = Form1.days[6].tempLow;
            max6.Text = Form1.days[6].tempHigh;
            if (Form1.days[6].condition.Contains("cloud"))
                pictureBoxD6.BackgroundImage = Properties.Resources.cloud;
            if (Form1.days[6].condition.Contains("rain"))
                pictureBoxD6.BackgroundImage = (Properties.Resources.Rain3);
            if (Form1.days[6].condition.Contains("sun"))
                pictureBoxD6.BackgroundImage = (Properties.Resources.sun);
            if (Form1.days[6].condition.Contains("clear"))
                pictureBoxD6.BackgroundImage = (Properties.Resources.clear);
            if (Form1.days[6].condition.Contains("fog"))
                pictureBoxD6.BackgroundImage = (Properties.Resources.fog);
            if (Form1.days[6].condition.Contains("snow"))
                pictureBoxD6.BackgroundImage = (Properties.Resources.snow1);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void ForecastScreen_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
