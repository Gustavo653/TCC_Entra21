using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Objetos
{
    public class Usuario
    {
        public string Nome { get; set; }
        public int Filial { get; set; }
        public string Cargo { get; set; }
        public string Contato { get; set; }
        public int NivelAcesso { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Usuario(string nome, int filial, string cargo, string contato, int nivelAcesso, string login, string senha)
        {
            Nome = nome;
            Filial = filial;
            Cargo = cargo;
            Contato = contato;
            NivelAcesso = nivelAcesso;
            Login = login;
            Senha = senha;
        }
    }
}
