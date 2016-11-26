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

            var query = @"Select p.Name, rusc.RushYds, rusc.RushTds, recc.Receptions, recc.RecYds, recc.RecTds, recc.Fum,
                rusl.RushYds, rusl.RushTds, recl.Receptions, recl.RecYds, recl.RecTds, recl.Fum,
                rusn.RushYds, rusn.RushTds, recn.Receptions, recn.RecYds, recn.RecTds, recn.Fum
                from 
                Player as p, RushingCurrentYr as rusc, ReceivingCurrentYr as recc, RushingLastYr as rusl, ReceivingLastYr as recl, RushingNextYr as rusn, ReceivingNextYr as recn 
                where 
                rusc.PlayerId = p.Id and recc.PlayerId = p.Id and rusl.PlayerId = p.Id and recl.PlayerId = p.Id and rusn.PlayerId = p.Id and recn.PlayerId = p.Id and p.Id =" + playerId;

            var command = conn.GetCommand(query);
            var stat = new BreakdownStatModel();

            using (SQLiteDataReader read = command.ExecuteReader())
            {
                while (read.Read())
                {
                    stat.playerName = read.GetValue(0).ToString();
                    // current year
                    stat.playerRushingYds = read.GetValue(1).ToString();
                    stat.playerRushingTDs = read.GetValue(2).ToString();
                    stat.playerReceptions = read.GetValue(3).ToString();
                    stat.playerRecYds = read.GetValue(4).ToString();
                    stat.playerRecTDs = read.GetValue(5).ToString();
                    stat.playerFumbles = read.GetValue(6).ToString();
                    // last year
                    stat.playerRushingYdsLy = read.GetValue(7).ToString();
                    stat.playerRushingTDsLy = read.GetValue(8).ToString();
                    stat.playerReceptionsLy = read.GetValue(9).ToString();
                    stat.playerRecYdsLy = read.GetValue(10).ToString();
                    stat.playerRecTDsLy = read.GetValue(11).ToString();
                    stat.playerFumblesLy = read.GetValue(12).ToString();
                    // next year
                    stat.playerRushingYdsNy = read.GetValue(13).ToString();
                    stat.playerRushingTDsNy = read.GetValue(14).ToString();
                    stat.playerReceptionsNy = read.GetValue(15).ToString();
                    stat.playerRecYdsNy = read.GetValue(16).ToString();
                    stat.playerRecTDsNy = read.GetValue(17).ToString();
                    stat.playerFumblesNy = read.GetValue(18).ToString();
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

        public QbBreakdownStatModel GetQbBreakdownStat(string playerId)
        {
            conn.GetConnection().Open();

            var query = @"Select p.Name, qbpc.PassingYds, qbpc.PassingTds, qbpc.Interceptions, qbpc.Fum, qbrc.RushYds, qbrc.RushTds,
                qbpl.PassingYds, qbpl.PassingTds, qbpl.Interceptions, qbpl.Fum, qbrl.RushYds, qbrl.RushTds,
                qbpn.PassingYds, qbpn.PassingTds, qbpn.Interceptions, qbpn.Fum, qbrn.RushYds, qbrn.RushTds
                from 
                Player as p, QBPassingCurrentYr as qbpc, QBRushingCurrentYr as qbrc, QBPassingLastYr as qbpl, QBRushingLastYr as qbrl, 
                QBPassingNextYr as qbpn, QBRushingNextYr as qbrn 
                where 
                qbpc.PlayerId = p.Id and qbrc.PlayerId = p.Id and qbpl.PlayerId = p.Id and qbrl.PlayerId = p.Id and qbpn.PlayerId = p.Id and qbrn.PlayerId = p.Id and p.Id =" + playerId;

            var command = conn.GetCommand(query);
            var player = new QbBreakdownStatModel();

            using (SQLiteDataReader read = command.ExecuteReader())
            {
                while (read.Read())
                {
                    // current year
                    player.playerName = read.GetValue(0).ToString();
                    player.playerPassingYds = read.GetValue(1).ToString();
                    player.playerPassingTDs = read.GetValue(2).ToString();
                    player.playerInts = read.GetValue(3).ToString();
                    player.playerFumbles = read.GetValue(4).ToString();
                    player.playerRushingYds = read.GetValue(5).ToString();
                    player.playerRushingTds = read.GetValue(6).ToString();
                    // last year
                    player.playerPassingYdsLy = read.GetValue(7).ToString();
                    player.playerPassingTDsLy = read.GetValue(8).ToString();
                    player.playerIntsLy = read.GetValue(9).ToString();
                    player.playerFumblesLy = read.GetValue(10).ToString();
                    player.playerRushingYdsLy = read.GetValue(11).ToString();
                    player.playerRushingTdsLy = read.GetValue(12).ToString();
                    // next year
                    player.playerPassingYdsNy = read.GetValue(13).ToString();
                    player.playerPassingTDsNy = read.GetValue(14).ToString();
                    player.playerIntsNy = read.GetValue(15).ToString();
                    player.playerFumblesNy = read.GetValue(16).ToString();
                    player.playerRushingYdsNy = read.GetValue(17).ToString();
                    player.playerRushingTdsNy = read.GetValue(18).ToString();
                }
            }

            conn.GetConnection().Close();

            return player;

        }

    }
}
