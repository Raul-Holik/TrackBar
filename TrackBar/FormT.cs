﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trcBar1_Scroll(object sender, EventArgs e)
        {
            txtBx1.Text = trcBar1.Value.ToString() ;
        }
    }
}
