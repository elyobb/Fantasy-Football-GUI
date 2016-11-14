using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fantasy_Football_Draft
{
    public partial class MainForm : Form
    {
        private String connStr;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // open connection for all sql calls while app is active
            this.connStr = @"data source = '..\..\..\FantasyFootballDb'";
            SQLiteConnection conn = new SQLiteConnection(connStr);
            conn.Open();
            populatePlayerTable(conn);
            populateLeagueTeams(conn);
            this.draftedTeamsTable.SelectionChanged += new System.EventHandler(this.draftedTeamTable_SelectionChanged);
            conn.Close();

        }

        private void draftedTeamTable_SelectionChanged(object sender, EventArgs e)
        {
            //first clear out old data
            draftedTeamPlayers.Rows.Clear();
            if(draftedTeamsTable.Focused){
                DataGridViewRow selectedRow = this.draftedTeamsTable.SelectedRows[0];
                if(selectedRow.Cells[0].Value != null)
                {
                    String teamName = selectedRow.Cells[0].Value.ToString();
                    SQLiteConnection conn = new SQLiteConnection(connStr);
                    conn.Open();
                    populateDraftedTeamPlayers(conn, teamName);
                    conn.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void qbSelectionList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void playerBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void playerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name == "fantasyLeagueTab")
            {
                SQLiteConnection conn = new SQLiteConnection(connStr);
                conn.Open();
                populateLeagueTeams(conn);
                conn.Close();
            }
        }

        /* calls a select from the database for all player data, populates it into the playerTable 
        in the GUI */
        private void populatePlayerTable(SQLiteConnection conn)
        {
            SQLiteCommand comm = new SQLiteCommand("Select * From Player", conn);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    // parse value into lots of money
                    int rawValue = (int)read.GetValue(3);
                    int newValue = rawValue * 10000;
                    String stringNewValue = newValue.ToString("N0");

                    playerTable.Rows.Add(new object[] {
                        read.GetValue(0),
                        read.GetValue(2),
                        read.GetValue(4),
                        read.GetValue(5),
                        read.GetValue(1),
                        stringNewValue
                    });
                }
            }
        }

        private void populateLeagueTeams(SQLiteConnection conn)
        {
            // first clear table
            draftedTeamsTable.Rows.Clear();

            SQLiteCommand comm = new SQLiteCommand("Select * From DraftedTeams", conn);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    // will just return team names as value
                    draftedTeamsTable.Rows.Add(new object[] {
                        read.GetValue(0)
                    });
                }
            }

            draftedTeamsTable.Rows[0].Selected = true;
            if(draftedTeamsTable.Rows[0].Cells[0].Value != null)
            {
                String selectedTeam = draftedTeamsTable.Rows[0].Cells[0].Value.ToString();
                populateDraftedTeamPlayers(conn, selectedTeam);
            }
        }

        private void populateDraftedTeamPlayers(SQLiteConnection conn, String teamName)
        {
            // now find all players with this team name, and add them to the roster panel
            String sql = @"select p.Name from Player as p where p.Id in (select PlayerId from DraftedPlayers where TeamName ='" + teamName + "');";
            SQLiteCommand comm = new SQLiteCommand(sql, conn);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    // will just return player names on the selected drafted team
                    draftedTeamPlayers.Rows.Add(new object[] {
                        read.GetValue(0)
                    });
                }
            }
        }

        private void getPhysicalStatsButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = playerTable.SelectedRows[0];
            String playerId = selectedRow.Cells[0].Value.ToString();
            // creates a popup for the selected player which shows their physical stats
            PhysicalStatsForm popup = new PhysicalStatsForm(playerId);
            popup.Show();
        }
        
        private void getBreakdownStatsButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = playerTable.SelectedRows[0];
            String playerId = selectedRow.Cells[0].Value.ToString();
            String playerPos = selectedRow.Cells[3].Value.ToString();

            // quarterbacks have different breakdown stats form
            if(playerPos == "QB")
            {
                QbBreakdownStatsForm popup = new QbBreakdownStatsForm(playerId);
                popup.Show();
            }
            else
            {
                BreakdownStatsForm popup = new BreakdownStatsForm(playerId);
                popup.Show();
            }
        }

        private void addToDraftButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = playerTable.SelectedRows[0];
            String playerId = selectedRow.Cells[0].Value.ToString();
            String playerName = selectedRow.Cells[1].Value.ToString();
            String team = selectedRow.Cells[2].Value.ToString();
            String position = selectedRow.Cells[3].Value.ToString();
            String rank = selectedRow.Cells[4].Value.ToString();
            String value = selectedRow.Cells[5].Value.ToString();
            int intValue = Int32.Parse(value, NumberStyles.AllowThousands);
            // adds the selected player to the draft tab list if it doesnt exist
            bool exists = false;
            foreach (DataGridViewRow row in draftTable.Rows)
            {

                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().Equals(playerId))
                {
                    exists = true;
                }             
            }
            if (!exists)
            {
                draftTable.Rows.Add(new object[] {
                            playerId,
                            playerName,
                            team,
                            position,
                            rank,
                            value
                        });
                int remFunds;
                try
                {
                    remFunds = Int32.Parse(remainingFunds.Text, NumberStyles.AllowThousands);
                }
                catch (System.FormatException)
                {
                    // happens when funds go below 0
                    String strFunds = remainingFunds.Text.Replace(",", "");
                    remFunds = Int32.Parse(strFunds, NumberStyles.AllowLeadingSign);
                }

                remFunds -= intValue;
                remainingFunds.Text = remFunds.ToString("N0");

            }
            else
            {
                MessageBox.Show("Player already in draft list!");
            }
        }

        private void removeDraftPlayerButton_Click(object sender, EventArgs e)
        {

            if(draftTable.Rows.Count > 1)
            {
                DataGridViewRow selectedRow = draftTable.SelectedRows[0];
                String value = selectedRow.Cells[5].Value.ToString();
                int intValue = Int32.Parse(value, NumberStyles.AllowThousands);
                int remFunds;
                try
                {
                    remFunds = Int32.Parse(remainingFunds.Text, NumberStyles.AllowThousands);
                }
                catch (System.FormatException)
                {
                    // happens when funds go below 0
                    String strFunds = remainingFunds.Text.Replace(",", "");
                    remFunds = Int32.Parse(strFunds, NumberStyles.AllowLeadingSign);
                }
                remFunds += intValue;
                remainingFunds.Text = remFunds.ToString("N0");
                draftTable.Rows.Remove(selectedRow);
            }

        }

        private void draftButton_Click(object sender, EventArgs e)
        {
            String teamName = draftTeamName.Text;
            int remFunds;
            try
            {
                remFunds = Int32.Parse(remainingFunds.Text, NumberStyles.AllowThousands);
            }
            catch (System.FormatException)
            {
                // happens when funds go below 0
                String strFunds = remainingFunds.Text.Replace(",", "");
                remFunds = Int32.Parse(strFunds, NumberStyles.AllowLeadingSign);
            }
            if (teamName == null || teamName == "")
            {
                MessageBox.Show("Please enter a team name to draft this team.");
                return;
            }

            if (remFunds >= 0)
            {
                bool rowsAdded = false;
                SQLiteConnection conn = new SQLiteConnection(connStr);
                conn.Open();
                String insertTeamSql = "Insert into DraftedTeams(TeamName) values ('" + teamName + "');";
                SQLiteCommand comm = new SQLiteCommand(insertTeamSql, conn);
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch(SQLiteException)
                {
                    MessageBox.Show("Team " + teamName + " already exists. Try again!");
                    return;
                }
                // the team name was unique and valid, so go ahead and add each player to the drafted player table
                foreach (DataGridViewRow row in draftTable.Rows)
                {
                   
                    if(row.Cells[0].Value != null)
                    {
                        String id = row.Cells[0].Value.ToString();
                        // dynamically created sql based on which players are in 'To draft' table
                        String insertDraftedPlayerSql = @"Insert into DraftedPlayers(PlayerId, TeamName) Values (" + id
                            + ", '" + teamName + "');";

                        comm = new SQLiteCommand(insertDraftedPlayerSql, conn);
                        comm.ExecuteNonQuery();
                        rowsAdded = true;
                    }
                }
                if (rowsAdded)
                {
                    MessageBox.Show("Team " + teamName + " successfully drafted!");
                    // clear out the data because the players were drafted
                    draftTable.Rows.Clear();
                    draftTeamName.Text = "";
                }
            }
            else
            {
                MessageBox.Show("You don't have enough money to draft this team. Try removing some players.");
                return;
            }
        }

        private void deleteTeamButton_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(connStr);
            conn.Open();

            DataGridViewRow selectedRow = draftedTeamsTable.SelectedRows[0];
            String teamName = selectedRow.Cells[0].Value.ToString();
            String deleteSql = "Delete from DraftedPlayers where TeamName ='" + teamName + "';";
            SQLiteCommand comm = new SQLiteCommand(deleteSql, conn);
            comm.ExecuteNonQuery();
            deleteSql = "Delete from DraftedTeams where TeamName = '" + teamName + "'; ";
            comm = new SQLiteCommand(deleteSql, conn);
            comm.ExecuteNonQuery();          
            conn.Close();

            draftedTeamsTable.Rows.Remove(selectedRow);
        }
    }
}
