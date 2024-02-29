using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            double salario;
            char genero;

            Console.WriteLine("Qual o seu Nome?");
            nome = Console.ReadLine();

            Console.WriteLine("Qual a sua Idade?");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o seu Salario?");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual o seu Genero?");
            genero = Convert.ToChar(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("********* Dados Salvo!!! ************");
            Console.WriteLine($" Nome:{nome}\n Idade:{idade}\n Salario:{salario}\n Genero:{genero}\n");
            Console.WriteLine("*************************************");
            Console.ReadKey();
        }
    }
}
