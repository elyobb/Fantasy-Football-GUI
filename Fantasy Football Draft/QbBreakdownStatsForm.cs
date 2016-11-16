using Fantasy_Football_Draft.SQL_Queries;
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
        public QbBreakdownStatsForm(string playerId)
        {
            InitializeComponent();
            populateQbBreakdownStats(playerId);
        }

        private void populateQbBreakdownStats(string playerId)
        {
            var query = new SqlQueries();
            var player = query.GetPlayerInfo(playerId);

            this.playerName.Text = player.playerName;
            this.playerPassYds.Text = player.playerPassYds;
            this.playerPassTDs.Text = player.playerPassTDs;
            this.playerInts.Text = player.playerInts;
            this.playerRushingTds.Text = player.playerRushingTds;
            this.playerRushingYds.Text = player.playerRushingYds;
            this.playerCarries.Text = player.playerCarries;
            this.playerFumbles.Text = player.playerFumbles;
            this.playerPts.Text = player.playerPts;

        }
    }
}
