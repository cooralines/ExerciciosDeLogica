using System;
using System.Globalization;

namespace Exercicio24CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double N, nota100, nota50, nota20, nota10, nota5, nota2, moeda1, moeda50Cent,
                moeda25Cent, moeda10Cent, moeda5Cent, moeda1Cent, resto1, resto2, resto3, 
                resto4, resto5, resto6, resto7, resto8, resto9, resto10, resto11;

            N = 100 * double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            nota100 = (int)N / 10000;
            resto1 = N % 10000.0;

            nota50 = (int)resto1 / 5000;
            resto2 = resto1 % 5000.0;

            nota20 = (int)resto2 / 2000;
            resto3 = resto2 % 2000.0;

            nota10 = (int)resto3 / 1000;
            resto4 = resto3 % 1000.0;

            nota5 = (int)resto4 / 500;
            resto5 = resto4 % 500.0;

            nota2 = (int)resto5 / 200;
            resto6 = resto5 % 200.0;

            moeda1 = (int)resto6 / 100;
            resto7 = resto6 % 100.0;

            moeda50Cent = (int)resto7 / 50;
            resto8 = resto7 % 50;

            moeda25Cent = (int)resto8 / 25;
            resto9 = resto8 % 25;

            moeda10Cent = (int)resto9 / 10;
            resto10 = resto9 % 10;

            moeda5Cent = (int)resto10 / 5;
            resto11 = resto10 % 5;

            moeda1Cent = (int)resto11 / 1;

            Console.WriteLine("NOTAS:");
            Console.WriteLine(nota100 + " nota(s) de R$ 100.00");
            Console.WriteLine(nota50 + " nota(s) de R$ 50.00");
            Console.WriteLine(nota20 + " nota(s) de R$ 20.00");
            Console.WriteLine(nota10 + " nota(s) de R$ 10.00");
            Console.WriteLine(nota5 + " nota(s) de R$ 5.00");
            Console.WriteLine(nota2 + " nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");
            Console.WriteLine(moeda1 + " moeda(s) de R$ 1.00");
            Console.WriteLine(moeda50Cent + " moeda(s) de R$ 0.50");
            Console.WriteLine(moeda25Cent + " moeda(s) de R$ 0.25");
            Console.WriteLine(moeda10Cent + " moeda(s) de R$ 0.10");
            Console.WriteLine(moeda5Cent + " moeda(s) de R$ 0.05");
            Console.WriteLine(moeda1Cent + " moeda(s) de R$ 0.01");
        }
    }
}
