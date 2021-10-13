using DAL.Model.Consultas;
using DAL.Model.Objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Vendas_DAL
    {
        public static double ValorTotalProduto(string quant, string precoUnitario)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            double resultado = (Convert.ToDouble(quant) * Convert.ToDouble(precoUnitario));
            return resultado;
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
        }

        public static double ValorTotal(string quant, string precoUnitario, string desconto)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            double resultado = ((Convert.ToDouble(quant) * Convert.ToDouble(precoUnitario)) - (Convert.ToDouble(desconto)));
            return resultado;
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
        }



    }
}
