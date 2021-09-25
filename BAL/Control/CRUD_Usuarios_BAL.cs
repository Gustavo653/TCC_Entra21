using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Control
{
    public class CRUD_Usuarios_BAL
    {
        public static DAL.Model.Consultas.HashLogin hash = new DAL.Model.Consultas.HashLogin(SHA512.Create());
        public static List<DAL.Model.Objetos.Usuario> GetUsuarios()
        {
            return DAL.Model.CRUD_Usuarios_DAL.GetUsuarios();
        }
        public static List<DAL.Model.Objetos.Usuario> GetUsuariosPorNome(string nome)
        {
            return DAL.Model.CRUD_Usuarios_DAL.GetUsuariosPorNome(nome);
        }
        public static int AdicionarUsuario(string nome, string filial, string cargo, string contato, string nivelAcesso, string login, string senha)
        {
            if (!string.IsNullOrEmpty(nome) &&
                !string.IsNullOrEmpty(filial.ToString()) &&
                !string.IsNullOrEmpty(cargo) &&
                !string.IsNullOrEmpty(contato) &&
                !string.IsNullOrEmpty(nivelAcesso.ToString()) &&
                !string.IsNullOrEmpty(login) &&
                !string.IsNullOrEmpty(senha))
            {
                if (!DAL.Model.CRUD_Usuarios_DAL.VerificaSeUsuarioRepete(contato)) //Verificar se deu certo
                {
                    try
                    {
                        DAL.Model.CRUD_Usuarios_DAL.InsereUsuario(nome, Convert.ToInt32(filial), cargo, contato, Convert.ToInt32(nivelAcesso), login, hash.CriptografarSenha(senha));
                        return 0; //Deu tudo certo
                    }
                    catch (FormatException)
                    {
                        return 4; //Algum dado que o usuario inseriu nao pode ser convertido
                    }
                    catch (Exception e)
                    {
                        DAL.Model.Consultas.LogErros.GerarErro(e, "CRUD_Usuarios_Adicionar");
                        return 3; //Algo inesperado ocorreu
                    }
                }
                return 2; //Erro usuario ja existe
            }
            return 1; //Erro algum campo está vazio
        }
        public static int RemoveUsuario(string contato)
        {
            if (!string.IsNullOrEmpty(contato))
            {
                try
                {
                    DAL.Model.CRUD_Usuarios_DAL.RemoveUsuario(contato);
                    return 0; //Deu tudo certo
                }
                catch(Exception e)
                {
                    DAL.Model.Consultas.LogErros.GerarErro(e, "CRUD_Usuarios_Atualizar");
                    return 2; //Algo inesperado ocorreu
                }
            }
            return 1; //Erro contato vazio
        }
        public static int AtualizaUsuario(string nome, string filial, string cargo, string contato, string nivelAcesso, string login, string senha, string where)
        {
            if (!string.IsNullOrEmpty(nome) &&
              !string.IsNullOrEmpty(filial.ToString()) &&
              !string.IsNullOrEmpty(cargo) &&
              !string.IsNullOrEmpty(contato) &&
              !string.IsNullOrEmpty(nivelAcesso.ToString()) &&
              !string.IsNullOrEmpty(login) &&
              !string.IsNullOrEmpty(senha))
            {
                if (DAL.Model.CRUD_Usuarios_DAL.VerificaSeUsuarioRepete(contato))
                {
                    if(!(Convert.ToInt32(nivelAcesso) > 3) || !(Convert.ToInt32(nivelAcesso) < 1))
                    {
                        return 4; //Algum dado que o usuario inseriu nao pode ser convertido
                    }
                    try
                    {
                        DAL.Model.CRUD_Usuarios_DAL.AtualizaUsuario(nome, Convert.ToInt32(filial), cargo, contato, Convert.ToInt32(nivelAcesso), login, hash.CriptografarSenha(senha), where);
                        return 0; //Deu tudo certo
                    }
                    catch (FormatException)
                    {
                        return 4; //Algum dado que o usuario inseriu nao pode ser convertido
                    }
                    catch (Exception e)
                    {
                        DAL.Model.Consultas.LogErros.GerarErro(e, "CRUD_Usuarios_Atualizar");
                        return 3; //Algo inesperado ocorreu
                    }
                }
                return 2; //Erro usuario ja existe
            }
            return 1; //Erro algum campo está vazio
        }
    }
}
