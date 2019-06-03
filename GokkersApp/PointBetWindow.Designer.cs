namespace GokkersApp
{
    partial class PointBetWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.team1Label = new System.Windows.Forms.Label();
            this.team1Incrementor = new System.Windows.Forms.NumericUpDown();
            this.team2Incrementor = new System.Windows.Forms.NumericUpDown();
            this.confirmPointButton = new System.Windows.Forms.Button();
            this.team2Label = new System.Windows.Forms.Label();
            this.teamPickGroupBox = new System.Windows.Forms.GroupBox();
            this.team2Choice = new System.Windows.Forms.RadioButton();
            this.team1Choice = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.team1Incrementor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.team2Incrementor)).BeginInit();
            this.teamPickGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(334, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoeveel punten precies?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // team1Label
            // 
            this.team1Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.team1Label.AutoSize = true;
            this.team1Label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1Label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.team1Label.Location = new System.Drawing.Point(149, 110);
            this.team1Label.Name = "team1Label";
            this.team1Label.Size = new System.Drawing.Size(116, 32);
            this.team1Label.TabIndex = 1;
            this.team1Label.Text = "Team 1";
            this.team1Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // team1Incrementor
            // 
            this.team1Incrementor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.team1Incrementor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1Incrementor.Location = new System.Drawing.Point(175, 145);
            this.team1Incrementor.Name = "team1Incrementor";
            this.team1Incrementor.Size = new System.Drawing.Size(62, 30);
            this.team1Incrementor.TabIndex = 2;
            // 
            // team2Incrementor
            // 
            this.team2Incrementor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.team2Incrementor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team2Incrementor.Location = new System.Drawing.Point(768, 145);
            this.team2Incrementor.Name = "team2Incrementor";
            this.team2Incrementor.Size = new System.Drawing.Size(62, 30);
            this.team2Incrementor.TabIndex = 3;
            // 
            // confirmPointButton
            // 
            this.confirmPointButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPointButton.Location = new System.Drawing.Point(340, 273);
            this.confirmPointButton.Name = "confirmPointButton";
            this.confirmPointButton.Size = new System.Drawing.Size(337, 69);
            this.confirmPointButton.TabIndex = 4;
            this.confirmPointButton.Text = "Gokken!";
            this.confirmPointButton.UseVisualStyleBackColor = true;
            this.confirmPointButton.Click += new System.EventHandler(this.confirmPointButton_Click);
            // 
            // team2Label
            // 
            this.team2Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.team2Label.AutoSize = true;
            this.team2Label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team2Label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.team2Label.Location = new System.Drawing.Point(747, 110);
            this.team2Label.Name = "team2Label";
            this.team2Label.Size = new System.Drawing.Size(116, 32);
            this.team2Label.TabIndex = 5;
            this.team2Label.Text = "Team 2";
            this.team2Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // teamPickGroupBox
            // 
            this.teamPickGroupBox.Controls.Add(this.team2Choice);
            this.teamPickGroupBox.Controls.Add(this.team1Choice);
            this.teamPickGroupBox.Location = new System.Drawing.Point(169, 181);
            this.teamPickGroupBox.Name = "teamPickGroupBox";
            this.teamPickGroupBox.Size = new System.Drawing.Size(661, 86);
            this.teamPickGroupBox.TabIndex = 6;
            this.teamPickGroupBox.TabStop = false;
            // 
            // team2Choice
            // 
            this.team2Choice.AutoSize = true;
            this.team2Choice.Location = new System.Drawing.Point(534, 37);
            this.team2Choice.Name = "team2Choice";
            this.team2Choice.Size = new System.Drawing.Size(121, 21);
            this.team2Choice.TabIndex = 1;
            this.team2Choice.TabStop = true;
            this.team2Choice.Text = "Gok op team2!";
            this.team2Choice.UseVisualStyleBackColor = true;
            this.team2Choice.Click += new System.EventHandler(this.team2Choice_Click);
            // 
            // team1Choice
            // 
            this.team1Choice.AutoSize = true;
            this.team1Choice.Location = new System.Drawing.Point(6, 37);
            this.team1Choice.Name = "team1Choice";
            this.team1Choice.Size = new System.Drawing.Size(121, 21);
            this.team1Choice.TabIndex = 0;
            this.team1Choice.TabStop = true;
            this.team1Choice.Text = "Gok op team1!";
            this.team1Choice.UseVisualStyleBackColor = true;
            this.team1Choice.Click += new System.EventHandler(this.team1Choice_Click);
            // 
            // PointBetWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(995, 354);
            this.Controls.Add(this.teamPickGroupBox);
            this.Controls.Add(this.team2Label);
            this.Controls.Add(this.confirmPointButton);
            this.Controls.Add(this.team2Incrementor);
            this.Controls.Add(this.team1Incrementor);
            this.Controls.Add(this.team1Label);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PointBetWindow";
            this.Text = "PointBetWindow";
            this.Load += new System.EventHandler(this.PointBetWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.team1Incrementor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.team2Incrementor)).EndInit();
            this.teamPickGroupBox.ResumeLayout(false);
            this.teamPickGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label team1Label;
        private System.Windows.Forms.NumericUpDown team1Incrementor;
        private System.Windows.Forms.NumericUpDown team2Incrementor;
        private System.Windows.Forms.Button confirmPointButton;
        private System.Windows.Forms.Label team2Label;
        private System.Windows.Forms.GroupBox teamPickGroupBox;
        private System.Windows.Forms.RadioButton team2Choice;
        private System.Windows.Forms.RadioButton team1Choice;
    }
}