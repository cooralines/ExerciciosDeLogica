using System;
using System.Globalization;

namespace Exercicio14CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseRetangulo, altura, area, perimetro, diagonal;

            baseRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = baseRetangulo * altura;
            perimetro = 2 * baseRetangulo + 2 * altura;
            diagonal = Math.Sqrt(Math.Pow(baseRetangulo, 2.0) + Math.Pow(altura, 2.0));

            Console.WriteLine("AREA = " + area.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4"), CultureInfo.InvariantCulture);

            Console.ReadKey();
        }
    }
}
