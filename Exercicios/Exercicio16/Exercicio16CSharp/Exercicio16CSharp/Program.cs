using System;
using System.Globalization;

namespace Exercicio16CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do vendedor: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o valor do salário fixo: ");
            double salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor total de vendas: ");
            double totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = total = salarioFixo + ((totalVendas * 15) / 100);

            Console.WriteLine("O total que o funcionário deverá receber é: " + total.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
