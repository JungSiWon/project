using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ERP_Programming
{
    public partial class FormMain : Form
    {
        employeeInfo employee = new employeeInfo();
        bool is_LoadedLC = false;
        bool is_LoadedMC = false;
        string settingName = "autoLoad.set";
        string basicQuery = $"SELECT work.num, work.work_em_num, employee.name, work.large, work.medium, work.small, work.start_time, work.end_time, work.date, work.comment " +
                            $"FROM work LEFT JOIN employee ON work.work_em_num = employee.num";

        DataTable LargeTable;
        DataTable MediumTable;
        DataTable SmallTable;

        public FormMain()
        {
            InitializeComponent();
            InitVariables();
            Client.Client client = new Client.Client();
            client.Show();
        }

        private void InitVariables()
        {
            employee.Init();
            AccountInfoSet();
            ComboBoxSet();
            ListViewSet();
            ListView_Fill(basicQuery);
            FillCategory();
            FillLCComboBox();
        }

        private void AccountInfoSet()
        {
            labelAccountName.Text = "이름 : " + employee.name;
            switch (employee.dpt_num)
            {
                case 0:
                    labelDpt.Text = "부서 : 미배정";
                    break;
                case 1:
                    labelDpt.Text = "부서 : 인사";
                    break;
                case 2:
                    labelDpt.Text = "부서 : 기획";
                    break;
                case 3:
                    labelDpt.Text = "부서 : 영업";
                    break;
            }
            switch (employee.pos_num)
            {
                case 1:
                    labelPos.Text = "직책 : 주임";
                    break;
                case 2:
                    labelPos.Text = "직책 : 대리";
                    break;
                case 3:
                    labelPos.Text = "직책 : 차장";
                    break;
                case 4:
                    labelPos.Text = "직책 : 부장";
                    break;
            }
        }

        private void ComboBoxSet()
        {
            comboBoxLargeCategory.Items.Clear();
            comboBoxSearch.Items.Clear();

            comboBoxSearch.Items.Add("본인업무");
            comboBoxSearch.Items.Add("날짜");
            comboBoxSearch.Items.Add("업무 키워드");
            comboBoxSearch.Items.Add("작성자");
            comboBoxSearch.SelectedIndex = 0;

            string[] hour = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" };
            string[] minute = { "00", "30" };
            comboBoxStart_h.Items.AddRange(hour);
            comboBoxStart_h.SelectedIndex = 0;
            comboBoxEnd_h.Items.AddRange(hour);
            comboBoxEnd_h.SelectedIndex = 0;
            comboBoxStart_m.Items.AddRange(minute);
            comboBoxStart_m.SelectedIndex = 0;
            comboBoxEnd_m.Items.AddRange(minute);
            comboBoxEnd_m.SelectedIndex = 0;
        }

        private void FillCategory()
        {
            LargeTable = new DataTable();
            LargeTable.Clear();
            LargeTable.Columns.Add(new DataColumn("num", typeof(int)));
            LargeTable.Columns.Add(new DataColumn("name", typeof(string)));

            string query = $"SELECT * FROM large_category";
            DataSet ds = WorkDB.Instance.DataAdapter_Fill(query);
            foreach (DataRow dsRow in ds.Tables[0].Rows)
            {
                DataRow LCRow = LargeTable.NewRow();
                LCRow["num"] = dsRow["num"];
                LCRow["name"] = dsRow["name"];
                LargeTable.Rows.Add(LCRow);
            }

            MediumTable = new DataTable();
            MediumTable.Clear();
            MediumTable.Columns.Add(new DataColumn("num", typeof(int)));
            MediumTable.Columns.Add(new DataColumn("name", typeof(string)));
            MediumTable.Columns.Add(new DataColumn("large_num", typeof(int)));

            ds.Clear();
            query = $"SELECT * FROM medium_category";
            ds = WorkDB.Instance.DataAdapter_Fill(query);
            foreach (DataRow dsRow in ds.Tables[0].Rows)
            {
                DataRow MCRow = MediumTable.NewRow();
                MCRow["num"] = dsRow["num"];
                MCRow["name"] = dsRow["name"];
                MCRow["large_num"] = dsRow["large_num"];
                MediumTable.Rows.Add(MCRow);
            }

            SmallTable = new DataTable();
            SmallTable.Clear();
            SmallTable.Columns.Add(new DataColumn("num", typeof(int)));
            SmallTable.Columns.Add(new DataColumn("name", typeof(string)));
            SmallTable.Columns.Add(new DataColumn("medium_num", typeof(int)));

            ds.Clear();
            query = $"SELECT * FROM small_category";
            ds = WorkDB.Instance.DataAdapter_Fill(query);
            foreach (DataRow dsRow in ds.Tables[0].Rows)
            {
                DataRow SCRow = SmallTable.NewRow();
                SCRow["num"] = dsRow["num"];
                SCRow["name"] = dsRow["name"];
                SCRow["medium_num"] = dsRow["medium_num"];
                SmallTable.Rows.Add(SCRow);
            }
        }

        private void FillLCComboBox()
        {
            comboBoxLargeCategory.DataSource = LargeTable;
            comboBoxLargeCategory.DisplayMember = "name";
            comboBoxLargeCategory.ValueMember = "num";
            is_LoadedLC = true;
            FillMCComboBox();
        }

        private void FillMCComboBox()
        {
            if (!is_LoadedLC)
                return;
            DataTable Medium = new DataTable();
            Medium.Clear();
            Medium.Columns.Add(new DataColumn("num", typeof(int)));
            Medium.Columns.Add(new DataColumn("name", typeof(string)));
            Medium.Columns.Add(new DataColumn("large_num", typeof(int)));
            DataRow[] arrRows = null;
            arrRows = MediumTable.Select($"large_num='{comboBoxLargeCategory.SelectedValue}'");
            for (int i = 0; i < arrRows.Length; i++)
            {
                DataRow MCRow = Medium.NewRow();
                MCRow["num"] = arrRows[i]["num"];
                MCRow["name"] = arrRows[i]["name"];
                MCRow["large_num"] = arrRows[i]["large_num"];
                Medium.Rows.Add(MCRow);
            }
            comboBoxMediumCategory.DataSource = Medium;
            comboBoxMediumCategory.DisplayMember = "name";
            comboBoxMediumCategory.ValueMember = "num";
            is_LoadedMC = true;
            FillSCComboBox();
        }

        private void FillSCComboBox()
        {
            if (!is_LoadedMC)
                return;
            DataTable Small = new DataTable();
            Small.Clear();
            Small.Columns.Add(new DataColumn("num", typeof(int)));
            Small.Columns.Add(new DataColumn("name", typeof(string)));
            Small.Columns.Add(new DataColumn("medium_num", typeof(int)));
            DataRow[] arrRows = null;
            arrRows = SmallTable.Select($"medium_num='{comboBoxMediumCategory.SelectedValue}'");
            for (int i = 0; i < arrRows.Length; i++)
            {
                DataRow SCRow = Small.NewRow();
                SCRow["num"] = arrRows[i]["num"];
                SCRow["name"] = arrRows[i]["name"];
                SCRow["medium_num"] = arrRows[i]["medium_num"];
                Small.Rows.Add(SCRow);
            }
            comboBoxSmallCategory.DataSource = Small;
            comboBoxSmallCategory.DisplayMember = "name";
            comboBoxSmallCategory.ValueMember = "num";
        }

        private void comboBoxLargeCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillMCComboBox();
        }

        private void comboBoxMiddleLCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSCComboBox();
        }

        private void ListViewSet()
        {
            listViewWork.Clear();
            listViewWork.View = View.Details;

            listViewWork.BeginUpdate();

            string[] columns = { "번호", "업무자번호", "업무자", "대분류", "중분류", "소분류", "시작시간", "끝시간", "날짜", "코멘트" };
            for (int i = 0; i < columns.Length; i++)
            {
                listViewWork.Columns.Add(columns[i]);
                listViewWork.Columns[i].Width = -2;
            }
            listViewWork.Columns[1].Width = 0;

            listViewWork.EndUpdate();
        }

        private void ListView_Fill(string query)
        {
            listViewWork.Items.Clear();
            DataSet ds = WorkDB.Instance.DataAdapter_Fill(query);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                ListViewItem lvi = new ListViewItem(row["num"].ToString());
                lvi.SubItems.Add(row["work_em_num"].ToString());
                lvi.SubItems.Add(row["name"].ToString());
                lvi.SubItems.Add(row["large"].ToString());
                lvi.SubItems.Add(row["medium"].ToString());
                lvi.SubItems.Add(row["small"].ToString());
                lvi.SubItems.Add((row["start_time"].ToString()).Substring(0, 5));
                lvi.SubItems.Add((row["end_time"].ToString()).Substring(0, 5));
                lvi.SubItems.Add((row["date"].ToString()).Substring(0, 10));
                lvi.SubItems.Add(row["comment"].ToString());
                listViewWork.Items.Add(lvi);
            }
        }

        private void buttonMessage_Click(object sender, EventArgs e)
        {
            Message_Main_Form form = new Message_Main_Form();
            form.Show();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string LC = (string)comboBoxLargeCategory.Text;
            string MC = (string)comboBoxMediumCategory.Text;
            string SC = (string)comboBoxSmallCategory.Text;
            string comment = textBoxTaskComment.Text;
            string startTime = comboBoxStart_h.SelectedItem.ToString() + ':' + comboBoxStart_m.SelectedItem.ToString();
            string endTime = comboBoxEnd_h.SelectedItem.ToString() + ':' + comboBoxEnd_m.SelectedItem.ToString();
            string date = dateTimePickerWorkDate.Value.ToString("yyyy-MM-dd");

            if (TimeCheak(date, startTime, endTime))
            {
                MessageBox.Show("겹치는 시간이 있습니다.");
            }
            else
            {
                WorkDB.Instance.Execute_NonQuery(
                    $"INSERT INTO work(work_em_num, large, medium, small, start_time, end_time, date, comment) " +
                    $"VALUES ('{employee.num}', '{LC}', '{MC}', '{SC}', '{startTime}', '{endTime}', '{date}', '{comment}')");
            }
            ListView_Fill(basicQuery);
        }

        private bool TimeCheak(string date, string startTime, string endTime)
        {
            string query = $"SELECT * FROM work WHERE date = '{date}' AND work_em_num = '{employee.num}' AND " +
                $"((start_time < '{startTime}' AND end_time > '{startTime}') OR (start_time < '{endTime}' AND end_time > '{endTime}'))";
            DataSet ds = WorkDB.Instance.DataAdapter_Fill(query);

            if (ds.Tables[0].Rows.Count != 0)
                return true;

            return false;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string query = "";
            string searchTerm = textBoxSearch.Text;
            switch(comboBoxSearch.SelectedIndex)
            {
                case 0:
                    query = basicQuery +
                        $" WHERE work.work_em_num = '{employee.num}'";
                    break;
                case 1:
                    query = basicQuery + 
                        $" WHERE date LIKE '%{searchTerm}%'";
                    break;
                case 2:
                    query = basicQuery + 
                        $" WHERE large LIKE '%{searchTerm}%' OR medium LIKE '%{searchTerm}%' OR small LIKE '%{searchTerm}%'";
                    break;
                case 3:
                    query = basicQuery + 
                            $" WHERE employee.name = '{searchTerm}'";
                    break;
            }
            ListView_Fill(query);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ListView_Fill(basicQuery);
        }

        private void 업무마스터ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (employee.pos_num == 4)
            {
                FormWorkMaster showFormWorkMaster = new FormWorkMaster();
                showFormWorkMaster.ShowDialog();
            }
            else
            {
                MessageBox.Show("접근할 수 없습니다");
            }
        }

        private void 인사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (employee.dpt_num == 1)
            {
                FormPersonnel form = new FormPersonnel();
                form.Show();
            }
            else
            {
                MessageBox.Show("접근할 수 없습니다");
            }
        }

        private void 결제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginManager.GetInstance().acc_num = employee.num;

            Payment form = new Payment();
            form.Show();
        }

        private void 사원채팅방ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chatting.Chatting_Form form = new Chatting.Chatting_Form();
            form.Show();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Client.Client.Get.Close();
        }

        private void workout()
        {
            DataRow dr = WorkDB.Instance.LoadData();

            MySqlConnection conn = new MySqlConnection("Server=49.50.174.201;Database=oracle2;Uid=oracle2;Pwd=oracle2;Charset=utf8");
            conn.Open();

            bool holiday = false;
            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday || DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
            {
                holiday = true;
            }

            string query = "UPDATE attendance SET `out` = '" + DateTime.Now.ToString("HH:mm:ss") + "' WHERE att_em_num = " + dr["num"] + " AND date = '" + DateTime.Now.ToString("yyyy-MM-dd") + "';";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            workout();
            Client.Client.Get.h_Close();

            this.Close();
        }

        private void listViewWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] columns = { "번호", "업무자번호", "업무자", "대분류", "중분류", "소분류", "시작시간", "끝시간", "날짜", "코멘트" };

            int index = listViewWork.FocusedItem.Index;

            string large_category = listViewWork.Items[index].SubItems[3].Text;
            string medium_category = listViewWork.Items[index].SubItems[4].Text;
            string small_category = listViewWork.Items[index].SubItems[5].Text;
            DateTime date = Convert.ToDateTime(listViewWork.Items[index].SubItems[8].Text);
            int start_time_h = Convert.ToInt32((listViewWork.Items[index].SubItems[6].Text).Substring(0, 2));
            int start_time_m = Convert.ToInt32((listViewWork.Items[index].SubItems[6].Text).Substring(3, 2));
            int end_time_h = Convert.ToInt32((listViewWork.Items[index].SubItems[7].Text).Substring(0, 2));
            int end_time_m = Convert.ToInt32((listViewWork.Items[index].SubItems[7].Text).Substring(3, 2));
            string comment = listViewWork.Items[index].SubItems[9].Text;

            dateTimePickerWorkDate.Value = date;

            comboBoxStart_h.SelectedIndex = start_time_h - 1;
            comboBoxEnd_h.SelectedIndex = end_time_h - 1;
            if (start_time_m == 0)
                comboBoxStart_m.SelectedIndex = 0;
            else
                comboBoxStart_m.SelectedIndex = 1;
            if (end_time_m == 0)
                comboBoxEnd_m.SelectedIndex = 0;
            else
                comboBoxEnd_m.SelectedIndex = 1;

            for(int i = 0; i < comboBoxLargeCategory.Items.Count; i++)
            {
                comboBoxLargeCategory.SelectedIndex = i;
                if (comboBoxLargeCategory.Text == large_category)
                    break;
            }

            for (int i = 0; i < comboBoxMediumCategory.Items.Count; i++)
            {
                comboBoxMediumCategory.SelectedIndex = i;
                if (comboBoxMediumCategory.Text == medium_category)
                    break;
            }

            for (int i = 0; i < comboBoxSmallCategory.Items.Count; i++)
            {
                comboBoxSmallCategory.SelectedIndex = i;
                if (comboBoxSmallCategory.Text == small_category)
                    break;
            }

            textBoxTaskComment.Text = comment;
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            int index ;
            try
            {
                index = listViewWork.FocusedItem.Index;
            }
            catch
            {
                MessageBox.Show("수정할 업무를 선택해주세요.");
                return;
            }
            int work_em_num = Convert.ToInt32(listViewWork.Items[index].SubItems[1].Text);
            int num = Convert.ToInt32(listViewWork.Items[index].SubItems[0].Text);

            string LC = (string)comboBoxLargeCategory.Text;
            string MC = (string)comboBoxMediumCategory.Text;
            string SC = (string)comboBoxSmallCategory.Text;
            string comment = textBoxTaskComment.Text;
            string startTime = comboBoxStart_h.SelectedItem.ToString() + ':' + comboBoxStart_m.SelectedItem.ToString();
            string endTime = comboBoxEnd_h.SelectedItem.ToString() + ':' + comboBoxEnd_m.SelectedItem.ToString();
            string date = dateTimePickerWorkDate.Value.ToString("yyyy-MM-dd");

            if (work_em_num != employee.num)
            {
                MessageBox.Show("본인의 업무만 수정할 수 있습니다.");
                return;
            }

            if (TimeCheak(date, startTime, endTime))
            {
                MessageBox.Show("겹치는 시간이 있습니다.");
                return;
            }

            WorkDB.Instance.Execute_NonQuery(
                $"UPDATE work " +
                $"SET large = '{LC}', medium = '{MC}', small = '{SC}', start_time = '{startTime}', end_time = '{endTime}', date = '{date}', comment = '{comment}' " +
                $"WHERE num = '{num}'");

            ListView_Fill(basicQuery);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index;
            try
            {
                index = listViewWork.FocusedItem.Index;
            }
            catch
            {
                MessageBox.Show("삭제할 업무를 선택해주세요.");
                return;
            }
            int work_em_num = Convert.ToInt32(listViewWork.Items[index].SubItems[1].Text);
            int num = Convert.ToInt32(listViewWork.Items[index].SubItems[0].Text);

            if (work_em_num != employee.num)
            {
                MessageBox.Show("본인의 업무만 삭제할 수 있습니다.");
                return;
            }

            string query = $"DELETE FROM work " +
                $"WHERE num = '{num}'";
            WorkDB.Instance.Execute_NonQuery(query);

            ListView_Fill(basicQuery);
        }
    }
}
