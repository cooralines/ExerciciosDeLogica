using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio27CSharpCondicoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            num1 = int.Parse(vet[0]);
            num2 = int.Parse(vet[1]);
            num3 = int.Parse(vet[2]);

            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine("MENOR = " + num1);
            }
            else if (num2 < num3)
            {
                Console.WriteLine("MENOR = " + num2);
            }
            else
            {
                Console.WriteLine("MENOR = " + num3);
            }

            Console.ReadKey();
        }
    }
}
