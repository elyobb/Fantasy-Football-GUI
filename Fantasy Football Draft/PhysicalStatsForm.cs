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
    public partial class PhysicalStatsForm : Form
    {
        private String connStr;
        public PhysicalStatsForm(String playerId)
        {
            this.connStr = @"data source = '..\..\..\FantasyFootballDb'";
            InitializeComponent();
            // fill out the physical stats data
            populatePlayerStats(playerId);
        }

        private void populatePlayerStats(String playerId)
        {
            SQLiteConnection conn = new SQLiteConnection(connStr);
            conn.Open();
            SQLiteCommand comm = new SQLiteCommand("Select p.Name, s.Height, s.Weight, s.BloodType, s.EyeColor From PhysicalStats as s, Player as p where s.PlayerId = p.Id and s.PlayerId =" + playerId, conn);
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    this.playerName.Text = read.GetValue(0).ToString();
                    this.playerHeight.Text = read.GetValue(1).ToString();
                    this.playerWeight.Text = read.GetValue(2).ToString();
                    this.playerBloodType.Text = read.GetValue(3).ToString();
                    this.playerEyeColor.Text = read.GetValue(4).ToString();
                }
            }
            conn.Close();
        }

    }
}
