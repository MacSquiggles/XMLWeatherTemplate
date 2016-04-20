using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastMenu : UserControl
    {
        public ForecastMenu()
        {
            InitializeComponent();
        }

        private void exitLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dayOneButton_Click(object sender, EventArgs e)
        {
            // take info from the forecast weather file and display it to the screen
            ForecastForm1 ff1 = new ForecastForm1();
            Form f = this.FindForm();
            ff1.Controls.Remove(this);
            ff1.Location = new Point((f.Width - ff1.Width) / 2, (f.Height - ff1.Height) / 2);
            f.Controls.Add(ff1);
            ff1.BringToFront();
        }

        private void dayTwoButton_Click(object sender, EventArgs e)
        {
            // take info from the forecast weather file and display it to the screen
            ForecastForm2 ff2 = new ForecastForm2();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            ff2.Location = new Point((f.Width - ff2.Width) / 2, (f.Height - ff2.Height) / 2);
            f.Controls.Add(ff2);
            ff2.BringToFront();
        }

        private void dayThreeButton_Click(object sender, EventArgs e)
        {
            // take info from the forecast weather file and display it to the screen
            ForecastForm3 ff3 = new ForecastForm3();
            Form f = this.FindForm();
            f.Controls.Remove(this);
            ff3.Location = new Point((f.Width - ff3.Width) / 2, (f.Height - ff3.Height) / 2);
            f.Controls.Add(ff3);
            ff3.BringToFront();
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
