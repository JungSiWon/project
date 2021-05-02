using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Programming
{
    static class Program
    {
        public static ApplicationContext ac = new ApplicationContext();
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormLogin form = new FormLogin();
            //Message_Main_Form form = new Message_Main_Form();
            form.Show();
            //ac.MainForm = form;
            Application.Run(ac);
        }
    }
}
