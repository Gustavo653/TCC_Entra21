using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Control
{
    public class Caixa_BAL
    {
        public static int GetCaixa()
        {
            return DAL.Model.Caixa_DAL.GetCaixa(DateTime.Now.ToString().Substring(0, 10));
        }
        public static bool GetEstadoCaixa()
        {
            return DAL.Model.Caixa_DAL.VerificaEstadoCaixa(DateTime.Now.ToString().Substring(0, 10));
        }
        public static int AbreCaixa(string data, string caixa, string usuario, string valor)
        {
            if (!string.IsNullOrEmpty(caixa) && !string.IsNullOrEmpty(valor) && Convert.ToDouble(valor) > 0)
            {
                valor = valor.Replace(",", ".");
                try
                {
                    DAL.Model.Caixa_DAL.AbreCaixa(data, caixa, usuario, valor);
                    return 0;
                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.LogErros.GerarErro(e, "CAIXA_Abrir");
                    return 2;
                }
            }
            return 1;
        }
    }
}
