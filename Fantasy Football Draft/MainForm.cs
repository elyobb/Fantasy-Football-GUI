using Fantasy_Football_Draft.SQL_Queries;
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
        private Connection connection = new Connection();
        private SQLiteConnection conn;
        private SqlQueries queries;

        public MainForm()
        {
            InitializeComponent();
            queries = new SqlQueries();
            conn = connection.GetConnection();
        }

        /**
         * Main app form load event
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            // open connection for all sql calls while app is active

            conn.Open();
            populatePlayerTable();
            populateLeagueTeams();
            this.draftedTeamsTable.SelectionChanged += new System.EventHandler(this.draftedTeamTable_SelectionChanged);
            conn.Close();
        }

        /**
         * Selects the players on the currently selected drafted team when the selected team changes.
         */
        private void draftedTeamTable_SelectionChanged(object sender, EventArgs e)
        {
            //first clear out old data
            draftedTeamPlayers.Rows.Clear();
            if(draftedTeamsTable.Focused){
                DataGridViewRow selectedRow = this.draftedTeamsTable.SelectedRows[0];
                if(selectedRow.Cells[0].Value != null)
                {
                    var teamName = selectedRow.Cells[0].Value.ToString();
                    conn.Open();
                    populateDraftedTeamPlayers(teamName);
                    conn.Close();
                }
            }
        }

        /**
         * Refreshes the list of drafted teams when the tab is selected, in case a team has been deleted
         */
        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name == "fantasyLeagueTab")
            {
                conn.Open();
                populateLeagueTeams();
                conn.Close();
            }
        }

        /* calls a select from the database for all player data, populates it into the playerTable 
        in the GUI */
        private void populatePlayerTable()
        {
            var comm = connection.GetCommand("Select * From Player");
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    // parse value into lots of money
                    int rawValue = (int)read.GetValue(3);
                    int newValue = rawValue * 10000;
                    string stringNewValue = newValue.ToString("N0");

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

        /**
         * Poulates all drafted teams from the DraftedTeams table, then all the players on that team
         * from the DraftedPlayers table.
         */
        private void populateLeagueTeams()
        {
            // first clear table
            draftedTeamsTable.Rows.Clear();

            var comm = connection.GetCommand("Select * From DraftedTeams");
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
                string selectedTeam = draftedTeamsTable.Rows[0].Cells[0].Value.ToString();
                populateDraftedTeamPlayers(selectedTeam);
            }
        }

        /**
         * Populates from the DraftedPlayers table all players for the selected team name in the Drafted Teams list
         */
        private void populateDraftedTeamPlayers(string teamName)
        {
            // now find all players with this team name, and add them to the roster panel
            var query = @"select p.Name from Player as p where p.Id in (select PlayerId from DraftedPlayers where TeamName ='" + teamName + "');";
            var comm = connection.GetCommand(query);
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

        /**
         * Displays a popup for the selected player showing their physical stats including blood type and eye color
         */
        private void getPhysicalStatsButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = playerTable.SelectedRows[0];
            string playerId = selectedRow.Cells[0].Value.ToString();
            // creates a popup for the selected player which shows their physical stats
            PhysicalStatsForm popup = new PhysicalStatsForm(playerId);
            popup.Show();
        }
        
        /**
         * Displays a popup for the selected player showing their play performance stats
         */ 
        private void getBreakdownStatsButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = playerTable.SelectedRows[0];
            var playerId = selectedRow.Cells[0].Value.ToString();
            var playerPos = selectedRow.Cells[3].Value.ToString();

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

        /**
         * Adds the selected player to the draft list if it doesn't already exist there.
         * The cost of the player is debited from the remaining funds to draft with. 
         */
        private void addToDraftButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = playerTable.SelectedRows[0];
            string playerId = selectedRow.Cells[0].Value.ToString();
            string playerName = selectedRow.Cells[1].Value.ToString();
            string team = selectedRow.Cells[2].Value.ToString();
            string position = selectedRow.Cells[3].Value.ToString();
            string rank = selectedRow.Cells[4].Value.ToString();
            string value = selectedRow.Cells[5].Value.ToString();
            int intValue = Int32.Parse(value, NumberStyles.AllowThousands);
            // adds the selected player to the draft tab list if it doesnt exist
            bool exists = false;
            foreach (DataGridViewRow row in draftTable.Rows)
            {
                // the table will have an empty row even if it has no data, so we check for that to be null 
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
                    // if funds have updated to be below 0, an exception is thrown because we haven't set the flag for allowing negatives
                    String strFunds = remainingFunds.Text.Replace(",", "");
                    // tell number parser to parse negatives
                    remFunds = Int32.Parse(strFunds, NumberStyles.AllowLeadingSign);
                }
                remFunds -= intValue;
                // argument "N0" on toString adds back in the ',' thousands separators  
                remainingFunds.Text = remFunds.ToString("N0");
            }
            else
            {
                // user can't draft 85 Ocho Cincos
                MessageBox.Show("Player already in draft list!");
            }
        }

        /**
         * Removes a player from the list to draft. Whatever their draft value was
         * is deposited back into the remaining funds.
         */
        private void removeDraftPlayerButton_Click(object sender, EventArgs e)
        {
            // the default number of rows in a datagridview (gui table) is 1 empty row.
            // this can probably be changed as a property
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

        /**
         * Adds the current working list in the "to draft" list to a new drafted team, with the name of 
         * whatever the user entered as the team name. Each player in the list is added to DraftedPlayers 
         * with a reference to the team name (which is added to the separate DraftedTeams table).
         * 
         * A team is not drafted if the user hasn't the funds, hasn't entered a team name or has entered
         * a team name which already exists.     
         */
        private void draftButton_Click(object sender, EventArgs e)
        {
            var teamName = draftTeamName.Text;
            int remFunds;
            try
            {
                // allowThousands flag parses numbers with ',' separating thousands
                remFunds = Int32.Parse(remainingFunds.Text, NumberStyles.AllowThousands);
            }
            catch (System.FormatException)
            {
                // if funds have updated to be below 0, an exception is thrown because we haven't set the flag for allowing negatives
                var strFunds = remainingFunds.Text.Replace(",", "");
                // tell the number parser to parse negatives 
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
                var insertTeamSql = @"Insert into DraftedTeams(TeamName) values ('" + teamName + "');";

                try
                {
                    queries.ExecuteQuery(insertTeamSql);
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
                        var id = row.Cells[0].Value.ToString();
                        // dynamically created sql based on which players are in 'To draft' table
                        var insertDraftedPlayerSql = @"Insert into DraftedPlayers(PlayerId, TeamName) Values (" + id
                            + ", '" + teamName + "');";

                        queries.ExecuteQuery(insertDraftedPlayerSql);
                        rowsAdded = true;
                    }
                }
                if (rowsAdded)
                {
                    MessageBox.Show("Team '" + teamName + "' successfully drafted!");
                    // clear out the data because the players were drafted
                    draftTable.Rows.Clear();
                    draftTeamName.Text = "";
                }
            }
            else
            {
                // what happens when your money is less than 0
                MessageBox.Show("You don't have enough money to draft this team. Try removing some players.");
                return;
            }
        }

        /**
         * Deletes a team from the database.
         * Starts by deleting the individual players referencing the team in DraftedPlayers, then the team itself
         * in DraftedTeams.
         * 
         * Finally, deletes the entry in the GUI table
         */
        private void deleteTeamButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = draftedTeamsTable.SelectedRows[0];
            var teamName = selectedRow.Cells[0].Value.ToString();
            var deleteDraftedPlayers = "Delete from DraftedPlayers where TeamName ='" + teamName + "';";
            var deleteDraftedTeams = "Delete from DraftedTeams where TeamName = '" + teamName + "'; ";
            queries.ExecuteQuery(deleteDraftedPlayers);
            queries.ExecuteQuery(deleteDraftedTeams);
            draftedTeamsTable.Rows.Remove(selectedRow);
        }
    }
}
