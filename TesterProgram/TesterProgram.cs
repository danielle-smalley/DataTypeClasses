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


            Student s1 = new Student("Spongebob", "Squarepants", 4321, 3.2m);
            Console.WriteLine(s1);

            Student s2 = new Student();
            s2.FirstName = "Patrick";
            s2.LastName = "Star";
            s2.StudentId = 1234;
            s2.StudentGpa = 2.0m;
            Console.WriteLine(s2);

        } //end main
    }//end class
}//end namespace
