using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTech.Model.Objetos
{
    class UsuarioStatic
    {
        public static string Nome { get; set; }
        public static int Filial { get; set; }
        public static string Cargo { get; set; }
        public static string Contato { get; set; }
        public static int NivelAcesso { get; set; }
        //public string Login { get; set; }//Há a necessidade de guardar as credenciais?
        //public string Senha { get; set; } //Há a necessidade de guardar as credenciais?
    }
}
