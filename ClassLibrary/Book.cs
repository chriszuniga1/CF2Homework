using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }

        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }

        public Book () { }

        public override string ToString()
        {
            return string.Format("\nTitle: {0}\nAuthor: {1}\nNumber of Pages: {2}",
                Title,
                Author,
                NumberOfPages);
        }
    }
}
