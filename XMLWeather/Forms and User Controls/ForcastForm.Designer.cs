namespace XMLWeather
{
    partial class ForecastForm1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.forecastMinLabel = new System.Windows.Forms.Label();
            this.forecastMaxLabel = new System.Windows.Forms.Label();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.exitLabel2 = new System.Windows.Forms.Label();
            this.cloudsLabel = new System.Windows.Forms.Label();
            this.windLabel = new System.Windows.Forms.Label();
            this.windLabel2 = new System.Windows.Forms.Label();
            this.mainMenuLabel2 = new System.Windows.Forms.Label();
            this.rainPerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // forecastMinLabel
            // 
            this.forecastMinLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastMinLabel.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastMinLabel.Location = new System.Drawing.Point(31, 277);
            this.forecastMinLabel.Name = "forecastMinLabel";
            this.forecastMinLabel.Size = new System.Drawing.Size(427, 52);
            this.forecastMinLabel.TabIndex = 10;
            // 
            // forecastMaxLabel
            // 
            this.forecastMaxLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastMaxLabel.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastMaxLabel.Location = new System.Drawing.Point(31, 192);
            this.forecastMaxLabel.Name = "forecastMaxLabel";
            this.forecastMaxLabel.Size = new System.Drawing.Size(427, 52);
            this.forecastMaxLabel.TabIndex = 9;
            // 
            // nameLabel2
            // 
            this.nameLabel2.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel2.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel2.Location = new System.Drawing.Point(27, 69);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(431, 96);
            this.nameLabel2.TabIndex = 6;
            this.nameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitLabel2
            // 
            this.exitLabel2.BackColor = System.Drawing.Color.Red;
            this.exitLabel2.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel2.Location = new System.Drawing.Point(449, 0);
            this.exitLabel2.Name = "exitLabel2";
            this.exitLabel2.Size = new System.Drawing.Size(51, 46);
            this.exitLabel2.TabIndex = 13;
            this.exitLabel2.Text = "X";
            this.exitLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitLabel2.Click += new System.EventHandler(this.exitLabel2_Click);
            // 
            // cloudsLabel
            // 
            this.cloudsLabel.BackColor = System.Drawing.Color.Transparent;
            this.cloudsLabel.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloudsLabel.Location = new System.Drawing.Point(31, 362);
            this.cloudsLabel.Name = "cloudsLabel";
            this.cloudsLabel.Size = new System.Drawing.Size(427, 52);
            this.cloudsLabel.TabIndex = 14;
            // 
            // windLabel
            // 
            this.windLabel.BackColor = System.Drawing.Color.Transparent;
            this.windLabel.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windLabel.Location = new System.Drawing.Point(31, 447);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(427, 52);
            this.windLabel.TabIndex = 16;
            // 
            // windLabel2
            // 
            this.windLabel2.BackColor = System.Drawing.Color.Transparent;
            this.windLabel2.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windLabel2.Location = new System.Drawing.Point(30, 605);
            this.windLabel2.Name = "windLabel2";
            this.windLabel2.Size = new System.Drawing.Size(422, 52);
            this.windLabel2.TabIndex = 17;
            // 
            // mainMenuLabel2
            // 
            this.mainMenuLabel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.mainMenuLabel2.Font = new System.Drawing.Font("Pristina", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuLabel2.Location = new System.Drawing.Point(161, 0);
            this.mainMenuLabel2.Name = "mainMenuLabel2";
            this.mainMenuLabel2.Size = new System.Drawing.Size(282, 46);
            this.mainMenuLabel2.TabIndex = 18;
            this.mainMenuLabel2.Text = "Back to Menu";
            this.mainMenuLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainMenuLabel2.Click += new System.EventHandler(this.mainMenuLabel2_Click);
            // 
            // rainPerLabel
            // 
            this.rainPerLabel.BackColor = System.Drawing.Color.Transparent;
            this.rainPerLabel.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rainPerLabel.Location = new System.Drawing.Point(31, 532);
            this.rainPerLabel.Name = "rainPerLabel";
            this.rainPerLabel.Size = new System.Drawing.Size(427, 52);
            this.rainPerLabel.TabIndex = 19;
            // 
            // ForecastForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.white_background;
            this.Controls.Add(this.rainPerLabel);
            this.Controls.Add(this.mainMenuLabel2);
            this.Controls.Add(this.windLabel2);
            this.Controls.Add(this.windLabel);
            this.Controls.Add(this.cloudsLabel);
            this.Controls.Add(this.exitLabel2);
            this.Controls.Add(this.forecastMinLabel);
            this.Controls.Add(this.forecastMaxLabel);
            this.Controls.Add(this.nameLabel2);
            this.Name = "ForecastForm1";
            this.Size = new System.Drawing.Size(500, 600);
            this.Load += new System.EventHandler(this.ForcastForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label forecastMinLabel;
        private System.Windows.Forms.Label forecastMaxLabel;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.Label exitLabel2;
        private System.Windows.Forms.Label cloudsLabel;
        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.Label windLabel2;
        private System.Windows.Forms.Label mainMenuLabel2;
        private System.Windows.Forms.Label rainPerLabel;
    }
}
