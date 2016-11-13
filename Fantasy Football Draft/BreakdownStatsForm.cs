using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fantasy_Football_Draft
{
    public partial class BreakdownStatsForm : Form
    {
        private String connStr;
        public BreakdownStatsForm(String playerId)
        {
            this.connStr = @"data source = 'C:\Users\Brennan\Documents\Visual Studio 2015\Projects\Fantasy Football Draft\FantasyFootballDb'";
            InitializeComponent();
            populateBreakdownStats(playerId);
        }
        private void populateBreakdownStats(String playerId)
        {
            SQLiteConnection conn = new SQLiteConnection(connStr);
            conn.Open();

            String sqlText = @"Select p.Name, b.Carries, b.RushYds, b.RushTDs, b.Rec, b.RecYds, b.RecTDs, b.Fum, b.Pts
                from Player as p, BreakDownStats as b where b.PlayerId = p.Id and b.PlayerId =" + playerId;
            SQLiteCommand comm = new SQLiteCommand(sqlText, conn);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    this.playerName.Text = read.GetValue(0).ToString();
                    this.playerRushingYds.Text = read.GetValue(1).ToString();
                    this.playerRushingTDs.Text = read.GetValue(2).ToString();
                    this.playerReceptions.Text = read.GetValue(3).ToString();
                    this.playerRecYds.Text = read.GetValue(4).ToString();
                    this.playerRecTDs.Text = read.GetValue(5).ToString();
                    this.playerFumbles.Text = read.GetValue(6).ToString();
                    this.playerPts.Text = read.GetValue(7).ToString();
                }
            }   
            conn.Close();
        }
    }
}
