namespace Clicker
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.labelStateName = new System.Windows.Forms.Label();
            this.buttonRUS = new System.Windows.Forms.Button();
            this.buttonENG = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStateName
            // 
            this.labelStateName.AutoSize = true;
            this.labelStateName.Font = new System.Drawing.Font("Cascadia Mono", 13.8F);
            this.labelStateName.ForeColor = System.Drawing.Color.White;
            this.labelStateName.Location = new System.Drawing.Point(12, 17);
            this.labelStateName.Name = "labelStateName";
            this.labelStateName.Size = new System.Drawing.Size(91, 30);
            this.labelStateName.TabIndex = 0;
            this.labelStateName.Text = "------";
            // 
            // buttonRUS
            // 
            this.buttonRUS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonRUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRUS.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRUS.ForeColor = System.Drawing.Color.White;
            this.buttonRUS.Location = new System.Drawing.Point(150, 11);
            this.buttonRUS.Name = "buttonRUS";
            this.buttonRUS.Size = new System.Drawing.Size(50, 50);
            this.buttonRUS.TabIndex = 1;
            this.buttonRUS.Text = "RUS";
            this.buttonRUS.UseVisualStyleBackColor = false;
            // 
            // buttonENG
            // 
            this.buttonENG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonENG.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonENG.ForeColor = System.Drawing.Color.White;
            this.buttonENG.Location = new System.Drawing.Point(220, 11);
            this.buttonENG.Name = "buttonENG";
            this.buttonENG.Size = new System.Drawing.Size(50, 50);
            this.buttonENG.TabIndex = 2;
            this.buttonENG.Text = "ENG";
            this.buttonENG.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Clicker.Properties.Resources.ImageOne;
            this.pictureBox.Location = new System.Drawing.Point(17, 67);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(253, 120);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(17, 190);
            this.labelTitle.MaximumSize = new System.Drawing.Size(253, 248);
            this.labelTitle.MinimumSize = new System.Drawing.Size(253, 248);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelTitle.Size = new System.Drawing.Size(253, 248);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "----";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(282, 453);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonENG);
            this.Controls.Add(this.buttonRUS);
            this.Controls.Add(this.labelStateName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 500);
            this.MinimumSize = new System.Drawing.Size(300, 500);
            this.Name = "FormHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHelp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStateName;
        private System.Windows.Forms.Button buttonRUS;
        private System.Windows.Forms.Button buttonENG;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelTitle;
    }
}