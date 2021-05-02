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
    public partial class FormAttendance : Form
    {
        public FormAttendance()
        {
            InitializeComponent();
            dateTimePickerDateIn.Value = DateTime.Now;
            dateTimePickerDateOut.Value = DateTime.Now;
            dateTimePickerTimeIn.Value = Convert.ToDateTime("09:00:00");
            dateTimePickerTimeOut.Value = Convert.ToDateTime("18:00:00");
            SetMyCustomFormat();
            dateTimePickerMonth.Value = DateTime.Now;

        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dateTimePickerMonth.Format = DateTimePickerFormat.Custom;
            dateTimePickerMonth.CustomFormat = "yyyy-MM";
        }
        public EmployeeInfo empInfo2 { get; set; }

        private void loadattendance()
        {
            string query = "SELECT date, `in`, `out` FROM attendance WHERE att_em_num = " + empInfo2.num.ToString() + " AND year(date) = '" + dateTimePickerMonth.Value.Year + "' AND month(date) = '" + dateTimePickerMonth.Value.Month + "' ORDER BY date;";
            MySqlConnection conn = new MySqlConnection("Server=49.50.174.201;Database=oracle2;Uid=oracle2;Pwd=oracle2;Charset=utf8;Allow User Variables=true;");
            conn.Open();
            MySqlDataAdapter adt = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adt.Fill(dt);

            listViewAtlog.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(DateTime.Parse(dr["date"].ToString()).ToString("yyyy-MM-dd"));
                item.SubItems.Add(dr["in"].ToString());
                item.SubItems.Add(dr["out"].ToString());

                listViewAtlog.Items.Add(item);

            }
            listViewAtlog.EndUpdate();

        }

        private void buttonIn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server=49.50.174.201;Database=oracle2;Uid=oracle2;Pwd=oracle2;Charset=utf8;Allow User Variables=true;");
            conn.Open();
            string query = "UPDATE attendance SET `in`='" + dateTimePickerTimeIn.Value.ToString("HH:mm:ss") + "' WHERE date ='" + dateTimePickerDateIn.Value.ToString("yyyy-MM-dd") + "' AND att_em_num =" + empInfo2.num.ToString() + ";";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server=49.50.174.201;Database=oracle2;Uid=oracle2;Pwd=oracle2;Charset=utf8;Allow User Variables=true;");
            conn.Open();
            string query = "UPDATE attendance SET `out`='" + dateTimePickerTimeOut.Value.ToString("HH:mm:ss") + "' WHERE date ='" + dateTimePickerDateOut.Value.ToString("yyyy-MM-dd") + "' AND att_em_num =" + empInfo2.num.ToString() + ";";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void listViewAtlog_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = listViewAtlog.SelectedItems[0];
            dateTimePickerDateIn.Value = Convert.ToDateTime(item.Text);
            dateTimePickerDateOut.Value = Convert.ToDateTime(item.Text);
            dateTimePickerTimeIn.Value = Convert.ToDateTime(item.SubItems[1].Text);
            dateTimePickerTimeOut.Value = Convert.ToDateTime(item.SubItems[2].Text);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            loadattendance();
        }
    }
}
