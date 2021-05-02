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
    public partial class FormUpdateEmpInfo : Form
    {
        private MySqlConnection conn = new MySqlConnection("Server=49.50.174.201;Database=oracle2;Uid=oracle2;Pwd=oracle2;Charset=utf8;Allow User Variables=true;");
        public EmployeeInfo empInfo { get; set; }

        private Dictionary<string, int> dpt_dic = new Dictionary<string, int>();
        private Dictionary<string, int> pos_dic = new Dictionary<string, int>();

        public FormUpdateEmpInfo()
        {
            InitializeComponent();

            initComboboxItems();
        }

        private void applyReceivedData()
        {
            string address = empInfo.address;
            var adr = address.Split('^');

            try
            {
                labelEmpNum.Text = empInfo.num.ToString();
                textBoxEmpName.Text = empInfo.name;
                textBoxEmpAge.Text = empInfo.age.ToString();
                textBoxEmpAdr.Text = adr[0];
                textBoxEmpDetailAdr.Text = adr[1];
                textBoxEmpZoneCode.Text = adr[2];
                comboBoxEmpGender.SelectedItem = empInfo.gender;
                comboBoxEmpDpt.SelectedIndex = comboBoxEmpDpt.Items.IndexOf(empInfo.dpt);
                comboBoxEmpPos.SelectedIndex = comboBoxEmpPos.Items.IndexOf(empInfo.pos);
                textBoxEmpPhone.Text = empInfo.phone_num;
                dateTimePickerEmpJoin.Value = DateTime.Parse(empInfo.join);
            }
            catch
            {
                labelEmpNum.Text = empInfo.num.ToString();
                textBoxEmpName.Text = empInfo.name;
                textBoxEmpAge.Text = empInfo.age.ToString();
                textBoxEmpAdr.Text = empInfo.address;
                comboBoxEmpGender.SelectedItem = empInfo.gender;
                comboBoxEmpDpt.SelectedIndex = comboBoxEmpDpt.Items.IndexOf(empInfo.dpt);
                comboBoxEmpPos.SelectedIndex = comboBoxEmpPos.Items.IndexOf(empInfo.pos);
                textBoxEmpPhone.Text = empInfo.phone_num;
                dateTimePickerEmpJoin.Value = DateTime.Parse(empInfo.join);
            }
        }

        private void initComboboxItems()
        {
            conn.Open();

            #region 부서 아이템 추가
            string query = "select num, name from department;";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBoxEmpDpt.Items.Add(dr["name"].ToString());
                dpt_dic.Add(dr["name"].ToString(), Convert.ToInt32(dr["num"]));
            }
            dr.Close();
            #endregion

            #region 직책 아이템 추가
            query = "select num, name from position;";
            cmd = new MySqlCommand(query, conn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBoxEmpPos.Items.Add(dr["name"].ToString());
                pos_dic.Add(dr["name"].ToString(), Convert.ToInt32(dr["num"]));
            }
            dr.Close();
            #endregion

            conn.Close();
        }

        private void FormUpsertEmployeeInfo_Load(object sender, EventArgs e)
        {
            applyReceivedData();
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
                if (comboBoxEmpPos.SelectedItem.ToString().Equals("부장"))
                {
                    conn.Open();

                    string query = "SELECT * FROM employee WHERE dpt_num=" + dpt_dic[comboBoxEmpDpt.SelectedItem.ToString()] + " AND pos_num=4;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        MessageBox.Show("해당 직책은 위임할 수 없습니다");
                        conn.Close();
                    }
                    else
                    {
                        conn.Close();
                        upsertEmpData();
                    }
                }
                else
                {
                    upsertEmpData();
                }
            }
        }

        private void upsertEmpData()
        {
            conn.Open();

            string address = textBoxEmpAdr.Text + "^" + textBoxEmpDetailAdr.Text + "^" + textBoxEmpZoneCode.Text;
            string query = "UPDATE employee SET " +
                "name='" + textBoxEmpName.Text + "', " +
                "age=" + textBoxEmpAge.Text + ", " +
                "address='" + address + "', " +
                "gender='" + comboBoxEmpGender.SelectedItem.ToString() + "', " +
                "dpt_num=" + dpt_dic[comboBoxEmpDpt.SelectedItem.ToString()] + ", " +
                "pos_num=" + pos_dic[comboBoxEmpPos.SelectedItem.ToString()] + ", " +
                "phone_num='" + textBoxEmpPhone.Text + "', " +
                "`join`='" + dateTimePickerEmpJoin.Value.ToString("yyyy-MM-dd") + "' " +
                "WHERE num=" + labelEmpNum.Text + ";";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

            this.Close();
        }
    }
}
