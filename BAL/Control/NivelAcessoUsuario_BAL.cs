using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Control
{
    public class NivelAcessoUsuario_BAL
    {
        public static bool VerificaPermissao(string login, string senha) //Verifica se o login possui uma permissao
        {
            return DAL.Model.Login_DAL.VerificaNivelAcesso(login, senha);
        }
        public static bool VerificaDiferencaPermissao() //Verifica a diferenca de permissao
        {
            if(DAL.Model.Objetos.UsuarioStatic.NivelAcesso != DAL.Model.Objetos.UsuarioStatic.NivelAcessoTemp)
            {
                return true;
            }
            return false;
        }
    }
}
