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
    public partial class FormSearchAddress : Form
    {
        public delegate void sendDataToParent(object obj);
        public event sendDataToParent sendDataEvent;

        public FormSearchAddress()
        {
            InitializeComponent();
        }

        private void FormSearchAddress_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://localhost/postcode.html");
            this.webBrowser1.ObjectForScripting = this;
        }

        public void receiveFromWeb(object val1, object val2, object val3, object val4, object val5)
        {
            string strAddress = string.Empty;
            string strZoneCode = string.Empty;
            string strBuildingName = string.Empty;

            string jAddress = (string)val2;
            string rAddress = (string)val1;
            string userSelectedType = (string)val4;

            if (userSelectedType.Equals("R"))
            {
                strAddress = rAddress;
            }
            else
            {
                strAddress = jAddress;
            }
            strZoneCode = (string)val3;
            strBuildingName = (string)val5;

            DataTable dt = new DataTable();
            dt.Columns.Add("address");
            dt.Columns.Add("zoneCode");
            dt.Columns.Add("buildingName");

            DataRow dr = dt.NewRow();

            dr["address"] = strAddress;
            dr["zoneCode"] = strZoneCode;
            dr["buildingName"] = strBuildingName;

            this.sendDataEvent(dr);
            this.Close();
        }
    }
}
