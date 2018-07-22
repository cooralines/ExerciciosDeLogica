using System;

namespace Exercicio23CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade em dias: ");
            int idadeDias = int.Parse(Console.ReadLine());
            int anos, meses, dias;
          
            anos = idadeDias / 365;
            meses = (idadeDias % 365) / 30;
            dias = (idadeDias % 365) % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }
    }
}
