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
    public partial class QbBreakdownStatsForm : Form
    {
        private String connStr;
        public QbBreakdownStatsForm(String playerId)
        {
            this.connStr = @"data source = '..\..\..\FantasyFootballDb'";
            InitializeComponent();
            populateQbBreakdownStats(playerId);
        }

        private void populateQbBreakdownStats(String playerId)
        {
            SQLiteConnection conn = new SQLiteConnection(connStr);
            conn.Open();

            String sqlText = @"Select p.Name, b.PassYds, b.PassTDs, b.PassInt, b.RushTDs, b.RushYds, b.Carries, b.Fum, b.Pts from 
                Player as p, QbBreakdownStats as b where b.PlayerId = p.Id and b.PlayerId =" + playerId;

            SQLiteCommand comm = new SQLiteCommand(sqlText, conn);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    this.playerName.Text = read.GetValue(0).ToString();
                    this.playerPassYds.Text = read.GetValue(1).ToString();
                    this.playerPassTDs.Text = read.GetValue(2).ToString();
                    this.playerInts.Text = read.GetValue(3).ToString();
                    this.playerRushingTds.Text = read.GetValue(4).ToString();
                    this.playerRushingYds.Text = read.GetValue(5).ToString();
                    this.playerCarries.Text = read.GetValue(6).ToString();
                    this.playerFumbles.Text = read.GetValue(7).ToString();
                    this.playerPts.Text = read.GetValue(8).ToString();
                }
            }

            conn.Close();

        }
    }
}
