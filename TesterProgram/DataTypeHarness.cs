﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace TesterProgram
{
    class DataTypeHarness
    {
        static void Main(string[] args)
        {
            Students s1 = new Students("Christina", "Zuniga", "123456", 3.9f);
            Console.WriteLine(s1);

            Vehicle v1 = new Vehicle("Toyota", "Prius", 2015, 2900);
            Console.WriteLine(v1);

            Login l1 = new Login("czuniga989", "bigbadbabbies");
            Console.WriteLine(l1);

            ContactInfo c1 = new ContactInfo("3919 Independance BLVD", "Kansas City", "Kansas", "66109", "(913)867-5309", "emailthis@hotmail");
            Console.WriteLine(c1);

            Customer cus1 = new Customer("123456", "Christina", "Zuniga", c1);
            Console.WriteLine(cus1);

            CreditCardAccount cc1 = new CreditCardAccount(12545235, cus1, 50, true, 15);
            Console.WriteLine(cc1);

            Book b1 = new Book("The Joy of Programing", "Michael Zuniga", 621);
            Console.WriteLine(b1);
            List<Book> Books = new List<Book>() { b1 };

            Library lb1 = new Library(Books, "ParkHill Library", "12354 Happy Street", "Kansas City", "Kansas", "66025");
            Console.WriteLine(lb1);

            Song sg1 = new Song("Barnes & Barnes", "Fish Heads", 146);
            Console.WriteLine(sg1);

            Artist a1 = new Artist("The Firm", "Star Trekking'", 212, "Novelty Song");
            Console.WriteLine(a1);

        }
    }
}
