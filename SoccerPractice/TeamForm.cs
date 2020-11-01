using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerPractice
{
    public partial class TeamForm : Form
    {
        SoccerContext context;
        Team team;

        public TeamForm()
        {
            InitializeComponent();
        }

        private void TeamForm_Load(object sender, EventArgs e)
        {
            LoadTeams();
        }

        protected internal void LoadTeams()
        {
            context = new SoccerContext();
            context.Teams.Load();

            teams_DataGridView.DataSource = context.Teams.Local.ToBindingList();
        }

        private void add_Button_Click(object sender, EventArgs e)
        {
            TeamEditor editor = new TeamEditor();
            DialogResult result = editor.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            context.Teams.Add
                (
                    new Team
                    {
                        Name = editor.name_textBox.Text,
                        Couch = editor.couch_TextBox.Text == string.Empty ? null : editor.couch_TextBox.Text
                    }
                );

            context.SaveChanges();
            teams_DataGridView.Refresh();
        }

        private void edit_Button_Click(object sender, EventArgs e)
        {
            TeamEditor editor = new TeamEditor();
            editor.name_textBox.Text = team.Name;
            editor.couch_TextBox.Text = team.Couch;
            DialogResult result = editor.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            team.Name = editor.name_textBox.Text;
            team.Couch = editor.couch_TextBox.Text;

            context.SaveChanges();
            teams_DataGridView.Refresh();
        }

        private void delete_Button_Click(object sender, EventArgs e)
        {
            context.Teams.Remove(team);
            context.SaveChanges();
            teams_DataGridView.Refresh();
        }

        private void teams_DataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            team = context.Teams.Find(((Team)Data((DataGridView)sender, e.RowIndex)).Id);
        }

        protected internal object Data(DataGridView data, int rowIndex)
        {
            return data.Rows[rowIndex].DataBoundItem;
        }

        private void players_Button_Click(object sender, EventArgs e)
        {
            players_ListBox.DataSource = team.Players.ToList();
        }
    }
}
