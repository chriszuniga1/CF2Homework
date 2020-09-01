using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Login
    {
        private string _userName;
        private string _userPassword;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string UserPassword
        {
            get { return _userPassword; }
            set { _userPassword = value; }
        }


        public Login(string userName, string userPassword)
        {
            UserName = userName;
            UserPassword = userPassword;
            
        }

        public Login() { }

        public override string ToString()
        {
            return string.Format("Login Information:\nUserName: {0:}\nUserPassword: {1}", UserName, UserPassword);
        }

    }
}
