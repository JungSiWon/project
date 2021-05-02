using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Programming
{
    public partial class FormLogin : Form
    {
        string fileName = "saveInfo.info";
        string settingName = "autoLoad.set";
        static bool isSighedUp = false;
        static bool isAutoLoaded = false;

        public FormLogin()
        {
            InitializeComponent();
            InitVariables();
        }

        private void InitVariables()
        {
            labelNotice.Text = "";
            if(!File.Exists(fileName))
            {
                BinaryWriter saveInfo_bw = new BinaryWriter(new FileStream(fileName, FileMode.Create));
                saveInfo_bw.Close();
            }

            if(!File.Exists(settingName))
            {
                BinaryWriter autoLoad_bw = new BinaryWriter(new FileStream(settingName, FileMode.Create));
                autoLoad_bw.Write(false);
                autoLoad_bw.Close();
            }

            BinaryReader setting_br = new BinaryReader(new FileStream(settingName, FileMode.Open));
            if(setting_br.ReadBoolean())
            {
                checkBoxAutoLoadAccount.Checked = true;
                setting_br.Close();
                AutoLoad();
                return;
            }
            setting_br.Close();
            //TODO : 컴퓨터에 저장된 체크상태 및 ID, PW 암호화된 파일 불러오기
            // 체크상태에 따라 메인화면
        }

        private void AutoLoad()
        {
            BinaryReader br = new BinaryReader(new FileStream(fileName, FileMode.Open));
            String userID = br.ReadString();
            br.Close();

            WorkDB.Instance.ConnectSetting();
            string query = $"SELECT pw FROM account WHERE id = '{userID}'";
            DataSet ds = WorkDB.Instance.DataAdapter_Fill(query);
            string userPW = ds.Tables[0].Rows[0]["pw"].ToString();

            textBoxID.Text = userID;
            textBoxPW.Text = userPW;
        }

        private void Login()
        {
            WorkDB.Instance.ConnectSetting();
            String userID = textBoxID.Text;
            String userPW = textBoxPW.Text;

            String query = $"SELECT t2.* FROM account AS t1, employee AS t2 WHERE t1.id = '{userID}' AND t1.pw = '{userPW}' AND t1.account_em_num = t2.num";

            DataSet accountDS = WorkDB.Instance.DataAdapter_Fill(query);
            if (accountDS.Tables[0].Rows.Count != 0)
            {
                isSighedUp = true;
                WorkDB.Instance.Init(accountDS.Tables[0].Rows[0]);
            }
            else
                isSighedUp = false;

            if (isSighedUp)
            {
                if (checkBoxAutoLoadAccount.Checked)
                {
                    BinaryWriter bw = new BinaryWriter(new FileStream(fileName, FileMode.Create));
                    bw.Write(userID);
                    bw.Close();
                    //TODO : 체크박스 체크상태에 따라 컴퓨터 내 체크상태 및 ID,PW 암호화된 파일 저장
                }

                BinaryWriter setting_bw = new BinaryWriter(new FileStream(settingName, FileMode.Create));
                setting_bw.Write(isAutoLoaded);
                setting_bw.Close();

                workin();
                this.Visible = false;
                FormMain showFormMain = new FormMain();
                showFormMain.ShowDialog();
                this.Visible = true;
            }
            else
            {
                labelNotice.ForeColor = Color.Red;
                labelNotice.Text = "ID 혹은 PW가 틀렸습니다.";
            }
        }

        private void workin()
        {
            try
            {
                DataRow dr = WorkDB.Instance.LoadData();

                MySqlConnection conn = new MySqlConnection("Server=49.50.174.201;Database=oracle2;Uid=oracle2;Pwd=oracle2;Charset=utf8");
                conn.Open();

                bool holiday = false;
                if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday || DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
                {
                    holiday = true;
                }

                string query = "INSERT INTO attendance (`in`,att_em_num,date,holiday) " +
                "VALUES ('" + DateTime.Now.ToString("HH:mm:ss") + "'," + dr["num"] + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "'," + holiday + ");";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch
            {
                
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login();
        }           

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void checkBoxAutoLoadAccount_CheckedChanged(object sender, EventArgs e)
        {
            isAutoLoaded = checkBoxAutoLoadAccount.Checked;
        }
    }
}
