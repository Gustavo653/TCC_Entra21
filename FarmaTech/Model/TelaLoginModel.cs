using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FarmaTech.Model
{
    class TelaLoginModel
    {
        private static readonly SqlConnection conn = DbConnection.conn;
        private static HashLogin hash = new HashLogin(SHA512.Create());
        public static bool VerificaCredenciais(string login, string senha)
        {
            List<string> senhas = new List<string>();
            string select = $"SELECT Login, Senha from dbo.Usuarios WHERE Login = '{login}'";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
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
