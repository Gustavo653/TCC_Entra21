using DAL.Model.Consultas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Caixa_DAL
    {
        public static string GetValorCaixa(string data, string filial)
        {
            string valor = null;
            string select = $"SELECT Valor from dbo.Caixa WHERE Data = '{data}' AND idFilial = '{filial}'";
            SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
            if (DbConnection.conn.State == System.Data.ConnectionState.Closed)
                DbConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                valor = dr["Valor"].ToString();
            }
            dr.Close();
            DbConnection.conn.Close();
            return valor;
        }
        public static int GetCaixa(string data, string idFilial)
        {
            int caixa = 1;
            string select = $"SELECT Caixa from dbo.Caixa WHERE Data = '{data}' AND idFilial = '{idFilial}'";
            SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
            if (DbConnection.conn.State == System.Data.ConnectionState.Closed)
                DbConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                caixa = Convert.ToInt32(dr["Caixa"]);
                caixa++;
            }
            dr.Close();
            DbConnection.conn.Close();
            return caixa;
        }
        public static int GetCaixaFechamento(string data, string idFilial)
        {
            int caixa = 1;
            string select = $"SELECT Caixa from dbo.Caixa WHERE Data = '{data}' AND idFilial = '{idFilial}'";
            SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
            if (DbConnection.conn.State == System.Data.ConnectionState.Closed)
                DbConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                caixa = Convert.ToInt32(dr["Caixa"]);
            }
            dr.Close();
            DbConnection.conn.Close();
            return caixa;
        }
        public static bool VerificaEstadoCaixa(string data, string idFilial)
        {
            string select = $"SELECT EstadoCaixa from dbo.Caixa WHERE Data = '{data}' AND idFilial = '{idFilial}'";
            SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
            if (DbConnection.conn.State == System.Data.ConnectionState.Closed)
                DbConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr["EstadoCaixa"].ToString() == "1")
                {
                    dr.Close();
                    DbConnection.conn.Close();
                    return true;
                }
            }
            dr.Close();
            DbConnection.conn.Close();
            return false;
        }
        public static void AbreCaixa(string data, string caixa, string usuario, string valor, string idFilial)
        {
            string operacao;
            if (caixa == 1.ToString())
            {
                operacao = $"INSERT into dbo.Caixa (Data, Caixa, Usuario, Valor, EstadoCaixa, idFilial, ValorCredito, ValorDebito) values ('{data}', '{caixa}', '{usuario}', '{valor}', '1', '{idFilial}', '0', '0')";
            }
            else
            {
                operacao = $"UPDATE dbo.Caixa Set Valor = '{valor}', Caixa = '{GetCaixa(data, idFilial)}', EstadoCaixa = '1' WHERE Data = '{data}' AND idFilial = '{idFilial}'";
            }
            DbConnection.Execute(operacao);
        }
        public static void AtualizaCaixa(string data, string valor, string idFilial)
        {
            string valorCaixa = GetValorCaixa(data, idFilial);
            string update;
            if (Convert.ToDouble(valor) < 0)
            {
                valor = valor.Replace("-", "");
                valor = valor.Replace(",", ".");
                update = $"UPDATE dbo.Caixa Set Valor = '{Convert.ToDouble(valorCaixa) - Convert.ToDouble(valor)}' WHERE Data = '{data}' AND idFilial = '{idFilial}'";
            }
            else
            {
                valor = valor.Replace(",", ".");
                update = $"UPDATE dbo.Caixa Set Valor = '{Convert.ToDouble(valorCaixa) + Convert.ToDouble(valor)}' WHERE Data = '{data}' AND idFilial = '{idFilial}'";
            }
            DbConnection.Execute(update);
        }
        public static void FechaCaixa(string data, string caixa, string valor, string valorCredito, string valorDebito, string idFilial)
        {
            string update = $"UPDATE dbo.Caixa Set EstadoCaixa = '0', Valor = '{valor}', ValorCredito = '{valorCredito}', ValorDebito = '{valorDebito}' WHERE Data = '{data}' AND Caixa = '{caixa}' AND idFilial = '{idFilial}'";
            DbConnection.Execute(update);
        }
    }
}
