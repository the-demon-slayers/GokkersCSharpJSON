namespace GokkersApp
{
    partial class AccountForm
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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.newAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(13, 37);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(396, 30);
            this.usernameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gebruikersnaam";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wachtword";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(13, 98);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(396, 30);
            this.passwordTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "A.U.B Inloggen";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(13, 171);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(397, 80);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Inloggen";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Geen Account? Maak en nieuwe aan!";
            // 
            // newAccountButton
            // 
            this.newAccountButton.Location = new System.Drawing.Point(262, 257);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(148, 29);
            this.newAccountButton.TabIndex = 7;
            this.newAccountButton.Text = "Nieuw Account";
            this.newAccountButton.UseVisualStyleBackColor = true;
            this.newAccountButton.Click += new System.EventHandler(this.newAccountButton_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(421, 290);
            this.Controls.Add(this.newAccountButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button newAccountButton;
    }
}