using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Library
    {


        //make book list
        public List<Book> Books { get; set; }
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public Library(List<Book> books, string libraryName, string streetAddress, string city, string state, string zip)
        {
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }

        public override string ToString()
        {
            string booksInLibrary = "";
            foreach (Book book in Books)
            {
                booksInLibrary += book + "\n";
            }

            return string.Format("\nBook in Library: {5}\nLibrary Name: {0}\nStreet Address: {1}\nCity: {2}\nState: {3}\nZip: {4}",
            LibraryName,
            StreetAddress,
            City,
            State,
            Zip,
            booksInLibrary);
        }
    }
}
