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
        private static readonly SqlConnection conn = DbConnection.conn;
        public static string GetValorCaixa(string data)
        {
            string valor = null;
            string select = $"SELECT Valor from dbo.Caixa WHERE Data = '{data}'";
            SqlCommand cmd = new SqlCommand(select, conn);
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                valor = dr["Valor"].ToString();
            }
            dr.Close();
            conn.Close();
            return valor;
        }
        public static int GetCaixa(string data)
        {
            int caixa = 1;
            string select = $"SELECT Caixa from dbo.Caixa WHERE Data = '{data}'";
            SqlCommand cmd = new SqlCommand(select, conn);
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                caixa = Convert.ToInt32(dr["Caixa"]);
                caixa++;
            }
            dr.Close();
            conn.Close();
            return caixa;
        }
        public static bool VerificaEstadoCaixa(string data)
        {
            string select = $"SELECT EstadoCaixa from dbo.Caixa WHERE Data = '{data}'";
            SqlCommand cmd = new SqlCommand(select, conn);
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr["EstadoCaixa"].ToString() == "1")
                {
                    dr.Close();
                    conn.Close();
                    return true;
                }
            }
            dr.Close();
            conn.Close();
            return false;
        }
        public static void AbreCaixa(string data, string caixa, string usuario, string valor)
        {
            string operacao;
            if (caixa == 1.ToString())
            {
                operacao = $"INSERT into dbo.Caixa (Data, Caixa, Usuario, Valor, EstadoCaixa) values ('{data}', '{caixa}', '{usuario}', '{valor}', '1')";
            }
            else
            {
                operacao = $"UPDATE dbo.Caixa Set Valor = '{valor}', Caixa = '{GetCaixa(data)}', EstadoCaixa = '1' WHERE Data = '{data}'";
            }
            DbConnection.Execute(operacao);
        }
        public static void AtualizaCaixa(string data, string valor)
        {
            string valorCaixa = GetValorCaixa(data);
            string update;
            if (Convert.ToDouble(valor) < 0)
            {
                valor = valor.Replace("-", "");
                valor = valor.Replace(",", ".");
                update = $"UPDATE dbo.Caixa Set Valor = '{Convert.ToDouble(valorCaixa) - Convert.ToDouble(valor)}' WHERE Data = '{data}'";
            }
            else
            {
                valor = valor.Replace(",", ".");
                update = $"UPDATE dbo.Caixa Set Valor = '{Convert.ToDouble(valorCaixa) + Convert.ToDouble(valor)}' WHERE Data = '{data}'";
            }
            DbConnection.Execute(update);
        }
        public static void FechaCaixa(string data, string caixa)
        {
            string update = $"UPDATE dbo.Caixa Set EstadoCaixa = '0' WHERE Data = '{data}' AND Caixa = '{caixa}'";
            DbConnection.Execute(update);
        }
    }
}
