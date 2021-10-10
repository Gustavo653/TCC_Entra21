using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Control
{
    public class Vendas_BAL
    {
        public static double ValorTotalProduto(string quant, string precoUnitario)
        {
            double teste = 0;
            if (!string.IsNullOrEmpty(quant) && !string.IsNullOrEmpty(precoUnitario))
            {
                try
                {
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
                    teste = DAL.Model.Vendas_DAL.ValorTotal(quant, precoUnitario, desconto);

                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.LogErros.GerarErro(e, "Vendas_ValorTotal");
                }
            }
            return teste;
        }

    }
}
