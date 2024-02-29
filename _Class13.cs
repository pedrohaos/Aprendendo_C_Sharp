using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 2; i++)// vai ser executada 2 vezes
            {
                Console.WriteLine("\n|");
                for(int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("_");// vai ser executada 6 vezes = (2*3)
                }
            }

            Console.WriteLine("\n");

            // foreach
            string[] nomes = { "Pedro", "Alexandra", "João" };
            foreach(string str in nomes)
            {
                Console.WriteLine(str);
            }
        }
    }
}
