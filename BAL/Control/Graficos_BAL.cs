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
        public static string FuncionarioComMaisVendas()
        {
            //Pegar NomeFuncionario e CodigoCupom do dbo.Cupom
            //Contar qual funcionario tem mais cupons
            return null;
        }
        public static List<string> ProdutosMaisVendidos()
        {
            //Selecionar todas as vendas da dbo.Vendas e mostrar produtos mais vendidos (somar todas as quantidades)
            return null;
        }
        public static void RelacaoCompraVenda()
        {
            //Obter preco de custo e preco de venda de todos os produtos
        }

        //TodasFiliais
    }
}
