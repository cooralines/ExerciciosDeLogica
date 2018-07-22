using System;
using System.Globalization;

namespace Exercicio9CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número do funcionário: ");
            int numeroFunc = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de horas trabalhadas: ");
            int numeroHorasTrab = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor por hora: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = numeroHorasTrab * valorHora;

            Console.WriteLine("Número do funcionário " + numeroFunc);

            Console.WriteLine("Salário = R$ " + salario.ToString("F2"));
        }
    }
}
