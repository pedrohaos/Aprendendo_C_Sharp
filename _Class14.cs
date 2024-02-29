using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array
            string[] str = { "Pedro", "Alexandra", "João" };
            for(int i = 0; i <= 2; i++)
            {
                Console.WriteLine(str[i]);
            }
            foreach(string i in str)
            {
                Console.WriteLine(i);
            }

            int[] numeros = { 1, 5, 3 };
            for(int i = 0; i <= 2; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            foreach(int i in numeros)
            {
                Console.WriteLine(i);
            }

            // a metodologia Arry.Sort()
            // organiza os numeros do menor para o maior e
            // coloca uma lista em ordem alfabetica
            Array.Sort(str);
            Array.Sort(numeros);

            for(int i = 0; i <= 2; i++)
            {
                Console.WriteLine(str[i]);
                Console.WriteLine(numeros[i]);
            }

            //Array 2D ou Matrix
            int[,] matrix = { {1, 2, 3}, {4, 5, 6} };
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
               for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine(matrix[i,j]);
                }
            }

            int[,] matrix2 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[,] matrix3 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < matrix3.GetLength(0); i++)
            {
                Console.WriteLine(string.Join(" ", Enumerable.Range(0, matrix3.GetLength(1)).Select(j => matrix3[i, j])));
            }

            int[,] matrix4 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            foreach (var row in Enumerable.Range(0, matrix4.GetLength(0)))
            {
                Console.WriteLine(string.Join(" ", Enumerable.Range(0, matrix4.GetLength(1)).Select(col => matrix4[row, col])));
            }

            int[,] matrix5 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            foreach (int i in matrix5)
            {
                Console.Write(i + " ");
                if (Array.IndexOf(matrix5, i) % matrix5.GetLength(1) == matrix5.GetLength(1) - 1)
                {
                    Console.WriteLine();
                }
            }


        }
    }
}
