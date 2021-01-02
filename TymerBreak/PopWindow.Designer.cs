
namespace TymerBreak
{
    partial class PopWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopWindow));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.startBreak = new System.Windows.Forms.Button();
            this.breakTimer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 416);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(24, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(561, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Time for a break! Do a break, or you\'ll be like Dorky:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startBreak
            // 
            this.startBreak.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startBreak.Location = new System.Drawing.Point(243, 504);
            this.startBreak.Name = "startBreak";
            this.startBreak.Size = new System.Drawing.Size(120, 40);
            this.startBreak.TabIndex = 4;
            this.startBreak.Text = "Start break";
            this.startBreak.UseVisualStyleBackColor = true;
            this.startBreak.Click += new System.EventHandler(this.startBreak_Click);
            // 
            // breakTimer
            // 
            this.breakTimer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.breakTimer.Location = new System.Drawing.Point(223, 84);
            this.breakTimer.Multiline = true;
            this.breakTimer.Name = "breakTimer";
            this.breakTimer.Size = new System.Drawing.Size(140, 38);
            this.breakTimer.TabIndex = 5;
            this.breakTimer.Text = "00:10:00";
            this.breakTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PopWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 580);
            this.Controls.Add(this.breakTimer);
            this.Controls.Add(this.startBreak);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PopWindow";
            this.Text = "PopWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PopWindow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button startBreak;
        private System.Windows.Forms.TextBox breakTimer;
    }
}