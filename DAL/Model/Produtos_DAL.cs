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
    public class Produtos_DAL
    {
        public static List<string> GetUnidades(string filial)
        {
            if (DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from Unidades WHERE idFilial = '{filial}'";
                List<string> lista = new List<string>();
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr["Nome"].ToString());
                }
                dr.Close();
                ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Unidades WHERE idFilial = '{filial}'";
                List<string> lista = new List<string>();
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr["Nome"].ToString());
                }
                dr.Close();
                ConnectionStatic.connRemoto.Close();
                return lista;
            }
        }
        public static List<Produto> GetProdutos()
        {
            if (DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from Produtos";
                List<Produto> lista = new List<Produto>();
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Produto produto = new Produto(dr["Nome"].ToString(), dr["Unidade"].ToString(), Convert.ToInt32(dr["Quantidade"]), dr["Codigo"].ToString(), dr["Laboratorio"].ToString(), dr["PrecoCusto"].ToString(), dr["PrecoUnitario"].ToString(), Convert.ToInt32(dr["Grupo"]));
                    lista.Add(produto);
                }
                dr.Close();
                ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Produtos";
                List<Produto> lista = new List<Produto>();
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Produto produto = new Produto(dr["Nome"].ToString(), dr["Unidade"].ToString(), Convert.ToInt32(dr["Quantidade"]), dr["Codigo"].ToString(), dr["Laboratorio"].ToString(), dr["PrecoCusto"].ToString(), dr["PrecoUnitario"].ToString(), Convert.ToInt32(dr["Grupo"]));
                    lista.Add(produto);
                }
                dr.Close();
                ConnectionStatic.connRemoto.Close();
                return lista;
            }
        }
        public static List<Produto> GetTodosProdutos()
        {
            if (DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from Produtos";
                List<Produto> lista = new List<Produto>();
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Produto produto = new Produto(dr["Nome"].ToString(), dr["Unidade"].ToString(), Convert.ToInt32(dr["Quantidade"]), dr["Codigo"].ToString(), dr["Laboratorio"].ToString(), dr["PrecoCusto"].ToString(), dr["PrecoUnitario"].ToString(), Convert.ToInt32(dr["Grupo"]), dr["idFilial"].ToString());
                    lista.Add(produto);
                }
                dr.Close();
                ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Produtos";
                List<Produto> lista = new List<Produto>();
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Produto produto = new Produto(dr["Nome"].ToString(), dr["Unidade"].ToString(), Convert.ToInt32(dr["Quantidade"]), dr["Codigo"].ToString(), dr["Laboratorio"].ToString(), dr["PrecoCusto"].ToString(), dr["PrecoUnitario"].ToString(), Convert.ToInt32(dr["Grupo"]), dr["idFilial"].ToString());
                    lista.Add(produto);
                }
                dr.Close();
                ConnectionStatic.connRemoto.Close();
                return lista;
            }
        }
        public static List<Produto> GetProdutos(string filial)
        {
            if(DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from Produtos WHERE idFilial = '{filial}'";
                List<Produto> lista = new List<Produto>();
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Produto produto = new Produto(dr["Nome"].ToString(), dr["Unidade"].ToString(), Convert.ToInt32(dr["Quantidade"]), dr["Codigo"].ToString(), dr["Laboratorio"].ToString(), dr["PrecoCusto"].ToString(), dr["PrecoUnitario"].ToString(), Convert.ToInt32(dr["Grupo"]));
                    lista.Add(produto);
                }
                dr.Close();
                ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Produtos WHERE idFilial = '{filial}'";
                List<Produto> lista = new List<Produto>();
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Produto produto = new Produto(dr["Nome"].ToString(), dr["Unidade"].ToString(), Convert.ToInt32(dr["Quantidade"]), dr["Codigo"].ToString(), dr["Laboratorio"].ToString(), dr["PrecoCusto"].ToString(), dr["PrecoUnitario"].ToString(), Convert.ToInt32(dr["Grupo"]));
                    lista.Add(produto);
                }
                dr.Close();
                ConnectionStatic.connRemoto.Close();
                return lista;
            }
   
        }
        public static List<Produto> GetProdutosPorNome(string nome)
        {
            if(DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from Produtos WHERE Nome LIKE '%{nome}%'";
                List<Produto> lista = new List<Produto>();
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Produto produto = new Produto(dr["Nome"].ToString(), dr["Unidade"].ToString(), Convert.ToInt32(dr["Quantidade"]), dr["Codigo"].ToString(), dr["Laboratorio"].ToString(), dr["PrecoCusto"].ToString(), dr["PrecoUnitario"].ToString(), Convert.ToInt32(dr["Grupo"]));
                    lista.Add(produto);
                }
                dr.Close();
                ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Produtos WHERE Nome LIKE '%{nome}%'";
                List<Produto> lista = new List<Produto>();
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Produto produto = new Produto(dr["Nome"].ToString(), dr["Unidade"].ToString(), Convert.ToInt32(dr["Quantidade"]), dr["Codigo"].ToString(), dr["Laboratorio"].ToString(), dr["PrecoCusto"].ToString(), dr["PrecoUnitario"].ToString(), Convert.ToInt32(dr["Grupo"]));
                    lista.Add(produto);
                }
                dr.Close();
                ConnectionStatic.connRemoto.Close();
                return lista;
            }
             }
        public static List<Produto> GetProdutosPorNome(string nome, string filial)
        {
            if(DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from Produtos WHERE Nome LIKE '%{nome}%' AND idFilial = '{filial}'";
                List<Produto> lista = new List<Produto>();
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Produto produto = new Produto(dr["Nome"].ToString(), dr["Unidade"].ToString(), Convert.ToInt32(dr["Quantidade"]), dr["Codigo"].ToString(), dr["Laboratorio"].ToString(), dr["PrecoCusto"].ToString(), dr["PrecoUnitario"].ToString(), Convert.ToInt32(dr["Grupo"]));
                    lista.Add(produto);
                }
                dr.Close();
                ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Produtos WHERE Nome LIKE '%{nome}%' AND idFilial = '{filial}'";
                List<Produto> lista = new List<Produto>();
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Produto produto = new Produto(dr["Nome"].ToString(), dr["Unidade"].ToString(), Convert.ToInt32(dr["Quantidade"]), dr["Codigo"].ToString(), dr["Laboratorio"].ToString(), dr["PrecoCusto"].ToString(), dr["PrecoUnitario"].ToString(), Convert.ToInt32(dr["Grupo"]));
                    lista.Add(produto);
                }
                dr.Close();
                ConnectionStatic.connRemoto.Close();
                return lista;
            }
         }
        public static void InsereProduto(string nome, string unidade, int quantidade, string codigo, string laboratorio, string precoCusto, string precoUnitario, int grupo, string filial)
        {
            string insert = $"INSERT into dbo.Produtos(Nome, Unidade, Quantidade, Codigo, Laboratorio, PrecoCusto, PrecoUnitario, Grupo, idFilial) values ('{nome}', '{unidade}', {quantidade}, '{codigo}', '{laboratorio}', '{precoCusto}', '{precoUnitario}', {grupo}, '{filial}')";
            DbConnection.Execute(insert);
        }
        public static void RemoveProduto(string codigo)
        {
            string delete = $"DELETE from dbo.Produtos WHERE Codigo = '{codigo}'";
            DbConnection.Execute(delete);
        }
        public static void RemoveProduto(string codigo, string filial)
        {
            string delete = $"DELETE from dbo.Produtos WHERE Codigo = '{codigo}' AND idFilial = '{filial}'";
            DbConnection.Execute(delete);
        }
        public static void AtualizaProduto(string nome, string unidade, int quantidade, string codigo, string laboratorio, string precoCusto, string precoUnitario, int grupo, string whereCodigo)
        {
            string update = $"UPDATE dbo.Produtos Set Nome = '{nome}', Unidade = '{unidade}', Quantidade = {quantidade}, Codigo = '{codigo}', Laboratorio = '{laboratorio}', PrecoCusto = '{precoCusto}', PrecoUnitario = '{precoUnitario}', Grupo = {grupo} WHERE Codigo = '{whereCodigo}'";
            DbConnection.Execute(update);
        }
        public static void AtualizaProduto(string nome, string unidade, int quantidade, string codigo, string laboratorio, string precoCusto, string precoUnitario, int grupo, string whereCodigo, string whereFilial)
        {
            string update = $"UPDATE dbo.Produtos Set Nome = '{nome}', Unidade = '{unidade}', Quantidade = {quantidade}, Codigo = '{codigo}', Laboratorio = '{laboratorio}', PrecoCusto = '{precoCusto}', PrecoUnitario = '{precoUnitario}', Grupo = {grupo} WHERE Codigo = '{whereCodigo}' AND idFilial = '{whereFilial}'";
            DbConnection.Execute(update);
        }
    }
}
