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
    public class Enderecos_DAL
    {
        public static List<Endereco> GetEnderecos(int enumEndereco)
        {
            if (DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from Enderecos WHERE enumEndereco = {enumEndereco}";
                List<Endereco> lista = new List<Endereco>();
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
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
                ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Enderecos WHERE enumEndereco = {enumEndereco}";
                List<Endereco> lista = new List<Endereco>();
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
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
                ConnectionStatic.connRemoto.Close();
                return lista;
            }
        }

        public static List<Endereco> GetEnderecos(int enumEndereco, string idFilial)
        {
            if (DBHibrido.VerificaInternet == 1)
            {
                string select;
                if (enumEndereco == 1)
                {
                    select = $"SELECT * from Enderecos WHERE enumEndereco = {enumEndereco} AND NomeFantasia = '{idFilial}'";
                }
                else
                {
                    select = $"SELECT * from Enderecos WHERE enumEndereco = {enumEndereco} AND idFilial = '{idFilial}'";
                }
                List<Endereco> lista = new List<Endereco>();
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
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
                ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select;
                if (enumEndereco == 1)
                {
                    select = $"SELECT * from dbo.Enderecos WHERE enumEndereco = {enumEndereco} AND NomeFantasia = '{idFilial}'";
                }
                else
                {
                    select = $"SELECT * from dbo.Enderecos WHERE enumEndereco = {enumEndereco} AND idFilial = '{idFilial}'";
                }
                List<Endereco> lista = new List<Endereco>();
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
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
                ConnectionStatic.connRemoto.Close();
                return lista;
            }
        }
        public static string GetEnderecosPorContato(string contato)
        {
            if (DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from Enderecos WHERE Contato = '{contato}'";
                string nomeFantasia = null;
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    nomeFantasia = dr["NomeFantasia"].ToString();
                    dr.Close();
                    ConnectionStatic.connLocal.Close();
                }
                dr.Close();
                ConnectionStatic.connLocal.Close();
                return nomeFantasia;
            }
            else
            {
                string select = $"SELECT * from dbo.Enderecos WHERE Contato = '{contato}'";
                string nomeFantasia = null;
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    nomeFantasia = dr["NomeFantasia"].ToString();
                    dr.Close();
                    ConnectionStatic.connRemoto.Close();
                }
                dr.Close();
                ConnectionStatic.connRemoto.Close();
                return nomeFantasia;
            }

        }
        public static List<Endereco> GetEnderecosPorNome(string nome, int enumEndereco)
        {
            if (DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from Enderecos WHERE enumEndereco = {enumEndereco} AND NomeFantasia LIKE '%{nome}%'";
                List<Endereco> lista = new List<Endereco>();
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
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
                ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Enderecos WHERE enumEndereco = {enumEndereco} AND NomeFantasia LIKE '%{nome}%'";
                List<Endereco> lista = new List<Endereco>();
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
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
                ConnectionStatic.connRemoto.Close();
                return lista;
            }
        }
        public static List<Endereco> GetEnderecosPorNome(string nome, int enumEndereco, string idFilial)
        {
            if (DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from Enderecos WHERE enumEndereco = {enumEndereco} AND NomeFantasia LIKE '%{nome}%' AND idFilial = '{idFilial}'";
                List<Endereco> lista = new List<Endereco>();
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
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
                ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Enderecos WHERE enumEndereco = {enumEndereco} AND NomeFantasia LIKE '%{nome}%' AND idFilial = '{idFilial}'";
                List<Endereco> lista = new List<Endereco>();
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
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
                ConnectionStatic.connRemoto.Close();
                return lista;
            }
        }
        public static void InsereEndereco(int enumEndereco, string razaoSocial, string nomeFantasia, string cNPJCPF, string contato, string rua, string numero, string complemento, string cidade, string estado, string idFilial)
        {
            string insert = $"INSERT into dbo.Enderecos(enumEndereco, RazaoSocial, NomeFantasia, Cnpj, Contato, Rua, Numero, Complemento, Cidade, Estado, idFilial) values ({enumEndereco}, '{razaoSocial}', '{nomeFantasia}', '{cNPJCPF}', '{contato}', '{rua}', '{numero}','{complemento}','{cidade}','{estado}', '{idFilial}')";
            DbConnection.Execute(insert);
        }
        public static void RemoveEndereco(string contato)
        {
            string delete = $"DELETE from dbo.Enderecos WHERE Contato = '{contato}'";
            DbConnection.Execute(delete);
        }
        public static void AtualizaTodasTabelas(string idFilial, string contato)
        {
            string nomeFilial = GetEnderecosPorContato(contato);
            List<string> lista = new List<string>();
            lista.Add($"UPDATE dbo.Unidades Set idFilial = '{idFilial}' WHERE idFilial = '{nomeFilial}'");
            lista.Add($"UPDATE dbo.Requisicoes Set Filial = '{idFilial}' WHERE Filial = '{nomeFilial}'");
            lista.Add($"UPDATE dbo.Usuarios Set Filial = '{idFilial}' WHERE Filial = '{nomeFilial}'");
            lista.Add($"UPDATE dbo.Produtos Set idFilial = '{idFilial}' WHERE idFilial = '{nomeFilial}'");
            lista.Add($"UPDATE dbo.ContasPagar Set idFilial = '{idFilial}' WHERE idFilial = '{nomeFilial}'");
            lista.Add($"UPDATE dbo.ContasReceber Set idFilial = '{idFilial}' WHERE idFilial = '{nomeFilial}'");
            lista.Add($"UPDATE dbo.Caixa Set idFilial = '{idFilial}' WHERE idFilial = '{nomeFilial}'");
            lista.Add($"UPDATE dbo.Cupom Set Cliente = '{idFilial}' WHERE Cliente = '{nomeFilial}'");
            foreach (var item in lista)
            {
                DbConnection.Execute(item);
            }
        }
        public static void RemoveTodasTabelas(string idFilial)
        {
            List<string> lista = new List<string>();
            lista.Add($"DELETE from dbo.Unidades WHERE idFilial = '{idFilial}'");
            lista.Add($"DELETE from dbo.Requisicoes WHERE Filial = '{idFilial}'");
            lista.Add($"DELETE from dbo.Usuarios WHERE Filial = '{idFilial}'");
            lista.Add($"DELETE from dbo.Produtos WHERE idFilial = '{idFilial}'");
            lista.Add($"DELETE from dbo.ContasPagar WHERE idFilial = '{idFilial}'");
            lista.Add($"DELETE from dbo.ContasReceber WHERE idFilial = '{idFilial}'");
            lista.Add($"DELETE from dbo.Caixa WHERE idFilial = '{idFilial}'");
            foreach (var item in lista)
            {
                DbConnection.Execute(item);
            }
        }
        public static void AtualizaEndereco(string razaoSocial, string nomeFantasia, string cNPJCPF, string contato, string rua, string numero, string complemento, string cidade, string estado, string where)
        {
            string update = $"UPDATE dbo.Enderecos Set RazaoSocial = '{razaoSocial}', NomeFantasia = '{nomeFantasia}', Cnpj = '{cNPJCPF}', Contato = '{contato}', Rua = '{rua}', Numero = '{numero}', Complemento = '{complemento}', Cidade = '{cidade}', Estado = '{estado}' WHERE Contato = '{where}'";
            AtualizaTodasTabelas(nomeFantasia, where);
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

