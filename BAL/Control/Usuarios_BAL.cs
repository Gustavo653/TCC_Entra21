using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Control
{
    public class Usuarios_BAL
    {
        public static DAL.Model.Consultas.HashLogin hash = new DAL.Model.Consultas.HashLogin(SHA512.Create()); //Criptografa a senha inserida pelo usuario
        public static List<DAL.Model.Objetos.Usuario> GetUsuarios() //Obtem todos os usuarios (de uma ou de todas as filiais)
        {
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso > 2)
            {
                return DAL.Model.Usuarios_DAL.GetUsuarios();
            }
            return DAL.Model.Usuarios_DAL.GetUsuarios(DAL.Model.Objetos.UsuarioStatic.Filial);
        }
        public static List<DAL.Model.Objetos.Usuario> GetUsuariosPorNome(string nome) //Obtem todos os usuarios por nome (de uma ou de todas as filiais)
        {
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso > 2)
            {
                return DAL.Model.Usuarios_DAL.GetUsuariosPorNome(nome);
            }
            return DAL.Model.Usuarios_DAL.GetUsuariosPorNome(nome, DAL.Model.Objetos.UsuarioStatic.Filial);
        }
        private static int ConfereNivelAcesso(string AccesLevel) //Converte de string para int (enum)
        {
            if (AccesLevel == "Funcionario")
            {
                return 1;
            }
            else if (AccesLevel == "Supervisor")
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        public static int AdicionarUsuario(string nome, string filial, string contato, string nivelAcesso, string login, string senha) //Adiciona um usuario caso esteja tudo coerente
        {
            if (!string.IsNullOrEmpty(nome) &&
                !string.IsNullOrEmpty(filial) &&
                !string.IsNullOrEmpty(contato) &&
                !string.IsNullOrEmpty(nivelAcesso) &&
                !string.IsNullOrEmpty(login) &&
                !string.IsNullOrEmpty(senha))
            {
                if (!DAL.Model.Usuarios_DAL.VerificaSeUsuarioRepete(contato)) //Verificar se deu certo
                {
                    try
                    {
                        DAL.Model.Usuarios_DAL.InsereUsuario(nome, filial, contato, ConfereNivelAcesso(nivelAcesso), login, hash.CriptografarSenha(senha));
                        return 0; //Deu tudo certo
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
        public static int RemoveUsuario(string contato) //Remove um usuario caso tudo esteja coerente
        {
            if (!string.IsNullOrEmpty(contato))
            {
                try
                {
                    DAL.Model.Usuarios_DAL.RemoveUsuario(contato);
                    return 0; //Deu tudo certo
                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.LogErros.GerarErro(e, "CRUD_Usuarios_Remover");
                    return 2; //Algo inesperado ocorreu
                }
            }
            return 1; //Erro contato vazio
        }
        public static int AtualizaUsuario(string nome, string filial, string contato, string nivelAcesso, string login, string senha, string where) //Atualiza um usuario caso tudo esteja coerente
        {
            if (!string.IsNullOrEmpty(nome) &&
              !string.IsNullOrEmpty(filial.ToString()) &&
              !string.IsNullOrEmpty(contato) &&
              !string.IsNullOrEmpty(nivelAcesso.ToString()) &&
              !string.IsNullOrEmpty(login) &&
              !string.IsNullOrEmpty(senha))
            {
                if (ConfereNivelAcesso(nivelAcesso) > 3 && ConfereNivelAcesso(nivelAcesso) < 1)
                {
                    return 4; //Algum dado que o usuario inseriu nao pode ser convertido
                }
                try
                {
                    DAL.Model.Usuarios_DAL.AtualizaUsuario(nome, filial, contato, ConfereNivelAcesso(nivelAcesso), login, hash.CriptografarSenha(senha), where);
                    return 0; //Deu tudo certo
                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.LogErros.GerarErro(e, "CRUD_Usuarios_Atualizar");
                    return 3; //Algo inesperado ocorreu
                }
            }
            return 1; //Erro algum campo está vazio
        }
    }
}
