using System;
using System.Globalization;

namespace Exercicio7CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota: ");
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a segunda nota: ");
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a terceira nota: ");
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = ((A * 2) + (B * 3) + (C * 5)) / 10;

            Console.WriteLine("MEDIA = " + media.ToString("F1"));
        }
    }
}
