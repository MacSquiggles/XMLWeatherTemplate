namespace XMLWeather
{
    partial class CurrentForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.currentTempLabel = new System.Windows.Forms.Label();
            this.currentWindLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(22, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(431, 96);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentTempLabel
            // 
            this.currentTempLabel.AutoSize = true;
            this.currentTempLabel.Location = new System.Drawing.Point(91, 168);
            this.currentTempLabel.Name = "currentTempLabel";
            this.currentTempLabel.Size = new System.Drawing.Size(51, 20);
            this.currentTempLabel.TabIndex = 1;
            this.currentTempLabel.Text = "label1";
            // 
            // currentWindLabel
            // 
            this.currentWindLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentWindLabel.Font = new System.Drawing.Font("Pristina", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentWindLabel.Location = new System.Drawing.Point(31, 233);
            this.currentWindLabel.Name = "currentWindLabel";
            this.currentWindLabel.Size = new System.Drawing.Size(422, 52);
            this.currentWindLabel.TabIndex = 2;
            this.currentWindLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Pristina", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Pristina", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 52);
            this.label2.TabIndex = 4;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Pristina", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 52);
            this.label3.TabIndex = 5;
            this.label3.Text = "label1";
            // 
            // CurrentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::XMLWeather.Properties.Resources.white_background;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentWindLabel);
            this.Controls.Add(this.currentTempLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "CurrentForm";
            this.Size = new System.Drawing.Size(500, 600);
            this.Load += new System.EventHandler(this.CurrentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label currentTempLabel;
        private System.Windows.Forms.Label currentWindLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
