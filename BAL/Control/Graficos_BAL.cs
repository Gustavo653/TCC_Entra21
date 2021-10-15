using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Control
{
    public class Graficos_BAL
    {
        //1 Filial
        public static string LucroPorFuncionario(string data, string idFilial)
        {
            double lucroFuncionario = 0;
            //Obter filial do vendedor para conferencia
            //Pegar Vendedor e CodigoCupom do dbo.Cupom
            //Separar cada produto vendido por 1 funcionario do dbo.Vendas
            //Obter PrecoUnitario - PrecoCusto da tabela dbo.Produtos baseado no produto vendido
            List<DAL.Model.Objetos.Usuario> usuarios = BAL.Control.Usuarios_BAL.GetUsuarios().Where(x => x.Filial == idFilial).ToList();
            List<string> cupons = DAL.Model.Graficos_DAL.GetCupons(usuarios, data);
            List<DAL.Model.Objetos.Produto> codigosProdutos = DAL.Model.Graficos_DAL.GetCodigosProduto(cupons);
            List<DAL.Model.Objetos.Produto> produtos = BAL.Control.Produtos_BAL.GetProdutos();
            foreach (var item in codigosProdutos)
            {
                DAL.Model.Objetos.Produto precoCusto = produtos.Where(x => x.Codigo == item.Codigo).ElementAt(0);
                DAL.Model.Objetos.Produto precoUnitario = produtos.Where(x => x.Codigo == item.Codigo).ElementAt(0);
                double lucroProduto = item.Quantidade * (Convert.ToDouble(precoUnitario.PrecoUnitario) - Convert.ToDouble(precoCusto.PrecoCusto));
                lucroFuncionario += lucroProduto;
            }
            lucroFuncionario /= usuarios.Count;

            return lucroFuncionario.ToString();
        }
        public static double[] RelacaoCompraVenda(string data, string idFilial)
        {
            double[] relacoes = new double[3];
            //Obter preco de custo e preco de venda de todos os produtos
            List<DAL.Model.Objetos.Usuario> usuarios = BAL.Control.Usuarios_BAL.GetUsuarios().Where(x => x.Filial == idFilial).ToList();
            List<string> cupons = DAL.Model.Graficos_DAL.GetCupons(usuarios, data);
            List<DAL.Model.Objetos.Produto> codigosProdutos = DAL.Model.Graficos_DAL.GetCodigosProduto(cupons);
            List<DAL.Model.Objetos.Produto> produtos = BAL.Control.Produtos_BAL.GetProdutos();
            foreach (var item in codigosProdutos)
            {
                DAL.Model.Objetos.Produto precoCusto = produtos.Where(x => x.Codigo == item.Codigo).ElementAt(0);
                DAL.Model.Objetos.Produto precoUnitario = produtos.Where(x => x.Codigo == item.Codigo).ElementAt(0);
                double lucroProduto = item.Quantidade * (Convert.ToDouble(precoUnitario.PrecoUnitario) - Convert.ToDouble(precoCusto.PrecoCusto));

                relacoes[0] = relacoes[0] + Convert.ToDouble(precoCusto.PrecoCusto) * item.Quantidade;
                relacoes[1] = relacoes[1] + Convert.ToDouble(precoUnitario.PrecoUnitario) * item.Quantidade;
                relacoes[2] = relacoes[2] + lucroProduto;
            }

            return relacoes;
        }
        public static string FuncionarioComMaisVendas(string data, string idFilial)
        {
            //Pegar NomeFuncionario e CodigoCupom do dbo.Cupom
            //Contar qual funcionario tem mais cupons
            int usuarioComMaisVendas = 0;
            int quantidadeVendas = 0;
            List<DAL.Model.Objetos.Usuario> usuarios = BAL.Control.Usuarios_BAL.GetUsuarios().Where(x => x.Filial == idFilial).ToList();

            for (int i = 0; i < usuarios.Count; i++)
            {
                if (DAL.Model.Graficos_DAL.GetCupons(usuarios[i], data).Count > quantidadeVendas)
                {
                    usuarioComMaisVendas = i;
                }
            }
            if (usuarios.Count > 0)
            {
                return usuarios[usuarioComMaisVendas].Nome;
            }
            return null;
        }
        public static Dictionary<string, string> ReceitaPorFuncionario(string data, string idFilial)
        {
            Dictionary<string, string> funcionarios = new Dictionary<string, string>();
            List<DAL.Model.Objetos.Usuario> usuarios = BAL.Control.Usuarios_BAL.GetUsuarios().Where(x => x.Filial == idFilial).ToList();
            foreach (var item2 in usuarios)
            {
                List<string> cupons = DAL.Model.Graficos_DAL.GetCupons(item2, data);
                List<DAL.Model.Objetos.Produto> codigosProdutos = DAL.Model.Graficos_DAL.GetCodigosProduto(cupons);
                List<DAL.Model.Objetos.Produto> produtos = BAL.Control.Produtos_BAL.GetProdutos();
                foreach (var item in codigosProdutos)
                {
                    DAL.Model.Objetos.Produto precoCusto = produtos.Where(x => x.Codigo == item.Codigo).ElementAt(0);
                    DAL.Model.Objetos.Produto precoUnitario = produtos.Where(x => x.Codigo == item.Codigo).ElementAt(0);
                    double lucroProduto = item.Quantidade * (Convert.ToDouble(precoUnitario.PrecoUnitario) - Convert.ToDouble(precoCusto.PrecoCusto));
                    if (funcionarios.ContainsKey(item2.Nome))
                    {
                        funcionarios[item2.Nome] = (Convert.ToDouble(funcionarios[item2.Nome]) + lucroProduto).ToString();
                    }
                    else
                    {
                        funcionarios.Add(item2.Nome, lucroProduto.ToString());
                    }
                }
            }
            return funcionarios;
        }
        public static Dictionary<string, int> ProdutosMaisVendidos(string data, string idFilial)
        {
            //Selecionar todas as vendas da dbo.Vendas e mostrar produtos mais vendidos (somar todas as quantidades)
            Dictionary<string, int> produtos = new Dictionary<string, int>();
            Dictionary<string, int> produtosNome = new Dictionary<string, int>();
            List<DAL.Model.Objetos.Usuario> usuarios = BAL.Control.Usuarios_BAL.GetUsuarios().Where(x => x.Filial == idFilial).ToList();
            List<string> cupons = DAL.Model.Graficos_DAL.GetCupons(usuarios, data);
            List<DAL.Model.Objetos.Produto> codigosProdutos = DAL.Model.Graficos_DAL.GetCodigosProduto(cupons);
            List<DAL.Model.Objetos.Produto> produtosEstoque = DAL.Model.Produtos_DAL.GetProdutos();
            for (int i = 0; i < codigosProdutos.Count; i++)
            {
                if (!produtos.ContainsKey(codigosProdutos[i].Codigo))
                {
                    produtos.Add(codigosProdutos[i].Codigo, codigosProdutos[i].Quantidade);
                }
                else
                {
                    produtos[codigosProdutos[i].Codigo] += codigosProdutos[i].Quantidade;
                }
            }
            produtos.OrderBy(x => x.Value);
            foreach (var item in produtos)
            {
                string codigoProduto = item.Key;
                DAL.Model.Objetos.Produto prodSelecionado = produtosEstoque.Where(x => x.Codigo == codigoProduto).ElementAt(0);
                codigoProduto = prodSelecionado.Nome;
                int quantidadeProduto = produtos[item.Key];
                produtosNome.Add(codigoProduto, quantidadeProduto);
            }
            return produtosNome;
        }
        //TodasFiliais
    }
}
