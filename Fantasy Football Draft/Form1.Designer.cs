namespace Fantasy_Football_Draft
{
    partial class Form1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.draftTeamTab = new System.Windows.Forms.TabPage();
            this.draftButton = new System.Windows.Forms.Button();
            this.draftTeamList = new System.Windows.Forms.ListBox();
            this.remainingFunds = new System.Windows.Forms.Label();
            this.remainingFundsLabel = new System.Windows.Forms.Label();
            this.qbsTab = new System.Windows.Forms.TabPage();
            this.qbSelectionList = new System.Windows.Forms.CheckedListBox();
            this.wrsTab = new System.Windows.Forms.TabPage();
            this.wrSelectionList = new System.Windows.Forms.CheckedListBox();
            this.rbsTab = new System.Windows.Forms.TabPage();
            this.rbSelectionList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fantasyLeagueTab = new System.Windows.Forms.TabPage();
            this.leagueTeamsList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fantasyRosterList = new System.Windows.Forms.ListBox();
            this.deleteTeamButton = new System.Windows.Forms.Button();
            this.leagueTeamsListLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.draftTeamName = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.qbSelectionListLabel = new System.Windows.Forms.Label();
            this.wrSelectionListLabel = new System.Windows.Forms.Label();
            this.rbSelectionListLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.draftTeamTab.SuspendLayout();
            this.qbsTab.SuspendLayout();
            this.wrsTab.SuspendLayout();
            this.rbsTab.SuspendLayout();
            this.fantasyLeagueTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.draftTeamTab);
            this.tabControl.Controls.Add(this.qbsTab);
            this.tabControl.Controls.Add(this.wrsTab);
            this.tabControl.Controls.Add(this.rbsTab);
            this.tabControl.Controls.Add(this.fantasyLeagueTab);
            this.tabControl.Location = new System.Drawing.Point(12, 36);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(615, 409);
            this.tabControl.TabIndex = 0;
            // 
            // draftTeamTab
            // 
            this.draftTeamTab.Controls.Add(this.teamNameLabel);
            this.draftTeamTab.Controls.Add(this.draftTeamName);
            this.draftTeamTab.Controls.Add(this.draftButton);
            this.draftTeamTab.Controls.Add(this.draftTeamList);
            this.draftTeamTab.Controls.Add(this.remainingFunds);
            this.draftTeamTab.Controls.Add(this.remainingFundsLabel);
            this.draftTeamTab.Location = new System.Drawing.Point(4, 22);
            this.draftTeamTab.Name = "draftTeamTab";
            this.draftTeamTab.Padding = new System.Windows.Forms.Padding(3);
            this.draftTeamTab.Size = new System.Drawing.Size(607, 383);
            this.draftTeamTab.TabIndex = 0;
            this.draftTeamTab.Text = "Draft a Team";
            this.draftTeamTab.UseVisualStyleBackColor = true;
            // 
            // draftButton
            // 
            this.draftButton.Location = new System.Drawing.Point(526, 357);
            this.draftButton.Name = "draftButton";
            this.draftButton.Size = new System.Drawing.Size(75, 20);
            this.draftButton.TabIndex = 3;
            this.draftButton.Text = "Draft Team";
            this.draftButton.UseVisualStyleBackColor = true;
            // 
            // draftTeamList
            // 
            this.draftTeamList.FormattingEnabled = true;
            this.draftTeamList.Location = new System.Drawing.Point(3, 22);
            this.draftTeamList.Name = "draftTeamList";
            this.draftTeamList.Size = new System.Drawing.Size(601, 329);
            this.draftTeamList.TabIndex = 2;
            // 
            // remainingFunds
            // 
            this.remainingFunds.AutoSize = true;
            this.remainingFunds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingFunds.Location = new System.Drawing.Point(149, 3);
            this.remainingFunds.Name = "remainingFunds";
            this.remainingFunds.Size = new System.Drawing.Size(70, 16);
            this.remainingFunds.TabIndex = 1;
            this.remainingFunds.Text = "10,000,000";
            // 
            // remainingFundsLabel
            // 
            this.remainingFundsLabel.AutoSize = true;
            this.remainingFundsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingFundsLabel.Location = new System.Drawing.Point(6, 3);
            this.remainingFundsLabel.Name = "remainingFundsLabel";
            this.remainingFundsLabel.Size = new System.Drawing.Size(137, 16);
            this.remainingFundsLabel.TabIndex = 0;
            this.remainingFundsLabel.Text = "Remaining Funds ($): ";
            // 
            // qbsTab
            // 
            this.qbsTab.Controls.Add(this.qbSelectionListLabel);
            this.qbsTab.Controls.Add(this.qbSelectionList);
            this.qbsTab.Location = new System.Drawing.Point(4, 22);
            this.qbsTab.Name = "qbsTab";
            this.qbsTab.Padding = new System.Windows.Forms.Padding(3);
            this.qbsTab.Size = new System.Drawing.Size(607, 383);
            this.qbsTab.TabIndex = 1;
            this.qbsTab.Text = "Quarterbacks";
            this.qbsTab.UseVisualStyleBackColor = true;
            // 
            // qbSelectionList
            // 
            this.qbSelectionList.FormattingEnabled = true;
            this.qbSelectionList.Location = new System.Drawing.Point(3, 31);
            this.qbSelectionList.Name = "qbSelectionList";
            this.qbSelectionList.Size = new System.Drawing.Size(601, 349);
            this.qbSelectionList.TabIndex = 0;
            // 
            // wrsTab
            // 
            this.wrsTab.Controls.Add(this.wrSelectionListLabel);
            this.wrsTab.Controls.Add(this.wrSelectionList);
            this.wrsTab.Location = new System.Drawing.Point(4, 22);
            this.wrsTab.Name = "wrsTab";
            this.wrsTab.Padding = new System.Windows.Forms.Padding(3);
            this.wrsTab.Size = new System.Drawing.Size(607, 383);
            this.wrsTab.TabIndex = 2;
            this.wrsTab.Text = "Wide Receivers";
            this.wrsTab.UseVisualStyleBackColor = true;
            // 
            // wrSelectionList
            // 
            this.wrSelectionList.FormattingEnabled = true;
            this.wrSelectionList.Location = new System.Drawing.Point(3, 31);
            this.wrSelectionList.Name = "wrSelectionList";
            this.wrSelectionList.Size = new System.Drawing.Size(601, 349);
            this.wrSelectionList.TabIndex = 0;
            // 
            // rbsTab
            // 
            this.rbsTab.Controls.Add(this.rbSelectionListLabel);
            this.rbsTab.Controls.Add(this.rbSelectionList);
            this.rbsTab.Location = new System.Drawing.Point(4, 22);
            this.rbsTab.Name = "rbsTab";
            this.rbsTab.Padding = new System.Windows.Forms.Padding(3);
            this.rbsTab.Size = new System.Drawing.Size(607, 383);
            this.rbsTab.TabIndex = 3;
            this.rbsTab.Text = "Running Backs";
            this.rbsTab.UseVisualStyleBackColor = true;
            // 
            // rbSelectionList
            // 
            this.rbSelectionList.FormattingEnabled = true;
            this.rbSelectionList.Location = new System.Drawing.Point(3, 31);
            this.rbSelectionList.Name = "rbSelectionList";
            this.rbSelectionList.Size = new System.Drawing.Size(601, 349);
            this.rbSelectionList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the draft! Build your team using the tabs for each position.";
            // 
            // fantasyLeagueTab
            // 
            this.fantasyLeagueTab.Controls.Add(this.panel2);
            this.fantasyLeagueTab.Controls.Add(this.panel1);
            this.fantasyLeagueTab.Location = new System.Drawing.Point(4, 22);
            this.fantasyLeagueTab.Name = "fantasyLeagueTab";
            this.fantasyLeagueTab.Size = new System.Drawing.Size(607, 383);
            this.fantasyLeagueTab.TabIndex = 4;
            this.fantasyLeagueTab.Text = "Fantasy League ";
            this.fantasyLeagueTab.UseVisualStyleBackColor = true;
            // 
            // leagueTeamsList
            // 
            this.leagueTeamsList.FormattingEnabled = true;
            this.leagueTeamsList.Location = new System.Drawing.Point(0, 26);
            this.leagueTeamsList.Name = "leagueTeamsList";
            this.leagueTeamsList.Size = new System.Drawing.Size(283, 316);
            this.leagueTeamsList.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fantasyRosterList);
            this.panel1.Location = new System.Drawing.Point(295, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 377);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.leagueTeamsListLabel);
            this.panel2.Controls.Add(this.deleteTeamButton);
            this.panel2.Controls.Add(this.leagueTeamsList);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 377);
            this.panel2.TabIndex = 2;
            // 
            // fantasyRosterList
            // 
            this.fantasyRosterList.FormattingEnabled = true;
            this.fantasyRosterList.Location = new System.Drawing.Point(3, 26);
            this.fantasyRosterList.Name = "fantasyRosterList";
            this.fantasyRosterList.Size = new System.Drawing.Size(303, 316);
            this.fantasyRosterList.TabIndex = 0;
            // 
            // deleteTeamButton
            // 
            this.deleteTeamButton.Location = new System.Drawing.Point(158, 348);
            this.deleteTeamButton.Name = "deleteTeamButton";
            this.deleteTeamButton.Size = new System.Drawing.Size(125, 23);
            this.deleteTeamButton.TabIndex = 1;
            this.deleteTeamButton.Text = "Delete Selected Team";
            this.deleteTeamButton.UseVisualStyleBackColor = true;
            // 
            // leagueTeamsListLabel
            // 
            this.leagueTeamsListLabel.AutoSize = true;
            this.leagueTeamsListLabel.Location = new System.Drawing.Point(3, 10);
            this.leagueTeamsListLabel.Name = "leagueTeamsListLabel";
            this.leagueTeamsListLabel.Size = new System.Drawing.Size(92, 13);
            this.leagueTeamsListLabel.TabIndex = 2;
            this.leagueTeamsListLabel.Text = "Teams in League:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selected Team Roster:";
            // 
            // draftTeamName
            // 
            this.draftTeamName.Location = new System.Drawing.Point(422, 357);
            this.draftTeamName.Name = "draftTeamName";
            this.draftTeamName.Size = new System.Drawing.Size(98, 20);
            this.draftTeamName.TabIndex = 4;
            this.draftTeamName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Location = new System.Drawing.Point(348, 360);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(68, 13);
            this.teamNameLabel.TabIndex = 5;
            this.teamNameLabel.Text = "Team Name:";
            // 
            // qbSelectionListLabel
            // 
            this.qbSelectionListLabel.AutoSize = true;
            this.qbSelectionListLabel.Location = new System.Drawing.Point(6, 15);
            this.qbSelectionListLabel.Name = "qbSelectionListLabel";
            this.qbSelectionListLabel.Size = new System.Drawing.Size(156, 13);
            this.qbSelectionListLabel.TabIndex = 1;
            this.qbSelectionListLabel.Text = "Select Quarterbacks(s) to Draft:";
            // 
            // wrSelectionListLabel
            // 
            this.wrSelectionListLabel.AutoSize = true;
            this.wrSelectionListLabel.Location = new System.Drawing.Point(6, 15);
            this.wrSelectionListLabel.Name = "wrSelectionListLabel";
            this.wrSelectionListLabel.Size = new System.Drawing.Size(163, 13);
            this.wrSelectionListLabel.TabIndex = 1;
            this.wrSelectionListLabel.Text = "Select Wide Receiver(s) to Draft:";
            // 
            // rbSelectionListLabel
            // 
            this.rbSelectionListLabel.AutoSize = true;
            this.rbSelectionListLabel.Location = new System.Drawing.Point(6, 15);
            this.rbSelectionListLabel.Name = "rbSelectionListLabel";
            this.rbSelectionListLabel.Size = new System.Drawing.Size(160, 13);
            this.rbSelectionListLabel.TabIndex = 1;
            this.rbSelectionListLabel.Text = "Select Running Back(s) to Draft:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Fantasy Football Draft";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.draftTeamTab.ResumeLayout(false);
            this.draftTeamTab.PerformLayout();
            this.qbsTab.ResumeLayout(false);
            this.qbsTab.PerformLayout();
            this.wrsTab.ResumeLayout(false);
            this.wrsTab.PerformLayout();
            this.rbsTab.ResumeLayout(false);
            this.rbsTab.PerformLayout();
            this.fantasyLeagueTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage draftTeamTab;
        private System.Windows.Forms.TabPage qbsTab;
        private System.Windows.Forms.TabPage wrsTab;
        private System.Windows.Forms.TabPage rbsTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button draftButton;
        private System.Windows.Forms.ListBox draftTeamList;
        private System.Windows.Forms.Label remainingFunds;
        private System.Windows.Forms.Label remainingFundsLabel;
        private System.Windows.Forms.CheckedListBox qbSelectionList;
        private System.Windows.Forms.CheckedListBox wrSelectionList;
        private System.Windows.Forms.CheckedListBox rbSelectionList;
        private System.Windows.Forms.TabPage fantasyLeagueTab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox leagueTeamsList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox fantasyRosterList;
        private System.Windows.Forms.Label leagueTeamsListLabel;
        private System.Windows.Forms.Button deleteTeamButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox draftTeamName;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label qbSelectionListLabel;
        private System.Windows.Forms.Label wrSelectionListLabel;
        private System.Windows.Forms.Label rbSelectionListLabel;
    }
}

