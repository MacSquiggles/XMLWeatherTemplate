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
    public partial class ForecastForm1 : UserControl
    {
        Day d;
        string clo, windDir, max, min, rain, wnd, press;

        public ForecastForm1()
        {
            InitializeComponent();
        }

        private void ForcastForm_Load(object sender, EventArgs e)
        {
            System.Globalization.DateTimeFormatInfo mfi = new
            System.Globalization.DateTimeFormatInfo();

            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData7Day.xml");

            //create a node variable to represent the parent element
            XmlNode parent;
            parent = doc.DocumentElement;

            //check each child of the parent element
            foreach (XmlNode child in parent.ChildNodes)
            {
                // TODO if the "city" element is found display the value of it's "name" attribute
                if (child.Name == "forecast")
                {
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        if (grandChild.Name == "time")
                        {
                            if (grandChild.Attributes["day"].Value == MainMenu.days[ForecastMenu.numFore])
                            {
                                foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                                {
                                    if (greatGrandChild.Name == "humidity")
                                    {
                                        rain = greatGrandChild.Attributes["value"].Value;
                                    }
                                    if (greatGrandChild.Name == "pressure")
                                    {
                                        press = greatGrandChild.Attributes["value"].Value;
                                    }
                                    if (greatGrandChild.Name == "temperature")
                                    {
                                        max = greatGrandChild.Attributes["max"].Value;
                                        min = greatGrandChild.Attributes["min"].Value;
                                    }
                                    if (greatGrandChild.Name == "clouds")
                                    {
                                        clo = greatGrandChild.Attributes["value"].Value;
                                    }
                                    if (greatGrandChild.Name == "WindSpeed")
                                    {
                                        wnd = Convert.ToString(float.Parse(greatGrandChild.Attributes["mps"].Value) * 3.6);
                                    }
                                    if (greatGrandChild.Name == "windDirection")
                                    {
                                        windDir = greatGrandChild.Attributes["code"].Value;
                                    }
                                }
                            }
                        }
                        d = new Day(clo, max, min, rain, wnd, windDir, press);
                        if (ForecastMenu.numFore == 1)
                        {
                            nameLabel2.Text = mfi.GetMonthName(Convert.ToInt16(ForecastMenu.forecast1[1])) + " " + ForecastMenu.forecast1[2];
                        }
                        if (ForecastMenu.numFore == 2)
                        {
                            nameLabel2.Text = mfi.GetMonthName(Convert.ToInt16(ForecastMenu.forecast2[1])) + " " + ForecastMenu.forecast2[2];
                        }
                        if (ForecastMenu.numFore == 3)
                        {
                            nameLabel2.Text = mfi.GetMonthName(Convert.ToInt16(ForecastMenu.forecast3[1])) + " " + ForecastMenu.forecast3[2];
                        }
                        if (ForecastMenu.numFore == 4)
                        {
                            nameLabel2.Text = mfi.GetMonthName(Convert.ToInt16(ForecastMenu.forecast4[1])) + " " + ForecastMenu.forecast4[2];
                        }
                    }
                }
            }

            forecastMaxLabel.Text = "Max " + d.maxTemp + "°C";
            forecastMinLabel.Text = "Min " + d.minTemp + "°C";
            cloudsLabel.Text = d.clouds;
            rainPerLabel.Text = d.rainPer + "%" + " humidity";
            pressureLabel.Text = "Pressure of " + d.pressure + "hKpa";
            windLabel.Text = d.windDir + " wind at " + d.wind + "km/h";
        }

        private void exitLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainMenuLabel2_Click(object sender, EventArgs e)
        {
            ForecastMenu mm = new ForecastMenu();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            mm.Location = new Point((f.Width - mm.Width) / 2, (f.Height - mm.Height) / 2);
            f.Controls.Add(mm);
            mm.BringToFront();
        }


    }
}
