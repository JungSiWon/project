using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Programming
{
    public static class Function
    {
        public static readonly string conn_str = "Server=49.50.174.201;Database=oracle2;Uid=oracle2;Pwd=oracle2;Charset=utf8;Allow User Variables=true;";
        private static MySqlConnection m_con = null;
        static private readonly string KEY = "01234567890123456789012345678901";
        static private readonly string KEY_128 = KEY.Substring(0, 128 / 8);
        static private readonly string KEY_256 = KEY.Substring(0, 256 / 8);
        public static string password(string plain)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plain);

            RijndaelManaged rm = new RijndaelManaged();
            rm.Mode = CipherMode.CBC;
            rm.Padding = PaddingMode.PKCS7;
            rm.KeySize = 128;

            MemoryStream memoryStream = new MemoryStream();
            ICryptoTransform encryptor = rm.CreateEncryptor(Encoding.UTF8.GetBytes(KEY_128), Encoding.UTF8.GetBytes(KEY_128));
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);

            cryptoStream.Write(plainBytes, 0, plainBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] encryptBytes = memoryStream.ToArray();

            string encryptString = Convert.ToBase64String(encryptBytes);

            cryptoStream.Close();
            memoryStream.Close();

            return encryptString;
        }
        public static MySqlConnection con
        {
            get {
                if (m_con == null)
                {
                    m_con = new MySqlConnection(conn_str);
                    m_con.Open();
                    return m_con;
                }
                else
                {
                    con = null;
                    m_con = new MySqlConnection(conn_str);
                    m_con.Open();
                    return m_con;
                }
            }
            set
            {
                if(value ==null)
                {
                    m_con.Close();
                    m_con = null;
                }
            }
        }
        static public string int2string(int data)
        {
            string result = "";
            for(int digit = 1; data>=digit;digit*=10)
            {
                int itemp = data;
                itemp /= digit;
                itemp = itemp % 10;
                char a = (char)(itemp + 48);
                result = string.Format("{0}{1}", a,result);
            }
            return result;
        }
        static public int string2int(string data)
        {
            string stemp = "";
            foreach (char e in data)
            {
                if (e <= '9' && e >= '0')
                {
                    stemp += e;
                }
            }
            stemp = string_reverse(stemp);
            int result = 0;
            int digit = 1;
            foreach (char e in stemp)
            {
                result += (int)(e - 48) * digit;
                digit *= 10;
            }
            return result;
        }
        static public string string_reverse(string data)
        {
            string result = "";
            for (int i = data.Length - 1; i >= 0; i--)
            {
                result += data[i];
            }
            return result;
        }

    }
}
