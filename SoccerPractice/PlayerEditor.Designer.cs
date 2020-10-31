namespace SoccerPractice
{
    partial class PlayerEditor
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
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.position_comboBox = new System.Windows.Forms.ComboBox();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.age_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ok_Button = new System.Windows.Forms.Button();
            this.cancel_Button = new System.Windows.Forms.Button();
            this.name_Label = new System.Windows.Forms.Label();
            this.position_Label = new System.Windows.Forms.Label();
            this.age_Label = new System.Windows.Forms.Label();
            this.null_ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.team_label = new System.Windows.Forms.Label();
            this.team_comboBox = new System.Windows.Forms.ComboBox();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.null_ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // name_textBox
            // 
            this.name_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.name_textBox.Location = new System.Drawing.Point(89, 21);
            this.name_textBox.Margin = new System.Windows.Forms.Padding(3, 3, 15, 23);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(121, 20);
            this.name_textBox.TabIndex = 1;
            this.name_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.name_textBox_Validating);
            // 
            // position_comboBox
            // 
            this.position_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.position_comboBox.DataSource = this.playerBindingSource;
            this.position_comboBox.DisplayMember = "Position";
            this.position_comboBox.FormattingEnabled = true;
            this.position_comboBox.Location = new System.Drawing.Point(89, 67);
            this.position_comboBox.Margin = new System.Windows.Forms.Padding(3, 3, 15, 23);
            this.position_comboBox.Name = "position_comboBox";
            this.position_comboBox.Size = new System.Drawing.Size(121, 21);
            this.position_comboBox.TabIndex = 2;
            this.position_comboBox.ValueMember = "Position";
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(SoccerPractice.Player);
            // 
            // age_numericUpDown
            // 
            this.age_numericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.age_numericUpDown.Location = new System.Drawing.Point(89, 114);
            this.age_numericUpDown.Margin = new System.Windows.Forms.Padding(3, 3, 15, 23);
            this.age_numericUpDown.Name = "age_numericUpDown";
            this.age_numericUpDown.Size = new System.Drawing.Size(121, 20);
            this.age_numericUpDown.TabIndex = 3;
            this.age_numericUpDown.Validating += new System.ComponentModel.CancelEventHandler(this.age_numericUpDown_Validating);
            // 
            // ok_Button
            // 
            this.ok_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ok_Button.Location = new System.Drawing.Point(66, 226);
            this.ok_Button.Name = "ok_Button";
            this.ok_Button.Size = new System.Drawing.Size(75, 23);
            this.ok_Button.TabIndex = 6;
            this.ok_Button.Text = "Ok";
            this.ok_Button.UseVisualStyleBackColor = true;
            this.ok_Button.Click += new System.EventHandler(this.ok_Button_Click);
            // 
            // cancel_Button
            // 
            this.cancel_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_Button.Location = new System.Drawing.Point(147, 226);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.cancel_Button.TabIndex = 7;
            this.cancel_Button.Text = "Cancel";
            this.cancel_Button.UseVisualStyleBackColor = true;
            // 
            // name_Label
            // 
            this.name_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.name_Label.AutoSize = true;
            this.name_Label.Location = new System.Drawing.Point(12, 24);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(35, 13);
            this.name_Label.TabIndex = 8;
            this.name_Label.Text = "Name";
            // 
            // position_Label
            // 
            this.position_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.position_Label.AutoSize = true;
            this.position_Label.Location = new System.Drawing.Point(12, 70);
            this.position_Label.Name = "position_Label";
            this.position_Label.Size = new System.Drawing.Size(44, 13);
            this.position_Label.TabIndex = 9;
            this.position_Label.Text = "Position";
            // 
            // age_Label
            // 
            this.age_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.age_Label.AutoSize = true;
            this.age_Label.Location = new System.Drawing.Point(12, 116);
            this.age_Label.Name = "age_Label";
            this.age_Label.Size = new System.Drawing.Size(26, 13);
            this.age_Label.TabIndex = 10;
            this.age_Label.Text = "Age";
            // 
            // null_ErrorProvider
            // 
            this.null_ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.null_ErrorProvider.ContainerControl = this;
            // 
            // team_label
            // 
            this.team_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.team_label.AutoSize = true;
            this.team_label.Location = new System.Drawing.Point(12, 163);
            this.team_label.Name = "team_label";
            this.team_label.Size = new System.Drawing.Size(34, 13);
            this.team_label.TabIndex = 12;
            this.team_label.Text = "Team";
            // 
            // team_comboBox
            // 
            this.team_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.team_comboBox.DataSource = this.teamBindingSource;
            this.team_comboBox.DisplayMember = "Name";
            this.team_comboBox.FormattingEnabled = true;
            this.team_comboBox.Location = new System.Drawing.Point(89, 160);
            this.team_comboBox.Margin = new System.Windows.Forms.Padding(3, 3, 15, 23);
            this.team_comboBox.Name = "team_comboBox";
            this.team_comboBox.Size = new System.Drawing.Size(121, 21);
            this.team_comboBox.TabIndex = 11;
            this.team_comboBox.ValueMember = "Id";
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataSource = typeof(SoccerPractice.Team);
            // 
            // PlayerEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(234, 261);
            this.Controls.Add(this.team_label);
            this.Controls.Add(this.team_comboBox);
            this.Controls.Add(this.age_Label);
            this.Controls.Add(this.position_Label);
            this.Controls.Add(this.name_Label);
            this.Controls.Add(this.cancel_Button);
            this.Controls.Add(this.ok_Button);
            this.Controls.Add(this.age_numericUpDown);
            this.Controls.Add(this.position_comboBox);
            this.Controls.Add(this.name_textBox);
            this.MinimumSize = new System.Drawing.Size(250, 300);
            this.Name = "PlayerEditor";
            this.Text = "PlayerEditor";
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.age_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.null_ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ok_Button;
        private System.Windows.Forms.Button cancel_Button;
        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.Label position_Label;
        private System.Windows.Forms.Label age_Label;
        private System.Windows.Forms.ErrorProvider null_ErrorProvider;
        protected internal System.Windows.Forms.TextBox name_textBox;
        protected internal System.Windows.Forms.ComboBox position_comboBox;
        protected internal System.Windows.Forms.NumericUpDown age_numericUpDown;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.Label team_label;
        protected internal System.Windows.Forms.ComboBox team_comboBox;
        private System.Windows.Forms.BindingSource teamBindingSource;
    }
}