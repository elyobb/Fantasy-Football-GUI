using Fantasy_Football_Draft.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Football_Draft.SQL_Queries
{
    public class SqlQueries
    {
        Connection conn = new Connection();

        public void ExecuteQuery(string query)
        {
            conn.GetConnection().Open();
            var command = conn.GetCommand(query);
            command.ExecuteNonQuery();
            conn.GetConnection().Close();
        }

        public BreakdownStatModel GetBreakdownStat(string playerId)
        {
            conn.GetConnection().Open();

            var query = @"Select p.Name, b.Carries, b.RushYds, b.RushTDs, b.Rec, b.RecYds, b.RecTDs, b.Fum, b.Pts
                from Player as p, BreakDownStats as b where b.PlayerId = p.Id and b.PlayerId =" + playerId;

            var command = conn.GetCommand(query);
            var stat = new BreakdownStatModel();

            using (SQLiteDataReader read = command.ExecuteReader())
            {
                while (read.Read())
                {
                    stat.playerName = read.GetValue(0).ToString();
                    stat.playerRushingYds = read.GetValue(1).ToString();
                    stat.playerRushingTDs = read.GetValue(2).ToString();
                    stat.playerReceptions = read.GetValue(3).ToString();
                    stat.playerRecYds = read.GetValue(4).ToString();
                    stat.playerRecTDs = read.GetValue(5).ToString();
                    stat.playerFumbles = read.GetValue(6).ToString();
                    stat.playerPts = read.GetValue(7).ToString();
                }
            }
            conn.GetConnection().Close();

            return stat;
        }

        public PhysicalStatModel GetPhysicalStat(string playerId)
        {
            conn.GetConnection().Open();

            var query = @"Select p.Name, s.Height, s.Weight, s.BloodType, s.EyeColor From PhysicalStats as s, Player as p where s.PlayerId = p.Id and s.PlayerId =" + playerId;

            var command = conn.GetCommand(query);
            var stat = new PhysicalStatModel();

            using (SQLiteDataReader read = command.ExecuteReader())
            {
                while (read.Read())
                {
                    stat.playerName = read.GetValue(0).ToString();
                    stat.playerHeight = read.GetValue(1).ToString();
                    stat.playerWeight = read.GetValue(2).ToString();
                    stat.playerBloodType = read.GetValue(3).ToString();
                    stat.playerEyeColor = read.GetValue(4).ToString();
                }
            }
            conn.GetConnection().Close();

            return stat;
        }

        public PlayerModel GetPlayerInfo(string playerId)
        {
            conn.GetConnection().Open();

            var query = @"Select p.Name, b.PassYds, b.PassTDs, b.PassInt, b.RushTDs, b.RushYds, b.Carries, b.Fum, b.Pts from 
                Player as p, QbBreakdownStats as b where b.PlayerId = p.Id and b.PlayerId =" + playerId;

            var command = conn.GetCommand(query);
            var player = new PlayerModel();

            using (SQLiteDataReader read = command.ExecuteReader())
            {
                while (read.Read())
                {
                    player.playerName = read.GetValue(0).ToString();
                    player.playerPassYds = read.GetValue(1).ToString();
                    player.playerPassTDs = read.GetValue(2).ToString();
                    player.playerInts = read.GetValue(3).ToString();
                    player.playerRushingTds = read.GetValue(4).ToString();
                    player.playerRushingYds = read.GetValue(5).ToString();
                    player.playerCarries = read.GetValue(6).ToString();
                    player.playerFumbles = read.GetValue(7).ToString();
                    player.playerPts = read.GetValue(8).ToString();
                }
            }

            conn.GetConnection().Close();

            return player;

        }

    }
}
