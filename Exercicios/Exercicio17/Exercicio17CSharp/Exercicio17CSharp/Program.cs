using System;
using System.Globalization;

namespace Exercicio17CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double volume = (4 / 3.0) * 3.14159 * Math.Pow(raio, 3.0);

            Console.WriteLine("O volume será: " + volume.ToString("F3"), CultureInfo.InvariantCulture);
        }
    }
}
