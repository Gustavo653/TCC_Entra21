using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Control
{
    public class Caixa_BAL
    {
        public static int GetCaixa() //Obtem o numero do caixa
        {
            return DAL.Model.Caixa_DAL.GetCaixa(DateTime.Now.ToString().Substring(0, 10), DAL.Model.Objetos.UsuarioStatic.Filial);
        }
        public static bool GetEstadoCaixa() //Obtem o estado do caixa(aberto ou fechado)
        {
            return DAL.Model.Caixa_DAL.VerificaEstadoCaixa(DateTime.Now.ToString().Substring(0, 10), DAL.Model.Objetos.UsuarioStatic.Filial);
        }
        public static int GetFechamentoCaixa() //Obtem o estado do caixa(aberto ou fechado)
        {
            return DAL.Model.Caixa_DAL.GetCaixaFechamento(DateTime.Now.ToString().Substring(0, 10), DAL.Model.Objetos.UsuarioStatic.Filial);
        }
        public static int AbreCaixa(string data, string caixa, string usuario, string valor) //Abre o caixa, caso todas as informacoes sejam coerentes
        {
            if (!string.IsNullOrEmpty(caixa) && !string.IsNullOrEmpty(valor) && Convert.ToDouble(valor) > 0)
            {
                valor = valor.Replace(",", ".");
                try
                {
                    DAL.Model.Caixa_DAL.AbreCaixa(data, caixa, usuario, valor, DAL.Model.Objetos.UsuarioStatic.Filial);
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
        public static int AtualizaCaixa(string data, string inserir, string retirada) //Atualiza o caixa, caso todas as informacoes sejam coerentes
        {
            retirada = retirada.Replace(",", ".");
            inserir = inserir.Replace(",", ".");
            if (!string.IsNullOrEmpty(retirada) && !string.IsNullOrEmpty(inserir))
            {
                try
                {
                    string valor = (Convert.ToDouble(inserir) - Convert.ToDouble(retirada)).ToString();
                    DAL.Model.Caixa_DAL.AtualizaCaixa(data, valor, DAL.Model.Objetos.UsuarioStatic.Filial);
                    return 0;
                }
                catch (FormatException)
                {
                    return 1;
                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.LogErros.GerarErro(e, "CAIXA_Atualizar");
                    return 2;
                }
            }
            return 1;
        }
        public static int FecharCaixa(string valor, string valorCredito, string valorDebito)
        {
            if (!string.IsNullOrEmpty(valor) && !string.IsNullOrEmpty(valorCredito) && !string.IsNullOrEmpty(valorDebito))
            {
                try
                {
                    valor = valor.Replace(",", ".");
                    valorCredito = valorCredito.Replace(",", ".");
                    valorDebito = valorDebito.Replace(",", ".");
                    if (Convert.ToDouble(valor) >= 0 && Convert.ToDouble(valorCredito) >= 0 && Convert.ToDouble(valorDebito) >= 0)
                    {
                        DAL.Model.Caixa_DAL.FechaCaixa(DateTime.Now.ToString().Substring(0, 10), DAL.Model.Caixa_DAL.GetCaixaFechamento(DateTime.Now.ToString().Substring(0, 10), DAL.Model.Objetos.UsuarioStatic.Filial).ToString(), valor, valorCredito, valorDebito, DAL.Model.Objetos.UsuarioStatic.Filial);
                        return 0;
                    }
                    return 2;
                }
                catch (Exception e)
                {
                    DAL.Model.Consultas.LogErros.GerarErro(e, "Caixa_FecharCaixa");
                    return 3;
                }
            }
            return 1;
        }
    }
}
