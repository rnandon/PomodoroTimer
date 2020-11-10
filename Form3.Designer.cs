namespace PomodoroTimer
{
    partial class Form3
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
            this.gotoForm1 = new System.Windows.Forms.Button();
            this.gotoForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gotoForm1
            // 
            this.gotoForm1.Location = new System.Drawing.Point(41, 46);
            this.gotoForm1.Name = "gotoForm1";
            this.gotoForm1.Size = new System.Drawing.Size(152, 64);
            this.gotoForm1.TabIndex = 0;
            this.gotoForm1.Text = "Countdown Timer";
            this.gotoForm1.UseVisualStyleBackColor = true;
            this.gotoForm1.Click += new System.EventHandler(this.gotoForm1_Click);
            // 
            // gotoForm2
            // 
            this.gotoForm2.Location = new System.Drawing.Point(225, 46);
            this.gotoForm2.Name = "gotoForm2";
            this.gotoForm2.Size = new System.Drawing.Size(152, 64);
            this.gotoForm2.TabIndex = 1;
            this.gotoForm2.Text = "Count Up Timer";
            this.gotoForm2.UseVisualStyleBackColor = true;
            this.gotoForm2.Click += new System.EventHandler(this.gotoForm2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(424, 158);
            this.Controls.Add(this.gotoForm2);
            this.Controls.Add(this.gotoForm1);
            this.Name = "Form3";
            this.Text = "Timer Application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gotoForm1;
        private System.Windows.Forms.Button gotoForm2;
    }
}