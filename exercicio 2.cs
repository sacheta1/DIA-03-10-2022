using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double base1, altura;
            Console.WriteLine("digite o valor da base: ");
            base1 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor da altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("a multiplicaçao dos numeros é: ");
            double vezes = V (base1, altura);
            Console.WriteLine(vezes);

        }
        public static double V (double x, double y)
        {
            double vezes = (x * y) /2;
            return vezes;
        }
    }
}
