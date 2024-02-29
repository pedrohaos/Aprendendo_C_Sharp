using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 8;
            int c = 2;
            int d = 14;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);

            Console.WriteLine(a+d-b/c);
        }
    }
}
