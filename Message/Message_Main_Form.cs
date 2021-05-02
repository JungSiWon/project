using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Programming
{
    public partial class Message_Main_Form : Form
    {
        public Message_Main_Form()
        {
            InitializeComponent();
            h_start();
        }
        private void h_start()
        {
            listViewMessageList.View = View.Details;
            listViewMessageList.Columns.Add("번호", 50, HorizontalAlignment.Left);
            listViewMessageList.Columns.Add("보낸사람", 100, HorizontalAlignment.Left);
            listViewMessageList.Columns.Add("제목", 150, HorizontalAlignment.Left);

            comboBoxSearchMenu.Items.Add("보관함");
            comboBoxSearchMenu.Items.Add("작성자");
            comboBoxSearchMenu.Items.Add("제목");
            comboBoxSearchMenu.Items.Add("내용");
            comboBoxSearchMenu.Items.Add("안읽은 메세지");
            comboBoxSearchMenu.SelectedIndex = 4;
            h_content_no_check();
        }
        public void h_my_update()
        {
            int sender_num = Client.Client.Get.connect_employee.m_num;
            string search_name = textBoxSearchBar.Text;
            string SENDER = string.Format("(SELECT num,name FROM employee) sender");
            string MESSAGE = string.Format("(SELECT * FROM message WHERE sender_em_num = {0}) message", sender_num);
            string query = string.Format("SELECT * FROM {0} JOIN {1} ON  message.sender_em_num = sender.num", MESSAGE, SENDER);
            MySqlCommand command = new MySqlCommand(query, Function.con);
            MySqlDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                string sender_name = (string)rdr["name"];
                string title = (string)rdr["title"];
                string check = "○";
                if ((bool)rdr["check"])
                    check = "●";

                string num = string.Format("{0}{1}", check, Function.int2string((int)rdr["num"]));
                string[] arg = { num, sender_name, title };
                ListViewItem listviewItem = new ListViewItem(arg, 3);
                listViewMessageList.Items.Add(listviewItem);
            }
        }
        public void h_employee_update()
        {
            int recever_num = Client.Client.Get.connect_employee.m_num;
            string search_name = textBoxSearchBar.Text;
            string SENDER = string.Format("(SELECT num,name FROM employee WHERE name LIKE '%{0}%') sender", search_name);
            string MESSAGE = string.Format("(SELECT * FROM message WHERE receiver_em_num = {0}) message", recever_num);
            string query = string.Format("SELECT * FROM {0} JOIN {1} ON  message.sender_em_num = sender.num",MESSAGE,SENDER);
            MySqlCommand command = new MySqlCommand(query, Function.con);
            MySqlDataReader rdr = command.ExecuteReader();
            //DataTable datatable = new DataTable();
            //datatable.Load(command.ExecuteReader());
            //dataGridView.DataSource = datatable;
            while (rdr.Read())
            {
                string sender_name = (string)rdr["name"];
                string title = (string)rdr["title"]; 
                string check = "○";
                if ((bool)rdr["check"])
                    check = "●";

                string num =  string.Format("{0}{1}",check,Function.int2string((int)rdr["num"]));
                string[] arg = { num, sender_name , title };
                ListViewItem listviewItem = new ListViewItem(arg, 3);
                listViewMessageList.Items.Add(listviewItem);
            }
        }
        public void h_title_update()
        {
            int recever_num = Client.Client.Get.connect_employee.m_num;
            string search_title = textBoxSearchBar.Text;
            string SENDER = string.Format("(SELECT num,name FROM employee) sender");
            string MESSAGE = string.Format("(SELECT * FROM message WHERE receiver_em_num = {0} AND title LIKE '%{1}%') message", recever_num, search_title);
            string query = string.Format("SELECT * FROM {0} JOIN {1} ON  message.sender_em_num = sender.num", MESSAGE, SENDER);
            MySqlCommand command = new MySqlCommand(query, Function.con);
            MySqlDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                string sender_name = (string)rdr["name"];
                string check = "○";
                if ((bool)rdr["check"])
                    check = "●";
                string num = string.Format("{0}{1}", check, Function.int2string((int)rdr["num"]));
                string title = (string)rdr["title"];
                string[] arg = { num, sender_name ,title};
                ListViewItem listviewItem = new ListViewItem(arg, 3);
                listViewMessageList.Items.Add(listviewItem);
            }
        }
        public void h_content_no_check()
        {

            int recever_num = Client.Client.Get.connect_employee.m_num;
            string search_title = textBoxSearchBar.Text;
            string SENDER = string.Format("(SELECT num,name FROM employee) sender");
            string MESSAGE = string.Format("(SELECT * FROM message WHERE receiver_em_num = '{0}') message", recever_num,false);
            string query = string.Format("SELECT * FROM {0} JOIN {1} ON  message.sender_em_num = sender.num", MESSAGE, SENDER);
            MySqlCommand command = new MySqlCommand(query, Function.con);
            MySqlDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                if ((bool)rdr["check"])
                { }
                else
                {
                    string sender_name = (string)rdr["name"];
                    string num = string.Format("{0}{1}", "○", Function.int2string((int)rdr["num"]));
                    string title = (string)rdr["title"];
                    string[] arg = { num, sender_name, title };
                    ListViewItem listviewItem = new ListViewItem(arg, 3);
                    listViewMessageList.Items.Add(listviewItem);
                }
            }
        }
        public void h_content_update()
        {
            int recever_num = Client.Client.Get.connect_employee.m_num;
            string search_content = textBoxSearchBar.Text;
            string SENDER = string.Format("(SELECT num,name FROM employee) sender");
            string MESSAGE = string.Format("(SELECT * FROM message WHERE receiver_em_num = {0} AND content LIKE '%{1}%') message", recever_num, search_content);
            string query = string.Format("SELECT * FROM {0} JOIN {1} ON  message.sender_em_num = sender.num", MESSAGE, SENDER);
            MySqlCommand command = new MySqlCommand(query, Function.con);
            MySqlDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                string sender_name = (string)rdr["name"];
                string title = (string)rdr["title"];
                string check = "○";
                if ((bool)rdr["check"])
                    check = "●";
                string num = string.Format("{0}{1}", check, Function.int2string((int)rdr["num"]));

                string[] arg = { num, sender_name, title };
                ListViewItem listviewItem = new ListViewItem(arg, 3);
                listViewMessageList.Items.Add(listviewItem);
            }
        }

        private void buttonMessageWrite_Click(object sender, EventArgs e)
        {
            Message_Write_Form form = new Message_Write_Form();
            form.Show();
        }

        private void buttonMessageRead_Click(object sender, EventArgs e)
        {
            if (listViewMessageList.SelectedIndices.Count > 0)
            {
                int index = listViewMessageList.SelectedIndices[0];
                string message_num = listViewMessageList.SelectedItems[0].SubItems[0].Text.ToString();
                int input = Function.string2int(message_num);
                Message_Read_Form form = new Message_Read_Form(input);

                form.Show();
            }
            else
            {
                MessageBox.Show("메시지를 선택해주세요");
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listViewMessageList.Items.Clear();
            switch(comboBoxSearchMenu.SelectedIndex)
            {
                case 0:
                    {
                        h_my_update();
                        break;
                    }
                case 1:
                    {
                        h_employee_update();
                        break;
                    }
                case 2:
                    {
                        h_title_update();
                        break;
                    }
                case 3:
                    {
                        h_content_update();
                        break;
                    }
                case 4:
                    {
                        h_content_no_check();
                        break;
                    }
            }
        }
    }
}
