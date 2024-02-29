using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // aprendendo string
            string primeiroNome = "Pedro";
            string ultimoNome = "Henrique";

            // Concatenação
            Console.WriteLine("Ola "+ primeiroNome + ultimoNome);

            //interpolação
            Console.WriteLine($"Ola {primeiroNome} {ultimoNome}");

            //Toda string é um Array, logo é possível acessar cada caracter
            Console.WriteLine($"primeiro caracter da string primeiroNome: {primeiroNome[0]}");

            //É possivel saber qual o numero do caracter usando metodo IndexOf()
            Console.WriteLine($"index do caracter pesquisado: {primeiroNome.IndexOf("e")}");

            // A Metodologia Substring() que extrai os caracteres de uma string,
            // começando na posição/índice do caractere especificado, e retorna uma nova string.
            // Este método é frequentemente usado junto com IndexOf() para obter a posição
            // específica do caracter:
            int charPos = ultimoNome.IndexOf("n");
            string restoDoNome = ultimoNome.Substring(charPos);
            Console.WriteLine($"Usando a metodologia Substring: {restoDoNome}");

            // \n Quebra linha
            // \t Tab
            // \b Barra de espaço

            // A string Pedro sera escrica com aspas duplas "Pedro"
            Console.WriteLine("ola \"Pedro\" como esta?");
            Console.WriteLine("ola \'Pedro\' como esta?");
            Console.WriteLine("ola \\Pedro\\ como esta?");
        }
    }
}
