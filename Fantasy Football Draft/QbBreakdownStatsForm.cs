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
            var player = query.GetQbBreakdownStat(playerId);

            this.playerName.Text = player.playerName;
            // current yr
            this.playerPassingYds.Text = player.playerPassingYds;
            this.playerPassingTDs.Text = player.playerPassingTDs;
            this.playerInts.Text = player.playerInts;
            this.playerRushingTds.Text = player.playerRushingTds;
            this.playerRushingYds.Text = player.playerRushingYds;
            this.playerFumbles.Text = player.playerFumbles;
            // last yr
            this.playerPassingYdsLy.Text = player.playerPassingYdsLy;
            this.playerPassingTDsLy.Text = player.playerPassingTDsLy;
            this.playerIntsLy.Text = player.playerIntsLy;
            this.playerRushingTdsLy.Text = player.playerRushingTdsLy;
            this.playerRushingYdsLy.Text = player.playerRushingYdsLy;
            this.playerFumblesLy.Text = player.playerFumblesLy;
            // next yr
            this.playerPassingYdsNy.Text = player.playerPassingYdsNy;
            this.playerPassingTDsNy.Text = player.playerPassingTDsNy;
            this.playerIntsNy.Text = player.playerIntsNy;
            this.playerRushingTdsNy.Text = player.playerRushingTdsNy;
            this.playerRushingYdsNy.Text = player.playerRushingYdsNy;
            this.playerFumblesNy.Text = player.playerFumblesNy;
        }
    }
}
