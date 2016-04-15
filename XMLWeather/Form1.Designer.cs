namespace XMLWeather
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cityOutput = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Button();
            this.futureButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.AutoSize = true;
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.Location = new System.Drawing.Point(63, 9);
            this.cityOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(285, 52);
            this.cityOutput.TabIndex = 0;
            this.cityOutput.Text = "Stratford Weather";
            // 
            // currentLabel
            // 
            this.currentLabel.BackColor = System.Drawing.Color.White;
            this.currentLabel.Font = new System.Drawing.Font("Pristina", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLabel.Location = new System.Drawing.Point(22, 317);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(165, 84);
            this.currentLabel.TabIndex = 1;
            this.currentLabel.Text = "Current Forcast";
            this.currentLabel.UseVisualStyleBackColor = false;
            this.currentLabel.Click += new System.EventHandler(this.currentLabel_Click);
            // 
            // futureButton
            // 
            this.futureButton.BackColor = System.Drawing.Color.White;
            this.futureButton.Font = new System.Drawing.Font("Pristina", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.futureButton.Location = new System.Drawing.Point(212, 317);
            this.futureButton.Name = "futureButton";
            this.futureButton.Size = new System.Drawing.Size(165, 84);
            this.futureButton.TabIndex = 2;
            this.futureButton.Text = "Future    Forcast";
            this.futureButton.UseVisualStyleBackColor = false;
            this.futureButton.Click += new System.EventHandler(this.futureButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.sun;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 413);
            this.Controls.Add(this.futureButton);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.cityOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Weather";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Button currentLabel;
        private System.Windows.Forms.Button futureButton;
    }
}

