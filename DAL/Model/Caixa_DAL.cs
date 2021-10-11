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
        public static int GetCaixa(string data, string idFilial, int entradaSaida)
        {
            List<int> caixas = new List<int>();
            string select = $"SELECT Caixa from dbo.Caixa WHERE Data = '{data}' AND idFilial = '{idFilial}'";
            SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
            if (DbConnection.conn.State == System.Data.ConnectionState.Closed)
                DbConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                caixas.Add(Convert.ToInt32(dr["Caixa"]));
            }
            dr.Close();
            DbConnection.conn.Close();

            caixas.Sort();
            caixas.Reverse();

            if (entradaSaida == 1)
            {
                int caixa = caixas[0] + 1;
                return caixa;
            }
            else
            {
                return caixas[0];
            }
        }
        public static bool VerificaEstadoCaixa(string data, string idFilial)
        {
            string select = $"SELECT EstadoCaixa from dbo.Caixa WHERE Data = '{data}' AND idFilial = '{idFilial}' AND EstadoCaixa = '1'";
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
            string operacao = $"INSERT into dbo.Caixa (Data, Caixa, Usuario, Valor, EstadoCaixa, idFilial, ValorCredito, ValorDebito) values ('{data}', '{GetCaixa(data, idFilial, 1)}', '{usuario}', '{valor}', '1', '{idFilial}', '0', '0')";
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
