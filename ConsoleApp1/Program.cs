using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

            DoSomething();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("\nPress ENTER to exit");
                Console.ReadLine();
            }
        }

        private static void DoSomething()
        {
            // This has to be outside Main !!! (think about the load order when JITting Main)
            var library = new ClassLibrary1.Class1();
            string text = library.GetSomeText();
            Console.WriteLine(text);
        }

        private static System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string assemblyThatWeAreResolving = args.Name;
            if (assemblyThatWeAreResolving.ToLower().Contains("classlibrary1"))
            {
                byte[] b = EmbeddedLibraries.ClassLibrary1;
                Assembly a = Assembly.Load(b);
                return a;
            }

            return null;
        }
    }
}
