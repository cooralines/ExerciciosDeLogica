using System;
using System.Globalization;

namespace Exercicio13CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tempo gasto na viagem: ");
            int tempo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a velocidade média gasta durante a viagem: ");
            int velocidade = int.Parse(Console.ReadLine());

            int distancia = tempo * velocidade;

            double litros =  distancia / 12.0;

            Console.WriteLine("A quantidade de litros necessária para completar a viagem será : " + litros.ToString("F3"));
            Console.ReadKey();
        }
    }
}
