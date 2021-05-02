using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Programming
{
    class employeeInfo
    {
        public string userID { get; set; }
        public string userPW { get; set; }
        public int num { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public int dpt_num { get; set; }
        public int pos_num { get; set; }
        public string phone_num { get; set; }
        public DateTime join { get; set; }

        public void Init()
        {
            DataRow data = WorkDB.Instance.LoadData();

            num = Convert.ToInt32(data["num"]);
            name = data["name"].ToString();
            age = Convert.ToInt32(data["age"]);
            address = data["address"].ToString();
            gender = data["gender"].ToString();
            dpt_num = Convert.ToInt32(data["dpt_num"]);
            pos_num = Convert.ToInt32(data["pos_num"]);
            phone_num = data["phone_num"].ToString();
            join = Convert.ToDateTime(data["join"]); 
        }
    }
}
