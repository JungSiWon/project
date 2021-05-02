using MySql.Data.MySqlClient;
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

namespace ERP_Programming
{
    
    public partial class Payment : Form
    {
        private NewPayment N;
        public Payment()
        {
            InitializeComponent();
            InitValue();
            Listview();
            TimePickerChange();
            Combo_small();
            Payagree_person1();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                N.AddPayment(textBoxPaymentName.Text, textBoxPaymentContent.Text, textBoxComment.Text, comboBoxPerson1.Text, comboBoxPerson2.Text, comboBoxRelationTask.Text);
                MessageBox.Show("등록되었습니다.");
            }
            catch(Exception)
            {
                MessageBox.Show("등록실패");
            } 
        }
        public void InitValue()//초기화함수
        {
            N = new NewPayment(dateTimePicker1);
            groupBox4.Visible = false;
            textBoxSearchName.Text = "";
            textBoxCompanion.Text = "";
            comboBoxRelationTask.Items.Clear();
            comboBoxPerson1.Items.Clear();
        }
        private void Listview()
        {

            listViewPayment.BeginUpdate();
            listViewPayment.View = View.Details;

            for(int i=0;i<N.Count();i++)//행을 다돌도록 반복
            {
                ListViewItem newitem = new ListViewItem(N.PaymentQuery1(i));
                newitem.SubItems.Add(N.PaymentQuery2(i));
                newitem.SubItems.Add(N.PaymentQuery3(i));
                newitem.SubItems.Add(N.PaymentQuery4(i));

                listViewPayment.Items.Add(newitem);
            }
            listViewPayment.Columns.Add("결재 진행상황",300,HorizontalAlignment.Left);
            listViewPayment.Columns.Add("결재중", 300, HorizontalAlignment.Left);
            listViewPayment.Columns.Add("결재완료", 300, HorizontalAlignment.Left);
            listViewPayment.Columns.Add("결재 업무 리스트", 300, HorizontalAlignment.Left);

            listViewPayment.EndUpdate();
        }

        private void 검색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;

        }

        private void 검색종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = false;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM signlist WHERE num = " + textBoxSearchNum.Text + " AND register_em_num = "+LoginManager.GetInstance().acc_num+" OR num = " + textBoxSearchNum.Text + " AND first_em_num = " + LoginManager.GetInstance().acc_num + " OR num = " + textBoxSearchNum.Text + " AND fin_em_num = " + LoginManager.GetInstance().acc_num + "";
                MySqlDataReader rdr = DBManager.GetInstance().Select(query);
                rdr.Read();
                textBoxSearchContext.Text = rdr["content"].ToString();
                textBoxSearchName.Text = rdr["title"].ToString();
                rdr.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("결재num를 확인하고 결재num를 입력해 주세요");
            }
           
            if(textBoxSearchNum.Text=="")
            {
                MessageBox.Show("결재num를 입력하고 검색을 눌러주세요");
            }
        }
        public void TimePickerChange()
        {
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.CustomFormat = "hh:mm:ss";
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        }

        private void buttonAgree_Click(object sender, EventArgs e)
        {
            string query = "UPDATE signlist SET status = '1결재완료' WHERE first_em_num = "+ LoginManager.GetInstance().acc_num +" AND status='1결재중' AND num=" + textBoxNUM.Text + "";
           DBManager.GetInstance().DBquery(query);
           string query2 = "UPDATE signlist SET status = '최종결재완료' WHERE fin_em_num = "+ LoginManager.GetInstance().acc_num +" AND status='1결재완료' AND num=" + textBoxNUM.Text + "";
           DBManager.GetInstance().DBquery(query2);
            
            
            N.TimeCheck(Convert.ToInt32(textBoxNUM.Text));
            MessageBox.Show("승인되었습니다.");
        }

        private void buttoncompanion_Click(object sender, EventArgs e)
        {

            string query = "UPDATE signlist SET status = '반려',note = '"+ textBoxCompanion.Text+ "' WHERE first_em_num = " + LoginManager.GetInstance().acc_num + " AND status='1결재중' AND num=" + textBoxNUM.Text + " OR fin_em_num = " + LoginManager.GetInstance().acc_num + " AND status='1결재완료' AND num=" + textBoxNUM.Text + "";
            DBManager.GetInstance().DBquery(query);
            MessageBox.Show("반려되었습니다.");
            /*string query2 = "INSERT INTO approval(note) VALUES('" +textBoxCompanion.Text+"')";
            DBManager.GetInstance().DBquery(query2);*/
        }
        private void Combo_small()//소분류 항목 동적 적용
        {
            comboBoxRelationTask.Items.AddRange(N.Small_category());
        }

        private void Payagree_person1()
        {
            List<string> list = new List<string>();
            list.Clear();
            if (N.dpt_num()!=0)
            {
                if( N.pos_num()==4)
                {
                    string query3 = "SELECT name FROM employee WHERE  pos_num = " + (N.pos_num() + 1) + "";
                    MySqlDataReader rdr3 = DBManager.GetInstance().Select(query3);
                    while (rdr3.Read())
                    {
                        list.Add(rdr3["name"].ToString());
                    }
                    string[] array3 = list.ToArray();
                    comboBoxPerson1.Items.AddRange(array3);
                    rdr3.Close();
                    list.Clear();
                }
               string query = "SELECT name FROM employee WHERE dpt_num = " + N.dpt_num() + " AND pos_num = " + (N.pos_num()+1) + "";
               MySqlDataReader rdr = DBManager.GetInstance().Select(query);
               while(rdr.Read())
                {
                    list.Add(rdr["name"].ToString());
                }
                string[] array = list.ToArray();
                comboBoxPerson1.Items.AddRange(array);
                rdr.Close();
                list.Clear();
                string query2 = "SELECT name FROM employee WHERE dpt_num = " + N.dpt_num() + " AND pos_num > " + (N.pos_num()+1) + "";
                MySqlDataReader rdr2 = DBManager.GetInstance().Select(query2);
                while (rdr2.Read())
                {
                    list.Add(rdr2["name"].ToString());
                }
                string[] array2 = list.ToArray();
                comboBoxPerson2.Items.AddRange(array2);
                rdr2.Close();
            }
            else if(N.dpt_num()==0)
            {
                if (N.pos_num() == 4)
                {
                    string query = "SELECT name FROM employee WHERE  pos_num = 5";
                    MySqlDataReader rdr = DBManager.GetInstance().Select(query);
                    rdr.Read();

                    comboBoxPerson1.Items.Add(rdr["name"].ToString());
                    comboBoxPerson2.Items.Add(rdr["name"].ToString());
                    rdr.Close();
                }
                else
                {
                    string query = "SELECT name FROM employee WHERE pos_num > " + N.pos_num() + " AND pos_num < 5";
                    MySqlDataReader rdr = DBManager.GetInstance().Select(query);
                    while (rdr.Read())
                    {
                        list.Add(rdr["name"].ToString());
                    }
                    string[] array = list.ToArray();
                    comboBoxPerson1.Items.AddRange(array);
                    comboBoxPerson2.Items.AddRange(array);
                    rdr.Close();
                }
                
            }
            else if(N.dpt_num()==4)
            {
                string query = "SELECT name FROM employee WHERE pos_num = 5";
                MySqlDataReader rdr = DBManager.GetInstance().Select(query);
                rdr.Read();
                comboBoxPerson1.Items.Add(rdr["name"].ToString());
                comboBoxPerson2.Items.Add(rdr["name"].ToString());
                rdr.Close();
            }
        }
    }
}
