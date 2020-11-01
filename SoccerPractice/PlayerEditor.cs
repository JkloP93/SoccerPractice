using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace SoccerPractice
{
    public partial class PlayerEditor : Form
    {
        public PlayerEditor()
        {
            InitializeComponent();
        }

        public PlayerEditor(IEnumerable<Player> players, IEnumerable<Team> teams) : this()
        {
            this.position_comboBox.DataSource = players;
            this.team_comboBox.DataSource = teams;
        }

        private void name_textBox_Validating(object sender, CancelEventArgs e)
        {
            Program.TextBoxValidation((TextBox)sender, null_ErrorProvider, e);
        }

        private void age_numericUpDown_Validating(object sender, CancelEventArgs e)
        {
            Program.NumericUpDownValidation((NumericUpDown)sender, null_ErrorProvider, e);
        }

        private void ok_Button_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
