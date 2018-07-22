using System;

namespace Exercicio21CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            int tempo = int.Parse(Console.ReadLine());
            
            int horas = tempo / 3600;

            int resto = tempo % 3600;

            int minutos = resto / 60;

            int segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}
