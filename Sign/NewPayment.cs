using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Programming
{
    class NewPayment
    {
        private DateTimePicker date_;
        public NewPayment(DateTimePicker date)
        {
            date_ = date;
        }
        public void AddPayment(string title, string content, string comment, string name1, string name2, string num_name)
        {
            string querry = "INSERT INTO signlist(small_num,status,register_em_num,title,content,comment,first_em_num,fin_em_num) VALUES( (SELECT medium_num FROM small_category WHERE name = '" + num_name + "'),'1결재중'," + LoginManager.GetInstance().acc_num + ",'" + title+"','"+content+"','"+comment+ "',(SELECT num FROM employee WHERE name = '" + name1 + "'),(SELECT num FROM employee WHERE name = '" + name2 + "'))";
            DBManager.GetInstance().DBquery(querry);

            /*string querry2 = "INSERT INTO signlist(first_em_num) SELECT num FROM employee WHERE name = '" + name1 + "'";
            DBManager.GetInstance().DBquery(querry2);

            string querry3 = "INSERT INTO signlist(fin_em_num) SELECT num FROM employee WHERE name = '" + name2 + "'";
            DBManager.GetInstance().DBquery(querry3);*/
        }
        public int Count()
        {
            string query = "SELECT COUNT(*) AS cnt FROM signlist";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query);
            rdr.Read();
            int count =Convert.ToInt32(rdr["cnt"].ToString());
            return count;
        }
        public string PaymentQuery1(int count)
        {
            string []a = new string[100];
            int i = 0;
            try
            {
                string query = "SELECT * FROM signlist WHERE register_em_num = " + LoginManager.GetInstance().acc_num + "";
                MySqlDataReader rdr = DBManager.GetInstance().Select(query);
                while(rdr.Read())
                {
                    a[i] = "결재 NUM : "+rdr["num"].ToString() +" // 결재 TITLE : " + rdr["title"].ToString() + " //  결재상태 : " + rdr["status"].ToString();
                    i++;
                }
                rdr.Close();
                
            }
            catch(Exception)
            {
                a[count] = "결재중인 목록이 없습니다.";
            }
            return a[count];
            
        }
        public string PaymentQuery2(int count)
        {
            string []a = new string[100];
            int i = 0;
            try
            {
                string query = "SELECT title FROM signlist WHERE register_em_num = " + LoginManager.GetInstance().acc_num + " AND status = '1결재중' OR register_em_num = " + LoginManager.GetInstance().acc_num + " AND status = '1결재완료'";
                MySqlDataReader rdr = DBManager.GetInstance().Select(query);
                while(rdr.Read())
                {
                    a[i] = rdr["title"].ToString();
                    i++;
                }
                
            }
            catch(Exception)
            {
                a[count] = "결재중인 목록이 없습니다.";
            }
            return a[count];
            
        }
        public string PaymentQuery3(int count)
        {
            string[] a = new string[100];
            int i = 0;
            try
            {
                string query = "SELECT title FROM signlist WHERE register_em_num = " + LoginManager.GetInstance().acc_num + " AND status = '최종결재완료'";
                MySqlDataReader rdr = DBManager.GetInstance().Select(query);
                while(rdr.Read())
                {
                    a[i] = rdr["title"].ToString();
                    i++;
                }    
                rdr.Close();
                
            }
            catch (Exception)
            {
                a[count] = "결재완료 목록이 없습니다.";
            }
            return a[count];
        }
        public string PaymentQuery4(int count)
        {
            string[] a = new string[100];
            int i = 0;
            try
            {
                string query = "SELECT * FROM signlist WHERE  first_em_num = " + LoginManager.GetInstance().acc_num + " AND status = '1결재중' OR fin_em_num = " + LoginManager.GetInstance().acc_num + " AND status = '1결재완료'";
                MySqlDataReader rdr = DBManager.GetInstance().Select(query);
                while(rdr.Read())
                {
                    a[i] = "결재 num : "+rdr["num"].ToString()+"// 결재 TITLE : "+ rdr["title"].ToString();
                    i++;
                }
                rdr.Close();
                
            }
            catch (Exception)
            {
                a[count] = "결재해야할 목록이 없습니다.";
            }
            return a[count];
        }
        public void TimeCheck(int num)
        {
            string date = string.Format("{0}:{1}:{2}", date_.Value.Hour, date_.Value.Minute, date_.Value.Second);
            string query = "UPDATE signlist SET time = '"+date+"' WHERE num = "+num+"";
            DBManager.GetInstance().DBquery(query);
        }

        public string[] Small_category()
        {
            List<string> list = new List<string>();
            string query = "SELECT name FROM small_category";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query);
            while(rdr.Read())
            {
                list.Add(rdr["name"].ToString());
            }
            rdr.Close();
            string[] array = list.ToArray(); 
            return array;

        }
        public int dpt_num()
        {
            int a;
            string query = "SELECT dpt_num FROM employee WHERE num = " + LoginManager.GetInstance().acc_num + "";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query);
            rdr.Read();
            a = Convert.ToInt32(rdr["dpt_num"].ToString());
            rdr.Close();
            return a;
        }
        public int pos_num()
        {
            int a;
            string query = "SELECT pos_num FROM employee WHERE num = " + LoginManager.GetInstance().acc_num + "";
            MySqlDataReader rdr = DBManager.GetInstance().Select(query);
            rdr.Read();
            a = Convert.ToInt32(rdr["pos_num"].ToString());
            rdr.Close();
            return a;
        }
    }
}
