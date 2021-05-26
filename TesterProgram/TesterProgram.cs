using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class TesterProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n-----Student Info-----\n\n");


            Student s1 = new Student("Spongebob", "Squarepants");
            Console.WriteLine(s1);

            Student s2 = new Student();
            s2.FirstName = "Patrick";
            s2.LastName = "Star";
            Console.WriteLine(s2);

        } //end main

        private class Students
        {
        }
    }//end class
}//end namespace
