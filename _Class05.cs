using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Fruta = "banana";

            for (int cont = 10; cont >= 1; cont--)
            {
                Console.WriteLine("Qual o nome da Fruta? vc ainda tem " + cont + " Vidas");
                string Resposta = Console.ReadLine();

                if(Resposta == Fruta)
                {
                    Console.WriteLine("Parabens vc acertou!!! Ainda sobrou "+cont+ " Vidas");
                    break;
                }
                else
                {
                    Console.WriteLine("Infelizmente vc ainda não acertou");
                }
            }
        }
    }
}
