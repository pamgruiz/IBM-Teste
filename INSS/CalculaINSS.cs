using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    class CalculaINSS : ICalculadorInss
    {
        public DateTime data { get; set; }
        public decimal salario { get; set; }

        // Calcular valor do desconto do INSS baseado no salario + ano;

        Tabela tabela = new Tabela();

        internal decimal CalcularDesconto(DateTime data, decimal salario)
        {
            int ano = TrataData(data);

            decimal desconto = tabela.CalculoTabela(salario);

            return desconto;
        }


        // Trata a data recebida e retorna apenas o ano.
        private int TrataData(DateTime data)
        {
            int ano = data.Year;
            return ano;
        }
    }
}
