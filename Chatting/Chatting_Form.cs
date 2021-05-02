using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Programming.Chatting
{
    public partial class Chatting_Form : Form
    {
        public Chatting_Form()
        {
            InitializeComponent();
            Client.Client.Get.Chatting = this;
            
            string txt = string.Format("CHAT&{0} 님이 입장하셨습니다", Client.Client.Get.connect_employee.m_name);
            Client.Client.Get.PushLog(txt);
        }
        public void Chat_Message(string txt)
        {
            textBox_Log.Text += txt + "\r\n";
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            if (textBox_Send_Message.Text != "")
            {
                string txt = string.Format("CHAT&{0} : {1}", Client.Client.Get.connect_employee.m_name, textBox_Send_Message.Text);
                Client.Client.Get.PushLog(txt);
                textBox_Send_Message.Text = "";
            }
        }

        private void Chatting_Form_FormClosing(object sender, FormClosingEventArgs e)
        {

            Client.Client.Get.Chatting = null;
            string txt = string.Format("CHAT&{0} 님이 퇴장하셨습니다", Client.Client.Get.connect_employee.m_name);
            Client.Client.Get.PushLog(txt);
        }
    }
}
