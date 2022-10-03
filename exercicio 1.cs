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
            double num1, num2;
            Console.WriteLine("digite o primeiro numero: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("a multiplicaçao dos numeros é: ");
            double vezes = V (num1, num2);
            Console.WriteLine(vezes);

        }
        public static double V (double x, double y)
        {
            double vezes = x * y;
            return vezes;
        }
    }
}
