﻿using System;
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

            Console.WriteLine("\n\n-----Customers-----\n\n");

            Customer cust1 = new Customer("5566", "Sandy", "Cheeks", c1);
            Console.WriteLine(cust1);
            Customer cust2 = new Customer();
            cust2.CustomerId = "7777";
            cust2.FirstName = "Eugene";
            cust2.LastName = "Krabs";
            cust2.ContactInfo = c2;
            Console.WriteLine(cust2);

            Console.WriteLine("\n\n-----Credit Card Account-----\n\n");

            CreditCardAccount acc1 = new CreditCardAccount(55554444, cust1, 200.00m, false, 18.99m);
            Console.WriteLine(acc1);

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
            Library lib1 = new Library(books, "Smalley Library", "123 Nowhere St", "Columbia", "MO", "65203");
            Console.WriteLine(lib1);

            Library lib2 = new Library(books, "Main St Library", "321 Main St", "North Pole", "AK", "99705");
            Console.WriteLine(lib2);

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
            List<Song> songs = new List<Song>() { song1, song2, song3 };
            Artist a1 = new Artist(songs, "Alejandro", Genre.Pop);
            Console.WriteLine(a1);

            //Artist a2 = new Artist(songs, "Queen", Genre.RnB);
            //Console.WriteLine(a2);    **If I add one here, it will only display this one and not a1 too

        } //end main
    }//end class
}//end namespace
