using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio1CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a largura:");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o comprimento:");
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor do metro quadrado:");
            double valorMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorArea = largura * comprimento;

            double precoTerreno = valorMetroQuadrado * valorArea;

            Console.WriteLine("O valor da área é " + valorArea.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("O preço do terreno é " + precoTerreno.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
