using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class MainMenu : UserControl
    {
        DateTime currentMonth = DateTime.Now.AddMonths(0);
        DateTime currentDate = DateTime.Now.AddDays(0);
        DateTime forecastDate1 = DateTime.Now.AddDays(1);
        DateTime forecastDate2 = DateTime.Now.AddDays(2);
        DateTime forecastDate3 = DateTime.Now.AddDays(3);
        public static List<int> days = new List<int>(4);

        public MainMenu()
        {
            InitializeComponent();
            GetData();
        }

        private void currentLabel_Click(object sender, EventArgs e)
        {
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
            ForecastMenu fm = new ForecastMenu();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            fm.Location = new Point((f.Width - fm.Width) / 2, (f.Height - fm.Height) / 2);
            f.Controls.Add(fm);
            fm.BringToFront();
        }
        private static void GetData()
        {
            WebClient client = new WebClient();

            string currentFile = "http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0";
            string forecastFile = "http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0";

            client.DownloadFile(currentFile, "WeatherData.xml");
            client.DownloadFile(forecastFile, "WeatherData7Day.xml");

            days.InsertRange(days.Count(), new int[] { currentDate, forecast1, forecast2, forecastDate3 });
        }

        private void exitLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
