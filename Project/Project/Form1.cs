﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void txt(object sender, EventArgs e)
        {
            for (int i = 0; i < TimeSpan.FromSeconds(9.0D); i++)
            {
                
            }
            pictureBox1.ImageLocation = @"C:\Users\FURQAN\Desktop\RESOUSES\1.png";
        }
    }
}
