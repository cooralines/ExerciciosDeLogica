using System;
using System.Globalization;

namespace Exercicio16CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioFixo, totalVendas, total;

            nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = total = salarioFixo + ((totalVendas * 15) / 100);

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
