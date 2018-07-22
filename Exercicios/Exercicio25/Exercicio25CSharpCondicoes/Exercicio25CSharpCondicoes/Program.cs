using System;
using System.Globalization;

namespace Exercicio25CSharpCondicoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double soma = nota1 + nota2;

            Console.WriteLine("NOTA FINAL: " + soma.ToString("F1"), CultureInfo.InvariantCulture);

            if(soma < 60.0)
            {
                Console.WriteLine("REPROVADO");
            }

            Console.ReadKey();
        }
    }
}
