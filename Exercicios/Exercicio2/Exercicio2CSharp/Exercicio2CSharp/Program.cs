using System;

namespace Exercicio2CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, X;

            A = int.Parse(Console.ReadLine());

            B = int.Parse(Console.ReadLine());

            X = A + B;

            Console.WriteLine("A soma de A + B é: " + X);
            Console.ReadKey();
        }
    }
}
