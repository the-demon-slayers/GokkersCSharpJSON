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
            this.pointUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.teamPickerComboBox = new System.Windows.Forms.ComboBox();
            this.betButton = new System.Windows.Forms.Button();
            this.lossLabel = new System.Windows.Forms.Label();
            this.winsLabel = new System.Windows.Forms.Label();
            this.playerListView = new System.Windows.Forms.ListView();
            this.pointLabel = new System.Windows.Forms.Label();
            this.refreshConnectionButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.changeUserButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.pointUpDown);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.teamPickerComboBox);
            this.groupBox1.Controls.Add(this.betButton);
            this.groupBox1.Controls.Add(this.lossLabel);
            this.groupBox1.Controls.Add(this.winsLabel);
            this.groupBox1.Controls.Add(this.playerListView);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
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
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // teamPickerComboBox
            // 
            this.teamPickerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.teamPickerComboBox, "teamPickerComboBox");
            this.teamPickerComboBox.FormattingEnabled = true;
            this.teamPickerComboBox.Name = "teamPickerComboBox";
            // 
            // betButton
            // 
            resources.ApplyResources(this.betButton, "betButton");
            this.betButton.Name = "betButton";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
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
            // playerListView
            // 
            resources.ApplyResources(this.playerListView, "playerListView");
            this.playerListView.AutoArrange = false;
            this.playerListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerListView.Name = "playerListView";
            this.playerListView.UseCompatibleStateImageBehavior = false;
            this.playerListView.View = System.Windows.Forms.View.List;
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
            ((System.ComponentModel.ISupportInitialize)(this.pointUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.ListView playerListView;
        private System.Windows.Forms.Label lossLabel;
        private System.Windows.Forms.Label winsLabel;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox teamPickerComboBox;
        private System.Windows.Forms.NumericUpDown pointUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button refreshConnectionButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button changeUserButton;
    }
}

