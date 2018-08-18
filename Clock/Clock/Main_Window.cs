using System;
using System.Windows.Forms;

namespace Clock
{
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
        }

        private void Image_Timer_Click(object sender, EventArgs e)
        {
            Timer_Form timerObj = new Timer_Form();
            timerObj.Show();
        }

        private void Image_StopWatch_Click(object sender, EventArgs e)
        {
            StopWatch_Form stopWatchobj=new StopWatch_Form();
            stopWatchobj.Show();
        }

        private void Image_Clock_Click(object sender, EventArgs e)
        {
            TimeNow TimeNowObj=new TimeNow();
            TimeNowObj.Show();

        }

        private void Panel_TimeSpan_Click(object sender, EventArgs e)
        {
            TimeSpan TimeSpanObj = new TimeSpan();
            TimeSpanObj.Show();

        }
    }
}
