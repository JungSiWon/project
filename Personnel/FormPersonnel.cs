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
    public partial class FormPersonnel : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=49.50.174.201;Database=oracle2;Uid=oracle2;Pwd=oracle2;Charset=utf8;Allow User Variables=true;");
        Dictionary<string, int> dpt_dic = new Dictionary<string, int>();
        Dictionary<string, int> pos_dic = new Dictionary<string, int>();
        Dictionary<string, string> search_dic = new Dictionary<string, string>();

        public FormPersonnel()
        {
            InitializeComponent();

            load_depart();
            loadInitialEmpData();

            search_dic.Add("사원번호", "emp.num");
            search_dic.Add("이름", "emp.name");
            search_dic.Add("나이", "emp.age");
            search_dic.Add("주소", "emp.address");
            search_dic.Add("성별", "emp.gender");
            search_dic.Add("부서", "dpt.name");
            search_dic.Add("직책", "pos.name");

            comboBoxEmpSearch.SelectedIndex = 0;
        }

        private void load_depart()
        {
            conn.Open();

            listViewDpt.BeginUpdate();

            string query = "SELECT dpt.num, dpt.name, dpt.boss_em_num, emp.name as employee_name FROM department as dpt JOIN employee as emp ON dpt.boss_em_num=emp.num WHERE dpt.name != '사장님';";
            MySqlDataAdapter adt = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adt.Fill(dt);

            listViewDpt.Items.Clear();

            foreach(DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["num"].ToString());
                item.SubItems.Add(dr["name"].ToString());
                item.SubItems.Add(dr["employee_name"].ToString());
                item.SubItems.Add(dr["boss_em_num"].ToString());

                listViewDpt.Items.Add(item);
            }
            listViewDpt.EndUpdate();

            conn.Close();
        }

        private void loadInitialEmpData()
        {
            load_emp();
            load_nextEmpNum();
            load_dpt();
            load_pos();
        }

        #region 사원목록 불러오기
        private void load_emp()
        {
            string query = string.Empty;

            if (textBoxEmpSearch.Text != string.Empty)
            {
                query = "SELECT emp.num, emp.name, emp.age, emp.address, emp.gender, dpt.name AS dpt_name, pos.name AS pos_name, emp.phone_num, emp.join FROM employee AS emp " +
                    "JOIN department AS dpt ON emp.dpt_num=dpt.num " +
                    "JOIN position AS pos ON emp.pos_num=pos.num " +
                    "WHERE " + search_dic[comboBoxEmpSearch.SelectedItem.ToString()] + " LIKE '%" + textBoxEmpSearch.Text + "%' " +
                    "ORDER BY emp.num;";
            }
            else
            {
                query = "SELECT emp.num, emp.name, emp.age, emp.address, emp.gender, dpt.name AS dpt_name, pos.name AS pos_name, emp.phone_num, emp.join FROM employee AS emp " +
                    "JOIN department AS dpt ON emp.dpt_num=dpt.num " +
                    "JOIN position AS pos ON emp.pos_num=pos.num " +
                    "ORDER BY emp.num;";
            }

            conn.Open();

            listViewEmp.BeginUpdate();

            MySqlDataAdapter adt = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adt.Fill(dt);

            listViewEmp.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(dr["num"].ToString());
                item.SubItems.Add(dr["name"].ToString());
                item.SubItems.Add(dr["age"].ToString());
                item.SubItems.Add(dr["address"].ToString().Replace('^', ' '));
                item.SubItems.Add(dr["gender"].ToString());
                item.SubItems.Add(dr["dpt_name"].ToString());
                item.SubItems.Add(dr["pos_name"].ToString());
                item.SubItems.Add(dr["phone_num"].ToString());
                item.SubItems.Add(DateTime.Parse(dr["join"].ToString()).ToString("yyyy-MM-dd"));
                item.Tag = dr["address"].ToString();

                listViewEmp.Items.Add(item);
            }

            listViewEmp.EndUpdate();

            conn.Close();
        }
        #endregion

        #region 다음 사원번호 지정
        private void load_nextEmpNum()
        {
            conn.Open();

            string query = "SELECT num FROM employee ORDER BY num DESC;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader mdr = cmd.ExecuteReader();

            mdr.Read();
            int empNum = Convert.ToInt32(mdr["num"]) + 1;
            labelEmpNum.Text = empNum.ToString();
            mdr.Close();

            conn.Close();
        }
        #endregion

        #region 부서목록 지정
        private void load_dpt()
        {
            conn.Open();

            string query = "SELECT num, name FROM department;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBoxEmpDpt.Items.Add(dr["name"].ToString());
                dpt_dic.Add(dr["name"].ToString(), Convert.ToInt32(dr["num"]));
            }
            dr.Close();

            conn.Close();
        }
        #endregion

        #region 직책목록 지정
        private void load_pos()
        {
            conn.Open();

            string query = "SELECT num, name FROM position;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBoxEmpPos.Items.Add(dr["name"].ToString());
                pos_dic.Add(dr["name"].ToString(), Convert.ToInt32(dr["num"]));
            }
            dr.Close();

            conn.Close();
        }
        #endregion

        private void 수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem selectedItem = listViewEmp.SelectedItems[0];

                EmployeeInfo emp = new EmployeeInfo();
                emp.num = Convert.ToInt32(selectedItem.Text);
                emp.name = selectedItem.SubItems[1].Text;
                emp.age = Convert.ToInt32(selectedItem.SubItems[2].Text);
                emp.address = selectedItem.Tag.ToString();
                emp.gender = selectedItem.SubItems[4].Text;
                emp.dpt = selectedItem.SubItems[5].Text;
                emp.pos = selectedItem.SubItems[6].Text;
                emp.phone_num = selectedItem.SubItems[7].Text;
                emp.join = selectedItem.SubItems[8].Text;

                FormUpdateEmpInfo form = new FormUpdateEmpInfo();
                form.empInfo = emp;
                form.ShowDialog();

                load_emp();
            }
            catch
            {

            }
        }

        private void buttonDptAdd_Click(object sender, EventArgs e)
        {
            dptprogramstate pro = new dptprogramstate();
            pro.ButtonDptAddClicked = true;
            pro.ToolStripMenuItem1Clicked = false;

            FormDpartInfo form = new FormDpartInfo();
            form.program = pro;
            form.ShowDialog();

            load_depart();
        }

        private void 수정ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                dptprogramstate pro = new dptprogramstate();
                pro.dptnum = Convert.ToInt32(listViewDpt.SelectedItems[0].Text);
                pro.dptname = listViewDpt.SelectedItems[0].SubItems[1].Text;
                pro.dpthead = listViewDpt.SelectedItems[0].SubItems[2].Text;
                pro.headnum = Convert.ToInt32(listViewDpt.SelectedItems[0].SubItems[3].Text);

                pro.ButtonDptAddClicked = false;
                pro.ToolStripMenuItem1Clicked = true;

                FormDpartInfo form = new FormDpartInfo();
                form.program = pro;
                form.ShowDialog();

                load_depart();
                load_emp();
            }
            catch
            {

            }
        }

        private void buttonAdrSearch_Click(object sender, EventArgs e)
        {
            FormSearchAddress form = new FormSearchAddress();
            form.sendDataEvent += new FormSearchAddress.sendDataToParent(updateData);
            form.ShowDialog();
        }

        private void updateData(object sender)
        {
            DataRow dr = sender as DataRow;

            string address = dr["address"].ToString();
            string buildingName = dr["buildingName"].ToString();
            string zoneCode = dr["zoneCode"].ToString();

            address += "(" + buildingName + ")";

            textBoxEmpAdr.Text = address;
            textBoxEmpZoneCode.Text = zoneCode;

            textBoxEmpDetailAdr.Text = string.Empty;
            textBoxEmpDetailAdr.Focus();
        }

        private void buttonEmpAdd_Click(object sender, EventArgs e)
        {
            if (textBoxEmpName.Text == string.Empty ||
                textBoxEmpAge.Text == string.Empty ||
                textBoxEmpAdr.Text == string.Empty ||
                textBoxEmpDetailAdr.Text == string.Empty ||
                textBoxEmpZoneCode.Text == string.Empty ||
                comboBoxEmpGender.SelectedIndex == -1 ||
                comboBoxEmpDpt.SelectedIndex == -1 ||
                comboBoxEmpPos.SelectedIndex == -1 ||
                textBoxEmpPhone.Text == string.Empty)
            {
                MessageBox.Show("모든 항목은 필수입력 사항입니다");
            }
            else
            {
                EmployeeInfo emp = new EmployeeInfo();
                emp.num = Convert.ToInt32(labelEmpNum.Text);
                emp.name = textBoxEmpName.Text;
                emp.age = Convert.ToInt32(textBoxEmpAge.Text);
                emp.address = textBoxEmpAdr.Text + "^" + textBoxEmpDetailAdr.Text + "^" + textBoxEmpZoneCode.Text;
                emp.gender = comboBoxEmpGender.SelectedItem.ToString();
                emp.dpt = dpt_dic[comboBoxEmpDpt.Text].ToString();
                emp.pos = pos_dic[comboBoxEmpPos.Text].ToString();
                emp.phone_num = textBoxEmpPhone.Text;
                emp.join = dateTimePickerEmpJoin.Value.ToString("yyyy-MM-dd");

                if (comboBoxEmpPos.SelectedItem.ToString().Equals("부장"))
                {
                    conn.Open();

                    string query = "SELECT * FROM employee WHERE dpt_num=" + emp.dpt + " AND pos_num=4;";                    

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        MessageBox.Show("해당 직책은 위임할 수 없습니다");
                        conn.Close();
                        return;
                    }
                    else
                    {
                        query = "INSERT INTO employee(num, name, age, address, gender, dpt_num, pos_num, phone_num, `join`) " +
                        "VALUES (" + emp.num + ", '" + emp.name + "', " + emp.age + ", '" + emp.address + "', '" + emp.gender + "', " + emp.dpt + ", " + emp.pos + ", '" + emp.phone_num + "', '" + emp.join + "');" +
                        "INSERT INTO account(id,pw,account_em_num) VALUES ('a" + emp.num + "','a" + emp.num + "'," + emp.num + ");";

                        cmd = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();

                        conn.Close();

                        load_emp();
                        inputValueReset();
                    }
                }
                else
                {
                    conn.Open();

                    string query = "INSERT INTO employee(num, name, age, address, gender, dpt_num, pos_num, phone_num, `join`) " +
                        "VALUES (" + emp.num + ", '" + emp.name + "', " + emp.age + ", '" + emp.address + "', '" + emp.gender + "', " + emp.dpt + ", " + emp.pos + ", '" + emp.phone_num + "', '" + emp.join + "');" +
                        "INSERT INTO account(id,pw,account_em_num) VALUES ('a" + emp.num + "','a" + emp.num + "'," + emp.num + ");";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    conn.Close();

                    load_emp();
                    inputValueReset();
                }
            }
        }

        private void buttonEmpSearch_Click(object sender, EventArgs e)
        {
            load_emp();
        }

        private void buttonEmpReset_Click(object sender, EventArgs e)
        {
            inputValueReset();
        }

        private void inputValueReset()
        {
            textBoxEmpName.Text = string.Empty;
            textBoxEmpAge.Text = string.Empty;
            textBoxEmpAdr.Text = string.Empty;
            textBoxEmpDetailAdr.Text = "상세주소";
            textBoxEmpZoneCode.Text = "우편번호";
            comboBoxEmpGender.SelectedIndex = -1;
            comboBoxEmpDpt.SelectedIndex = -1;
            comboBoxEmpPos.SelectedIndex = -1;
            textBoxEmpPhone.Text = string.Empty;
        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listViewEmp.SelectedItems[0];

            string query = "DELETE FROM employee WHERE num=" + selectedItem.Text + ";" + 
                "DELETE FROM account WHERE account_em_num=" + selectedItem.Text + ";";

            conn.Open();

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

            load_emp();
        }

        private void 삭제ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string log = listViewDpt.SelectedItems[0].Text;
                conn.Open();
                string query = "DELETE FROM department WHERE num = " + log + ";";
                query += "UPDATE employee SET dpt_num = 0 WHERE dpt_num = " + log + ";";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                load_depart();
                load_emp();
            }
            catch
            {

            }
        }

        private void 급여내역ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem selectedItem = listViewEmp.SelectedItems[0];

                EmployeeInfo emp = new EmployeeInfo();
                emp.num = Convert.ToInt32(selectedItem.Text);
                emp.name = selectedItem.SubItems[1].Text;
                emp.age = Convert.ToInt32(selectedItem.SubItems[2].Text);
                emp.address = selectedItem.SubItems[3].Text;
                emp.gender = selectedItem.SubItems[4].Text;
                emp.dpt = selectedItem.SubItems[5].Text;
                emp.pos = selectedItem.SubItems[6].Text;
                emp.phone_num = selectedItem.SubItems[7].Text;
                emp.join = selectedItem.SubItems[8].Text;

                FormPaydoc form = new FormPaydoc();
                form.empInfo1 = emp;
                form.ShowDialog();
            }
            catch
            {

            }
        }

        private void 출근기록보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem selectedItem = listViewEmp.SelectedItems[0];

                EmployeeInfo emp = new EmployeeInfo();
                emp.num = Convert.ToInt32(selectedItem.Text);
                emp.name = selectedItem.SubItems[1].Text;
                emp.age = Convert.ToInt32(selectedItem.SubItems[2].Text);
                emp.address = selectedItem.SubItems[3].Text;
                emp.gender = selectedItem.SubItems[4].Text;
                emp.dpt = selectedItem.SubItems[5].Text;
                emp.pos = selectedItem.SubItems[6].Text;
                emp.phone_num = selectedItem.SubItems[7].Text;
                emp.join = selectedItem.SubItems[8].Text;

                FormAttendance form = new FormAttendance();
                form.empInfo2 = emp;
                form.ShowDialog();
            }
            catch
            {

            }
        }
    }
}
