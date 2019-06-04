namespace GokkersApp
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gameGridView = new System.Windows.Forms.DataGridView();
            this.pointUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.gameVersusLabel = new System.Windows.Forms.Label();
            this.betButton = new System.Windows.Forms.Button();
            this.lossLabel = new System.Windows.Forms.Label();
            this.winsLabel = new System.Windows.Forms.Label();
            this.pointLabel = new System.Windows.Forms.Label();
            this.refreshConnectionButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.changeUserButton = new System.Windows.Forms.Button();
            this.team1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Name = "label3";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pointUpDown);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.gameVersusLabel);
            this.groupBox1.Controls.Add(this.betButton);
            this.groupBox1.Controls.Add(this.lossLabel);
            this.groupBox1.Controls.Add(this.winsLabel);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.gameGridView);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Name = "label6";
            // 
            // gameGridView
            // 
            this.gameGridView.AllowUserToAddRows = false;
            this.gameGridView.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.gameGridView, "gameGridView");
            this.gameGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.team1,
            this.team2});
            this.gameGridView.Name = "gameGridView";
            this.gameGridView.ReadOnly = true;
            this.gameGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gameGridView_CellClick);
         
            // 
            // pointUpDown
            // 
            resources.ApplyResources(this.pointUpDown, "pointUpDown");
            this.pointUpDown.Name = "pointUpDown";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // gameVersusLabel
            // 
            resources.ApplyResources(this.gameVersusLabel, "gameVersusLabel");
            this.gameVersusLabel.Name = "gameVersusLabel";
            // 
            // betButton
            // 
            resources.ApplyResources(this.betButton, "betButton");
            this.betButton.Name = "betButton";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            this.betButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.betButton_KeyDown);
            // 
            // lossLabel
            // 
            resources.ApplyResources(this.lossLabel, "lossLabel");
            this.lossLabel.Name = "lossLabel";
            // 
            // winsLabel
            // 
            resources.ApplyResources(this.winsLabel, "winsLabel");
            this.winsLabel.Name = "winsLabel";
            // 
            // pointLabel
            // 
            resources.ApplyResources(this.pointLabel, "pointLabel");
            this.pointLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pointLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pointLabel.Name = "pointLabel";
            // 
            // refreshConnectionButton
            // 
            resources.ApplyResources(this.refreshConnectionButton, "refreshConnectionButton");
            this.refreshConnectionButton.Name = "refreshConnectionButton";
            this.refreshConnectionButton.UseVisualStyleBackColor = true;
            this.refreshConnectionButton.Click += new System.EventHandler(this.refreshConnectionButton_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            resources.ApplyResources(this.userNameLabel, "userNameLabel");
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userNameLabel.Name = "userNameLabel";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Name = "label7";
            // 
            // changeUserButton
            // 
            resources.ApplyResources(this.changeUserButton, "changeUserButton");
            this.changeUserButton.Name = "changeUserButton";
            this.changeUserButton.UseVisualStyleBackColor = true;
            this.changeUserButton.Click += new System.EventHandler(this.changeUserButton_Click);
            // 
            // team1
            // 
            this.team1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.team1, "team1");
            this.team1.Name = "team1";
            this.team1.ReadOnly = true;
            // 
            // team2
            // 
            this.team2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.team2, "team2");
            this.team2.Name = "team2";
            this.team2.ReadOnly = true;
            // 
            // mainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.changeUserButton);
            this.Controls.Add(this.refreshConnectionButton);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.pointLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Name = "mainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.Label lossLabel;
        private System.Windows.Forms.Label winsLabel;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label gameVersusLabel;
        private System.Windows.Forms.NumericUpDown pointUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button refreshConnectionButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button changeUserButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gameGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn team1;
        private System.Windows.Forms.DataGridViewTextBoxColumn team2;
    }
}

