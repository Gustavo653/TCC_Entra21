using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Objetos
{
    public class Cupom
    {
        public string Data { get; set; }
        public string CodigoCupom { get; set; }
        public int FormaPagamento { get; set; }
        public string Vendedor { get; set; }
        public string Cliente { get; set; }
        public string ValorTotal { get; set; }

        public Cupom(string data, string codigoCupom, int formaPagamento, string vendedor, string cliente, string valorTotal)
        {
            Data = data;
            CodigoCupom = codigoCupom;
            FormaPagamento = formaPagamento;
            Vendedor = vendedor;
            Cliente = cliente;
            ValorTotal = valorTotal;
        }
    }
}
