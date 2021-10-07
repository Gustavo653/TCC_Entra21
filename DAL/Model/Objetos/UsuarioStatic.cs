using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Objetos
{
    public class UsuarioStatic
    {
        public static string Nome { get; set; }
        public static string Filial { get; set; }
        public static string Contato { get; set; }
        public static int NivelAcesso { get; set; }
        public static int NivelAcessoTemp { get; set; }
    }
}
