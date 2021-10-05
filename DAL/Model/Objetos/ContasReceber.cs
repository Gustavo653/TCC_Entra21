using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Objetos
{
    public class ContasReceber
    {
        public string NomeFornecedor { get; set; }
        public string Valor { get; set; }
        public string Vencimento { get; set; }

        public ContasReceber(string nomeFornecedor, string valor, string vencimento)
        {
            NomeFornecedor = nomeFornecedor;
            Valor = valor;
            Vencimento = vencimento;
        }
    }
}
