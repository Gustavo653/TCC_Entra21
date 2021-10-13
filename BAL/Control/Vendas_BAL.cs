using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Control
{
    public class Vendas_BAL
    {
        public static string Cupom { get; set; }
        public static double ValorTotalProduto(string quant, string precoUnitario)
        {
            double teste = 0;
            if (!string.IsNullOrEmpty(quant) && !string.IsNullOrEmpty(precoUnitario))
            {
                try
                {
                    precoUnitario = precoUnitario.Replace(",", ".");
                    teste = DAL.Model.Vendas_DAL.ValorTotalProduto(quant, precoUnitario);
                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.LogErros.GerarErro(e, "Vendas_ValorTotalPedido");
                }
            }
            return teste;
        }

        public static double ValorTotal(string quant, string precoUnitario, string desconto)
        {
            double teste = 0;
            if (!string.IsNullOrEmpty(quant) && !string.IsNullOrEmpty(precoUnitario))
            {
                try
                {
                    precoUnitario = precoUnitario.Replace(",", ".");
                    desconto = desconto.Replace(",", ".");
                    teste = DAL.Model.Vendas_DAL.ValorTotal(quant, precoUnitario, desconto);

                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.LogErros.GerarErro(e, "Vendas_ValorTotal");
                }
            }
            return teste;
        }
        public static int InsereVenda(string nomeProduto, string quantidade, string valorUnitario)
        {
            if (!string.IsNullOrEmpty(nomeProduto) &&
                !string.IsNullOrEmpty(quantidade.ToString()) &&
                !string.IsNullOrEmpty(valorUnitario))
            {
                try
                {
                    if (Cupom == "CupomLivre")
                    {
                        Cupom = DAL.Model.Vendas_DAL.GeraCupom();
                    }
                    List<DAL.Model.Objetos.Produto> produtos = BAL.Control.Produtos_BAL.GetProdutosPorNome(nomeProduto);
                    DAL.Model.Vendas_DAL.InsereVenda(Cupom, produtos[0].Codigo, Convert.ToInt32(quantidade), valorUnitario);
                    return 0; //Deu tudo certo
                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.LogErros.GerarErro(e, "Vendas_BAL_InsereVenda");
                    return 2; //Erro inesperado
                }
            }
            return 1; //Algum campo esta vazio
        }
        public static int InsereCupom(string vendedor, string cliente, string valorTotal, string formaPagamento)
        {
            if (!string.IsNullOrEmpty(Cupom) &&
              !string.IsNullOrEmpty(vendedor) &&
              !string.IsNullOrEmpty(cliente) &&
              !string.IsNullOrEmpty(valorTotal) &&
              !string.IsNullOrEmpty(formaPagamento.ToString()))
            {
                DAL.Model.Vendas_DAL.InsereCupom(DateTime.Now.ToString().Substring(0, 10), Cupom, Convert.ToInt32(formaPagamento), vendedor, cliente, valorTotal);
                Cupom = "CupomLivre";
                return 0;
            }
            return 1;
        }
    }
}
