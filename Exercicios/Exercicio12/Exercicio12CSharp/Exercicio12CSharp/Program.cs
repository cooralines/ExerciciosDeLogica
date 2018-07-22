using System;

namespace Exercicio12CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a distância: ");
            int distancia = int.Parse(Console.ReadLine());

            int tempo = distancia * 2;
 
            Console.WriteLine(tempo + " minutos");
        }
    }
}
