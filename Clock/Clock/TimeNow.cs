﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class TimeNow : Form
    {
        public TimeNow()
        {
            InitializeComponent();
            L_Time.Text = DateTime.Now.ToString();
        }

        private void L_Time_Click(object sender, EventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            L_Time.Text = DateTime.Now.ToString();
        }
    }
}
