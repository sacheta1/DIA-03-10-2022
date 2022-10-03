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
            double num1;
            Console.WriteLine("digite o valor: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("a raiz quadrada do valor é de: ");
            double vezes = V (num1, num1);
            Console.WriteLine(vezes);

        }
        public static double V (double x, double y)
        {
            double vezes = (x * y);
            return vezes;
        }
    }
}
