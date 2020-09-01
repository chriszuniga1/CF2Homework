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

        }
    }
}
