namespace SoccerPractice
{
    partial class TeamEditor
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
            this.couch_Label = new System.Windows.Forms.Label();
            this.name_Label = new System.Windows.Forms.Label();
            this.cancel_Button = new System.Windows.Forms.Button();
            this.ok_Button = new System.Windows.Forms.Button();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.couch_TextBox = new System.Windows.Forms.TextBox();
            this.null_ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.null_ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // couch_Label
            // 
            this.couch_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.couch_Label.AutoSize = true;
            this.couch_Label.Location = new System.Drawing.Point(19, 106);
            this.couch_Label.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.couch_Label.Name = "couch_Label";
            this.couch_Label.Size = new System.Drawing.Size(38, 13);
            this.couch_Label.TabIndex = 17;
            this.couch_Label.Text = "Couch";
            // 
            // name_Label
            // 
            this.name_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.name_Label.AutoSize = true;
            this.name_Label.Location = new System.Drawing.Point(19, 51);
            this.name_Label.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(35, 13);
            this.name_Label.TabIndex = 16;
            this.name_Label.Text = "Name";
            // 
            // cancel_Button
            // 
            this.cancel_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_Button.Location = new System.Drawing.Point(147, 176);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.cancel_Button.TabIndex = 15;
            this.cancel_Button.Text = "Cancel";
            this.cancel_Button.UseVisualStyleBackColor = true;
            // 
            // ok_Button
            // 
            this.ok_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ok_Button.Location = new System.Drawing.Point(66, 176);
            this.ok_Button.Name = "ok_Button";
            this.ok_Button.Size = new System.Drawing.Size(75, 23);
            this.ok_Button.TabIndex = 14;
            this.ok_Button.Text = "Ok";
            this.ok_Button.UseVisualStyleBackColor = true;
            this.ok_Button.Click += new System.EventHandler(this.ok_Button_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.name_textBox.Location = new System.Drawing.Point(90, 48);
            this.name_textBox.Margin = new System.Windows.Forms.Padding(3, 3, 15, 32);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(120, 20);
            this.name_textBox.TabIndex = 11;
            this.name_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.name_textBox_Validating);
            // 
            // couch_TextBox
            // 
            this.couch_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.couch_TextBox.Location = new System.Drawing.Point(90, 103);
            this.couch_TextBox.Margin = new System.Windows.Forms.Padding(3, 3, 15, 32);
            this.couch_TextBox.Name = "couch_TextBox";
            this.couch_TextBox.Size = new System.Drawing.Size(120, 20);
            this.couch_TextBox.TabIndex = 19;
            // 
            // null_ErrorProvider
            // 
            this.null_ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.null_ErrorProvider.ContainerControl = this;
            // 
            // TeamEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.couch_TextBox);
            this.Controls.Add(this.couch_Label);
            this.Controls.Add(this.name_Label);
            this.Controls.Add(this.cancel_Button);
            this.Controls.Add(this.ok_Button);
            this.Controls.Add(this.name_textBox);
            this.MinimumSize = new System.Drawing.Size(250, 250);
            this.Name = "TeamEditor";
            this.Text = "TeamEditor";
            ((System.ComponentModel.ISupportInitialize)(this.null_ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label couch_Label;
        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.Button cancel_Button;
        private System.Windows.Forms.Button ok_Button;
        private System.Windows.Forms.ErrorProvider null_ErrorProvider;
        protected internal System.Windows.Forms.TextBox name_textBox;
        protected internal System.Windows.Forms.TextBox couch_TextBox;
    }
}