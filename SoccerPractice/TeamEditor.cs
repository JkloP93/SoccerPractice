using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerPractice
{
    public partial class TeamEditor : Form
    {
        public TeamEditor()
        {
            InitializeComponent();
        }

        private void name_textBox_Validating(object sender, CancelEventArgs e)
        {
            Program.TextBoxValidation((TextBox)sender, null_ErrorProvider, e);
        }

        private void ok_Button_Click(object sender, EventArgs e)
        {
            if (null_ErrorProvider.GetError(name_textBox) != string.Empty)
                ok_Button.DialogResult = DialogResult.None;
            else
                ok_Button.DialogResult = DialogResult.OK;
        }
    }
}
