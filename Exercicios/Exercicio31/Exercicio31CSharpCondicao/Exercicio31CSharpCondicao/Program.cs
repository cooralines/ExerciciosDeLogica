using System;
using System.Globalization;
namespace Exercicio31CSharpCondicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); ;
         
            if (N >= 0.0 && N <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (N > 25 && N <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (N > 50 && N <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (N > 75 && N <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
