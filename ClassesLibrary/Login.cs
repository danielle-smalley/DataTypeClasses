using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Login
    {
        //fields
        private string _userName;
        private string _password;

        //properties
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        
        //ctor
        public Login(string userName, string password) //this is a method that allows us to create the new login object, so here we're passing in 2 parameters and assigning the value of those parameters to the properties. 
        {
            UserName = userName;
            Password = password;
        }

        public Login()
        {

        }

        //methods
        public override string ToString()
        {
            return string.Format("Username: {0}\n" +
                "Password: {1}\n", UserName, Password);
        }

    }//end class
}//end namespace
