namespace XMLWeather
{
    partial class ForecastForm3
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
            this.mainMenuLabel4 = new System.Windows.Forms.Label();
            this.exitLabel4 = new System.Windows.Forms.Label();
            this.nameLabel4 = new System.Windows.Forms.Label();
            this.windLabel3 = new System.Windows.Forms.Label();
            this.cloudsLabel3 = new System.Windows.Forms.Label();
            this.forcastMinLabel3 = new System.Windows.Forms.Label();
            this.forcastMaxLabel3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenuLabel4
            // 
            this.mainMenuLabel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.mainMenuLabel4.Font = new System.Drawing.Font("Pristina", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuLabel4.Location = new System.Drawing.Point(151, 1);
            this.mainMenuLabel4.Name = "mainMenuLabel4";
            this.mainMenuLabel4.Size = new System.Drawing.Size(290, 46);
            this.mainMenuLabel4.TabIndex = 15;
            this.mainMenuLabel4.Text = "Back to Menu";
            this.mainMenuLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainMenuLabel4.Click += new System.EventHandler(this.mainMenuLabel4_Click);
            // 
            // exitLabel4
            // 
            this.exitLabel4.BackColor = System.Drawing.Color.Red;
            this.exitLabel4.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel4.Location = new System.Drawing.Point(447, 1);
            this.exitLabel4.Name = "exitLabel4";
            this.exitLabel4.Size = new System.Drawing.Size(51, 46);
            this.exitLabel4.TabIndex = 9;
            this.exitLabel4.Text = "X";
            this.exitLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitLabel4.Click += new System.EventHandler(this.exitLabel4_Click);
            // 
            // nameLabel4
            // 
            this.nameLabel4.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel4.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel4.Location = new System.Drawing.Point(20, 24);
            this.nameLabel4.Name = "nameLabel4";
            this.nameLabel4.Size = new System.Drawing.Size(431, 96);
            this.nameLabel4.TabIndex = 8;
            this.nameLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windLabel3
            // 
            this.windLabel3.BackColor = System.Drawing.Color.Transparent;
            this.windLabel3.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windLabel3.Location = new System.Drawing.Point(33, 519);
            this.windLabel3.Name = "windLabel3";
            this.windLabel3.Size = new System.Drawing.Size(427, 52);
            this.windLabel3.TabIndex = 20;
            // 
            // cloudsLabel3
            // 
            this.cloudsLabel3.BackColor = System.Drawing.Color.Transparent;
            this.cloudsLabel3.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloudsLabel3.Location = new System.Drawing.Point(33, 439);
            this.cloudsLabel3.Name = "cloudsLabel3";
            this.cloudsLabel3.Size = new System.Drawing.Size(427, 52);
            this.cloudsLabel3.TabIndex = 19;
            // 
            // forcastMinLabel3
            // 
            this.forcastMinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.forcastMinLabel3.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forcastMinLabel3.Location = new System.Drawing.Point(33, 359);
            this.forcastMinLabel3.Name = "forcastMinLabel3";
            this.forcastMinLabel3.Size = new System.Drawing.Size(427, 52);
            this.forcastMinLabel3.TabIndex = 18;
            // 
            // forcastMaxLabel3
            // 
            this.forcastMaxLabel3.BackColor = System.Drawing.Color.Transparent;
            this.forcastMaxLabel3.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forcastMaxLabel3.Location = new System.Drawing.Point(33, 279);
            this.forcastMaxLabel3.Name = "forcastMaxLabel3";
            this.forcastMaxLabel3.Size = new System.Drawing.Size(427, 52);
            this.forcastMaxLabel3.TabIndex = 17;
            // 
            // ForecastForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.white_background;
            this.Controls.Add(this.windLabel3);
            this.Controls.Add(this.cloudsLabel3);
            this.Controls.Add(this.forcastMinLabel3);
            this.Controls.Add(this.forcastMaxLabel3);
            this.Controls.Add(this.mainMenuLabel4);
            this.Controls.Add(this.exitLabel4);
            this.Controls.Add(this.nameLabel4);
            this.Name = "ForecastForm3";
            this.Size = new System.Drawing.Size(500, 600);
            this.Load += new System.EventHandler(this.ForecastForm3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mainMenuLabel4;
        private System.Windows.Forms.Label exitLabel4;
        private System.Windows.Forms.Label nameLabel4;
        private System.Windows.Forms.Label windLabel3;
        private System.Windows.Forms.Label cloudsLabel3;
        private System.Windows.Forms.Label forcastMinLabel3;
        private System.Windows.Forms.Label forcastMaxLabel3;
    }
}
