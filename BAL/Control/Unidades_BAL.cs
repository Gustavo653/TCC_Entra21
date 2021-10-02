using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Control
{
    public class Unidades_BAL
    {
        public static List<string> GetUnidades()
        {
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso < 3)
            {
                return DAL.Model.Unidades_DAL.GetUnidades(DAL.Model.Objetos.UsuarioStatic.Filial);
            }
            return DAL.Model.Unidades_DAL.GetUnidades();
        }
        public static List<string> GetUnidadesPorNome(string nome)
        {
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso < 3)
            {
                return DAL.Model.Unidades_DAL.GetUnidadesPorNome(nome, DAL.Model.Objetos.UsuarioStatic.Filial);
            }
            return DAL.Model.Unidades_DAL.GetUnidadesPorNome(nome);
        }
        public static int AdicionarUnidade(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                if (!DAL.Model.Unidades_DAL.VerificaSeUnidadeRepete(nome)) //Verificar se deu certo
                {
                    try
                    {
                        DAL.Model.Unidades_DAL.InsereUnidade(nome, DAL.Model.Objetos.UsuarioStatic.Filial);
                        return 0; //Deu tudo certo
                    }
                    catch (FormatException)
                    {
                        return 4; //Algum dado que o usuario inseriu nao pode ser convertido
                    }
                    catch (Exception e)
                    {
                        DAL.Model.Consultas.LogErros.GerarErro(e, "CRUD_Unidades_Adicionar");
                        return 3; //Algo inesperado ocorreu
                    }
                }
                return 2; //Erro usuario ja existe
            }
            return 1; //Erro algum campo está vazio
        }
        public static int RemoveUnidade(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                try
                {
                    if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso > 2)
                    {
                        DAL.Model.Unidades_DAL.RemoveUnidade(nome);
                    }
                    else
                    {
                        DAL.Model.Unidades_DAL.RemoveUnidade(nome, DAL.Model.Objetos.UsuarioStatic.Filial);
                    }
                    return 0; //Deu tudo certo
                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.LogErros.GerarErro(e, "CRUD_Unidades_Remover");
                    return 2; //Algo inesperado ocorreu
                }
            }
            return 1; //Erro contato vazio
        }
        public static int AtualizaUnidade(string nome, string where)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                if (!DAL.Model.Unidades_DAL.VerificaSeUnidadeRepete(nome))
                {
                    try
                    {
                        if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso > 2)
                        {
                            DAL.Model.Unidades_DAL.AtualizaUnidade(nome, where);
                        }
                        else
                        {
                            DAL.Model.Unidades_DAL.AtualizaUnidade(nome, where, DAL.Model.Objetos.UsuarioStatic.Filial);
                        }
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
