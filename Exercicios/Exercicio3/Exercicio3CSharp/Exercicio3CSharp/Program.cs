using System;
using System.Globalization;

namespace Exercicio3CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, raio;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = 3.14159 * Math.Pow(raio, 2.0);

            Console.WriteLine("Area= " + area.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
