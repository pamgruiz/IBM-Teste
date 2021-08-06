using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class Tabela
    {
        internal decimal CalculoTabela(decimal salario)
        {
            decimal faixa1 = 1106.9m;
            decimal faixa2 = 1844.83m;
            decimal faixa3 = 3689.66m;
            decimal teto = 405.86m;
            decimal desconto = teto;
            decimal percent = 0m;

            if(salario <= faixa1)
            {
                percent = salario * 0.08m;
            }

            if(salario > faixa1 && salario <= faixa2)
            {
                percent = salario * 0.09m;
            }

            if(salario > faixa1 && salario > faixa2 && salario <= faixa3)
            {
                percent = salario * 0.11m;
            }

            if(percent <= desconto)
            {
                desconto = percent;
            }

            return desconto;
        }

    }
}
