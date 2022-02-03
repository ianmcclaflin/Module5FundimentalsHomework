using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Login
    {
        private string _username;
        private string _password;


        public string UserName { get; set; }
        public string PassWord { get; set; }

        public Login(string username, string password)
        {
            UserName = username;
            PassWord = password;
        }

        public Login() { }

        public override string ToString()
        {
            return string.Format("Username {0}\n" +
                "Password {1}\n", UserName, PassWord);

        }


    }
}
