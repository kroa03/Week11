﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment04
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartFormTimer_Tick(object sender, EventArgs e)
        {
            StartFormTimer.Enabled = false;
            Program.Forms[FormName.BMICALCULATOR_FORM].Show();
            this.Hide();
        }
    }
}
