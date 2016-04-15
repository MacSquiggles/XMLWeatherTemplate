using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // get information about current and forecast weather from the internet
            GetData();
        }

        private static void GetData()
        {
            WebClient client = new WebClient();

            string currentFile = "http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0";
            string forecastFile = "http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0";
            
            client.DownloadFile(currentFile, "WeatherData.xml");
            client.DownloadFile(forecastFile, "WeatherData7Day.xml");
        }


        private void MakePictureParent()
        {
            
        }

        private void currentLabel_Click(object sender, EventArgs e)
        {

            // take info from the current weather file and display it to the screen
           CurrentForm cf = new CurrentForm();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            cf.Location = new Point((f.Width - cf.Width) / 2, (f.Height - cf.Height) / 2);
            f.Controls.Add(cf);
            cf.BringToFront();
        }

        private void futureButton_Click(object sender, EventArgs e)
        {
            // take info from the forecast weather file and display it to the screen
            ForcastForm ff = new ForcastForm();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            ff.Location = new Point((f.Width - ff.Width) / 2, (f.Height - ff.Height) / 2);
            f.Controls.Add(ff);
            ff.BringToFront();
        }
    }
}
