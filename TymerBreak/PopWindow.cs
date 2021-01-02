using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TymerBreak
{
    public partial class PopWindow : Form
    {
        public PopWindow()
        {
            InitializeComponent();
            TopMost = true; 
        }
        //the code is almost the same as in Form1 
        async private void StartTimer()  
        {
            TimeSpan ts = new TimeSpan(0, 10, 0);
            while (ts > TimeSpan.Zero)
            {
                breakTimer.Invoke((Action)(() => { breakTimer.Text = ts.ToString(); }));
                await Task.Delay(1000);
                ts -= TimeSpan.FromSeconds(1);
            }
            MessageBox.Show("Break finished! You can return to work!"); //after 10min break ends, message box will appear
            Close();
        }

        private void startBreak_Click(object sender, EventArgs e)
        {
            StartTimer();
            startBreak.Enabled = false;  //enables start button
        }
        private void PopWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.DoEvents();
        }
    }
}
