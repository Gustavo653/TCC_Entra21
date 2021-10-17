using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Objetos
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Unidade { get; set; }
        public int Quantidade { get; set; }
        public string Codigo { get; set; }
        public string Laboratorio { get; set; }
        public string PrecoCusto { get; set; }
        public string PrecoUnitario { get; set; }
        public int Grupo { get; set; }
        public string idFilial { get; set; }
        public Produto(string nome, string unidade, int quantidade, string codigo, string laboratorio, string precoCusto, string precoUnitario, int grupo)
        {
            Nome = nome;
            Unidade = unidade;
            Quantidade = quantidade;
            Codigo = codigo;
            Laboratorio = laboratorio;
            PrecoCusto = precoCusto;
            PrecoUnitario = precoUnitario;
            Grupo = grupo;
        }

        public Produto(string nome, string unidade, int quantidade, string codigo, string laboratorio, string precoCusto, string precoUnitario, int grupo, string idFilial) : this(nome, unidade, quantidade, codigo, laboratorio, precoCusto, precoUnitario, grupo)
        {
            this.idFilial = idFilial;
        }

        public Produto(int quantidade, string codigo)
        {
            Quantidade = quantidade;
            Codigo = codigo;
        }
    }
}
