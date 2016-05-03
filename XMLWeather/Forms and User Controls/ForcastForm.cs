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
        string clo, windDir, max, min, rain, wnd;

        public ForecastForm1()
        {
            InitializeComponent();
        }

        private void ForcastForm_Load(object sender, EventArgs e)
        {
            int date = ForecastMenu.numFore;

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

                            foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                            {
                                if (greatGrandChild.Name == "temperature")
                                {
                                    max = greatGrandChild.Attributes["max"].Value;
                                    min = greatGrandChild.Attributes["min"].Value;
                                }
                                if (greatGrandChild.Name == "clouds")
                                {
                                    clo = greatGrandChild.Attributes["value"].Value;
                                }
                                if (greatGrandChild.Name == "wind")
                                {
                                    wnd = Convert.ToString(float.Parse(greatGrandChild.Attributes["mps"].Value) * 3.6);
                                }
                                else if (greatGrandChild.Name == "direction")
                                {
                                    windDir = greatGrandChild.Attributes["code"].Value;
                                }
                            }
                        }
                    }
                }
            }
            if (date == 1)
            {
                Day d = new Day(clo, max, min, rain, wnd, windDir);
            }
            if (date == 2)
            {
                Day d = new Day(clo, max, min, rain, wnd, windDir);
            }
            if (date == 3)
            {
                Day d = new Day(clo, max, min, rain, wnd, windDir);
            }

            forecastMaxLabel.Text = d.maxTemp + "°C";
            forecastMinLabel.Text = d.minTemp + "°C";
            cloudsLabel.Text = d.clouds;
            windLabel.Text = d.wind + "km/h";
        }

        private void exitLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainMenuLabel2_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            mm.Location = new Point((f.Width - mm.Width) / 2, (f.Height - mm.Height) / 2);
            f.Controls.Add(mm);
            mm.BringToFront();
        }


    }
}
