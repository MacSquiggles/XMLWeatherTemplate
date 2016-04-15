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
    public partial class ForcastForm : UserControl
    {
        public ForcastForm()
        {
            InitializeComponent();
        }

        private void ForcastForm_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData.xml");

            //create a node variable to represent the parent element
            XmlNode parent;
            parent = doc.DocumentElement;
            int day = 1;

            //check each child of the parent element
            foreach (XmlNode child in parent.ChildNodes)
            {
                // TODO if the "city" element is found display the value of it's "name" attribute
                if (child.Name == "forcast")
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
                                        day++;
                                        break;
                                    case 2:
                                        forcastMax2Label.Text = "Max Temp: " + greatGrandChild.Attributes["max"].Value;
                                        forcastMin2Label.Text = "Min Temp: " + greatGrandChild.Attributes["min"].Value;
                                        day++;
                                        break;
                                }
                                forcastTempLabel.Text = "Predicted Temp" + greatGrandChild.Attributes["name"].Value;
                            }
                        }
                    }
                }
            }
        }
    }
}
