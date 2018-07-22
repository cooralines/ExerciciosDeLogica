using System;
using System.Globalization;

namespace Exercicio11Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a distância total percorrida: ");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o total de combustível gasto: ");
            double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double consumo = X / Y;

            Console.WriteLine("O consumo médio do automóvel é de: " + consumo.ToString("F3") + " km/l");
            Console.ReadKey();
        }
    }
}
