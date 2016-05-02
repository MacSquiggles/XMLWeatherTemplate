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
        public static DateTime currentDate = DateTime.Now.AddDays(0);
        public static DateTime forecastDate1 = DateTime.Now.AddDays(1);
        public static  DateTime forecastDate2 = DateTime.Now.AddDays(2);
        public static DateTime forecastDate3 = DateTime.Now.AddDays(3);
        public static List<string> days = new List<string>(4);

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
            List<string> days1 = Convert.ToString(currentDate).Split(' ').ToList<string>();
            List<string> days2 = Convert.ToString(forecastDate1).Split(' ').ToList<string>();
            List<string> days3 = Convert.ToString(forecastDate2).Split(' ').ToList<string>();
            List<string> days4 = Convert.ToString(forecastDate3).Split(' ').ToList<string>();
            days.InsertRange(days.Count(), new string[] { days1[0], days2[0], days3[0], days4[0] });
           
        }

        private void exitLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
