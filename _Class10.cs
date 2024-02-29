using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool valor = true;

            while (valor)
            {
                Console.WriteLine("Ola Bem-Vindo ao Menu\nEscolha uma das opções");
                Console.WriteLine(" 1-multiplicador\n 2-Soma\n 3-Subtração\n 4-Divisão\n 5-Sair\n");

                int opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Qual numero deseja saber a tabuada?");
                        int numero1 = int.Parse(Console.ReadLine());
                        opc1(numero1);
                        break;
                    case 2:
                        Console.WriteLine("Qual numero deseja somar?");
                        int numero2 = int.Parse(Console.ReadLine());
                        opc2(numero2);
                        break;
                    case 3:
                        Console.WriteLine("Qual numero deseja subtrair?");
                        int numero3 = int.Parse(Console.ReadLine());
                        opc3(numero3);
                        break;
                    case 4:
                        Console.WriteLine("Qual numero deseja saber a divisão?");
                        int numero4 = int.Parse(Console.ReadLine());
                        opc4(numero4);
                        break;
                    case 5:
                        Console.WriteLine("Encerrando o Programa, até logo");
                        valor = false;
                        break;
                    default:
                        Console.WriteLine("*********************");
                        Console.WriteLine("Essa opção não existe");
                        Console.WriteLine("*********************");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }

            /*void opc1(int opc)
            {
                Console.WriteLine("****************************");
                Console.WriteLine($"***Você escoleu a opção {opc}***");
                Console.WriteLine("****************************");
                Console.ReadKey();
            }*/

            void opc1(int numero)
            {
                for(int cont = 1; cont <= 10; cont++)
                {
                    Console.WriteLine($"{numero} X {cont} = {numero * cont}");
                }
                Console.ReadKey();
            }

            void opc2(int numero)
            {
                for(int cont = 1; cont <= 10; cont++)
                {
                    Console.WriteLine($"{numero} + {cont} = {numero + cont}");
                }
                Console.ReadKey();
            }

            void opc3(int numero)
            {
                for(int cont = 1; cont <= 10; cont++)
                {
                    Console.WriteLine($"{numero} - {cont} = {numero - cont}");
                }
                Console.ReadKey();
            }

            void opc4(int numero)
            {
                for(int cont = 1; cont <= 10; cont++)
                {
                    Console.WriteLine($"{numero} / {cont} = {numero / cont}");
                }
                Console.ReadKey();
            }
        }
    }
}
