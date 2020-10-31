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
            //Application.Run(new PlayerForm());
            using (SoccerApplicationContext soccerAppContext = new SoccerApplicationContext())
            {
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
    }

    class SoccerApplicationContext : ApplicationContext
    {
        protected internal static int _formCount;
        protected internal static PlayerForm plForm;
        protected internal static TeamForm tmForm;

        public SoccerApplicationContext()
        {
            plForm = new PlayerForm();
            //tmForm = new TeamForm();
            //plForm.FormClosed += OnFormClosed;
            //tmForm.FormClosed += OnFormClosed;
            //plForm.Load += OnFormLoad;
            //tmForm.Load += OnFormLoad;

            plForm.Show();
            //tmForm.Show();
            MessageBox.Show("Kek");
            //tmForm.Close();
        }

        public static void PlayerFormsNew()
        {
            if (plForm is null)
            {
                plForm = new PlayerForm();
                plForm.Show();
            }
            else
                plForm.Focus();
        }

        public static void TeamFormsNew()
        {
            if (tmForm is null)
            {
                tmForm = new TeamForm();
                tmForm.Show();
            }
            else
                tmForm.Focus();
        }
        //TODO: Make one method FormsNew(Form form)

        private void OnFormClosed(object sender, EventArgs e)
        {
            _formCount--;
            MessageBox.Show("Форма закрыта");
            if (_formCount <= 0)
                ExitThread();
        }

        void OnFormLoad(object sender, EventArgs e)
        {
            //if(sender is PlayerForm p)
            //    p.LoadPlayers();
            //if (sender is TeamForm t)
            //    t.LoadTeams();
            _formCount++;
            MessageBox.Show("Форма открыта");
            switch (sender)
            {
                case PlayerForm p:
                    p.LoadPlayers();
                    return;
                case TeamForm t:
                    t.LoadTeams();
                    return;
            }
        }        
        internal static void WhenFormLoad(Form form)
        {
            //if(sender is PlayerForm p)
            //    p.LoadPlayers();
            //if (sender is TeamForm t)
            //    t.LoadTeams();
            _formCount++;
            //MessageBox.Show("Форма открыта");
            //switch (form)
            //{
            //    case PlayerForm p:
            //        p.LoadPlayers();
            //        return;
            //    case TeamForm t:
            //        t.LoadTeams();
            //        return;
            //}
        }
    }
}
