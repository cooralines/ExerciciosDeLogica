using System;
using System.Globalization;

namespace Exercicio9CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroFunc, numeroHorasTrab;
            double valorHora, salario;

            numeroFunc = int.Parse(Console.ReadLine());

            numeroHorasTrab = int.Parse(Console.ReadLine());

            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = numeroHorasTrab * valorHora;

            Console.WriteLine("NUMBER = " + numeroFunc);

            Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));
        }
    }
}
