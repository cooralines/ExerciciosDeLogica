using System;

namespace Exercicio19CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, m1, m2;
            string[] vet;

            vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            m1 = (a + b + Math.Abs(a - b)) / 2;
            m2 = (m1 + c + Math.Abs(m1 - c)) / 2;

            Console.WriteLine(m2 + " eh o maior");
        }
    }
}
