using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Student
    {
        //fields
        private string _firstName;
        private string _lastName;


        //properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }//end firstname

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }//end lastname

        //ctors

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Student()
        {

        }

        //methods

        public override string ToString()
        {
            return string.Format("First Name: {0}\t\tLast Name: {1}", FirstName, LastName);
        }

    }//end class
}//end namespace
