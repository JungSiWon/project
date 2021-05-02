using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ERP_Programming
{
    public partial class FormDpartInfo : Form
    {
        public FormDpartInfo()
        {
            InitializeComponent();
        }
        public dptprogramstate program { get; set; }
        MySqlConnection conn = new MySqlConnection("Server = 49.50.174.201; Database=oracle2;Uid=oracle2;Pwd=oracle2;Charset=utf8;Allow User Variables=true;");

        private void InitVariables()
        {
            string query;
            MySqlCommand cmd;
            MySqlDataReader dr;
            if (program.ButtonDptAddClicked == true)
            {
                conn.Open();
                query = "SELECT MAX(num) as mn FROM department as dpt;";
                cmd = new MySqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                int dptnum = Convert.ToInt32(dr["mn"]) + 1;

                dr.Close();
                conn.Close();
                labelDptNum.Text = dptnum.ToString();
            }
            else if (program.ToolStripMenuItem1Clicked == true)
            {
                labelDptNum.Text = program.dptnum.ToString();
                textBoxDptName.Text = program.dptname;
                textBoxDptHead.Text = program.dpthead;
                textBoxHeadNumber.Text = program.headnum.ToString();
            }

            conn.Open();
            query = "SELECT name FROM department";
            cmd = new MySqlCommand(query, conn);
            dr = cmd.ExecuteReader();
            comboBoxDepartmentList.Items.Add("");
            while (dr.Read())
            {
                comboBoxDepartmentList.Items.Add(dr["name"].ToString());
            }
            listViewSearchHead.Items.Clear();
            dr.Close();
            conn.Close();
        }

        private string log;
        private void FormDpartInfo_Load(object sender, EventArgs e)
        {
            InitVariables();
            log = textBoxHeadNumber.Text;
        }

        private void buttonDptSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT emp.num, emp.name, dpt.name as dpt_name, pos.name as pos_name FROM employee as emp"
                + " JOIN department as dpt ON emp.dpt_num=dpt.num"
                + " JOIN position as pos ON emp.pos_num=pos.num"
                + " WHERE";

            string depart = (comboBoxDepartmentList.SelectedIndex <= 0) ? string.Empty : " dpt.name = '" + comboBoxDepartmentList.Text + "'";
            string position = (comboBoxPositionList.SelectedIndex <= 0) ? string.Empty : " pos.name = '" + comboBoxPositionList.Text + "'";

            string[] condition = { depart, position };

            int i = 0;
            foreach (string str in condition)
            {
                if (str != string.Empty)
                {
                    query += str;
                    query += " and";
                    i += 1;
                }
            }

            if (i == 0)
            {
                query = query.Substring(0, query.Length - 6);
            }
            else
            {
                query = query.Substring(0, query.Length - 4);
            }
            query += ";";

            Console.WriteLine(query);

            conn.Open();
            MySqlDataAdapter adt = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adt.Fill(dt);

            listViewSearchHead.Items.Clear();

            listViewSearchHead.BeginUpdate();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["num"].ToString());
                item.SubItems.Add(dr["name"].ToString());
                item.SubItems.Add(dr["dpt_name"].ToString());
                item.SubItems.Add(dr["pos_name"].ToString());

                listViewSearchHead.Items.Add(item);
            }
            listViewSearchHead.EndUpdate();

            conn.Close();
        }

        private void listViewSearchHead_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedItem = listViewSearchHead.SelectedItems[0];
            textBoxHeadNumber.Text = selectedItem.Text;
            textBoxDptHead.Text = selectedItem.SubItems[1].Text;
        }

        private void buttonDptAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (program.ButtonDptAddClicked == true)
            {
                if (textBoxDptName.Text == "" || textBoxDptHead.Text == "")
                {
                    MessageBox.Show("입력하지 않은 정보가 있습니다.");
                }
                else
                {
                    string query = "INSERT INTO department VALUES (" + labelDptNum.Text + ",'" + textBoxDptName.Text + "'," + textBoxHeadNumber.Text + ");" +
                        "UPDATE employee SET dpt_num = " + labelDptNum.Text + ", pos_num = 4 WHERE num = " + textBoxHeadNumber.Text + ";";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }

            }
            else if (program.ToolStripMenuItem1Clicked == true)
            {
                string query;
                /*
                if(textBoxDptHead.Text != program.dpthead.ToString())
                {
                    query = "UPDATE employee SET dpt_num = 0 WHERE num =" + program.headnum + ";";
                    MySqlCommand cmd1 = new MySqlCommand(query, conn);
                    cmd1.ExecuteNonQuery();
                }
                */
                query = "UPDATE department as dpt, employee as emp, employee as emp1 SET dpt.name = '" + textBoxDptName.Text + "', dpt.boss_em_num = " + textBoxHeadNumber.Text + 
                    ", emp.dpt_num = " + labelDptNum.Text + ", emp.pos_num = 4" +  ", " +
                    "emp1.pos_num = 3" + " " +
                    "WHERE dpt.num = " + labelDptNum.Text + " AND emp.num = " + textBoxHeadNumber.Text + " AND emp1.num =" + log + ";" ;

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            conn.Close();

            this.Close();
        }
    }
}
