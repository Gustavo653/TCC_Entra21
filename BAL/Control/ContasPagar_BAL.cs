using DAL.Model.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Control
{
    public class ContasPagar_BAL
    {
        public static List<ContasPagar> GetContasPagar() //Obtem todas as contas a pagar
        {
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso == 3)
            {
                return DAL.Model.ContasPagar_DAL.GetContasPagar(); //De todas as filiais
            }
            return DAL.Model.ContasPagar_DAL.GetContasPagar(DAL.Model.Objetos.UsuarioStatic.Filial); //De uma filial
        }
        public static List<ContasPagar> GetContasPagarPorNome(string nome) //Obtem contas a pagar (pesquisando) por nome
        {
            return DAL.Model.ContasPagar_DAL.GetContasPagarPorNome(nome);
        }
        public static int AdicionarContasPagar(string nome, string valor, string vencimento) //Adiciona uma conta a pagar caso todos os dados sejam coerentes
        {
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(valor) && !string.IsNullOrEmpty(vencimento))
            {
                if(DAL.Model.Objetos.UsuarioStatic.NivelAcesso == 3)
                {
                    return 2; //Usuario sem filial
                }
                try
                {
                    valor = valor.Replace(",", ".");
                    DAL.Model.ContasPagar_DAL.InsereContasPagar(nome, valor, vencimento, DAL.Model.Objetos.UsuarioStatic.Filial);
                    return 0; //Deu tudo certo
                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.LogErros.GerarErro(e, "CRUD_ContasPagar_Adicionar");
                    return 3; //Algo inesperado ocorreu
                }
            }
            return 1; //Erro algum campo está vazio
        }
        public static int RemoveContasPagar(string nome, string valor, string vencimento) //Remove conta a pagar caso tudo esteja coerente
        {
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(valor) && !string.IsNullOrEmpty(vencimento))
            {
                try
                {
                    DAL.Model.ContasPagar_DAL.RemoveContasPagar(nome, valor, vencimento);
                    return 0; //Deu tudo certo
                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.LogErros.GerarErro(e, "CRUD_ContasPagar_Remover");
                    return 2; //Algo inesperado ocorreu
                }
            }
            return 1; //Erro contato vazio
        }
        public static int AtualizaContasPagar(string nome, string valor, string vencimento, string whereNome, string whereValor) //Atualiza contas a pagar
        {
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(valor) && !string.IsNullOrEmpty(vencimento))
            {     
                try
                {
                    valor = valor.Replace(",", ".");
                    DAL.Model.ContasPagar_DAL.AtualizaContasPagar(nome, valor, vencimento, whereNome, whereValor);
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
