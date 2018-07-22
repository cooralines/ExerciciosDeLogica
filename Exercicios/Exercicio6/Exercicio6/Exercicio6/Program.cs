using System;
using System.Globalization;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota: ");
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a segunda nota: ");
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine("A média do aluno é: " + media.ToString("F5"));

            Console.ReadKey();
        }
    }
}
