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
        List<string> currentDate = MainMenu.days[0].Split('-').ToList<string>();

        public CurrentForm()
        {
            InitializeComponent();
        }

        private void CurrentForm_Load(object sender, EventArgs e)
        {
            System.Globalization.DateTimeFormatInfo mfi = new
            System.Globalization.DateTimeFormatInfo();

            nameLabel.Text = "It is " + mfi.GetMonthName(Convert.ToInt16(currentDate[1])) + " " + currentDate[2];

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
                    cityLabel.Text = child.Attributes["name"].Value + " Weather";
                }
                if(child.Name == "temperature")
                {
                    currentTempLabel.Text = "It is " + child.Attributes["value"].Value + "°C";
                }
                if(child.Name == "clouds")
                {
                    cloudLabel.Text = child.Attributes["name"].Value;
                }
                if (child.Name == "wind")
                {
                    foreach (XmlNode grandChild in child.ChildNodes)
                    {
                        if (grandChild.Name == "direction")
                        {
                            windDirectLabel.Text = grandChild.Attributes["name"].Value + " wind";
                        }
                        if (grandChild.Name == "speed")
                        {
                            currentWindLabel.Text = grandChild.Attributes["name"].Value;
                        }
                    }
                }
            }
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainMenuLabel_Click(object sender, EventArgs e)
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
