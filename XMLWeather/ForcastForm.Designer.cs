namespace XMLWeather
{
    partial class ForcastForm
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
            this.forcastMax2Label = new System.Windows.Forms.Label();
            this.forcastMinLabel = new System.Windows.Forms.Label();
            this.forcastMaxLabel = new System.Windows.Forms.Label();
            this.forcastWindLabel = new System.Windows.Forms.Label();
            this.forcastTempLabel = new System.Windows.Forms.Label();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.forcastMin2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // forcastMax2Label
            // 
            this.forcastMax2Label.BackColor = System.Drawing.Color.Transparent;
            this.forcastMax2Label.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forcastMax2Label.Location = new System.Drawing.Point(37, 472);
            this.forcastMax2Label.Name = "forcastMax2Label";
            this.forcastMax2Label.Size = new System.Drawing.Size(422, 52);
            this.forcastMax2Label.TabIndex = 11;
            this.forcastMax2Label.Text = "label1";
            // 
            // forcastMinLabel
            // 
            this.forcastMinLabel.BackColor = System.Drawing.Color.Transparent;
            this.forcastMinLabel.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forcastMinLabel.Location = new System.Drawing.Point(37, 407);
            this.forcastMinLabel.Name = "forcastMinLabel";
            this.forcastMinLabel.Size = new System.Drawing.Size(422, 52);
            this.forcastMinLabel.TabIndex = 10;
            this.forcastMinLabel.Text = "label1";
            // 
            // forcastMaxLabel
            // 
            this.forcastMaxLabel.BackColor = System.Drawing.Color.Transparent;
            this.forcastMaxLabel.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forcastMaxLabel.Location = new System.Drawing.Point(37, 342);
            this.forcastMaxLabel.Name = "forcastMaxLabel";
            this.forcastMaxLabel.Size = new System.Drawing.Size(422, 52);
            this.forcastMaxLabel.TabIndex = 9;
            this.forcastMaxLabel.Text = "label1";
            // 
            // forcastWindLabel
            // 
            this.forcastWindLabel.BackColor = System.Drawing.Color.Transparent;
            this.forcastWindLabel.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forcastWindLabel.Location = new System.Drawing.Point(37, 277);
            this.forcastWindLabel.Name = "forcastWindLabel";
            this.forcastWindLabel.Size = new System.Drawing.Size(422, 52);
            this.forcastWindLabel.TabIndex = 8;
            this.forcastWindLabel.Text = "label1";
            // 
            // forcastTempLabel
            // 
            this.forcastTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.forcastTempLabel.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forcastTempLabel.Location = new System.Drawing.Point(37, 222);
            this.forcastTempLabel.Name = "forcastTempLabel";
            this.forcastTempLabel.Size = new System.Drawing.Size(422, 42);
            this.forcastTempLabel.TabIndex = 7;
            this.forcastTempLabel.Text = "label1";
            // 
            // nameLabel2
            // 
            this.nameLabel2.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel2.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel2.Location = new System.Drawing.Point(35, 77);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(431, 96);
            this.nameLabel2.TabIndex = 6;
            this.nameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forcastMin2Label
            // 
            this.forcastMin2Label.BackColor = System.Drawing.Color.Transparent;
            this.forcastMin2Label.Font = new System.Drawing.Font("Pristina", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forcastMin2Label.Location = new System.Drawing.Point(37, 524);
            this.forcastMin2Label.Name = "forcastMin2Label";
            this.forcastMin2Label.Size = new System.Drawing.Size(422, 52);
            this.forcastMin2Label.TabIndex = 12;
            this.forcastMin2Label.Text = "label1";
            // 
            // ForcastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.white_background;
            this.Controls.Add(this.forcastMin2Label);
            this.Controls.Add(this.forcastMax2Label);
            this.Controls.Add(this.forcastMinLabel);
            this.Controls.Add(this.forcastMaxLabel);
            this.Controls.Add(this.forcastWindLabel);
            this.Controls.Add(this.forcastTempLabel);
            this.Controls.Add(this.nameLabel2);
            this.Name = "ForcastForm";
            this.Size = new System.Drawing.Size(500, 600);
            this.Load += new System.EventHandler(this.ForcastForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label forcastMax2Label;
        private System.Windows.Forms.Label forcastMinLabel;
        private System.Windows.Forms.Label forcastMaxLabel;
        private System.Windows.Forms.Label forcastWindLabel;
        private System.Windows.Forms.Label forcastTempLabel;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.Label forcastMin2Label;
    }
}
