using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Objetos
{
    public class Venda : IEquatable<Venda>
    {
        public string CodigoCupom { get; set; }
        public string CodigoProduto { get; set; }
        public int Quantidade { get; set; }
        public string ValorUnitario { get; set; }

        public Venda(string codigoCupom, string codigoProduto, int quantidade, string valorUnitario)
        {
            CodigoCupom = codigoCupom;
            CodigoProduto = codigoProduto;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
        }
        public bool Equals(Venda v)
        {
            return this.CodigoCupom == v.CodigoCupom;
        }
    }
}
