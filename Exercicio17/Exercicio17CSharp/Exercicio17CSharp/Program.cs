using System;
using System.Globalization;

namespace Exercicio17CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, volume;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            volume = (4 / 3.0) * 3.14159 * Math.Pow(raio, 3.0);

            Console.WriteLine("VOLUME = " + volume.ToString("F3"), CultureInfo.InvariantCulture);
        }
    }
}
