using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Objetos
{
    public class Caixa : IEquatable<Caixa>
    {
        public string Data { get; set; }
        public string NumCaixa { get; set; }
        public string UsuarioAbertura { get; set; }
        public string UsuarioFechamento { get; set; }
        public string Valor { get; set; }
        public int EstadoCaixa { get; set; }
        public string idFilial { get; set; }
        public string ValorDinheiro { get; set; }
        public string ValorCredito { get; set; }
        public string ValorDebito { get; set; }

        public Caixa(string data, string numCaixa, string usuarioAbertura, string usuarioFechamento, string valor, int estadoCaixa, string idFilial, string valorDinheiro, string valorCredito, string valorDebito)
        {
            Data = data;
            NumCaixa = numCaixa;
            UsuarioAbertura = usuarioAbertura;
            UsuarioFechamento = usuarioFechamento;
            Valor = valor;
            EstadoCaixa = estadoCaixa;
            this.idFilial = idFilial;
            ValorDinheiro = valorDinheiro;
            ValorCredito = valorCredito;
            ValorDebito = valorDebito;
        }
        public bool Equals(Caixa c)
        {
            return this.Data == c.Data && this.ValorCredito == c.ValorCredito && this.idFilial == c.idFilial && this.Valor == c.Valor;
        }
    }
}
