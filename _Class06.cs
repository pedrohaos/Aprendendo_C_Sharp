using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual numero vc quer saber a tabuada");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            for (int cont = 1; cont <= 10; cont++)
            {
                /*int resultado = numero* cont;
                Console.WriteLine(numero + " X " + cont + " = " + resultado);*/
                Console.WriteLine("{0} X {1} = {2} \n", numero, cont, numero * cont);
            }
        }
    }
}
