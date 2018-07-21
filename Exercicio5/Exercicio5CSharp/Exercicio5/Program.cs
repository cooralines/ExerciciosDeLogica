using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, PROD;

            valor1 = int.Parse(Console.ReadLine());
            valor2 = int.Parse(Console.ReadLine());

            PROD = valor1 * valor2;

            Console.WriteLine("PROD = " + PROD);
        }
    }
}
