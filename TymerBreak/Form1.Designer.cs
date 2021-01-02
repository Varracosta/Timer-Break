
namespace TymerBreak
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startCycle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cycleTimer = new System.Windows.Forms.TextBox();
            this.hoursCounter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // startCycle
            // 
            this.startCycle.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startCycle.Location = new System.Drawing.Point(244, 518);
            this.startCycle.Name = "startCycle";
            this.startCycle.Size = new System.Drawing.Size(120, 40);
            this.startCycle.TabIndex = 0;
            this.startCycle.Text = "Start!";
            this.startCycle.UseVisualStyleBackColor = true;
            this.startCycle.Click += new System.EventHandler(this.startCycle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(595, 384);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 427);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(595, 71);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "This program will take care of your eye health. When 1 hour will pass, give your " +
    "eyes a 10 minutes break. Hit the Start button, and countdown will start! ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cycleTimer
            // 
            this.cycleTimer.Enabled = false;
            this.cycleTimer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cycleTimer.Location = new System.Drawing.Point(424, 48);
            this.cycleTimer.Multiline = true;
            this.cycleTimer.Name = "cycleTimer";
            this.cycleTimer.Size = new System.Drawing.Size(140, 38);
            this.cycleTimer.TabIndex = 3;
            this.cycleTimer.Text = "01:00:00";
            this.cycleTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hoursCounter
            // 
            this.hoursCounter.Enabled = false;
            this.hoursCounter.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hoursCounter.Location = new System.Drawing.Point(424, 114);
            this.hoursCounter.Multiline = true;
            this.hoursCounter.Name = "hoursCounter";
            this.hoursCounter.Size = new System.Drawing.Size(140, 38);
            this.hoursCounter.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 580);
            this.Controls.Add(this.hoursCounter);
            this.Controls.Add(this.cycleTimer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.startCycle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Time Break";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startCycle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox cycleTimer;
        private System.Windows.Forms.TextBox hoursCounter;
    }
}

