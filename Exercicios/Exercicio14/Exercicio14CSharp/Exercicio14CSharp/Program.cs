using System;
using System.Globalization;

namespace Exercicio14CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da base do retângulo: ");
            double baseRetangulo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a altura do retângulo: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double area = baseRetangulo * altura;

            double perimetro = 2 * baseRetangulo + 2 * altura;

            double diagonal = Math.Sqrt(Math.Pow(baseRetangulo, 2.0) + Math.Pow(altura, 2.0));

            Console.WriteLine("AREA = " + area.ToString("F4"), CultureInfo.InvariantCulture);

            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4"), CultureInfo.InvariantCulture);

            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4"), CultureInfo.InvariantCulture);

            Console.ReadKey();
        }
    }
}
