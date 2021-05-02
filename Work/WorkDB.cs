using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Programming
{
    public sealed class WorkDB
    {
        private static DataRow employeeInfo = null;
        private static string connString = null;
        private static MySqlConnection mySqlConn = null;
        private static MySqlCommand cmd = null;

        private WorkDB() { }
        private static readonly Lazy<WorkDB> _instance = new Lazy<WorkDB>(() => new WorkDB());
        public static WorkDB Instance { get { return _instance.Value; } }

        public void ConnectSetting()
        {
            connString = "Server=49.50.174.201;Database=oracle2;Uid=oracle2;Pwd=oracle2;Charset=utf8";
            mySqlConn = new MySqlConnection(connString);
        }

        public void Init(DataRow value)
        {
            employeeInfo = value;
        }

        public DataRow LoadData()
        {
            return employeeInfo;
        }

        public DataSet DataAdapter_Fill(String query)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter adpt = new MySqlDataAdapter(query, mySqlConn);
            adpt.Fill(ds, "ds");
            return ds;
        }

        public void Execute_NonQuery(string query)
        {
            var conn = mySqlConn;
            using (mySqlConn)
            {
                mySqlConn.Open();
                MySqlCommand cmd = new MySqlCommand(query, mySqlConn);
                cmd.ExecuteNonQuery();
            }
        }

        public void LoadWorkCategory()
        {

        }
    }
}
