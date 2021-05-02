using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Programming
{
    class DBManager
    {
        private string strConn = "Server=49.50.174.201;Database =oracle2;Uid=oracle2;pwd=oracle2;Charset=utf8;";

        private static DBManager instance = new DBManager();

        public static DBManager GetInstance() { return instance; }

        private DBManager() { }

        public void DBquery(string query)
        {
            using(MySqlConnection  conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query,conn);
                cmd.ExecuteNonQuery();
            }
        }

        public MySqlDataReader Select(string query)
        {
            MySqlConnection conn = new MySqlConnection(strConn);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            return rdr;
        }

    }
}
