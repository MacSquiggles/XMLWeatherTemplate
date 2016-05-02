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
        string clo, clo2, max, min, rain, wnd;

        public ForecastForm1()
        {
            InitializeComponent();
        }

        private void ForcastForm_Load(object sender, EventArgs e)
        {

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
                    if(child.Name == MainMenu.days[ForecastMenu.numFore])
                    {
                        foreach (XmlNode grandChild in child.ChildNodes)
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
                                    clo2 = greatGrandChild.Attributes["name"].Value;
                                }
                            }
                        }
                    }
                }
            }
            Day d = new Day(clo, max, min, rain, wnd, clo2);
            forecastMaxLabel = d.maxTemp + "°C";
            forecastMinLabel = d.minTemp + "°C";
            cloudsLabel = d.clouds + "°C";
            windLabel = d.wind + "°C";
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
