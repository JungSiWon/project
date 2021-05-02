using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Programming
{
    class LoginManager
    {
        public int acc_num { get; set; }//사원번호

        //싱글톤
        private static LoginManager instance = new LoginManager(); //객체 생성
        public static LoginManager GetInstance() { return instance; } //객체를 리턴
        private LoginManager() { } //생성자

    }
}
