using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str;

            Console.WriteLine("Digite quantas colunas você quer");
            int index = int.Parse(Console.ReadLine());

            str = new string[index];
            Console.WriteLine($"O index da string é: {str.Length}");

            Console.WriteLine("Agora adicione o conteudo no Array");
            for(int i =0; i< str.Length; i++)
            {
                Console.WriteLine($"Adicione o Item na Coluna:{i}");
                str[i] = Console.ReadLine();
            }

            for(int i = 0; i < str.Length; i++)
            {
                Console.WriteLine($"Nome registrado: {str[i]}");
            }

        }
    }
}
