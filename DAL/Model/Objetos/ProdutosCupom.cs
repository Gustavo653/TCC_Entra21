using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Objetos
{
    public class ProdutosCupom
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public string ValorUnitario { get; set; }
        public string ValorTotal { get; set; }

        public ProdutosCupom(string nome, int quantidade, string valorUnitario, string valorTotal)
        {
            Nome = nome;
            Quantidade = quantidade;
            ValorUnitario = valorUnitario;
            ValorTotal = valorTotal;
        }
    }
}
