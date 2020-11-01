using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.ComponentModel;

namespace SoccerPractice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PlayerForm());
        }
        internal static void TextBoxValidation(TextBox box, ErrorProvider error, CancelEventArgs e)
        {
            error.Clear();
            if (string.IsNullOrEmpty(box.Text))
            {
                error.SetError(box, "Can't be empty!");
                e.Cancel = true;
            }
        }
        
        internal static void NumericUpDownValidation(NumericUpDown box, ErrorProvider error, CancelEventArgs e)
        {
            error.Clear();
            if (((int)box.Value) == 0)
            {
                error.SetError(box, "Incorrect age!");
                e.Cancel = true;
            }
        }
    }
}
