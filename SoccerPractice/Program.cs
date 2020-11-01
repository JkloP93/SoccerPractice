using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.ComponentModel;
using System.Runtime.CompilerServices;

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
            using (soccerAppContext = new SoccerApplicationContext())
            {
                soccerAppContext.Run();
                Application.Run(soccerAppContext); 
            }
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

        internal static SoccerApplicationContext soccerAppContext;
    }

    class SoccerApplicationContext : ApplicationContext
    {
        /// <summary>
        /// Counter for forms currently in used.
        /// </summary>
        /// <remarks>
        /// When a form opens - counter increases and vice-versa.
        /// </remarks>
        protected internal static int _formCount;
        /// <summary>
        /// Variable to store PlayerForm.
        /// </summary>
        protected internal static PlayerForm plForm;
        /// <summary>
        /// Variable to store TeamForm.
        /// </summary>
        protected internal static TeamForm tmForm;

        public SoccerApplicationContext() { }

        /// <summary>
        /// Method that enables run first form (PlayerForm currently) and the whole app accordingly.
        /// </summary>
        internal void Run()
        {
            plForm = new PlayerForm();
            plForm.Show();
        }

        /// <summary>
        /// <para>Method used either for creating new instance of PlayerForm class</para> 
        /// <para>and assigning it to the plForm variable</para>
        /// <para>or focusing on existing PlayerForm object</para>
        /// </summary>
        public static void PlayerFormsNew()
        {
            if (plForm == null)
            {
                plForm = new PlayerForm();
                plForm.Show();
            }
            else
                plForm.Focus();
        }

        /// <summary>
        /// Method used either for creating new instance of TeamForm class 
        /// and assigning it to the tmForm variable
        /// or focusing on existing TeamForm object
        /// </summary>
        public static void TeamFormsNew()
        {
            if (tmForm == null)
            {
                tmForm = new TeamForm();
                tmForm.Show();
            }
            else
                tmForm.Focus();
        }

        /// <summary>
        /// Handler for FormClosed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void OnFormClosed(object sender, EventArgs e)
        {
            _formCount--;
            MessageBox.Show("Форма закрыта");
            if (_formCount <= 0)
                ExitThread();
            switch (sender)
            {
                case PlayerForm p:
                    plForm = null;
                    return;
                case TeamForm t:
                    tmForm = null;
                    return;
            }
        }
    }
}
