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
    public class Usuarios_DAL
    {
        public static List<Usuario> GetUsuarios()
        {
            string select = $"SELECT * from dbo.Usuarios";
            List<Usuario> lista = new List<Usuario>();
            SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
            if (DbConnection.conn.State == System.Data.ConnectionState.Closed)
                DbConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Usuario usuario = new Usuario(
                    dr["Nome"].ToString(),
                    dr["Filial"].ToString(),
                    dr["Contato"].ToString(),
                    Convert.ToInt32(dr["NivelAcesso"]),
                    dr["Login"].ToString());
                lista.Add(usuario);
            }
            dr.Close();
            DbConnection.conn.Close();
            return lista;
        }
        public static List<Usuario> GetUsuarios(string filial)
        {
            string select = $"SELECT * from dbo.Usuarios WHERE Filial = '{filial}'";
            List<Usuario> lista = new List<Usuario>();
            SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
            if (DbConnection.conn.State == System.Data.ConnectionState.Closed)
                DbConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Usuario usuario = new Usuario(
                    dr["Nome"].ToString(),
                    dr["Filial"].ToString(),
                    dr["Contato"].ToString(),
                    Convert.ToInt32(dr["NivelAcesso"]),
                    dr["Login"].ToString());
                lista.Add(usuario);
            }
            dr.Close();
            DbConnection.conn.Close();
            return lista;
        }
        public static List<Usuario> GetUsuariosPorNome(string nome)
        {
            string select = $"SELECT * from dbo.Usuarios WHERE Nome LIKE '%{nome}%'";
            List<Usuario> lista = new List<Usuario>();
            SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
            if (DbConnection.conn.State == System.Data.ConnectionState.Closed)
                DbConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Usuario usuario = new Usuario(
                   dr["Nome"].ToString(),
                   dr["Filial"].ToString(),
                   dr["Contato"].ToString(),
                   Convert.ToInt32(dr["NivelAcesso"]),
                   dr["Login"].ToString());
                lista.Add(usuario);
            }
            dr.Close();
            DbConnection.conn.Close();
            return lista;
        }
        public static List<Usuario> GetUsuariosPorNome(string nome, string filial)
        {
            string select = $"SELECT * from dbo.Usuarios WHERE Nome LIKE '%{nome}%' AND Filial = '{filial}'";
            List<Usuario> lista = new List<Usuario>();
            SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
            if (DbConnection.conn.State == System.Data.ConnectionState.Closed)
                DbConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Usuario usuario = new Usuario(
                   dr["Nome"].ToString(),
                   dr["Filial"].ToString(),
                   dr["Contato"].ToString(),
                   Convert.ToInt32(dr["NivelAcesso"]),
                   dr["Login"].ToString());
                lista.Add(usuario);
            }
            dr.Close();
            DbConnection.conn.Close();
            return lista;
        }
        public static void InsereUsuario(string nome, string filial, string contato, int nivelAcesso, string login, string senha)
        {
            string insert = $"INSERT into dbo.Usuarios(Nome, Filial, Contato, NivelAcesso, Login, Senha) values ('{nome}', '{filial}', '{contato}', {nivelAcesso}, '{login}', '{senha}')";
            DbConnection.Execute(insert);
        }
        public static void RemoveUsuario(string contato)
        {
            string delete = $"DELETE from dbo.Usuarios WHERE Contato = '{contato}'";
            DbConnection.Execute(delete);
        }
        public static void AtualizaUsuario(string nome, string filial, string contato, int nivelAcesso, string login, string senha, string where)
        {
            string update = $"UPDATE dbo.Usuarios Set Nome = '{nome}', Filial = '{filial}', Contato = '{contato}', NivelAcesso = {nivelAcesso}, Login = '{login}', Senha = '{senha}' WHERE Contato = '{where}'";
            DbConnection.Execute(update);
        }
        public static bool VerificaSeUsuarioRepete(string contato)
        {
            List<string> lista = DbConnection.GenericSelectUnit("Contato", "Usuarios");
            if (lista.Contains(contato))
                return true;
            return false;
        }
    }
}
