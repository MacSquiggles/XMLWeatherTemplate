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
    public partial class CurrentForm : UserControl
    {
        public CurrentForm()
        {
            InitializeComponent();
        }

        private void CurrentForm_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("WeatherData.xml");

            //create a node variable to represent the parent element
            XmlNode parent;
            parent = doc.DocumentElement;

            foreach (XmlNode child in parent.ChildNodes)
            {
                // TODO if the "city" element is found display the value of it's "name" attribute
                if (child.Name == "city")
                {
                    nameLabel.Text = "Current" + child.Attributes["name"].Value + " Weather";
                }
                if(child.Name == "temperature")
                {
                    currentTempLabel.Text = "Current Temperature: " + child.Attributes["temperature"].Value;
                }
                if (child.Name == "wind")
                {
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        if (grandChild.Name == "speed")
                        {
                            currentWindLabel.Text = grandChild.Attributes["name"].Value;
                        }
                    }
                }
            }
        }
    }
}
