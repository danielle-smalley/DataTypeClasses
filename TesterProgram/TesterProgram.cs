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

            Console.WriteLine("\n\n-----Vehicle Info-----\n\n");

            Vehicle v1 = new Vehicle("Ford", "Escort", 2000, 2450);
            Console.WriteLine(v1);

            Vehicle v2 = new Vehicle();
            v2.Make = "Kia";
            v2.Model = "Forte";
            v2.Year = 2015;
            v2.Weight = 2800;
            Console.WriteLine(v2);

            Console.WriteLine("\n\n-----Login Info-----\n\n");

            Login l1 = new Login("ssquarepants01", "G@ry");
            Console.WriteLine(l1);

            Login l2 = new Login();
            l2.UserName = "isMayonnaise";
            l2.Password = "AnInstrument?";
            Console.WriteLine(l2);
        } //end main
    }//end class
}//end namespace
