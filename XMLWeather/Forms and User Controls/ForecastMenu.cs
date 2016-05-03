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
        public static int numFore;

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
            //Day d = new Day(MainMenu.days[1]);
            // take info from the forecast weather file and display it to the screen
            numFore = 1;
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
            numFore = 2;
            ForecastForm1 ff1 = new ForecastForm1();
            Form f = this.FindForm();
            ff1.Controls.Remove(this);
            ff1.Location = new Point((f.Width - ff1.Width) / 2, (f.Height - ff1.Height) / 2);
            f.Controls.Add(ff1);
            ff1.BringToFront();
        }

        private void dayThreeButton_Click(object sender, EventArgs e)
        {
            // take info from the forecast weather file and display it to the screen
            numFore = 3;
            ForecastForm1 ff1 = new ForecastForm1();
            Form f = this.FindForm();
            ff1.Controls.Remove(this);
            ff1.Location = new Point((f.Width - ff1.Width) / 2, (f.Height - ff1.Height) / 2);
            f.Controls.Add(ff1);
            ff1.BringToFront();
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

        private void ForecastMenu_Load(object sender, EventArgs e)
        {
            System.Globalization.DateTimeFormatInfo mfi = new
            System.Globalization.DateTimeFormatInfo();

            List<string> forecast1 = MainMenu.days[1].Split('-').ToList<string>();
            List<string> forecast2 = MainMenu.days[2].Split('-').ToList<string>();
            List<string> forecast3 = MainMenu.days[3].Split('-').ToList<string>();

            dayOneButton.Text = mfi.GetMonthName(Convert.ToInt16(forecast1[1])) + "the"+ forecast1[2];
            dayTwoButton.Text = mfi.GetMonthName(Convert.ToInt16(forecast2[1])) + "the" + forecast2[2];
            dayThreeButton.Text = mfi.GetMonthName(Convert.ToInt16(forecast3[1])) + "the" + forecast3[2];
        }
    }
}
