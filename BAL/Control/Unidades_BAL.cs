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
            return DAL.Model.Unidades_DAL.GetUnidades();
        }
        public static List<string> GetUnidadesPorNome(string nome)
        {
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
                        DAL.Model.Unidades_DAL.InsereUnidade(nome);
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
                    DAL.Model.Unidades_DAL.RemoveUnidade(nome);
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
                        DAL.Model.Unidades_DAL.AtualizaUnidade(nome, where);
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
