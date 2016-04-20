namespace XMLWeather
{
    partial class ForecastMenu
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
            this.mainMenuLabel2 = new System.Windows.Forms.Label();
            this.exitLabel2 = new System.Windows.Forms.Label();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.dayOneButton = new System.Windows.Forms.Button();
            this.dayThreeButton = new System.Windows.Forms.Button();
            this.dayTwoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenuLabel2
            // 
            this.mainMenuLabel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.mainMenuLabel2.Font = new System.Drawing.Font("Pristina", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuLabel2.Location = new System.Drawing.Point(199, 0);
            this.mainMenuLabel2.Name = "mainMenuLabel2";
            this.mainMenuLabel2.Size = new System.Drawing.Size(243, 46);
            this.mainMenuLabel2.TabIndex = 18;
            this.mainMenuLabel2.Text = "Back to Menu";
            this.mainMenuLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mainMenuLabel2.Click += new System.EventHandler(this.mainMenuLabel2_Click);
            // 
            // exitLabel2
            // 
            this.exitLabel2.BackColor = System.Drawing.Color.Red;
            this.exitLabel2.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel2.Location = new System.Drawing.Point(448, 0);
            this.exitLabel2.Name = "exitLabel2";
            this.exitLabel2.Size = new System.Drawing.Size(51, 46);
            this.exitLabel2.TabIndex = 17;
            this.exitLabel2.Text = "X";
            this.exitLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitLabel2.Click += new System.EventHandler(this.exitLabel2_Click);
            // 
            // nameLabel2
            // 
            this.nameLabel2.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel2.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel2.Location = new System.Drawing.Point(34, 46);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(431, 96);
            this.nameLabel2.TabIndex = 16;
            this.nameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayOneButton
            // 
            this.dayOneButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.dayOneButton.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayOneButton.Location = new System.Drawing.Point(13, 203);
            this.dayOneButton.Name = "dayOneButton";
            this.dayOneButton.Size = new System.Drawing.Size(468, 97);
            this.dayOneButton.TabIndex = 19;
            this.dayOneButton.UseVisualStyleBackColor = false;
            this.dayOneButton.Click += new System.EventHandler(this.dayOneButton_Click);
            // 
            // dayThreeButton
            // 
            this.dayThreeButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.dayThreeButton.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayThreeButton.Location = new System.Drawing.Point(13, 467);
            this.dayThreeButton.Name = "dayThreeButton";
            this.dayThreeButton.Size = new System.Drawing.Size(468, 97);
            this.dayThreeButton.TabIndex = 20;
            this.dayThreeButton.UseVisualStyleBackColor = false;
            this.dayThreeButton.Click += new System.EventHandler(this.dayThreeButton_Click);
            // 
            // dayTwoButton
            // 
            this.dayTwoButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.dayTwoButton.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayTwoButton.Location = new System.Drawing.Point(13, 335);
            this.dayTwoButton.Name = "dayTwoButton";
            this.dayTwoButton.Size = new System.Drawing.Size(468, 97);
            this.dayTwoButton.TabIndex = 21;
            this.dayTwoButton.UseVisualStyleBackColor = false;
            this.dayTwoButton.Click += new System.EventHandler(this.dayTwoButton_Click);
            // 
            // ForecastMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.white_background;
            this.Controls.Add(this.dayTwoButton);
            this.Controls.Add(this.dayThreeButton);
            this.Controls.Add(this.dayOneButton);
            this.Controls.Add(this.mainMenuLabel2);
            this.Controls.Add(this.exitLabel2);
            this.Controls.Add(this.nameLabel2);
            this.Name = "ForecastMenu";
            this.Size = new System.Drawing.Size(500, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mainMenuLabel2;
        private System.Windows.Forms.Label exitLabel2;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.Button dayOneButton;
        private System.Windows.Forms.Button dayThreeButton;
        private System.Windows.Forms.Button dayTwoButton;
    }
}
