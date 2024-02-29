using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace class01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int year, age;
            double weight, height, salary;
            char gender;
            string name, address;

            year = 2001;
            age = 23;
            weight = 121.3399;
            height = 188.919;
            salary = 2938.789;
            gender = 'M';
            name = "Pedro";
            address = "Foz do Iguassu - PR";

            Console.WriteLine("Ano: " + year);
            Console.WriteLine("Idade: " + age);
            Console.WriteLine("Largura: " + weight.ToString("F2",CI));
            Console.WriteLine("Altura: " + height.ToString("F2",CI));
            Console.WriteLine("Salario: " + salary.ToString("F2", CI));
            Console.WriteLine("Genero: " + gender);
            Console.WriteLine("Nome: " + name);
            Console.WriteLine("Local: " + address);
        }
    }
}
