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
    public class ContasReceber_DAL
    {
        public static List<ContasReceber> GetContasReceber()
        {
            string select = $"SELECT * from dbo.ContasReceber";
            List<ContasReceber> lista = new List<ContasReceber>();
            SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
            if (DbConnection.conn.State == System.Data.ConnectionState.Closed)
                DbConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ContasReceber ContasReceber = new ContasReceber(dr["NomeFornecedor"].ToString(), dr["Valor"].ToString(), dr["Vencimento"].ToString());
                lista.Add(ContasReceber);
            }
            dr.Close();
            DbConnection.conn.Close();
            return lista;
        }
        public static List<ContasReceber> GetContasReceber(string idFilial)
        {
            string select = $"SELECT * from dbo.ContasReceber WHERE idFilial = '{idFilial}'";
            List<ContasReceber> lista = new List<ContasReceber>();
            SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
            if (DbConnection.conn.State == System.Data.ConnectionState.Closed)
                DbConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ContasReceber ContasReceber = new ContasReceber(dr["NomeFornecedor"].ToString(), dr["Valor"].ToString(), dr["Vencimento"].ToString());
                lista.Add(ContasReceber);
            }
            dr.Close();
            DbConnection.conn.Close();
            return lista;
        }
        public static List<ContasReceber> GetContasReceberPorNome(string nome)
        {
            string select = $"SELECT * from dbo.ContasReceber WHERE NomeFornecedor LIKE '%{nome}%'";
            List<ContasReceber> lista = new List<ContasReceber>();
            SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
            if (DbConnection.conn.State == System.Data.ConnectionState.Closed)
                DbConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ContasReceber ContasReceber = new ContasReceber(dr["NomeFornecedor"].ToString(), dr["Valor"].ToString(), dr["Vencimento"].ToString());
                lista.Add(ContasReceber);
            }
            dr.Close();
            DbConnection.conn.Close();
            return lista;
        }
        public static List<ContasReceber> GetContasReceberPorNome(string nome, string idFilial)
        {
            string select = $"SELECT * from dbo.ContasReceber WHERE NomeFornecedor LIKE '%{nome}%' AND idFilial = '{idFilial}'";
            List<ContasReceber> lista = new List<ContasReceber>();
            SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
            if (DbConnection.conn.State == System.Data.ConnectionState.Closed)
                DbConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ContasReceber ContasReceber = new ContasReceber(dr["NomeFornecedor"].ToString(), dr["Valor"].ToString(), dr["Vencimento"].ToString());
                lista.Add(ContasReceber);
            }
            dr.Close();
            DbConnection.conn.Close();
            return lista;
        }
        public static void InsereContasReceber(string nome, string valor, string vencimento, string idFilial)
        {
            string insert = $"INSERT into dbo.ContasReceber(NomeFornecedor, Valor, Vencimento, idFilial) values ('{nome}', '{valor}', '{vencimento}', '{idFilial}')";
            DbConnection.Execute(insert);
        }
        public static void RemoveContasReceber(string nome, string valor, string vencimento)
        {
            string delete = $"DELETE from dbo.ContasReceber WHERE NomeFornecedor = '{nome}' AND Valor = '{valor}' AND Vencimento = '{vencimento}'";
            DbConnection.Execute(delete);
        }
        public static void AtualizaContasReceber(string nome, string valor, string vencimento, string whereNome, string whereValor)
        {
            string update = $"UPDATE dbo.ContasReceber Set NomeFornecedor = '{nome}', Valor = '{valor}', Vencimento = '{vencimento}' WHERE NomeFornecedor = '{whereNome}' AND Valor = '{whereValor}'";
            DbConnection.Execute(update);
        }
        public static bool VerificaSeContasReceberRepete(string nome)
        {
            List<string> lista = DbConnection.GenericSelectUnit("NomeFornecedor", "ContasReceber");
            if (lista.Contains(nome))
                return true;
            return false;
        }
    }
}
