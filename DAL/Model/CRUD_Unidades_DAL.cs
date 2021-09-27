using DAL.Model.Consultas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class CRUD_Unidades_DAL
    {
        private static readonly SqlConnection conn = DbConnection.conn;
        public static List<string> GetUnidades()
        {
            string select = $"SELECT * from dbo.Unidades";
            List<string> lista = new List<string>();
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(dr["Nome"].ToString());
            }
            dr.Close();
            conn.Close();
            return lista;
        }
        public static List<string> GetUnidadesPorNome(string nome)
        {
            string select = $"SELECT * from dbo.Unidades WHERE Nome LIKE '%{nome}%'";
            List<string> lista = new List<string>();
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(dr["Nome"].ToString());
            }
            dr.Close();
            conn.Close();
            return lista;
        }
        public static void InsereUnidade(string nome)
        {
            string insert = $"INSERT into dbo.Unidades(Nome) values ('{nome}')";
            DbConnection.Execute(insert);
        }
        public static void RemoveUnidade(string nome)
        {
            string delete = $"DELETE from dbo.Unidades WHERE Nome = '{nome}'";
            DbConnection.Execute(delete);
        }
        public static void AtualizaUnidade(string nome, string where)
        {
            string update = $"UPDATE dbo.Unidades Set Nome = '{nome}' WHERE Nome = '{where}'";
            DbConnection.Execute(update);
        }
        public static bool VerificaSeUnidadeRepete(string nome)
        {
            List<string> lista = DbConnection.GenericSelectUnit("Nome", "Unidades");
            if (lista.Contains(nome))
                return true;
            return false;
        }
    }
}
