namespace GokkersApp
{
    partial class UserSelector
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
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.loadUserButton = new System.Windows.Forms.Button();
            this.newUserButton = new System.Windows.Forms.Button();
            this.chooseUserButton = new System.Windows.Forms.Button();
            this.makeNewUserButton = new System.Windows.Forms.Button();
            this.newUserTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userComboBox
            // 
            this.userComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userComboBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.userComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(12, 12);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(584, 32);
            this.userComboBox.TabIndex = 0;
            this.userComboBox.SelectedIndexChanged += new System.EventHandler(this.userComboBox_SelectedIndexChanged);
            // 
            // loadUserButton
            // 
            this.loadUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadUserButton.Location = new System.Drawing.Point(12, 102);
            this.loadUserButton.Name = "loadUserButton";
            this.loadUserButton.Size = new System.Drawing.Size(584, 48);
            this.loadUserButton.TabIndex = 1;
            this.loadUserButton.Text = "Laden";
            this.loadUserButton.UseVisualStyleBackColor = true;
            // 
            // newUserButton
            // 
            this.newUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newUserButton.Location = new System.Drawing.Point(12, 156);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(584, 48);
            this.newUserButton.TabIndex = 2;
            this.newUserButton.Text = "Nieuwe Gebruiker Maken";
            this.newUserButton.UseVisualStyleBackColor = true;
            // 
            // chooseUserButton
            // 
            this.chooseUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseUserButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.chooseUserButton.Location = new System.Drawing.Point(12, 102);
            this.chooseUserButton.Name = "chooseUserButton";
            this.chooseUserButton.Size = new System.Drawing.Size(584, 48);
            this.chooseUserButton.TabIndex = 1;
            this.chooseUserButton.Text = "Laden";
            this.chooseUserButton.UseVisualStyleBackColor = false;
            this.chooseUserButton.Click += new System.EventHandler(this.chooseUserButton_Click);
            // 
            // makeNewUserButton
            // 
            this.makeNewUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.makeNewUserButton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.makeNewUserButton.Location = new System.Drawing.Point(12, 156);
            this.makeNewUserButton.Name = "makeNewUserButton";
            this.makeNewUserButton.Size = new System.Drawing.Size(584, 48);
            this.makeNewUserButton.TabIndex = 2;
            this.makeNewUserButton.Text = "Nieuwe Gebruiker Maken";
            this.makeNewUserButton.UseVisualStyleBackColor = false;
            this.makeNewUserButton.Click += new System.EventHandler(this.makeNewUserButton_Click);
            // 
            // newUserTextBox
            // 
            this.newUserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserTextBox.Location = new System.Drawing.Point(13, 67);
            this.newUserTextBox.Name = "newUserTextBox";
            this.newUserTextBox.Size = new System.Drawing.Size(583, 29);
            this.newUserTextBox.TabIndex = 3;
            // 
            // UserSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(608, 215);
            this.Controls.Add(this.newUserTextBox);
            this.Controls.Add(this.makeNewUserButton);
            this.Controls.Add(this.newUserButton);
            this.Controls.Add(this.chooseUserButton);
            this.Controls.Add(this.loadUserButton);
            this.Controls.Add(this.userComboBox);
            this.Name = "UserSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gebruikers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.Button loadUserButton;
        private System.Windows.Forms.Button newUserButton;
        private System.Windows.Forms.Button chooseUserButton;
        private System.Windows.Forms.Button makeNewUserButton;
        private System.Windows.Forms.TextBox newUserTextBox;
    }
}