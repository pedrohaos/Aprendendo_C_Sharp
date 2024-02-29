using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Como usar ForEach In
            var numeros = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16, 18 };
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            string[] nomes = { "Pedro", "João", "Alexandra", "Ana" };
            foreach(string nome in nomes)
            {
                Console.WriteLine($"Nome: {nome}");
            }
        }
    }
}
