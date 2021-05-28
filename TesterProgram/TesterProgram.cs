using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;
using Enum;

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

            Console.WriteLine("\n\n-----Contact Info-----\n\n");

            ContactInfo c1 = new ContactInfo("1600 Pennsylvania Ave NW", "Washington", "DC", "20500", "877-777-7777", "steppinonthebeach@yahoo.com");
            Console.WriteLine(c1);

            ContactInfo c2 = new ContactInfo();
            c2.StreetAddress = "123 Derp Ave";
            c2.City = "Underarock";
            c2.State = "Florida";
            c2.Zip = "32920";
            c2.Phone = "800-123-4567";
            c2.Email = "ismayoaninstrument@hotmail.com";
            Console.WriteLine(c2);

            Console.WriteLine("\n\n-----Customer Info-----\n\n");

            Customer cust1 = new Customer("5566", "Sandy", "Cheeks", c1);
            Console.WriteLine(cust1);
            Customer cust2 = new Customer();
            cust2.CustomerId = "7777";
            cust2.FirstName = "Eugene";
            cust2.LastName = "Krabs";
            cust2.ContactInfo = c2;
            Console.WriteLine(cust2);

            Console.WriteLine("\n\n-----Credit Card Account Info-----\n\n");

            CreditCardAccount acc1 = new CreditCardAccount(55554444, cust1, 200.00m, false, 18.99m);
            Console.WriteLine(acc1);

            CreditCardAccount acc2 = new CreditCardAccount();
            acc2.AccountNumber = 666777894;
            acc2.CustomerInfo = cust2;
            acc2.Balance = 899.54m;
            acc2.IsPastDue = true;
            acc2.AnnualInterestRate = 16.99m;
            Console.WriteLine(acc2);


            Console.WriteLine("\n\n-----Books-----\n\n");
            Book b1 = new Book("Green Eggs & Ham", "Dr. Suess", 24);
            Console.WriteLine(b1);
            Book b2 = new Book();
            b2.Title = "One Fish, Two Fish, Red Fish, Blue Fish";
            b2.Author = "Dr. Suess";
            b2.NbrOfPages = 22;
            Console.WriteLine(b2);

            Console.WriteLine("\n\n-----Library-----\n\n");

            List<Book> books = new List<Book>() { b1, b2 }; //this list of type Book has 2 books in it
            Library lib2 = new Library();
            lib2.Books = books;
            lib2.LibraryName = "Test Library";
            lib2.StreetAddress = "555 West St";
            lib2.City = "Columbia";
            lib2.State = "MO";
            lib2.Zip = "65202";
            Console.WriteLine(lib2);

            Library lib1 = new Library(books, "Smalley Library", "123 Nowhere St", "Columbia", "MO", "65203");
            Console.WriteLine(lib1);

            Console.WriteLine("\n\n-----Songs-----\n\n");

            Song song1 = new Song("Lady Gaga", "Bad Romance", 300);
            Console.WriteLine(song1);

            Song song2 = new Song();
            song2.Artist = "Jessie J";
            song2.Title = "Masterpiece";
            song2.LengthInSeconds = 221;
            Console.WriteLine(song2);

            Song song3 = new Song("The Weeknd", "In Your Eyes", 240);
            Console.WriteLine(song3);

            Console.WriteLine("\n\n-----Artists-----\n\n");
            List<Song> tracks = new List<Song>() { song1, song2, song3 };
            Artist a1 = new Artist(tracks, "Alejandro", Genre.Pop);
            Console.WriteLine(a1);

            Artist a2 = new Artist();
            a2.Tracks = tracks;
            a2.Title = "Queen";
            a2.Genre = Genre.RnB;
            Console.WriteLine(a2);

            Console.WriteLine("\n\n-----MotorHomes-----\n\n");
            MotorHome mh1 = new MotorHome("Fancy", "MotorHomeMobile", 2010, 10000, 2);
            Console.WriteLine(mh1);
            MotorHome mh2 = new MotorHome();
            mh2.Make = "Snazzy";
            mh2.Model = "Jazzy";
            mh2.Year = 2020;
            mh2.Weight = 13000;
            mh2.NumberOfBeds = 3;
            Console.WriteLine(mh2);

            Console.WriteLine("\n\n-----Trucks-----\n\n");
            Truck t1 = new Truck("Ford", "Ranger", 2020, 4400, 1800);
            Console.WriteLine(t1);
            Truck t2 = new Truck();
            t2.Make = "GMC";
            t2.Model = "Canyon Denali";
            t2.Year = 2020;
            t2.Weight = 4500;
            t2.LoadCapacityLbs = 1500;
            Console.WriteLine(t2);

        } //end main
    }//end class
}//end namespace
