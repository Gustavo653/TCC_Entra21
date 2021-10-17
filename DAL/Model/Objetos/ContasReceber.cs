using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Objetos
{
    public class ContasReceber : IEquatable<ContasReceber>
    {
        public string NomeFornecedor { get; set; }
        public string Valor { get; set; }
        public string Vencimento { get; set; }
        public string idFilial { get; set; }

        public ContasReceber(string nomeFornecedor, string valor, string vencimento)
        {
            NomeFornecedor = nomeFornecedor;
            Valor = valor;
            Vencimento = vencimento;
        }

        public ContasReceber(string nomeFornecedor, string valor, string vencimento, string idFilial) : this(nomeFornecedor, valor, vencimento)
        {
            this.idFilial = idFilial;
        }
        public bool Equals(ContasReceber c)
        {
            return this.NomeFornecedor == c.NomeFornecedor && this.idFilial == c.idFilial && this.Valor == c.Valor;
        }
    }
}
