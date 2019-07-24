using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Author's Name: Koolait Roa
// Student No.: 301034220
// Revision History:
// Date         Changes
// 24-Jul-2019  Created
//              Added a timer and tick event
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
