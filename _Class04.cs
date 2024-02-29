using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IF & ELSE
            string Fruta = "banana";

            while (true)
            {
                Console.WriteLine("Qual o nome da Fruta");
                string Resposta = Console.ReadLine();

                if (Resposta == Fruta)
                {
                    Console.WriteLine("Parabens Resposta correta!!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Infelizmente vc errou");
                    continue;
                }
            }
        }
    }
}
