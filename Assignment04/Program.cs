using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
// Author's Name: Koolait Roa
// Student No.: 301034220
// Revision History:
// Date         Changes
// 22-Jul-2019  Created
// 24-Jul-2019  Instantiated Dictionary Forms
//              Created and added enums START_FORM, BMICALCULATOR_FORM at Forms
//              Application.Run(Forms[FormName.START_FORM]);
namespace Assignment04
{
    public static class Program
    {
        public static Dictionary<FormName, Form> Forms;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());

            Forms = new Dictionary<FormName, Form>();
            Forms.Add(FormName.START_FORM, new StartForm());
            Forms.Add(FormName.BMICALCULATOR_FORM, new BMICalculatorForm());

            Application.Run(Forms[FormName.START_FORM]);
        }
    }
}
