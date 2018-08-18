using System;
using System.Windows.Forms;

namespace Clock
{
    public partial class TimeSpan : Form
    {
        public TimeSpan()
        {
            InitializeComponent();
        }

        private void btn_Get_Duration_Click(object sender, EventArgs e)
        {
            
            var a=new DateTime(Convert.ToInt32(From_Y.Text), Convert.ToInt32(From_M.Text), Convert.ToInt32(From_D.Text));
            var b =new DateTime(Convert.ToInt32(To_Y.Text), Convert.ToInt32(To_M.Text), Convert.ToInt32(To_D.Text));
            var u = b - a;
            var y = u.Days / 365.00;
            var m = y - (u.Days / 365);
            y -= m;

            m *= 12;
            int dm = (int)m;
            var dd = m - dm;
            dd *= 30;
            MessageBox.Show("Years " + y + "\nMonths " + dm + "\nDays " + (int)dd);
        }

        private void From_M_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((From_M.Text == "4" || From_M.Text == "6" || From_M.Text == "9" || From_M.Text == "11") && From_D.Text == "31")
            {
                MessageBox.Show("Not all months are of 31 days");
            }
            if (From_M.Text == "2" && (From_D.Text == "30" || From_D.Text == "31"))
            {
                MessageBox.Show("Don't you know about Feburary?");
            }
        }

        private void From_D_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((From_M.Text == "4" || From_M.Text == "6" || From_M.Text == "9" || From_M.Text == "11") && From_D.Text == "31")
            {
                MessageBox.Show("Not all months are of 31 days");
            }
            if (From_M.Text == "2" && (From_D.Text == "30" || From_D.Text == "31"))
            {
                MessageBox.Show("Don't you know about Feburary?");
            }
        }

        private void To_M_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((To_M.Text == "4" || To_M.Text == "6" || To_M.Text == "9" || To_M.Text == "11") && From_D.Text == "31")
            {
                MessageBox.Show("Not all months are of 31 days");
            }
            if (To_M.Text == "2" && (To_D.Text == "30" || To_D.Text == "31"))
            {
                MessageBox.Show("Don't you know about Feburary?");
            }
        }

        private void To_D_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((To_M.Text == "4" || To_M.Text == "6" || To_M.Text == "9" || To_M.Text == "11" ) && From_D.Text == "31")
            {
                MessageBox.Show("Not all months are of 31 days");
            }
            if (To_M.Text == "2" && (To_D.Text == "30" || To_D.Text == "31"))
            {
                MessageBox.Show("Don't you know about Feburary?");
            }
        }
    }
}
