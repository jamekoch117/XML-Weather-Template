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
        private IFormatProvider currentTemp;

        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            dateLabel.Text = DateTime.Now.ToString("dddd" + ", " + "MMMM" + " dd");
            timeLabel.Text = DateTime.Now.ToString("h:mm tt");
            tempLabel.Text = Convert.ToDouble(Form1.days[0].currentTemp).ToString("0.0°C" ); 
            minOutput.Text = Convert.ToDouble(Form1.days[0].tempLow).ToString("0.0°C");
            maxOutput.Text = Convert.ToDouble(Form1.days[0].tempHigh).ToString("0.0°C");
            cityOutput.Text = Form1.days[0].location;
           // tempLabel.Text = Form1.days[0].currentTemp;
            //minOutput.Text = Form1.days[0].tempLow;
            //maxOutput.Text = Form1.days[0].tempHigh;
            conditionOutput.Text = Form1.days[0].condition;
            humidityOutput.Text = Form1.days[0].humidity + "";
            sunriseOutput.Text = Convert.ToDateTime(Form1.days[0].sunrise).ToString("h:mm tt");
            sunsetOutput.Text = Convert.ToDateTime(Form1.days[0].sunset).ToString("h:mm tt");


            if (Form1.days[0].condition.Contains("cloud"))
             pictureBox1.BackgroundImage = Properties.Resources.cloud;
             if (Form1.days[0].condition.Contains("rain"))
             pictureBox1.BackgroundImage = (Properties.Resources.Rain3);
             if (Form1.days[0].condition.Contains("sun")) 
            pictureBox1.BackgroundImage = (Properties.Resources.sun);
             if (Form1.days[0].condition.Contains("clear")) 
            pictureBox1.BackgroundImage = (Properties.Resources.clear);
            if (Form1.days[0].condition.Contains("fog")) 
                pictureBox1.BackgroundImage = (Properties.Resources.fog);
            if (Form1.days[0].condition.Contains("snow")) 
            pictureBox1.BackgroundImage = (Properties.Resources.snow1);


        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void minOutput_Click(object sender, EventArgs e)
        {

        }

        private void CurrentScreen_Load(object sender, EventArgs e)
        {

        }

        private void minLabel_Click(object sender, EventArgs e)
        {

        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void sunriseOutput_Click(object sender, EventArgs e)
        {

        }
    }
}

       