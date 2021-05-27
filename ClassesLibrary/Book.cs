using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Book
    {
        //fields

        //props
        public string Title { get; set; }
        public string Author { get; set; }
        public int NbrOfPages { get; set; }

        //ctors
        public Book(string title, string author, int nbrOfPages)
        {
            Title = title;
            Author = author;
            NbrOfPages = nbrOfPages;
        }

        public Book()
        {

        }
        //methods 
        public override string ToString()
        {
            return string.Format("Title: {0}\n" +
                "Author: {1}\n" +
                "Length: {2} pages\n", Title, Author, NbrOfPages);
        }

    }//end class
}//end namespace
