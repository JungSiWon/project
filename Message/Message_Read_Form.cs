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
    public partial class Message_Read_Form : Form
    {
        DBS.Message reading_message;
        public Message_Read_Form(int message_num)
        {
            InitializeComponent();
            reading_message = DBS.Message.find_num(message_num);
            h_load();
            reading_message.check();
        }
        public void h_load()
        {
            textBoxTilte.Text = reading_message.m_title;
            textBoxContents.Text = reading_message.m_content;
            DBS.Employee sender = DBS.Employee.find_num(reading_message.m_sender_em_num);
            DBS.Department depart = DBS.Department.find_num(sender.m_dpt_num);
            DBS.Position position = DBS.Position.find_num(sender.m_pos_num);
            string senderinfo = string.Format("부서:{0} 직책:{1} {2} {3} {4}",depart.m_name,position.m_name, sender.m_age, sender.m_gender, sender.m_name);
            textBoxSender.Text = senderinfo;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Message_Write_Form form = new Message_Write_Form();
            form.Show();
            this.Close();
        }
    }
}
