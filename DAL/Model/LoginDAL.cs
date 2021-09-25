using DAL.Model.Consultas;
using DAL.Model.Objetos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class LoginDAL
    {
        private static readonly SqlConnection conn = DbConnection.conn;
        private static HashLogin hash = new HashLogin(SHA512.Create());
        public static bool VerificaCredenciais(string login, string senha)
        {
            List<string> senhas = new List<string>();
            string select = $"SELECT * from dbo.Usuarios WHERE Login = '{login}'";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                UsuarioStatic.Nome = dr["Nome"].ToString();
                UsuarioStatic.Filial = Convert.ToInt32(dr["Filial"]);
                UsuarioStatic.Cargo = dr["Cargo"].ToString();
                UsuarioStatic.Contato = dr["Contato"].ToString();
                UsuarioStatic.NivelAcesso = Convert.ToInt32(dr["NivelAcesso"]); //Preenche as informacoes do usuario


                senhas.Add(dr["Senha"].ToString());
            }
            dr.Close();
            conn.Close();

            

            foreach (var item in senhas)
            {
                if(hash.VerificarSenha(senha, item))
                {
                    return true;
                }
            }

            return false;
        }      
    }
}
