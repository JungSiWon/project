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
    public partial class Message_Write_Form : Form
    {
        List<DBS.Department> m_dpt_list;
        List<DBS.Employee> m_em_list;
        public Message_Write_Form()
        {
            InitializeComponent();
            h_dpt_set();
            h_label();
        }
        public void h_start()
        {
            
        }
        public void h_label()
        {
            string sendername = DBS.Employee.find_num(Client.Client.Get.connect_employee.m_num).m_name;
            string recivername;
            if(comboBoxEmployee.SelectedIndex>=0)
            {
                recivername = m_em_list[comboBoxEmployee.SelectedIndex].m_name;
            }
            else
            {
                recivername = "";
            }
            labelSender.Text = string.Format("보내는 사람 : {0}", sendername);
            labelReciver.Text = string.Format("받는 사람 : {0}", recivername);
        }
        public void h_dpt_set()
        {
            m_dpt_list = DBS.Department.list;
            foreach(DBS.Department e in m_dpt_list)
            {
                comboBoxDepartment.Items.Add(e.m_name);
            }
        }
        public void h_em_set(int dpt_num)
        {
            comboBoxEmployee.SelectedIndex = -1;
            m_em_list = DBS.Employee.find_dpt_num(dpt_num);
            comboBoxEmployee.Items.Clear();
            foreach(DBS.Employee e in m_em_list)
            {
                string em_info = string.Format("{0} {1} {2}", e.m_age, e.m_gender, e.m_name);
                comboBoxEmployee.Items.Add(em_info);
            }
        }
        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dpt_num = m_dpt_list[comboBoxDepartment.SelectedIndex].m_num;
            h_em_set(dpt_num);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DBS.Message message = new DBS.Message();
            if(comboBoxEmployee.SelectedIndex<0)
            {
                MessageBox.Show("보낼사람을 선택하세요");
                return;
            }
            if(textBoxTitle.Text == "")
            {
                MessageBox.Show("제목을 입력하세요");
                return;
            }
            if(textBoxContents.Text =="")
            {
                MessageBox.Show("내용을 입력하세요");
                return;
            }
            int receiver_num = m_em_list[comboBoxEmployee.SelectedIndex].m_num;
            message.m_receiver_em_num = receiver_num;
            message.m_sender_em_num = Client.Client.Get.connect_employee.m_num;
            message.m_content = textBoxContents.Text;
            message.m_title = textBoxTitle.Text;
            message.h_save();
            MessageBox.Show("메세지를 보냇습니다");
            string txt = string.Format("MESS&{0}&{1}", receiver_num, Client.Client.Get.connect_employee.m_name);
            Client.Client.Get.PushLog(txt);
            this.Close();
        }

        private void comboBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            h_label();
        }
    }
}
