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
            string insert = $"INSERT into dbo.Caixa (Data, Caixa, Usuario, Valor, EstadoCaixa) values ('{data}', '{caixa}', '{usuario}', '{valor}', '1')";
            DbConnection.Execute(insert);
        }
        public static void AtualizaCaixa(string data, string caixa, string valor)
        {
            string update = $"UPDATE dbo.Caixa Set Valor = '{valor}' WHERE Data = '{data}' AND Caixa = '{caixa}'";
            DbConnection.Execute(update);
        }
        public static void FechaCaixa(string data, string caixa)
        {
            string update = $"UPDATE dbo.Caixa Set EstadoCaixa = '0' WHERE Data = '{data}' AND Caixa = '{caixa}'";
            DbConnection.Execute(update);
        }
    }
}
