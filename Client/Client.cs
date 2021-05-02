using ERP_Programming.Chatting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Programming.Client
{
    delegate void Ctrl_Invoke(string txt);
    
    public partial class Client : Form
    {
        int PORT = 5555;
        string IP = "175.112.226.91";
        NetworkStream NS = null;
        StreamWriter SW = null;
        StreamReader SR = null;
        TcpClient client = null;
        Thread thread;
        public DBS.Employee connect_employee;

        static Client client_;

        private Message_Main_Form Message_value;
        private Chatting_Form Chatting_value;

        bool STOP = false;
        public Message_Main_Form Message { get { return Message_value; }
            set {
                Message_value = value;
            }
        }
        public Chatting_Form Chatting
        {
            get { return Chatting_value; }
            set
            {
                Chatting_value = value;
            }
        }
        public static Client Get { get { return client_; } }
        public Client()
        {
            InitializeComponent();
            client_ = this;
            DataRow row = WorkDB.Instance.LoadData();
            int num =(int)row["num"];
            connect_employee = DBS.Employee.find_num(num);
            thread = new Thread(h_client);
            thread.Start();

        }
        public void h_client()
        {
            try
            {
                client = new TcpClient(IP, PORT); //client 연결
                NS = client.GetStream(); // 소켓에서 메시지를 가져오는 스트림
                SW = new StreamWriter(NS, Encoding.UTF8); // Send message
                SR = new StreamReader(NS, Encoding.UTF8); // Get message
                try
                {
                    PushLog(string.Format("CONN&{0}", connect_employee.m_num));
                    while (client.Connected)
                    {
                        string GetMessage = string.Empty;
                        GetMessage = SR.ReadLine();
                        if (GetMessage != null)
                            initMessage(GetMessage);
                        if (STOP)
                            return;
                    }
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
                finally
                {
                    if (NS != null) NS.Close();
                    if (SW != null) SW.Close();
                    if (SR != null) SR.Close();
                    if (client != null) client.Close();
                }
            }
            catch
            {
                //MessageBox.Show("서버가 닫혀있습니다");
            }
        }
        void initMessage(string txt)
        {
            Ctrl_Invoke invoke = new Ctrl_Invoke(MessageLog);
            Invoke(invoke, txt);
            string[] stemp = txt.Split('&');
            if(stemp[0] == "CHAT")
            {
                invoke = new Ctrl_Invoke(ChattingLog);
                Invoke(invoke,stemp[1]);
            }
            if(stemp[0] == "MESS")
            {
                invoke = new Ctrl_Invoke(GetMessage);
                Invoke(invoke, stemp[2]);
            }
        }
        void MessageLog(string txt)
        {
            textBoxLog.Text += txt+"\n\r";
        }
        void ChattingLog(string txt)
        {
            if(Chatting!=null)
            {
                Chatting.Chat_Message(txt);
            }
        }
        void GetMessage(string txt)
        {
            MessageBox.Show(string.Format("{0} 님 에게서 메시지가 도착했습니다!", txt));
        }
        public void PushLog(string txt)
        {
            if (SW != null)
            {
                try
                {
                    SW.WriteLine(txt);
                    SW.Flush();
                }
                catch
                {

                }
            }
            else
            {
                //MessageBox.Show("서버가 닫혀있습니다");
            }
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        public void h_Close()
        {
            PushLog("DCON");
            STOP = true;
            if (NS != null) NS.Close();
            if (SW != null) SW.Close();
            if (SR != null) SR.Close();
            if (client != null) client.Close();
            Close();
        }
    }
}
