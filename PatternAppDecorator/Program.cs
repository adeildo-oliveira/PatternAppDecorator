using PatternAppDecorator.ImpostoRendaDecorator;
using System;

namespace PatternAppDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var salario = new Salario(1500M, 1600M);
            var resultado = new AliquotaPercentual7(new AliquotaPercentual15());

            Console.WriteLine(resultado.CalculaImposto(salario));
            //Console.ReadKey();
        }
    }
}
