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
    public partial class PhysicalStatsForm : Form
    {
        public PhysicalStatsForm(String playerId)
        {
            InitializeComponent();
            populatePlayerStats(playerId);
        }

        private void populatePlayerStats(String playerId)
        {
            var queries = new SqlQueries();
            var stat = queries.GetPhysicalStat(playerId);

            this.playerName.Text = stat.playerName;
            this.playerHeight.Text = stat.playerHeight;
            this.playerWeight.Text = stat.playerWeight;
            this.playerBloodType.Text = stat.playerBloodType;
            this.playerEyeColor.Text = stat.playerEyeColor;
        }
    }
}
