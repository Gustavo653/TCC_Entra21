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
    public class Convenios_DAL
    {
        private static readonly SqlConnection conn = DbConnection.conn;
        public static List<Convenio> GetConvenios()
        {
            string select = $"SELECT * from dbo.Convenios";
            List<Convenio> lista = new List<Convenio>();
            SqlCommand cmd = new SqlCommand(select, conn);
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Convenio convenio = new Convenio(dr["Nome"].ToString(), dr["Desconto"].ToString());
                lista.Add(convenio);
            }
            dr.Close();
            conn.Close();
            return lista;
        }
        public static List<Convenio> GetConveniosPorNome(string nome)
        {
            string select = $"SELECT * from dbo.Convenios WHERE Nome LIKE '%{nome}%'";
            List<Convenio> lista = new List<Convenio>();
            SqlCommand cmd = new SqlCommand(select, conn);
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Convenio convenio = new Convenio(dr["Nome"].ToString(), dr["Desconto"].ToString());
                lista.Add(convenio);
            }
            dr.Close();
            conn.Close();
            return lista;
        }
        public static void InsereConvenio(string nome, string desconto)
        {
            string insert = $"INSERT into dbo.Convenios(Nome, Desconto) values ('{nome}', '{desconto}')";
            DbConnection.Execute(insert);
        }
        public static void RemoveConvenio(string nome)
        {
            string delete = $"DELETE from dbo.Convenios WHERE Nome = '{nome}'";
            DbConnection.Execute(delete);
        }
        public static void AtualizaConvenio(string nome, string desconto, string where)
        {
            string update = $"UPDATE dbo.Convenios Set Nome = '{nome}', Desconto = '{desconto}' WHERE Nome = '{where}'";
            DbConnection.Execute(update);
        }
        public static bool VerificaSeConvenioRepete(string nome)
        {
            List<string> lista = DbConnection.GenericSelectUnit("Nome", "Convenios");
            if (lista.Contains(nome))
                return true;
            return false;
        }
    }
}
