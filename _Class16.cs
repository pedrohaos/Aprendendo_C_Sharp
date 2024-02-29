using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] mtz = new string[3,5] { {"_","|", "_", "|", "_"},{ "_", "|", "_", "|", "_" }, { "_", "|", "_", "|", "_" } };

            for (int i = 0; i < 3; i++) 
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(mtz[i,j]);
                }
                Console.WriteLine();
            }

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (mtz[i,j] == "_")
                    {
                        mtz[i, j] = "0";
                    }

                    Console.Write(mtz[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("===============================================");

            Console.Write("Digite o numero de Linhas:");
            int linha = int.Parse(Console.ReadLine());

            Console.Write("Digite o numero de Colunas:");
            int coluna = int.Parse(Console.ReadLine());

            string[,] mtz2 = new string[linha, coluna];

            for (int i=0; i < linha; i++)
            {
                for (int j=0; j < coluna; j++)
                {
                    Console.Write($"Digite o nome da Linha{i} e na Coluna{j}:");
                    mtz2[i, j] = Console.ReadLine();
                }
            }

            for (int i =0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write(mtz2[i,j]+" | ");
                }
                Console.WriteLine();
            }
        }
    }
}
