using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace Clock
{
    public  partial class Timer_Form : Form
    {
        
        private double i,M,S;
        private int _60SecDelay = 0;
        System.Timers.Timer myTimer1 = new System.Timers.Timer();


        public Timer_Form()
        {
            InitializeComponent();
            myTimer1.Elapsed += new ElapsedEventHandler(DigitChanger);
        }



        /*COUNTDOWN         TIMER            STARTS*/

        private void Start_Timer_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txt_Min.Text) == 0 && Convert.ToDouble(txt_Sec.Text) == 0)
            {
                MessageBox.Show("Invalid Duration");
                myTimer1.Enabled = false;
            }
            else
            {
                myTimer1.Interval = 1000;
                myTimer1.Enabled = true;
                M = Convert.ToDouble(txt_Min.Text);
                S = Convert.ToDouble(txt_Sec.Text);
            }
            
        }

        private void DigitChanger(object source, ElapsedEventArgs e)
        {
            _60SecDelay += 1;
            txt_Sec.Text = S.ToString();
            txt_Min.Text = M.ToString();

            if (S == 0)
            {
                S = 0;
            }
            else
            {
                S -= 1;
            }


            if (_60SecDelay%59==0)
            {
                if (M == 0)
                {
                    M = 0;
                }
                else
                {
                    M -= 1;
                }
            }

           
            if (S==0&&M>0)
            {
                M -= 1;
                S = 59;
            }

            if (M == 0 && S == 0 && i==0)
            {
                i += 1;
                MessageBox.Show("Time's up!");
            }
            
        }

        /*COUNTDOWN          TIMER              END*/

    }
}

