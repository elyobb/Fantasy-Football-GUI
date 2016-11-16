using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Fantasy_Football_Draft.SQL_Queries
{
    public class Connection
    {
        public SQLiteConnection conn;
        public SQLiteCommand cmd;
        private string connectionString = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        public Connection()
        {
            conn = new SQLiteConnection(connectionString);
            cmd = new SQLiteCommand();
            cmd.Connection = conn;
        }

        public SQLiteConnection GetConnection()
        {
            return conn;
        }

        public SQLiteCommand GetCommand()
        {
            return cmd;
        }

        public SQLiteCommand GetCommand(string query)
        {
            cmd.CommandText = query;
            return cmd;
        }
    }
}
