using DAL.Model.Consultas;
using DAL.Model.Objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Vendas_DAL
    {
        public static double ValorTotalProduto(string quant, string precoUnitario)
        {
            double resultado = (Convert.ToDouble(quant) * Convert.ToDouble(precoUnitario));
            return resultado;
        }
    }
}
