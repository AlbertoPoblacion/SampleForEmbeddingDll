using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new ClassLibrary1.Class1();
            string text = library.GetSomeText();
            Console.WriteLine(text);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("\nPress ENTER to exit");
                Console.ReadLine();
            }
        }
    }
}
