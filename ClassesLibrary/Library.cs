using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Library
    {
        //fields - N/A

        //props
        public List<Book> Books { get; set; }
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        //ctors
        public Library(List<Book> books, string libraryName, string streetAddress, string city, string state, string zip)
        {
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }

        public Library()
        {

        }
        //methods
        public override string ToString()
        {
            string booksNeeded = ""; //created this string so I can get the books
            foreach (Book book in Books) //created a foreach loop to loop through the list of books and add to the string
            {
                booksNeeded += book + "\n"; //this will give me the book titles and add it to the list output
            }//end foreach
            return string.Format("Library Name: {0}\n" +
                "Street Address: {1} {2} {3} {4}\n" +
                "Current books available: \n{5}\n", LibraryName, StreetAddress, City, State, Zip, booksNeeded);
        }//end ToString





    }//end class
}//end namespace
