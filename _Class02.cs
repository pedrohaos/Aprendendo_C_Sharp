using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //converção implicita int para long ambos aceitão números inteiros
            int n1 = 1234567890;
            long n2 = n1;
            Console.WriteLine("Valor de Long : " + n2);

            //coverção explicita double para int ambos aceitão tipos diferentes de números
            double d1 = 335.547;
            int d2 = (int)d1;
            Console.WriteLine("Valor do d2 : " + d2);

            //converção explicita float é menor que double apesar de ambos receberem o mesmo tipo de número
            double f1 = 436.43577765;
            float f2 = (float)f1;
            Console.WriteLine("Valor de f2 : " + f2);
        }
    }
}
