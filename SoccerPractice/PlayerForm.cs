using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace SoccerPractice
{
    public partial class PlayerForm : Form
    {
        SoccerContext context;
        Player player;

        public PlayerForm()
        {
            InitializeComponent();
        }

        private void PlayerForm_Load(object sender, EventArgs e)
        {
            LoadPlayers();
            SoccerApplicationContext._formCount++;
            this.FormClosed += Program.soccerAppContext.OnFormClosed;
            //players_DataGridView.DataSource = context.Players.Select(p=>new { p.Name, p.Position, p.Age, p.Team }).ToList();
        }

        protected internal void LoadPlayers()
        {
            context = new SoccerContext();
            context.Players.Load();
            players_DataGridView.DataSource = context.Players.Local.ToBindingList();
        }

        private void players_DataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            player = context.Players.Find(((Player)Data((DataGridView)sender, e.RowIndex)).Id);
            //MessageBox.Show(player.ToString());
        }

        protected internal object Data(DataGridView data, int rowIndex)
        {
            return data.Rows[rowIndex].DataBoundItem;
        }

        private void teams_Button_Click(object sender, EventArgs e)
        {
            //TeamForm teamForm = new TeamForm();
            //teamForm.Show();
            
            SoccerApplicationContext.TeamFormsNew();
        }

        /// <summary>
        /// Event handler for adding player button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_Button_Click(object sender, EventArgs e)
        {
            //Creating and showing of players editor window form as dialog.
            PlayerEditor editor = new PlayerEditor
                (context.Players.Local.ToBindingList()
                , context.Teams.Local.ToBindingList());

            DialogResult result = editor.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;

            //Choosing of a team.
            //If that team doesn't exists - creating a new one.
            Team team;
            //int teamId = (int)editor.team_comboBox.SelectedValue;
            if (/*context.Teams.Find(teamId)*/editor.team_comboBox.SelectedValue is null)
            {
                team = new Team { Name = editor.team_comboBox.Text };
                context.Teams.Add(team);
                context.SaveChanges();
            }
            else
                team = (Team)editor.team_comboBox.SelectedItem;

            //Creating of a new player.
            Player player = new Player
            {
                Name = editor.name_textBox.Text,
                Age = (int)editor.age_numericUpDown.Value,
                Position = editor.position_comboBox.Text,
                Team = team
            };

            context.Players.Add(player);
            context.SaveChanges();
            players_DataGridView.Refresh();
        }

        /// <summary>
        /// Event handler for editing of existing player button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void edit_Button_Click(object sender, EventArgs e)
        {
            if (player is null) 
            {
                MessageBox.Show
                    ("At least one player must be selected", 
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }

            //Creating and showing of players editor window form as dialog.
            PlayerEditor editor = new PlayerEditor
                (context.Players.Local.ToBindingList()
                , context.Teams.Local.ToBindingList());

            //Assigning of selected player attributes values to the form attributes for convenience.
            editor.name_textBox.Text = player.Name;
            editor.age_numericUpDown.Value = player.Age;
            editor.position_comboBox.Text = player.Position;
            editor.team_comboBox.Text = player.Team.ToString();

            DialogResult result = editor.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;

            //Selecting of a team.
            //If that team doesn't exist - creating a new one.
            Team team;
            if (/*context.Teams.Find(teamId)*/editor.team_comboBox.SelectedValue is null)
            { 
                team = new Team { Name = editor.team_comboBox.Text };
                context.Teams.Add(team);
                context.SaveChanges();
            }
            else
                team = (Team)editor.team_comboBox.SelectedItem;

            player.Name = editor.name_textBox.Text;
            player.Age = (int)editor.age_numericUpDown.Value;
            player.Position = editor.position_comboBox.Text;
            player.TeamId = team.Id;

            //context.Entry(player).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            players_DataGridView.Refresh();
        }

        /// <summary>
        /// Event handler for deleting player button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_Button_Click(object sender, EventArgs e)
        {
            context.Players.Remove(player);
            context.SaveChanges();
            players_DataGridView.Refresh();
        }
    }
}
