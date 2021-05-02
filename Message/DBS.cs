using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Programming
{
    public static class DBS
    {
        public class Message
        {
            public int m_num;
            public int m_receiver_em_num;
            public int m_sender_em_num;
            public string m_content;
            public string m_title;
            public bool m_check;
            public void h_save()
            {
                string INSERT = string.Format("INSERT INTO `oracle2`.`message` (`receiver_em_num`, `sender_em_num`, `content`, `title`, `check`)");
                string VALUES = string.Format("VALUES ('{0}', '{1}', '{2}', '{3}', {4});", m_receiver_em_num, m_sender_em_num, m_content, m_title,false);
                
                string query = string.Format("{0} {1} ", INSERT, VALUES);

                MySqlCommand command = new MySqlCommand(query, Function.con);
                command.ExecuteNonQuery();
            }
            public static Message find_num(int num)
            {
                string query = string.Format("SELECT * FROM message WHERE num = {0}", num);
                MySqlCommand command = new MySqlCommand(query, Function.con);
                MySqlDataReader rdr = command.ExecuteReader();
                if (rdr.Read())
                {
                    Message result = new Message();
                    result.m_content = (string)rdr["content"];
                    result.m_receiver_em_num = (int)rdr["receiver_em_num"];
                    result.m_sender_em_num = (int)rdr["sender_em_num"];
                    result.m_title = (string)rdr["title"];
                    result.m_num = num;
                    result.m_check = true;
                    return result;
                }
                else
                {
                    Console.WriteLine("해당 넘버의 메세지가 없습니다");
                    return null;
                }
            }
            public void check()
            {
                string query = string.Format("UPDATE `oracle2`.`message` SET `check` = '1' WHERE(`num` = '{0}');", m_num);
                MySqlCommand command = new MySqlCommand(query, Function.con);
                command.ExecuteNonQuery();
            }
        }
        public class Employee
        {
            public int m_num;
            public string m_name;
            public int m_age;
            public string m_address;
            public string m_gender;
            public int m_dpt_num;
            public int m_pos_num;
            public string m_phone_num;
            public System.DateTime m_join;

            public static List<Employee> find_dpt_num(int num)
            {
                List<Employee> result = new List<Employee>();
                string qeury = string.Format("SELECT * FROM employee WHERE dpt_num = {0}", num);
                MySqlCommand command = new MySqlCommand(qeury, Function.con);
                MySqlDataReader rdr = command.ExecuteReader();
                while(rdr.Read())
                {
                    Employee cell = new Employee(rdr);
                    result.Add(cell);
                }
                return result;
            }
            public static Employee find_num(int num)
            {
                string query = string.Format("SELECT * FROM employee WHERE num = {0}", num);
                MySqlCommand command = new MySqlCommand(query, Function.con);
                MySqlDataReader rdr = command.ExecuteReader();
                if(rdr.Read())
                {
                    Employee result = new Employee(rdr);
                    return result;
                }
                else
                {
                    Console.WriteLine("해당 넘버의 회원이 없습니다");
                    return null;
                }
            }
            public Employee(MySqlDataReader rdr)
            {
                m_num = (int)rdr["num"];
                m_name = (string)rdr["name"];
                m_age = (int)rdr["age"];
                m_address = (string)rdr["address"];
                m_gender = (string)rdr["gender"];
                m_dpt_num = (int)rdr["dpt_num"];
                m_pos_num = (int)rdr["pos_num"];
                m_phone_num = (string)rdr["phone_num"];
                m_join = (System.DateTime)rdr["join"];
            }
        }
        public class Position
        {
            public string m_name;
            public int m_num;
            public static Position find_num(int num)
            {
                string query = string.Format("SELECT * FROM position WHERE num = {0}", num);
                MySqlCommand command = new MySqlCommand(query, Function.con);
                MySqlDataReader rdr = command.ExecuteReader();
                if (rdr.Read())
                {
                    Position result = new Position();
                    result.m_name = (string)rdr["name"];
                    result.m_num = (int)rdr["num"];
                    return result;
                }
                else
                {
                    Console.WriteLine("해당 넘버의 직책이 없습니다");
                    return null;
                }
            }
        }
        public class Department
        {
            public string m_name;
            public int m_num;
            public int m_boss_em_num;
            public static List<Department> list
            {
                get
                {
                    List<Department> result = new List<Department>();
                    string qeury = string.Format("SELECT * FROM department");
                    MySqlCommand command = new MySqlCommand(qeury, Function.con);
                    MySqlDataReader rdr = command.ExecuteReader();
                    while (rdr.Read())
                    {
                        string name = (string)rdr["name"];
                        int num = (int)rdr["num"];
                        //int boss_em_num = (int)rdr["boss_em_num"];
                        Department cell = new Department();
                        cell.m_name = name;
                        cell.m_num = num;
                        //cell.m_boss_em_num = boss_em_num;
                        result.Add(cell);
                    }
                    Function.con = null;
                    return result;
                }
            }
            public static Department find_num(int num)
            {
                string query = string.Format("SELECT * FROM department WHERE num = {0}", num);
                MySqlCommand command = new MySqlCommand(query, Function.con);
                MySqlDataReader rdr = command.ExecuteReader();
                if (rdr.Read())
                {
                    Department result = new Department();
                    result.m_name = (string)rdr["name"];
                    result.m_num = (int)rdr["num"];
                    result.m_boss_em_num = (int)rdr["boss_em_num"];
                    return result;
                }
                else
                {
                    Console.WriteLine("해당 넘버의 부서가 없습니다");
                    return null;
                }
            }
        }
        //public class Account
        //{
        //    public int m_account_em_num;
        //    public string m_pw;
        //    public string m_id;

        //    public static Account connect_id = null;

        //    public static Account find_id(string id)
        //    {
        //        string qeury = string.Format("SELECT * FROM account WHERE id LIKE '{0}'", id);
        //        MySqlCommand command = new MySqlCommand(qeury, Function.con);
        //        MySqlDataReader rdr = command.ExecuteReader();
        //        if (rdr.Read())
        //        {
        //            Account result = new Account();
        //            result.m_pw = (string)rdr["pw"];
        //            result.m_id = (string)rdr["id"];
        //            result.m_account_em_num = (int)rdr["account_em_num"];
        //            return result;
        //        }
        //        else
        //        {
        //            Console.WriteLine("해당 아이디가 없습니다");
        //            return null;
        //        }
        //    }
        //    public static Account login(string id)
        //    {
        //        Account result = find_id(id);
        //        if (result == null)
        //        {
        //            Console.WriteLine("아이디가 없습니다");
        //        }
        //        else
        //        {
        //            connect_id = result;
        //        }
        //        return connect_id;
        //    }
        //}
    }
}
