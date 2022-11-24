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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStateName
            // 
            this.labelStateName.AutoSize = true;
            this.labelStateName.Font = new System.Drawing.Font("Cascadia Mono", 13.8F);
            this.labelStateName.Location = new System.Drawing.Point(12, 17);
            this.labelStateName.Name = "labelStateName";
            this.labelStateName.Size = new System.Drawing.Size(91, 30);
            this.labelStateName.TabIndex = 0;
            this.labelStateName.Text = "------";
            // 
            // buttonRUS
            // 
            this.buttonRUS.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRUS.Location = new System.Drawing.Point(150, 11);
            this.buttonRUS.Name = "buttonRUS";
            this.buttonRUS.Size = new System.Drawing.Size(50, 50);
            this.buttonRUS.TabIndex = 1;
            this.buttonRUS.Text = "RUS";
            this.buttonRUS.UseVisualStyleBackColor = true;
            // 
            // buttonENG
            // 
            this.buttonENG.Font = new System.Drawing.Font("Cascadia Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonENG.Location = new System.Drawing.Point(220, 11);
            this.buttonENG.Name = "buttonENG";
            this.buttonENG.Size = new System.Drawing.Size(50, 50);
            this.buttonENG.TabIndex = 2;
            this.buttonENG.Text = "ENG";
            this.buttonENG.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox.Image = global::Clicker.Properties.Resources.adv2;
            this.pictureBox.Location = new System.Drawing.Point(1, 77);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(281, 378);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 453);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonENG);
            this.Controls.Add(this.buttonRUS);
            this.Controls.Add(this.labelStateName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHelp";
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
    }
}