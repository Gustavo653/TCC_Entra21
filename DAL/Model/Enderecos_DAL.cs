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
    public class Enderecos_DAL
    {
        private static readonly SqlConnection conn = DbConnection.conn;
        public static List<Endereco> GetEnderecos(int enumEndereco)
        {
            string select = $"SELECT * from dbo.Enderecos WHERE enumEndereco = {enumEndereco}";
            List<Endereco> lista = new List<Endereco>();
            SqlCommand cmd = new SqlCommand(select, conn);
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Endereco endereco = new Endereco(
                    dr["RazaoSocial"].ToString(),
                    dr["NomeFantasia"].ToString(),
                    dr["Cnpj"].ToString(),
                    dr["Contato"].ToString(),
                    dr["Rua"].ToString(),
                    dr["Numero"].ToString(),
                    dr["Complemento"].ToString(),
                    dr["Cidade"].ToString(),
                    dr["Estado"].ToString());
                lista.Add(endereco);
            }
            dr.Close();
            conn.Close();
            return lista;
        }
        public static List<Endereco> GetEnderecosPorNome(string nome, int enumEndereco)
        {
            string select = $"SELECT * from dbo.Enderecos WHERE enumEndereco = {enumEndereco} AND NomeFantasia LIKE '%{nome}%'";
            List<Endereco> lista = new List<Endereco>();
            SqlCommand cmd = new SqlCommand(select, conn);
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Endereco endereco = new Endereco(
                    dr["RazaoSocial"].ToString(),
                    dr["NomeFantasia"].ToString(),
                    dr["Cnpj"].ToString(),
                    dr["Contato"].ToString(),
                    dr["Rua"].ToString(),
                    dr["Numero"].ToString(),
                    dr["Complemento"].ToString(),
                    dr["Cidade"].ToString(),
                    dr["Estado"].ToString());
                lista.Add(endereco);
            }
            dr.Close();
            conn.Close();
            return lista;
        }
        public static void InsereEndereco(int enumEndereco, string razaoSocial, string nomeFantasia, string cNPJCPF, string contato, string rua, string numero, string complemento, string cidade, string estado)
        {
            string insert = $"INSERT into dbo.Enderecos(enumEndereco, RazaoSocial, NomeFantasia, Cnpj, Contato, Rua, Numero, Complemento, Cidade, Estado) values ({enumEndereco}, '{razaoSocial}', '{nomeFantasia}', '{cNPJCPF}', '{contato}', '{rua}', '{numero}','{complemento}','{cidade}','{estado}')";
            DbConnection.Execute(insert);
        }
        public static void RemoveEndereco(string contato)
        {
            string delete = $"DELETE from dbo.Enderecos WHERE Contato = '{contato}'";
            DbConnection.Execute(delete);
        }
        public static void AtualizaEndereco(string razaoSocial, string nomeFantasia, string cNPJCPF, string contato, string rua, string numero, string complemento, string cidade, string estado, string where)
        {
            string update = $"UPDATE dbo.Enderecos Set RazaoSocial = '{razaoSocial}', NomeFantasia = '{nomeFantasia}', Cnpj = '{cNPJCPF}', Contato = '{contato}', Rua = '{rua}', Numero = '{numero}', Complemento = '{complemento}', Cidade = '{cidade}', Estado = '{estado}' WHERE Contato = '{where}'";
            DbConnection.Execute(update);
        }
        public static bool VerificaSeEnderecoRepete(string contato)
        {
            List<string> lista = DbConnection.GenericSelectUnit("Contato", "Enderecos");
            if (lista.Contains(contato))
                return true;
            return false;
        }
    }
}

