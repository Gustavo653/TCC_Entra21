using DAL.Model.Objetos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Control
{
    public class Convenios_BAL
    {
        public static List<Convenio> GetConvenios()
        {
            List<Convenio> lista;
            if(DAL.Model.Objetos.UsuarioStatic.NivelAcesso == 2)
            {
                lista = DAL.Model.Convenios_DAL.GetConvenios(DAL.Model.Objetos.UsuarioStatic.Filial);
            }
            else
            {
                lista = DAL.Model.Convenios_DAL.GetConvenios();
            }

            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            foreach (var item in lista)
            {

                item.Desconto = (1.0 - Convert.ToDouble(item.Desconto)).ToString();
                item.Desconto = item.Desconto.Replace("0.", "");
                item.Desconto += "%";
            }
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            return lista;
        }
        public static List<Convenio> GetConveniosPorNome(string nome)
        {
            List<Convenio> lista;
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso == 2)
            {
                lista = DAL.Model.Convenios_DAL.GetConveniosPorNome(nome, DAL.Model.Objetos.UsuarioStatic.Filial);
            }
            else
            {
                lista = DAL.Model.Convenios_DAL.GetConveniosPorNome(nome);
            }
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            foreach (var item in lista)
            {

                item.Desconto = (1.0 - Convert.ToDouble(item.Desconto)).ToString();
                item.Desconto = item.Desconto.Replace("0.", "");
                item.Desconto += "%";
            }
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            return lista;
        }
        public static int AdicionarConvenio(string nome, string desconto)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            desconto = desconto.Replace("%", "");
            desconto = "0." + desconto;
            desconto = (1.0 - Convert.ToDouble(desconto)).ToString();
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(desconto))
            {
                if(DAL.Model.Objetos.UsuarioStatic.NivelAcesso == 3)
                {
                    return 3;
                }
                if (desconto.Contains(".") || desconto.Contains(","))
                {
                    return 4;
                }
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
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(desconto))
            {
                if (desconto.Contains(".") || desconto.Contains(","))
                {
                    return 4;
                }
                System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                desconto = desconto.Replace("%", "");
                desconto = "0." + desconto;
                desconto = (1.0 - Convert.ToDouble(desconto)).ToString();
                System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

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
            return 1; //Erro algum campo está vazio
        }
    }
}
