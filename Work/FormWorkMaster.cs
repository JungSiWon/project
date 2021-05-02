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
    public partial class FormWorkMaster : Form
    {
        public FormWorkMaster()
        {
            InitializeComponent();
        }

        DataTable LargeTable;  
        DataTable MediumTable;

        public class LargeCategory
        {
            public int num { get; set; }
            public string name { get; set; }
        }

        public class MediumCategory
        {
            public int num { get; set; }
            public string name { get; set; }
            public int LC_num { get; set; }
        }

        bool smallSelect = false;

        private void FormWorkMaster_Load(object sender, EventArgs e)
        {
            InitVariables();
        }

        private void InitVariables()
        {
            FillCategory();
            ComboBoxSet();
            ListViewSet();
            ListView_Fill();
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
        }

        private void ComboBoxSet()
        {
            comboBoxCTGRLocation.Items.Clear();
            string[] value = { "대분류", "중분류", "소분류" };
            comboBoxCTGRLocation.Items.AddRange(value);
        }

        private void ListViewSet()
        {
            listViewCategory.Clear();
            listViewCategory.View = View.Details;

            listViewCategory.BeginUpdate();

            string[] columns = { "분류", "번호", "이름", "대분류번호", "중분류번호" };
            for (int i = 0; i < columns.Length; i++)
            {
                listViewCategory.Columns.Add(columns[i]);
                listViewCategory.Columns[i].Width = -2;
            }

            listViewCategory.EndUpdate();
        }

        private void ListView_Fill()
        {
            listViewCategory.Items.Clear();

            DataTable allCategory = new DataTable();
            string query = $"SELECT * FROM large_category";
            allCategory = WorkDB.Instance.DataAdapter_Fill(query).Tables[0];
            query = $"SELECT * FROM medium_category";
            allCategory.Merge(WorkDB.Instance.DataAdapter_Fill(query).Tables[0]);
            query = $"SELECT * FROM small_category";
            allCategory.Merge(WorkDB.Instance.DataAdapter_Fill(query).Tables[0]);
            
            foreach (DataRow row in allCategory.Rows)
            {
                ListViewItem lvi;
                if (row["large_num"] == DBNull.Value && row["medium_num"] == DBNull.Value)
                {
                    lvi = new ListViewItem("대분류");
                }
                else if(row["large_num"] != DBNull.Value && row["medium_num"] == DBNull.Value)
                {
                    lvi = new ListViewItem("중분류");
                }
                else
                {
                    lvi = new ListViewItem("소분류");
                }

                lvi.SubItems.Add(row["num"].ToString());
                lvi.SubItems.Add(row["name"].ToString());
                lvi.SubItems.Add(row["large_num"].ToString());
                lvi.SubItems.Add(row["medium_num"].ToString());
                listViewCategory.Items.Add(lvi);
            }
            for(int i = 0; i < listViewCategory.Columns.Count ; i++)
            {
                listViewCategory.Columns[i].Width = -2;
            }
        }

        private void FillLCComboBox()
        {
            comboBoxLC.DataSource = LargeTable;
            comboBoxLC.DisplayMember = "name";
            comboBoxLC.ValueMember = "num";
        }

        private void FillMCComboBox()
        {
            DataTable Medium = new DataTable();
            Medium.Clear();
            Medium.Columns.Add(new DataColumn("num", typeof(int)));
            Medium.Columns.Add(new DataColumn("name", typeof(string)));
            Medium.Columns.Add(new DataColumn("large_num", typeof(int)));
            DataRow[] arrRows = null;
            arrRows = MediumTable.Select($"large_num='{comboBoxLC.SelectedValue}'");
            for (int i = 0; i < arrRows.Length; i++)
            {
                DataRow MCRow = Medium.NewRow();
                MCRow["num"] = arrRows[i]["num"];
                MCRow["name"] = arrRows[i]["name"];
                MCRow["large_num"] = arrRows[i]["large_num"];
                Medium.Rows.Add(MCRow);
            }
            comboBoxMC.DataSource = Medium;
            comboBoxMC.DisplayMember = "name";
            comboBoxMC.ValueMember = "num";
        }

        private void comboBoxCTGRLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = comboBoxCTGRLocation.SelectedIndex;
            switch(num)
            {
                case 0:
                    smallSelect = false;
                    comboBoxLC.DataSource = null;
                    comboBoxMC.DataSource = null;
                    break;
                case 1:
                    FillLCComboBox();
                    comboBoxMC.DataSource = null;
                    smallSelect = false;
                    break;
                case 2:
                    FillLCComboBox();
                    FillMCComboBox();
                    smallSelect = true;
                    break;
            }
        }

        private void comboBoxLC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (smallSelect)
            {
                FillMCComboBox();
            }
        }

        private void listViewCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listViewCategory.FocusedItem.Index;
            string category = listViewCategory.Items[index].SubItems[0].Text;
            if (category == "대분류")
            {
                comboBoxCTGRLocation.SelectedIndex = 0;
                comboBoxLC.DataSource = null;
                comboBoxMC.DataSource = null;
            }
            else if(category == "중분류")
            {
                comboBoxCTGRLocation.SelectedIndex = 1;
                FillLCComboBox();
                comboBoxMC.DataSource = null;
                string num = listViewCategory.Items[index].SubItems[3].Text;

                for (int i = 0; i < comboBoxLC.Items.Count; i++)
                {
                    comboBoxLC.SelectedIndex = i;
                    if (comboBoxLC.SelectedValue.ToString() == num)
                        break;
                }
            }
            else
            {
                comboBoxCTGRLocation.SelectedIndex = 2;
                FillLCComboBox();
                string LCnum = null;
                string MCnum = listViewCategory.Items[index].SubItems[4].Text;
                for (int i = 0; i < MediumTable.Rows.Count; i++)
                {
                    if (MediumTable.Rows[i]["num"].ToString() == MCnum)
                    {
                        LCnum = MediumTable.Rows[i]["large_num"].ToString();
                        break;
                    }
                }

                for (int i = 0; i < comboBoxLC.Items.Count; i++)
                {
                    comboBoxLC.SelectedIndex = i;
                    if (comboBoxLC.SelectedValue.ToString() == LCnum)
                        break;
                }

                FillMCComboBox();
                for (int i = 0; i < comboBoxMC.Items.Count; i++)
                {
                    comboBoxMC.SelectedIndex = i;
                    if (comboBoxMC.SelectedValue.ToString() == MCnum)
                        break;
                }

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listViewCategory.FocusedItem.Index != null)
            {
                int num = comboBoxCTGRLocation.SelectedIndex;
                string name = textBoxName.Text;
                switch (num)
                {
                    case 0:
                        if (name != "")
                        {
                            string query = $"INSERT INTO large_category(name) VALUES ('{name}')";
                            WorkDB.Instance.Execute_NonQuery(query);
                        }
                        else
                            MessageBox.Show("이름을 입력하세요");
                        break;
                    case 1:
                        if (name != "")
                        {
                            int large_num = Convert.ToInt32(comboBoxLC.SelectedValue);
                            string query = $"INSERT INTO medium_category(name, large_num) VALUES ('{name}', '{large_num}')";
                            WorkDB.Instance.Execute_NonQuery(query);
                        }
                        else
                            MessageBox.Show("이름을 입력하세요");
                        break;
                    case 2:
                        if (name != "")
                        {
                            int medium_num = Convert.ToInt32(comboBoxMC.SelectedValue);
                            string query = $"INSERT INTO small_category(name, medium_num) VALUES ('{name}', '{medium_num}')";
                            WorkDB.Instance.Execute_NonQuery(query);
                        }
                        else
                            MessageBox.Show("이름을 입력하세요");
                        break;
                }
                InitVariables();
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (listViewCategory.FocusedItem.Index != null)
            {
                int index = listViewCategory.FocusedItem.Index;

                string name = textBoxName.Text;
                int num = Convert.ToInt32(listViewCategory.Items[index].SubItems[1].Text);

                int i = comboBoxCTGRLocation.SelectedIndex;

                string query = "";
                switch (i)
                {
                    case 0:
                        if (name != "")
                        {
                            query = $"UPDATE large_category " +
                            $"SET name = '{name}' " +
                            $"WHERE num = '{num}'";
                            WorkDB.Instance.Execute_NonQuery(query);
                        }
                        else
                            MessageBox.Show("이름을 입력하세요");
                        break;

                    case 1:
                        if (name != "")
                        {
                            int large_num = Convert.ToInt32(comboBoxLC.SelectedValue);
                            query = $"UPDATE medium_category " +
                                $"SET name = '{name}', large_num = '{large_num}' " +
                                $"WHERE num = '{num}'";
                            WorkDB.Instance.Execute_NonQuery(query);
                        }
                        else
                            MessageBox.Show("이름을 입력하세요");
                        break;

                    case 2:
                        if (name != "")
                        {
                            int medium_num = Convert.ToInt32(comboBoxLC.SelectedValue);
                            query = $"UPDATE small_category " +
                                $"SET name = '{name}', medium_num = '{medium_num}' " +
                                $"WHERE num = '{num}'";
                            WorkDB.Instance.Execute_NonQuery(query);
                        }
                        else
                            MessageBox.Show("이름을 입력하세요");
                        break;
                }
                InitVariables();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewCategory.FocusedItem.Index != null)
            {
                int index = listViewCategory.FocusedItem.Index;
                int num = Convert.ToInt32(listViewCategory.Items[index].SubItems[1].Text);
                string category = listViewCategory.Items[index].SubItems[0].Text;

                int i;
                if (category == "대분류")
                    i = 0;
                else if (category == "중분류")
                    i = 1;
                else if (category == "소분류")
                    i = 2;
                else
                    return;

                string query = "";
                switch (i)
                {
                    case 0:
                        query = $"DELETE FROM large_category " +
                        $"WHERE num = '{num}'";
                        WorkDB.Instance.Execute_NonQuery(query);
                        break;
                    case 1:
                        query = $"DELETE FROM medium_category " +
                        $"WHERE num = '{num}'";
                        WorkDB.Instance.Execute_NonQuery(query);
                        break;
                    case 2:
                        query = $"DELETE FROM small_category " +
                        $"WHERE num = '{num}'";
                        WorkDB.Instance.Execute_NonQuery(query);
                        break;
                }
                InitVariables();
            }
        }
    }
}
