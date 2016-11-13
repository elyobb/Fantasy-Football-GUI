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
            this.connStr = @"data source = 'C:\Users\Brennan\Documents\Visual Studio 2015\Projects\Fantasy Football Draft\FantasyFootballDb'";
            SQLiteConnection conn = new SQLiteConnection(connStr);
            conn.Open();
            populatePlayerTable(conn);
            conn.Close();

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
            Boolean exists = false;
            foreach (DataGridViewRow row in draftTable.Rows)
            {

                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().Equals(playerName))
                {
                    exists = true;
                }
                
  

            }
            if (!exists)
            {
                draftTable.Rows.Add(new object[] {
                            playerName,
                            team,
                            position,
                            rank,
                            value
                        });
                int remFunds = int.Parse(remainingFunds.Text, NumberStyles.AllowThousands);
                remFunds -= intValue;
                remainingFunds.Text = remFunds.ToString("N0");
                //decrement funds remaining
            }
        }

        private void removeDraftPlayerButton_Click(object sender, EventArgs e)
        {

            if(draftTable.Rows.Count > 1)
            {
                DataGridViewRow selectedRow = draftTable.SelectedRows[0];
                String value = selectedRow.Cells[4].Value.ToString();
                int intValue = Int32.Parse(value, NumberStyles.AllowThousands);
                int remFunds = int.Parse(remainingFunds.Text, NumberStyles.AllowThousands);
                remFunds += intValue;
                remainingFunds.Text = remFunds.ToString("N0");
                draftTable.Rows.Remove(selectedRow);
            }

        }
    }
}
