using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Control
{
    public class Produtos_BAL
    {
        public static List<string> GetUnidades() //Obtem todas as unidades
        {
            return DAL.Model.Produtos_DAL.GetUnidades(DAL.Model.Objetos.UsuarioStatic.Filial);
        }
        public static List<DAL.Model.Objetos.Produto> GetProdutos() //Obtem todos os produtos (por filial ou por todas as filiais)
        {
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso < 3)
            {
                return DAL.Model.Produtos_DAL.GetProdutos(DAL.Model.Objetos.UsuarioStatic.Filial);
            }
            return DAL.Model.Produtos_DAL.GetProdutos();
        }
        public static List<DAL.Model.Objetos.Produto> GetProdutosPorNome(string nome) //Obtem todos os produtos por nome (por filial ou por todas as filiais)
        {
            if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso < 3)
            {
                return DAL.Model.Produtos_DAL.GetProdutosPorNome(nome, DAL.Model.Objetos.UsuarioStatic.Filial);
            }
            return DAL.Model.Produtos_DAL.GetProdutosPorNome(nome);
        }
        public static int AdicionarProduto(string nome, string unidade, string quantidade, string codigo, string laboratorio, string precoCusto, string precoUnitario, string grupo) //Adicioa um produto caso tudo esteja coerente
        {
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(unidade) && !string.IsNullOrEmpty(quantidade.ToString()) && !string.IsNullOrEmpty(laboratorio) && !string.IsNullOrEmpty(precoCusto) && !string.IsNullOrEmpty(precoUnitario) && !string.IsNullOrEmpty(grupo.ToString()))
            {
                try
                {
                    DAL.Model.Produtos_DAL.InsereProduto(nome, unidade, Convert.ToInt32(quantidade), codigo, laboratorio, precoCusto, precoUnitario, Convert.ToInt32(grupo), DAL.Model.Objetos.UsuarioStatic.Filial);
                    return 0; //Deu tudo certo
                }
                catch (FormatException)
                {
                    return 4; //Algum dado que o usuario inseriu nao pode ser convertido
                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.LogErros.GerarErro(e, "CRUD_Produtos_Adicionar");
                    return 3; //Algo inesperado ocorreu
                }
            }
            return 1; //Erro algum campo está vazio
        }
        public static int RemoveProduto(string codigo) //Remove um produto caso tudo esteja coerente
        {
            if (!string.IsNullOrEmpty(codigo))
            {
                try
                {
                    if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso > 2)
                    {
                        DAL.Model.Produtos_DAL.RemoveProduto(codigo);
                    }
                    else
                    {
                        DAL.Model.Produtos_DAL.RemoveProduto(codigo, DAL.Model.Objetos.UsuarioStatic.Filial);
                    }
                    return 0; //Deu tudo certo
                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.LogErros.GerarErro(e, "CRUD_Produtos_Remover");
                    return 2; //Algo inesperado ocorreu
                }
            }
            return 1; //Erro contato vazio
        }
        public static int AtualizaProduto(string nome, string unidade, string quantidade, string codigo, string laboratorio, string precoCusto, string precoUnitario, string grupo) //Atualiza um produto caso tudo esteja coerente
        {
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(unidade) && !string.IsNullOrEmpty(quantidade) && !string.IsNullOrEmpty(laboratorio) && !string.IsNullOrEmpty(precoCusto) && !string.IsNullOrEmpty(precoUnitario) && !string.IsNullOrEmpty(grupo))
            {
                try
                {
                    if (DAL.Model.Objetos.UsuarioStatic.NivelAcesso > 2)
                    {
                        DAL.Model.Produtos_DAL.AtualizaProduto(nome, unidade, Convert.ToInt32(quantidade), codigo, laboratorio, precoCusto, precoUnitario, Convert.ToInt32(grupo), codigo);
                    }
                    else
                    {
                        DAL.Model.Produtos_DAL.AtualizaProduto(nome, unidade, Convert.ToInt32(quantidade), codigo, laboratorio, precoCusto, precoUnitario, Convert.ToInt32(grupo), codigo, DAL.Model.Objetos.UsuarioStatic.Filial);
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
            return 1; //Erro algum campo está vazio
        }
    }
}
