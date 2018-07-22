using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());
            
            int produto = valor1 * valor2;

            Console.WriteLine("O valor do produto é: " + produto);
        }
    }
}
