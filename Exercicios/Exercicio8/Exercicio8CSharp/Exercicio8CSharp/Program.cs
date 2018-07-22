using System;

namespace Exercicio8CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor 1: ");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor 2: ");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor 3: ");
            int C = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor 4: ");
            int D = int.Parse(Console.ReadLine());

            int diferenca = A * B - C * D;

            Console.WriteLine("A diferença do produto de A e B pelo produto de C e D é: " + diferenca);
        }
    }
}
