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
    class CRUD_Usuarios_DAL
    {
        private static readonly SqlConnection conn = DbConnection.conn;
        public static List<Usuario> GetUsuarios()
        {
            string select = $"SELECT * from dbo.Usuarios";
            List<Usuario> lista = new List<Usuario>();
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Usuario usuario = new Usuario(
                    dr["Nome"].ToString(),
                    Convert.ToInt32(dr["Filial"]),
                    dr["Cargo"].ToString(),
                    dr["Contato"].ToString(),
                    Convert.ToInt32(dr["NivelAcesso"]),
                    dr["Login"].ToString(),
                    dr["Senha"].ToString());
                lista.Add(usuario);
            }
            dr.Close();
            conn.Close();
            return lista;
        }
        public static List<Usuario> GetUsuariosPorNome(string nome)
        {
            string select = $"SELECT * from dbo.Usuarios WHERE Nome LIKE '%{nome}%'";
            List<Usuario> lista = new List<Usuario>();
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Usuario usuario = new Usuario(
                    dr["Nome"].ToString(),
                    Convert.ToInt32(dr["Filial"]),
                    dr["Cargo"].ToString(),
                    dr["Contato"].ToString(),
                    Convert.ToInt32(dr["NivelAcesso"]),
                    dr["Login"].ToString(),
                    dr["Senha"].ToString());
                lista.Add(usuario);
            }
            dr.Close();
            conn.Close();
            return lista;
        }
    }
}
