﻿using System;
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
        public static int day = 1;

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
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        foreach (XmlNode greatGrandChild in grandChild.ChildNodes)
                        {
                            
                            if (greatGrandChild.Name == "temperature")
                            {
                                switch (day)
                                {
                                    case 1:
                                        forcastMaxLabel.Text = "Max Temp: " + greatGrandChild.Attributes["max"].Value;
                                        forcastMinLabel.Text = "Min Temp: " + greatGrandChild.Attributes["min"].Value;
                                        break;
                                    default:
                                        break;
                                }
                            }
                            if (greatGrandChild.Name == "clouds")
                                {
                                switch (day)
                                {
                                    case 1:
                                        cloudsLabel1.Text = "Clouds: " + greatGrandChild.Attributes["value"].Value;
                                        break;
                                    default:
                                        break;
                                }
                            }
                            if (greatGrandChild.Name == "wind")
                            {
                                switch (day)
                                {
                                    case 1:
                                        cloudsLabel1.Text = "Wind: " + greatGrandChild.Attributes["name"].Value;
                                        day++;
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                }
            }
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
