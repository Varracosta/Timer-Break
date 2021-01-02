using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace TymerBreak
{
    public partial class Form1 : Form
    {
        private int _totalHours = 0; //number of hours 
        public Form1()
        {
            InitializeComponent();
        }
        private void startCycle_Click(object sender, EventArgs e)
        {
            StartTimer(); //when cycle ends, 1 hour adds to total hours + start button becomes enabled
            _totalHours++;
            startCycle.Enabled = false; //start button becomes inactive so that cycle could end without interruption
        }
        async private void StartTimer()
        {
            TimeSpan ts = new TimeSpan(1, 0, 0); //initialising new Timespan with value of 1 hour
            while (ts > TimeSpan.Zero)
            {
                cycleTimer.Invoke((Action)(() => { cycleTimer.Text = ts.ToString(); }));
                await Task.Delay(1000);
                ts -= TimeSpan.FromSeconds(1);
            }
            PopWindow pw = new PopWindow(); 
            pw.Show();   //after cycle ends, new form pops up
            hoursCounter.Text = $"Total hours: {_totalHours}"; 
            startCycle.Enabled = true;  //displaying total hours and enabling the Start button
        }
    }
}
