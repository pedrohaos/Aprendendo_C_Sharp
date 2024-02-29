using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace class07
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Entradada de dados com String
            Console.WriteLine("Qual dia da semana eh hj: ");
            string resposta = Console.ReadLine();
            Console.WriteLine($"Hoje eh: {resposta}");
            Console.WriteLine("==============================\n");

            //Entradada de dados com Int
            Console.WriteLine("Qual o numero do dia");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numero do dia: {numero}"); //Interpolação
            Console.WriteLine("Numero do dia: "+ numero);//Concatenação
            Console.WriteLine("=============================\n");

            //Entradada de dados com Float
            Console.WriteLine("Digite um Numero Float");
            float numero2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Numero Float digitado: {numero2:0.00}");
            Console.WriteLine("Numero Float digitado: "+numero2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("=============================\n");

            //Entradada de dados com Char
            Console.WriteLine("Digite uma letra");
            char letra = char.Parse(Console.ReadLine());
            Console.WriteLine(letra);
        }
    }
}
