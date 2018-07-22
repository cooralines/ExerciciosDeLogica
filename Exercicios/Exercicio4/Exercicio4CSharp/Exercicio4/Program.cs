using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            int soma = numero1 + numero2;

            Console.WriteLine("O resultado é: " + soma);
        }
    }
}
