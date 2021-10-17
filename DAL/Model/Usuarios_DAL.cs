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
    public class Usuarios_DAL
    {
        public static string GetUsuarioPorContato(string contato)
        {
            if (DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT Nome from Usuarios WHERE Contato = '{contato}'";
                List<string> lista = new List<string>();
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lista.Add(dr["Nome"].ToString());
                }
                dr.Close();
                ConnectionStatic.connLocal.Close();
                if (lista.Count > 0)
                {
                    return lista[0];
                }
                else
                {
                    return null;
                }
            }
            else
            {
                string select = $"SELECT Nome from dbo.Usuarios WHERE Contato = '{contato}'";
                List<string> lista = new List<string>();
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lista.Add(dr["Nome"].ToString());
                }
                dr.Close();
                ConnectionStatic.connRemoto.Close();
                if (lista.Count > 0)
                {
                    return lista[0];
                }
                else
                {
                    return null;
                }
            }
        }
        public static List<Usuario> GetUsuarios()
        {
            if (DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from Usuarios";
                List<Usuario> lista = new List<Usuario>();
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Usuario usuario = new Usuario(
                        dr["Nome"].ToString(),
                        dr["Filial"].ToString(),
                        dr["Contato"].ToString(),
                        Convert.ToInt32(dr["NivelAcesso"]),
                        dr["Login"].ToString(), 
                        dr["Senha"].ToString());
                    lista.Add(usuario);
                }
                dr.Close();
                ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Usuarios";
                List<Usuario> lista = new List<Usuario>();
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Usuario usuario = new Usuario(
                       dr["Nome"].ToString(),
                       dr["Filial"].ToString(),
                       dr["Contato"].ToString(),
                       Convert.ToInt32(dr["NivelAcesso"]),
                       dr["Login"].ToString(),
                       dr["Senha"].ToString());
                    lista.Add(usuario);
                }
                dr.Close();
                ConnectionStatic.connRemoto.Close();
                return lista;
            }
        }
        public static List<Usuario> GetUsuarios(string filial)
        {
            if (DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from Usuarios WHERE Filial = '{filial}'";
                List<Usuario> lista = new List<Usuario>();
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Usuario usuario = new Usuario(
                                dr["Nome"].ToString(),
                                dr["Filial"].ToString(),
                                dr["Contato"].ToString(),
                                Convert.ToInt32(dr["NivelAcesso"]),
                                dr["Login"].ToString(),
                                dr["Senha"].ToString());
                    lista.Add(usuario);
                }
                dr.Close();
                ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Usuarios WHERE Filial = '{filial}'";
                List<Usuario> lista = new List<Usuario>();
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Usuario usuario = new Usuario(
                         dr["Nome"].ToString(),
                         dr["Filial"].ToString(),
                         dr["Contato"].ToString(),
                         Convert.ToInt32(dr["NivelAcesso"]),
                         dr["Login"].ToString(),
                         dr["Senha"].ToString());
                    lista.Add(usuario);
                }
                dr.Close();
                ConnectionStatic.connRemoto.Close();
                return lista;
            }
        }
        public static List<Usuario> GetUsuariosPorNome(string nome)
        {
            if(DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from Usuarios WHERE Nome LIKE '%{nome}%'";
                List<Usuario> lista = new List<Usuario>();
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Usuario usuario = new Usuario(
                          dr["Nome"].ToString(),
                          dr["Filial"].ToString(),
                          dr["Contato"].ToString(),
                          Convert.ToInt32(dr["NivelAcesso"]),
                          dr["Login"].ToString(),
                          dr["Senha"].ToString());
                    lista.Add(usuario);
                }
                dr.Close();
                ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Usuarios WHERE Nome LIKE '%{nome}%'";
                List<Usuario> lista = new List<Usuario>();
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Usuario usuario = new Usuario(
                         dr["Nome"].ToString(),
                         dr["Filial"].ToString(),
                         dr["Contato"].ToString(),
                         Convert.ToInt32(dr["NivelAcesso"]),
                         dr["Login"].ToString(),
                         dr["Senha"].ToString());
                    lista.Add(usuario);
                }
                dr.Close();
                ConnectionStatic.connRemoto.Close();
                return lista;
            }        
        }
        public static List<Usuario> GetUsuariosPorNome(string nome, string filial)
        {
            if(DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from Usuarios WHERE Nome LIKE '%{nome}%' AND Filial = '{filial}'";
                List<Usuario> lista = new List<Usuario>();
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Usuario usuario = new Usuario(
                        dr["Nome"].ToString(),
                        dr["Filial"].ToString(),
                        dr["Contato"].ToString(),
                        Convert.ToInt32(dr["NivelAcesso"]),
                        dr["Login"].ToString(),
                        dr["Senha"].ToString());
                    lista.Add(usuario);
                }
                dr.Close();
                ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Usuarios WHERE Nome LIKE '%{nome}%' AND Filial = '{filial}'";
                List<Usuario> lista = new List<Usuario>();
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Usuario usuario = new Usuario(
                        dr["Nome"].ToString(),
                        dr["Filial"].ToString(),
                        dr["Contato"].ToString(),
                        Convert.ToInt32(dr["NivelAcesso"]),
                        dr["Login"].ToString(),
                        dr["Senha"].ToString());
                    lista.Add(usuario);
                }
                dr.Close();
                ConnectionStatic.connRemoto.Close();
                return lista;
            }
      
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
            string nomeUsuario = GetUsuarioPorContato(contato);
            List<string> comandos = new List<string>();
            comandos.Add($"UPDATE dbo.Caixa Set UsuarioAbertura = '{nome}', UsuarioFechamento = '{nome}' WHERE UsuarioAbertura = '{nomeUsuario}' OR UsuarioFechamento = '{nomeUsuario}'");
            comandos.Add($"UPDATE dbo.Cupom Set Vendedor = '{nome}' WHERE Vendedor = '{nomeUsuario}'");
            comandos.Add($"UPDATE dbo.Usuarios Set Nome = '{nome}', Filial = '{filial}', Contato = '{contato}', NivelAcesso = {nivelAcesso}, Login = '{login}', Senha = '{senha}' WHERE Contato = '{where}'");
            foreach (var item in comandos)
            {
                DbConnection.Execute(item);
            }
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
