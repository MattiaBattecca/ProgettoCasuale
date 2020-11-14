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
            // ELIMINA RIPETIZIONI

            List<string> ls = new List<string>();
            List<string> ls1 = new List<string> { "cane", "cane", "cane", "casa", "albero", "cane", "casa", "casa" };

            foreach (var s in ls1)
            {
                if (!ls.Contains(s))
                    ls.Add(s);
            }

            foreach (var s in ls)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
