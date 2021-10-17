using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Objetos
{
    public class Endereco
    {
        public int enumEndereco { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJCPF { get; set; }
        public string Contato { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string idFilial { get; set; }

        public Endereco(string razaoSocial, string nomeFantasia, string cNPJCPF, string contato, string rua, string numero, string complemento, string cidade, string estado)
        {
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            CNPJCPF = cNPJCPF;
            Contato = contato;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Cidade = cidade;
            Estado = estado;
        }

        public Endereco(int enumEndereco, string razaoSocial, string nomeFantasia, string cNPJCPF, string contato, string rua, string numero, string complemento, string cidade, string estado, string idFilial)
        {
            this.enumEndereco = enumEndereco;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            CNPJCPF = cNPJCPF;
            Contato = contato;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Cidade = cidade;
            Estado = estado;
            this.idFilial = idFilial;
        }
    }
}
