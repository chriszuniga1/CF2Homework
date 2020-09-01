using System;
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
        }
    }
}
