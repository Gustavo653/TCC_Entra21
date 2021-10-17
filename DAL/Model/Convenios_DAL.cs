using DAL.Model.Consultas;
using DAL.Model.Objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Convenios_DAL
    {
        public static List<Convenio> GetTodosConvenios()
        {
            if (DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from Convenios";
                List<Convenio> lista = new List<Convenio>();
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Convenio convenio = new Convenio(dr["Nome"].ToString(), dr["Desconto"].ToString(), dr["idFilial"].ToString());
                    lista.Add(convenio);
                }
                dr.Close();
                ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Convenios";
                List<Convenio> lista = new List<Convenio>();
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Convenio convenio = new Convenio(dr["Nome"].ToString(), dr["Desconto"].ToString(), dr["idFilial"].ToString());
                    lista.Add(convenio);
                }
                dr.Close();
                ConnectionStatic.connRemoto.Close();
                return lista;
            }
        }
        public static List<Convenio> GetConvenios()
        {
            if (DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from Convenios";
                List<Convenio> lista = new List<Convenio>();
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Convenio convenio = new Convenio(dr["Nome"].ToString(), dr["Desconto"].ToString());
                    lista.Add(convenio);
                }
                dr.Close();
                ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Convenios";
                List<Convenio> lista = new List<Convenio>();
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Convenio convenio = new Convenio(dr["Nome"].ToString(), dr["Desconto"].ToString());
                    lista.Add(convenio);
                }
                dr.Close();
                ConnectionStatic.connRemoto.Close();
                return lista;
            }
        }
        public static List<Convenio> GetConveniosPorFilial(string idFilial)
        {
            if (DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from Convenios WHERE idFilial = '{idFilial}'";
                List<Convenio> lista = new List<Convenio>();
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Convenio convenio = new Convenio(dr["Nome"].ToString(), dr["Desconto"].ToString());
                    lista.Add(convenio);
                }
                dr.Close();
                ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Convenios WHERE idFilial = '{idFilial}'";
                List<Convenio> lista = new List<Convenio>();
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Convenio convenio = new Convenio(dr["Nome"].ToString(), dr["Desconto"].ToString());
                    lista.Add(convenio);
                }
                dr.Close();
                ConnectionStatic.connRemoto.Close();
                return lista;
            }
        }
        public static List<Convenio> GetConveniosPorNome(string nome)
        {
            if(DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from Convenios WHERE Nome LIKE '%{nome}%'";
                List<Convenio> lista = new List<Convenio>();
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Convenio convenio = new Convenio(dr["Nome"].ToString(), dr["Desconto"].ToString());
                    lista.Add(convenio);
                }
                dr.Close();
                ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Convenios WHERE Nome LIKE '%{nome}%'";
                List<Convenio> lista = new List<Convenio>();
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Convenio convenio = new Convenio(dr["Nome"].ToString(), dr["Desconto"].ToString());
                    lista.Add(convenio);
                }
                dr.Close();
                ConnectionStatic.connRemoto.Close();
                return lista;
            }
        }
        public static List<Convenio> GetConveniosPorNomePorFilial(string nome, string idFilial)
        {
            if(DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from Convenios WHERE Nome LIKE '%{nome}%' AND idFilial = '{idFilial}'";
                List<Convenio> lista = new List<Convenio>();
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Convenio convenio = new Convenio(dr["Nome"].ToString(), dr["Desconto"].ToString());
                    lista.Add(convenio);
                }
                dr.Close();
                ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Convenios WHERE Nome LIKE '%{nome}%' AND idFilial = '{idFilial}'";
                List<Convenio> lista = new List<Convenio>();
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Convenio convenio = new Convenio(dr["Nome"].ToString(), dr["Desconto"].ToString());
                    lista.Add(convenio);
                }
                dr.Close();
                ConnectionStatic.connRemoto.Close();
                return lista;
            }
        }
        public static void InsereConvenio(string nome, string desconto, string idFilial)
        {
            string insert = $"INSERT into dbo.Convenios(Nome, Desconto, idFilial) values ('{nome}', '{desconto}', '{idFilial}')";
            DbConnection.Execute(insert);
        }
        public static void RemoveConvenio(string nome)
        {
            string delete = $"DELETE from dbo.Convenios WHERE Nome = '{nome}'";
            DbConnection.Execute(delete);
        }
        public static void AtualizaConvenio(string nome, string desconto, string idFilial, string where)
        {
            string update = $"UPDATE dbo.Convenios Set Nome = '{nome}', Desconto = '{desconto}' WHERE Nome = '{where}' AND idFilial = '{idFilial}'";
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
