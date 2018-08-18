using System;
using System.Windows.Forms;


namespace Clock
{
    public partial class StopWatch_Form : Form
    {
        public StopWatch_Form()
        {
            InitializeComponent();
        }

        private void StopWatch_Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            L_MS.Text = "00";
            L_S.Text  = "00";
            L_M.Text  = "00";
            L_H.Text  = "00";
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            L_MS.Text = Convert.ToString(Convert.ToInt32(L_MS.Text) + 01);

           if (Convert.ToInt32(L_MS.Text)==79)
            {
                L_MS.Text = "00";
                L_S.Text = Convert.ToString(Convert.ToInt32(L_S.Text) + 1);
            }

            if (Convert.ToInt32(L_S.Text) == 59)
            {
                L_S.Text = "00";
                L_M.Text = Convert.ToString(Convert.ToInt32(L_M.Text) + 1);
            }

            if (Convert.ToInt32(L_M.Text) == 59)
            {
                L_M.Text = "00";
                L_H.Text = Convert.ToString(Convert.ToInt32(L_H.Text) + 1);
            }

        }
    }
}
