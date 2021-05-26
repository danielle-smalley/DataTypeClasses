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
        private int _studentid;
        private decimal _studentgpa;


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

        public int StudentId
        { get { return _studentid; }
            set { _studentid = value; }
        }//end ID

        public decimal StudentGpa
        {
            get { return _studentgpa; }
            set { _studentgpa = value; }
        }//end gpa

        //ctors

        public Student(string firstName, string lastName, int studentId, decimal studentGpa)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentId = studentId;
            StudentGpa = studentGpa;
        }

        public Student()
        {

        }

        //methods

        public override string ToString()
        {
            return string.Format("First Name: {0}\tLast Name: {1}\n" +
                "ID: {2}\tGPA: {3}", FirstName, LastName, StudentId, StudentGpa);
        }

    }//end class
}//end namespace
