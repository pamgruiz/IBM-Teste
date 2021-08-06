using System;

namespace INSS
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULO DE INSS");
            Console.WriteLine("DIGITE O SALARIO: ");

            decimal valor = Decimal.Parse(Console.ReadLine());

            CalculaINSS calculo = new CalculaINSS();
            decimal resultado = calculo.CalcularDesconto(DateTime.Now, valor);

            Console.WriteLine("O DESCONTO SERÁ DE " + resultado);
            Console.ReadLine();
        }
    }
}
