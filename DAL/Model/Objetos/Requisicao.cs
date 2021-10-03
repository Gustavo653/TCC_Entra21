using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Objetos
{
    public class Requisicao
    {
        public string Nome { get; set; }
        public string Filial { get; set; }
        public string Data { get; set; }
        public string Assunto { get; set; }
        public string Solicitacao { get; set; }
        public string Resposta { get; set; }

        public Requisicao(string nome, string filial, string data, string assunto, string solicitacao, string resposta)
        {
            Nome = nome;
            Filial = filial;
            Data = data;
            Assunto = assunto;
            Solicitacao = solicitacao;
            Resposta = resposta;
        }
    }
}
