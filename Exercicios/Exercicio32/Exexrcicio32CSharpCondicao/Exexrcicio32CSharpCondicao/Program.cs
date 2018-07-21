using System;
using System.Globalization;

namespace Exexrcicio32CSharpCondicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double conta = 0;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            quantidade = int.Parse(vet[1]);

            if (codigo == 1)
            {
                conta = quantidade * 4;
            }
            else if (codigo == 2)
            {
                conta = quantidade * 4.50;
            }
            else if (codigo == 3)
            {
                conta = quantidade * 5;
            }
            else if (codigo == 4)
            {
                conta = quantidade * 2;
            }
            else if (codigo == 5)
            {
                conta = quantidade * 1.50;
            }
            Console.WriteLine("Total: R$ " + conta.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
