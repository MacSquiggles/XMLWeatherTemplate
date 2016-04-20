namespace XMLWeather
{
    partial class MainMenu
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
            this.futureButton = new System.Windows.Forms.Button();
            this.currentLabel = new System.Windows.Forms.Button();
            this.cityOutput = new System.Windows.Forms.Label();
            this.exitLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // futureButton
            // 
            this.futureButton.BackColor = System.Drawing.Color.White;
            this.futureButton.Font = new System.Drawing.Font("Pristina", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.futureButton.Location = new System.Drawing.Point(296, 442);
            this.futureButton.Name = "futureButton";
            this.futureButton.Size = new System.Drawing.Size(165, 129);
            this.futureButton.TabIndex = 5;
            this.futureButton.Text = "Future    Forcast";
            this.futureButton.UseVisualStyleBackColor = false;
            this.futureButton.Click += new System.EventHandler(this.futureButton_Click);
            // 
            // currentLabel
            // 
            this.currentLabel.BackColor = System.Drawing.Color.White;
            this.currentLabel.Font = new System.Drawing.Font("Pristina", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLabel.Location = new System.Drawing.Point(28, 442);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(165, 129);
            this.currentLabel.TabIndex = 4;
            this.currentLabel.Text = "Current Forcast";
            this.currentLabel.UseVisualStyleBackColor = false;
            this.currentLabel.Click += new System.EventHandler(this.currentLabel_Click);
            // 
            // cityOutput
            // 
            this.cityOutput.AutoSize = true;
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.Location = new System.Drawing.Point(124, 29);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(285, 52);
            this.cityOutput.TabIndex = 3;
            this.cityOutput.Text = "Stratford Weather";
            // 
            // exitLabel1
            // 
            this.exitLabel1.BackColor = System.Drawing.Color.Red;
            this.exitLabel1.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel1.Location = new System.Drawing.Point(449, 0);
            this.exitLabel1.Name = "exitLabel1";
            this.exitLabel1.Size = new System.Drawing.Size(51, 46);
            this.exitLabel1.TabIndex = 18;
            this.exitLabel1.Text = "X";
            this.exitLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitLabel1.Click += new System.EventHandler(this.exitLabel2_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.sun;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.exitLabel1);
            this.Controls.Add(this.futureButton);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.cityOutput);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(500, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button futureButton;
        private System.Windows.Forms.Button currentLabel;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label exitLabel1;
    }
}
