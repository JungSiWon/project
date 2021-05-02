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
    public partial class FormPaydoc : Form
    {

        public EmployeeInfo empInfo1 { get; set; }
        public FormPaydoc()
        {
            InitializeComponent();
            SetMyCustomFormat();
        }

        private int norm=0;
        private int extend=0;
        private int night=0;
        private int hol=0;
        private int total=0;


        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            dateTimePickerMonth.Format = DateTimePickerFormat.Custom;
            dateTimePickerMonth.CustomFormat = "yyyy-MM";
        }

        private void loadpay()
        {
            string query = "SELECT date, 정기근무, 연장근무, 야간근무, holiday, 총근무시간 FROM pay WHERE att_em_num = " + empInfo1.num.ToString() + " AND year(date) = '" + dateTimePickerMonth.Value.Year + "' AND month(date) = '" + dateTimePickerMonth.Value.Month + "' ORDER BY date;";
            MySqlConnection conn = new MySqlConnection("Server=49.50.174.201;Database=oracle2;Uid=oracle2;Pwd=oracle2;Charset=utf8;Allow User Variables=true;");
            conn.Open();
            MySqlDataAdapter adt = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adt.Fill(dt);

            listViewPay.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem item = new ListViewItem(DateTime.Parse(dr["date"].ToString()).ToString("yyyy-MM-dd"));
                if (Convert.ToBoolean(dr["holiday"]) == true)
                {
                    item.SubItems.Add("0");
                    item.SubItems.Add("0");
                    item.SubItems.Add("0");
                    item.SubItems.Add(dr["총근무시간"].ToString());
                }
                else
                {
                    item.SubItems.Add(dr["정기근무"].ToString());
                    item.SubItems.Add(dr["연장근무"].ToString());
                    item.SubItems.Add(dr["야간근무"].ToString());
                    item.SubItems.Add("0");
                }
                item.SubItems.Add(dr["총근무시간"].ToString());

                listViewPay.Items.Add(item);

                if (Convert.ToBoolean(dr["holiday"]) == true)
                {
                    hol += Convert.ToInt32(dr["총근무시간"]);
                    total += Convert.ToInt32(dr["총근무시간"]);
                }
                else
                {
                    norm += Convert.ToInt32(dr["정기근무"]);
                    extend += Convert.ToInt32(dr["연장근무"]);
                    night += Convert.ToInt32(dr["야간근무"]);
                    total += Convert.ToInt32(dr["총근무시간"]);
                }
            }
            ListViewItem item1 = new ListViewItem("계");
            item1.SubItems.Add(norm.ToString());
            item1.SubItems.Add(extend.ToString());
            item1.SubItems.Add(night.ToString());
            item1.SubItems.Add(hol.ToString());
            item1.SubItems.Add(total.ToString());

            listViewPay.Items.Add(item1);
            listViewPay.EndUpdate();

            loadpay1();
            loadDeduct();
        }


        private void loadpay1()
        {
            string[] kind = { "기본수당", "연장수당", "야간수당", "휴일수당"};
            double[] pay = { norm * 10000, extend * 10000 * 1.5, night * 10000 * 1.5, hol * 10000 * 1.5};
            listViewPay1.Items.Clear();

            for(int i=0; i < 4; i++)
            {
                ListViewItem item = new ListViewItem(kind[i]);
                item.SubItems.Add(string.Format("{0:#,0}", pay[i]));

                listViewPay1.Items.Add(item);
                listViewPay1.EndUpdate();
            }
            textBoxTotal.Text = string.Format("{0:#,0}", (norm * 10000 + extend * 10000 * 1.5 + night * 10000 * 1.5 + hol * 10000 * 1.5));
        }

        private void loadDeduct()
        {
            string[] kind = { "국민연금공제", "국민건강보험공제", "고용보험료공제" };
            double totalpay = norm * 10000 + extend * 10000 * 1.5 + night * 10000 * 1.5 + hol * 10000 * 1.5;
            double health = totalpay * 0.0667;
            double[] pay = { -totalpay * 0.045 , -health * 0.5, -totalpay * 0.008 };
            listViewDeduct.Items.Clear();
            double tax=0;
            for (int i=0; i < 3; i++)
            {
                ListViewItem item = new ListViewItem(kind[i]);
                item.SubItems.Add(string.Format("{0:#,0}", pay[i]));

                listViewDeduct.Items.Add(item);
                listViewDeduct.EndUpdate();
                tax += pay[i];
            }
            textBoxTax.Text = string.Format("{0:#,0}", tax);
            textBoxReal.Text = string.Format("{0:#,0}", (totalpay + tax));
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            norm = 0;
            extend = 0;
            night = 0;
            hol = 0;
            total = 0;

            loadpay();
        }
    }
}
