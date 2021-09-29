using DAL.Model.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Control
{
    public class Convenios_BAL
    {
        public static List<Convenio> GetConvenios()
        {
            return DAL.Model.Convenios_DAL.GetConvenios();
        }
        public static List<Convenio> GetConveniosPorNome(string nome)
        {
            return DAL.Model.Convenios_DAL.GetConveniosPorNome(nome);
        }
        public static int AdicionarConvenio(string nome, string desconto)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                if (!DAL.Model.Convenios_DAL.VerificaSeConvenioRepete(nome)) //Verificar se deu certo
                {
                    try
                    {
                        DAL.Model.Convenios_DAL.InsereConvenio(nome, desconto);
                        return 0; //Deu tudo certo
                    }
                    catch (FormatException)
                    {
                        return 4; //Algum dado que o usuario inseriu nao pode ser convertido
                    }
                    catch (Exception e)
                    {
                        DAL.Model.Consultas.LogErros.GerarErro(e, "CRUD_Convenios_Adicionar");
                        return 3; //Algo inesperado ocorreu
                    }
                }
                return 2; //Erro usuario ja existe
            }
            return 1; //Erro algum campo está vazio
        }
        public static int RemoveConvenio(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                try
                {
                    DAL.Model.Convenios_DAL.RemoveConvenio(nome);
                    return 0; //Deu tudo certo
                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.LogErros.GerarErro(e, "CRUD_Convenios_Remover");
                    return 2; //Algo inesperado ocorreu
                }
            }
            return 1; //Erro contato vazio
        }
        public static int AtualizaConvenio(string nome, string desconto, string where)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                if (!DAL.Model.Convenios_DAL.VerificaSeConvenioRepete(nome))
                {
                    try
                    {
                        DAL.Model.Convenios_DAL.AtualizaConvenio(nome, desconto, where);
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
