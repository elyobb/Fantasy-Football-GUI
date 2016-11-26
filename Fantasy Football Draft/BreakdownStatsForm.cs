using Fantasy_Football_Draft.SQL_Queries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fantasy_Football_Draft
{
    public partial class BreakdownStatsForm : Form
    {
        public BreakdownStatsForm(string playerId)
        {
            InitializeComponent();
            populateBreakdownStats(playerId);
        }
        private void populateBreakdownStats(string playerId)
        {
            var queries = new SqlQueries();
            var breakdown = queries.GetBreakdownStat(playerId);

            this.playerName.Text = breakdown.playerName;
            // current year
            this.playerRushingYds.Text = breakdown.playerRushingYds;
            this.playerRushingTDs.Text = breakdown.playerRushingTDs;
            this.playerReceptions.Text = breakdown.playerReceptions;
            this.playerRecYds.Text = breakdown.playerRecYds;
            this.playerRecTDs.Text = breakdown.playerRecTDs;
            this.playerFumbles.Text = breakdown.playerFumbles;
            // last year
            this.playerRushingYdsLy.Text = breakdown.playerRushingYdsLy;
            this.playerRushingTDsLy.Text = breakdown.playerRushingTDsLy;
            this.playerReceptionsLy.Text = breakdown.playerReceptionsLy;
            this.playerReceptionYdsLy.Text = breakdown.playerRecYdsLy;
            this.playerReceptionTDsLy.Text = breakdown.playerRecTDsLy;
            this.playerFumblesLy.Text = breakdown.playerFumblesLy;
            // next year
            this.playerRushingYdsNy.Text = breakdown.playerRushingYdsNy;
            this.playerRushingTDsNy.Text = breakdown.playerRushingTDsNy;
            this.playerReceptionsNy.Text = breakdown.playerReceptionsNy;
            this.playerReceptionYdsNy.Text = breakdown.playerRecYdsNy;
            this.playerReceptionTDsNy.Text = breakdown.playerRecTDsNy;
            this.playerFumblesNy.Text = breakdown.playerFumblesNy;
        }
    }
}
