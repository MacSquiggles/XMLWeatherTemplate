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
            this.forcastMinLabel = new System.Windows.Forms.Label();
            this.forcastMaxLabel = new System.Windows.Forms.Label();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.exitLabel2 = new System.Windows.Forms.Label();
            this.cloudsLabel1 = new System.Windows.Forms.Label();
            this.windLabel1 = new System.Windows.Forms.Label();
            this.windLabel2 = new System.Windows.Forms.Label();
            this.mainMenuLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // forcastMinLabel
            // 
            this.forcastMinLabel.BackColor = System.Drawing.Color.Transparent;
            this.forcastMinLabel.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forcastMinLabel.Location = new System.Drawing.Point(29, 349);
            this.forcastMinLabel.Name = "forcastMinLabel";
            this.forcastMinLabel.Size = new System.Drawing.Size(427, 52);
            this.forcastMinLabel.TabIndex = 10;
            // 
            // forcastMaxLabel
            // 
            this.forcastMaxLabel.BackColor = System.Drawing.Color.Transparent;
            this.forcastMaxLabel.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forcastMaxLabel.Location = new System.Drawing.Point(29, 269);
            this.forcastMaxLabel.Name = "forcastMaxLabel";
            this.forcastMaxLabel.Size = new System.Drawing.Size(427, 52);
            this.forcastMaxLabel.TabIndex = 9;
            // 
            // nameLabel2
            // 
            this.nameLabel2.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel2.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel2.Location = new System.Drawing.Point(12, 0);
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
            // cloudsLabel1
            // 
            this.cloudsLabel1.BackColor = System.Drawing.Color.Transparent;
            this.cloudsLabel1.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloudsLabel1.Location = new System.Drawing.Point(29, 429);
            this.cloudsLabel1.Name = "cloudsLabel1";
            this.cloudsLabel1.Size = new System.Drawing.Size(427, 52);
            this.cloudsLabel1.TabIndex = 14;
            // 
            // windLabel1
            // 
            this.windLabel1.BackColor = System.Drawing.Color.Transparent;
            this.windLabel1.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windLabel1.Location = new System.Drawing.Point(29, 509);
            this.windLabel1.Name = "windLabel1";
            this.windLabel1.Size = new System.Drawing.Size(427, 52);
            this.windLabel1.TabIndex = 16;
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
            // ForecastForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.white_background;
            this.Controls.Add(this.mainMenuLabel2);
            this.Controls.Add(this.windLabel2);
            this.Controls.Add(this.windLabel1);
            this.Controls.Add(this.cloudsLabel1);
            this.Controls.Add(this.exitLabel2);
            this.Controls.Add(this.forcastMinLabel);
            this.Controls.Add(this.forcastMaxLabel);
            this.Controls.Add(this.nameLabel2);
            this.Name = "ForecastForm1";
            this.Size = new System.Drawing.Size(500, 600);
            this.Load += new System.EventHandler(this.ForcastForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label forcastMinLabel;
        private System.Windows.Forms.Label forcastMaxLabel;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.Label exitLabel2;
        private System.Windows.Forms.Label cloudsLabel1;
        private System.Windows.Forms.Label windLabel1;
        private System.Windows.Forms.Label windLabel2;
        private System.Windows.Forms.Label mainMenuLabel2;
    }
}
