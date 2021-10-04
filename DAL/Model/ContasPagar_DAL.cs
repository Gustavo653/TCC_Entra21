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
    public class ContasPagar_DAL
    {
        private static readonly SqlConnection conn = DbConnection.conn;
        public static List<ContasPagar> GetContasPagar()
        {
            string select = $"SELECT * from dbo.ContasPagar";
            List<ContasPagar> lista = new List<ContasPagar>();
            SqlCommand cmd = new SqlCommand(select, conn);
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ContasPagar ContasPagar = new ContasPagar(dr["NomeFornecedor"].ToString(), dr["Valor"].ToString(), dr["Vencimento"].ToString());
                lista.Add(ContasPagar);
            }
            dr.Close();
            conn.Close();
            return lista;
        }
        public static List<ContasPagar> GetContasPagar(string idFilial)
        {
            string select = $"SELECT * from dbo.ContasPagar WHERE idFilial = '{idFilial}'";
            List<ContasPagar> lista = new List<ContasPagar>();
            SqlCommand cmd = new SqlCommand(select, conn);
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ContasPagar ContasPagar = new ContasPagar(dr["NomeFornecedor"].ToString(), dr["Valor"].ToString(), dr["Vencimento"].ToString());
                lista.Add(ContasPagar);
            }
            dr.Close();
            conn.Close();
            return lista;
        }
        public static List<ContasPagar> GetContasPagarPorNome(string nome)
        {
            string select = $"SELECT * from dbo.ContasPagar WHERE NomeFornecedor LIKE '%{nome}%'";
            List<ContasPagar> lista = new List<ContasPagar>();
            SqlCommand cmd = new SqlCommand(select, conn);
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ContasPagar ContasPagar = new ContasPagar(dr["NomeFornecedor"].ToString(), dr["Valor"].ToString(), dr["Vencimento"].ToString());
                lista.Add(ContasPagar);
            }
            dr.Close();
            conn.Close();
            return lista;
        }
        public static List<ContasPagar> GetContasPagarPorNome(string nome, string idFilial)
        {
            string select = $"SELECT * from dbo.ContasPagar WHERE NomeFornecedor LIKE '%{nome}%' AND idFilial = '{idFilial}'";
            List<ContasPagar> lista = new List<ContasPagar>();
            SqlCommand cmd = new SqlCommand(select, conn);
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ContasPagar ContasPagar = new ContasPagar(dr["NomeFornecedor"].ToString(), dr["Valor"].ToString(), dr["Vencimento"].ToString());
                lista.Add(ContasPagar);
            }
            dr.Close();
            conn.Close();
            return lista;
        }
        public static void InsereContasPagar(string nome, string valor, string vencimento, string idFilial)
        {
            string insert = $"INSERT into dbo.ContasPagar(NomeFornecedor, Valor, Vencimento, idFilial) values ('{nome}', '{valor}', '{vencimento}', '{idFilial}')";
            DbConnection.Execute(insert);
        }
        public static void RemoveContasPagar(string nome, string valor, string vencimento)
        {
            string delete = $"DELETE from dbo.ContasPagar WHERE NomeFornecedor = '{nome}' AND Valor = '{valor}' AND Vencimento = '{vencimento}'";
            DbConnection.Execute(delete);
        }
        public static void AtualizaContasPagar(string nome, string valor, string vencimento, string whereNome, string whereValor)
        {
            string update = $"UPDATE dbo.ContasPagar Set NomeFornecedor = '{nome}', Valor = '{valor}', Vencimento = '{vencimento}' WHERE NomeFornecedor = '{whereNome}' AND Valor = '{whereValor}'";
            DbConnection.Execute(update);
        }
        public static bool VerificaSeContasPagarRepete(string nome)
        {
            List<string> lista = DbConnection.GenericSelectUnit("NomeFornecedor", "ContasPagar");
            if (lista.Contains(nome))
                return true;
            return false;
        }
    }
}
