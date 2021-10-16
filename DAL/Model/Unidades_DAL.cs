using DAL.Model.Consultas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Unidades_DAL
    {
        public static List<string> GetUnidades()
        {
            if(DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from dbo.Unidades";
                List<string> lista = new List<string>();
                SqlCeCommand cmd = new SqlCeCommand(select, Objetos.ConnectionStatic.connLocal);
                if (Objetos.ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    Objetos.ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr["Nome"].ToString());
                }
                dr.Close();
                Objetos.ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Unidades";
                List<string> lista = new List<string>();
                SqlCommand cmd = new SqlCommand(select, Objetos.ConnectionStatic.connRemoto);
                if (Objetos.ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    Objetos.ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr["Nome"].ToString());
                }
                dr.Close();
                Objetos.ConnectionStatic.connRemoto.Close();
                return lista;
            }          
        }
        public static List<string> GetUnidades(string filial)
        {
            if(DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from dbo.Unidades WHERE idFilial = '{filial}'";
                List<string> lista = new List<string>();
                SqlCeCommand cmd = new SqlCeCommand(select, Objetos.ConnectionStatic.connLocal);
                if (Objetos.ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    Objetos.ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr["Nome"].ToString());
                }
                dr.Close();
                Objetos.ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Unidades WHERE idFilial = '{filial}'";
                List<string> lista = new List<string>();
                SqlCommand cmd = new SqlCommand(select, Objetos.ConnectionStatic.connRemoto);
                if (Objetos.ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    Objetos.ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr["Nome"].ToString());
                }
                dr.Close();
                Objetos.ConnectionStatic.connRemoto.Close();
                return lista;
            }
        }
        public static List<string> GetUnidadesPorNome(string nome)
        {
            if(DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from dbo.Unidades WHERE Nome LIKE '%{nome}%'";
                List<string> lista = new List<string>();
                SqlCeCommand cmd = new SqlCeCommand(select, Objetos.ConnectionStatic.connLocal);
                if (Objetos.ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    Objetos.ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr["Nome"].ToString());
                }
                dr.Close();
                Objetos.ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Unidades WHERE Nome LIKE '%{nome}%'";
                List<string> lista = new List<string>();
                SqlCommand cmd = new SqlCommand(select, Objetos.ConnectionStatic.connRemoto);
                if (Objetos.ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    Objetos.ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr["Nome"].ToString());
                }
                dr.Close();
                Objetos.ConnectionStatic.connRemoto.Close();
                return lista;
            }       
        }
        public static List<string> GetUnidadesPorNome(string nome, string filial)
        {
            if (DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from dbo.Unidades WHERE Nome LIKE '%{nome}%' AND idFilial = '{filial}'";
                List<string> lista = new List<string>();
                SqlCeCommand cmd = new SqlCeCommand(select, Objetos.ConnectionStatic.connLocal);
                if (Objetos.ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    Objetos.ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr["Nome"].ToString());
                }
                dr.Close();
                Objetos.ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Unidades WHERE Nome LIKE '%{nome}%' AND idFilial = '{filial}'";
                List<string> lista = new List<string>();
                SqlCommand cmd = new SqlCommand(select, Objetos.ConnectionStatic.connRemoto);
                if (Objetos.ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    Objetos.ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr["Nome"].ToString());
                }
                dr.Close();
                Objetos.ConnectionStatic.connRemoto.Close();
                return lista;
            }
        }
        public static void InsereUnidade(string nome, string filial)
        {
            string insert = $"INSERT into dbo.Unidades(Nome, idFilial) values ('{nome}', '{filial}')";
            DbConnection.Execute(insert);
        }
        public static void RemoveUnidade(string nome)
        {
            string delete = $"DELETE from dbo.Unidades WHERE Nome = '{nome}'";
            DbConnection.Execute(delete);
        }
        public static void RemoveUnidade(string nome, string filial)
        {
            string delete = $"DELETE from dbo.Unidades WHERE Nome = '{nome}' AND idFilial = '{filial}'";
            DbConnection.Execute(delete);
        }
        public static void AtualizaUnidade(string nome, string whereNome)
        {
            string update = $"UPDATE dbo.Unidades Set Nome = '{nome}' WHERE Nome = '{whereNome}'";
            DbConnection.Execute(update);
        }
        public static void AtualizaUnidade(string nome, string whereNome, string whereFilial)
        {
            string update = $"UPDATE dbo.Unidades Set Nome = '{nome}' WHERE Nome = '{whereNome}' AND idFilial = '{whereFilial}'";
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
