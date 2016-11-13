using System.Windows.Forms;

namespace Fantasy_Football_Draft
{
    partial class MainForm
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
            this.physical_StatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fantasyLeagueTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.draftedTeamsTable = new System.Windows.Forms.DataGridView();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leagueTeamsListLabel = new System.Windows.Forms.Label();
            this.deleteTeamButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.draftedTeamPlayers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.playersTab = new System.Windows.Forms.TabPage();
            this.addToDraftButton = new System.Windows.Forms.Button();
            this.getBreakdownStatsButton = new System.Windows.Forms.Button();
            this.getPhysicalStatsButton = new System.Windows.Forms.Button();
            this.playerTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.draftTeamTab = new System.Windows.Forms.TabPage();
            this.removeDraftPlayerButton = new System.Windows.Forms.Button();
            this.draftTable = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.draftTeamName = new System.Windows.Forms.TextBox();
            this.draftButton = new System.Windows.Forms.Button();
            this.remainingFunds = new System.Windows.Forms.Label();
            this.remainingFundsLabel = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.physical_StatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.fantasyLeagueTab.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.draftedTeamsTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.draftedTeamPlayers)).BeginInit();
            this.playersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerTable)).BeginInit();
            this.draftTeamTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.draftTable)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the draft! Select players, view their details, and add them to your dr" +
    "aft list!";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Player";
            this.dataGridViewTextBoxColumn1.HeaderText = "Player";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // fantasyLeagueTab
            // 
            this.fantasyLeagueTab.Controls.Add(this.panel2);
            this.fantasyLeagueTab.Controls.Add(this.panel1);
            this.fantasyLeagueTab.Location = new System.Drawing.Point(4, 22);
            this.fantasyLeagueTab.Name = "fantasyLeagueTab";
            this.fantasyLeagueTab.Size = new System.Drawing.Size(680, 383);
            this.fantasyLeagueTab.TabIndex = 4;
            this.fantasyLeagueTab.Text = "Fantasy League ";
            this.fantasyLeagueTab.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.draftedTeamsTable);
            this.panel2.Controls.Add(this.leagueTeamsListLabel);
            this.panel2.Controls.Add(this.deleteTeamButton);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 377);
            this.panel2.TabIndex = 2;
            // 
            // draftedTeamsTable
            // 
            this.draftedTeamsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.draftedTeamsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column13});
            this.draftedTeamsTable.Location = new System.Drawing.Point(6, 27);
            this.draftedTeamsTable.MultiSelect = false;
            this.draftedTeamsTable.Name = "draftedTeamsTable";
            this.draftedTeamsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.draftedTeamsTable.Size = new System.Drawing.Size(277, 315);
            this.draftedTeamsTable.TabIndex = 3;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Team Name";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 220;
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
            // deleteTeamButton
            // 
            this.deleteTeamButton.Location = new System.Drawing.Point(158, 348);
            this.deleteTeamButton.Name = "deleteTeamButton";
            this.deleteTeamButton.Size = new System.Drawing.Size(125, 23);
            this.deleteTeamButton.TabIndex = 1;
            this.deleteTeamButton.Text = "Delete Selected Team";
            this.deleteTeamButton.UseVisualStyleBackColor = true;
            this.deleteTeamButton.Click += new System.EventHandler(this.deleteTeamButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.draftedTeamPlayers);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(295, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 377);
            this.panel1.TabIndex = 1;
            // 
            // draftedTeamPlayers
            // 
            this.draftedTeamPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.draftedTeamPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.draftedTeamPlayers.Location = new System.Drawing.Point(6, 27);
            this.draftedTeamPlayers.Name = "draftedTeamPlayers";
            this.draftedTeamPlayers.Size = new System.Drawing.Size(300, 315);
            this.draftedTeamPlayers.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Player Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 240;
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
            // playersTab
            // 
            this.playersTab.Controls.Add(this.addToDraftButton);
            this.playersTab.Controls.Add(this.getBreakdownStatsButton);
            this.playersTab.Controls.Add(this.getPhysicalStatsButton);
            this.playersTab.Controls.Add(this.playerTable);
            this.playersTab.Location = new System.Drawing.Point(4, 22);
            this.playersTab.Name = "playersTab";
            this.playersTab.Padding = new System.Windows.Forms.Padding(3);
            this.playersTab.Size = new System.Drawing.Size(680, 383);
            this.playersTab.TabIndex = 1;
            this.playersTab.Text = "Players";
            this.playersTab.UseVisualStyleBackColor = true;
            // 
            // addToDraftButton
            // 
            this.addToDraftButton.Location = new System.Drawing.Point(516, 354);
            this.addToDraftButton.Name = "addToDraftButton";
            this.addToDraftButton.Size = new System.Drawing.Size(158, 23);
            this.addToDraftButton.TabIndex = 3;
            this.addToDraftButton.Text = "Add Player to Draft List";
            this.addToDraftButton.UseVisualStyleBackColor = true;
            this.addToDraftButton.Click += new System.EventHandler(this.addToDraftButton_Click);
            // 
            // getBreakdownStatsButton
            // 
            this.getBreakdownStatsButton.Location = new System.Drawing.Point(146, 354);
            this.getBreakdownStatsButton.Name = "getBreakdownStatsButton";
            this.getBreakdownStatsButton.Size = new System.Drawing.Size(155, 23);
            this.getBreakdownStatsButton.TabIndex = 2;
            this.getBreakdownStatsButton.Text = "Player\'s Year Performance";
            this.getBreakdownStatsButton.UseVisualStyleBackColor = true;
            this.getBreakdownStatsButton.Click += new System.EventHandler(this.getBreakdownStatsButton_Click);
            // 
            // getPhysicalStatsButton
            // 
            this.getPhysicalStatsButton.Location = new System.Drawing.Point(7, 354);
            this.getPhysicalStatsButton.Name = "getPhysicalStatsButton";
            this.getPhysicalStatsButton.Size = new System.Drawing.Size(133, 23);
            this.getPhysicalStatsButton.TabIndex = 1;
            this.getPhysicalStatsButton.Text = "Player\'s Physical Stats";
            this.getPhysicalStatsButton.UseVisualStyleBackColor = true;
            this.getPhysicalStatsButton.Click += new System.EventHandler(this.getPhysicalStatsButton_Click);
            // 
            // playerTable
            // 
            this.playerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            this.playerTable.Location = new System.Drawing.Point(3, 3);
            this.playerTable.MultiSelect = false;
            this.playerTable.Name = "playerTable";
            this.playerTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.playerTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.playerTable.Size = new System.Drawing.Size(671, 345);
            this.playerTable.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Team";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Position";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Rank";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Draft Cost ($)";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // draftTeamTab
            // 
            this.draftTeamTab.Controls.Add(this.removeDraftPlayerButton);
            this.draftTeamTab.Controls.Add(this.draftTable);
            this.draftTeamTab.Controls.Add(this.teamNameLabel);
            this.draftTeamTab.Controls.Add(this.draftTeamName);
            this.draftTeamTab.Controls.Add(this.draftButton);
            this.draftTeamTab.Controls.Add(this.remainingFunds);
            this.draftTeamTab.Controls.Add(this.remainingFundsLabel);
            this.draftTeamTab.Location = new System.Drawing.Point(4, 22);
            this.draftTeamTab.Name = "draftTeamTab";
            this.draftTeamTab.Padding = new System.Windows.Forms.Padding(3);
            this.draftTeamTab.Size = new System.Drawing.Size(680, 383);
            this.draftTeamTab.TabIndex = 0;
            this.draftTeamTab.Text = "Draft a Team";
            this.draftTeamTab.UseVisualStyleBackColor = true;
            // 
            // removeDraftPlayerButton
            // 
            this.removeDraftPlayerButton.Location = new System.Drawing.Point(6, 353);
            this.removeDraftPlayerButton.Name = "removeDraftPlayerButton";
            this.removeDraftPlayerButton.Size = new System.Drawing.Size(174, 26);
            this.removeDraftPlayerButton.TabIndex = 7;
            this.removeDraftPlayerButton.Text = "Remove Player from Draft List";
            this.removeDraftPlayerButton.UseVisualStyleBackColor = true;
            this.removeDraftPlayerButton.Click += new System.EventHandler(this.removeDraftPlayerButton_Click);
            // 
            // draftTable
            // 
            this.draftTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.draftTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.draftTable.Location = new System.Drawing.Point(6, 23);
            this.draftTable.MultiSelect = false;
            this.draftTable.Name = "draftTable";
            this.draftTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.draftTable.Size = new System.Drawing.Size(668, 328);
            this.draftTable.TabIndex = 6;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Id";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Name";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 120;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Team";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Position";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Rank";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Value";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Location = new System.Drawing.Point(421, 360);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(68, 13);
            this.teamNameLabel.TabIndex = 5;
            this.teamNameLabel.Text = "Team Name:";
            // 
            // draftTeamName
            // 
            this.draftTeamName.Location = new System.Drawing.Point(495, 357);
            this.draftTeamName.Name = "draftTeamName";
            this.draftTeamName.Size = new System.Drawing.Size(98, 20);
            this.draftTeamName.TabIndex = 4;
            this.draftTeamName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // draftButton
            // 
            this.draftButton.Location = new System.Drawing.Point(599, 353);
            this.draftButton.Name = "draftButton";
            this.draftButton.Size = new System.Drawing.Size(75, 28);
            this.draftButton.TabIndex = 3;
            this.draftButton.Text = "Draft Team";
            this.draftButton.UseVisualStyleBackColor = true;
            this.draftButton.Click += new System.EventHandler(this.draftButton_Click);
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.playersTab);
            this.tabControl.Controls.Add(this.draftTeamTab);
            this.tabControl.Controls.Add(this.fantasyLeagueTab);
            this.tabControl.Location = new System.Drawing.Point(12, 36);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(688, 409);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new TabControlEventHandler(tabControl_Selected);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Fantasy Football Draft";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.physical_StatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.fantasyLeagueTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.draftedTeamsTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.draftedTeamPlayers)).EndInit();
            this.playersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerTable)).EndInit();
            this.draftTeamTab.ResumeLayout(false);
            this.draftTeamTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.draftTable)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource playerBindingSource;
        private System.Windows.Forms.BindingSource physical_StatsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn team;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerName;
        private TabPage fantasyLeagueTab;
        private Panel panel2;
        private Label leagueTeamsListLabel;
        private Button deleteTeamButton;
        private Panel panel1;
        private Label label2;
        private TabPage playersTab;
        private Button getBreakdownStatsButton;
        private Button getPhysicalStatsButton;
        private DataGridView playerTable;
        private TabPage draftTeamTab;
        private Label teamNameLabel;
        private TextBox draftTeamName;
        private Button draftButton;
        private Label remainingFunds;
        private Label remainingFundsLabel;
        private TabControl tabControl;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private Button addToDraftButton;
        private DataGridView draftTable;
        private Button removeDraftPlayerButton;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridView draftedTeamsTable;
        private DataGridViewTextBoxColumn Column13;
        private DataGridView draftedTeamPlayers;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

