namespace SoccerPractice
{
    partial class TeamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.players_Button = new System.Windows.Forms.Button();
            this.edit_Button = new System.Windows.Forms.Button();
            this.delete_Button = new System.Windows.Forms.Button();
            this.add_Button = new System.Windows.Forms.Button();
            this.teams_DataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.couchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.players_ListBox = new System.Windows.Forms.ListBox();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.teams_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // players_Button
            // 
            this.players_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.players_Button.Location = new System.Drawing.Point(247, 406);
            this.players_Button.Name = "players_Button";
            this.players_Button.Size = new System.Drawing.Size(131, 23);
            this.players_Button.TabIndex = 9;
            this.players_Button.Text = "Team members";
            this.players_Button.UseVisualStyleBackColor = true;
            this.players_Button.Click += new System.EventHandler(this.players_Button_Click);
            // 
            // edit_Button
            // 
            this.edit_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.edit_Button.Location = new System.Drawing.Point(275, 371);
            this.edit_Button.Margin = new System.Windows.Forms.Padding(9);
            this.edit_Button.Name = "edit_Button";
            this.edit_Button.Size = new System.Drawing.Size(75, 23);
            this.edit_Button.TabIndex = 8;
            this.edit_Button.Text = "Edit";
            this.edit_Button.UseVisualStyleBackColor = true;
            this.edit_Button.Click += new System.EventHandler(this.edit_Button_Click);
            // 
            // delete_Button
            // 
            this.delete_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_Button.Location = new System.Drawing.Point(537, 371);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(75, 23);
            this.delete_Button.TabIndex = 7;
            this.delete_Button.Text = "Delete";
            this.delete_Button.UseVisualStyleBackColor = true;
            this.delete_Button.Click += new System.EventHandler(this.delete_Button_Click);
            // 
            // add_Button
            // 
            this.add_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add_Button.Location = new System.Drawing.Point(12, 371);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(75, 23);
            this.add_Button.TabIndex = 6;
            this.add_Button.Text = "Add";
            this.add_Button.UseVisualStyleBackColor = true;
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click);
            // 
            // teams_DataGridView
            // 
            this.teams_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teams_DataGridView.AutoGenerateColumns = false;
            this.teams_DataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.teams_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teams_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.couchDataGridViewTextBoxColumn});
            this.teams_DataGridView.DataSource = this.teamBindingSource;
            this.teams_DataGridView.Location = new System.Drawing.Point(12, 12);
            this.teams_DataGridView.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.teams_DataGridView.Name = "teams_DataGridView";
            this.teams_DataGridView.Size = new System.Drawing.Size(475, 347);
            this.teams_DataGridView.TabIndex = 5;
            this.teams_DataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.teams_DataGridView_CellEnter);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // couchDataGridViewTextBoxColumn
            // 
            this.couchDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.couchDataGridViewTextBoxColumn.DataPropertyName = "Couch";
            this.couchDataGridViewTextBoxColumn.HeaderText = "Couch";
            this.couchDataGridViewTextBoxColumn.Name = "couchDataGridViewTextBoxColumn";
            this.couchDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataSource = typeof(SoccerPractice.Team);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.players_ListBox);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(493, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.groupBox1.Size = new System.Drawing.Size(119, 347);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Team players";
            // 
            // players_ListBox
            // 
            this.players_ListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.players_ListBox.DataSource = this.playerBindingSource;
            this.players_ListBox.DisplayMember = "Name";
            this.players_ListBox.FormattingEnabled = true;
            this.players_ListBox.Location = new System.Drawing.Point(0, 27);
            this.players_ListBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 15);
            this.players_ListBox.Name = "players_ListBox";
            this.players_ListBox.Size = new System.Drawing.Size(119, 316);
            this.players_ListBox.TabIndex = 0;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(SoccerPractice.Player);
            // 
            // TeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.players_Button);
            this.Controls.Add(this.edit_Button);
            this.Controls.Add(this.delete_Button);
            this.Controls.Add(this.add_Button);
            this.Controls.Add(this.teams_DataGridView);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "TeamForm";
            this.Text = "Teams";
            this.Load += new System.EventHandler(this.TeamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teams_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button players_Button;
        private System.Windows.Forms.Button edit_Button;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.Button add_Button;
        private System.Windows.Forms.DataGridView teams_DataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox players_ListBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn couchDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private System.Windows.Forms.BindingSource playerBindingSource;
    }
}