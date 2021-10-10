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
    public class Produtos_DAL
    {
        public static List<string> GetUnidades(string filial)
        {
            string select = $"SELECT * from dbo.Unidades WHERE idFilial = '{filial}'";
            List<string> lista = new List<string>();
            SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
            if (DbConnection.conn.State == System.Data.ConnectionState.Closed)
                DbConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(dr["Nome"].ToString());
            }
            dr.Close();
            DbConnection.conn.Close();
            return lista;
        }
        public static List<Produto> GetProdutos()
        {
            string select = $"SELECT * from dbo.Produtos";
            List<Produto> lista = new List<Produto>();
            SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
            if (DbConnection.conn.State == System.Data.ConnectionState.Closed)
                DbConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Produto produto = new Produto(dr["Nome"].ToString(), dr["Unidade"].ToString(), Convert.ToInt32(dr["Quantidade"]), dr["Codigo"].ToString(), dr["Laboratorio"].ToString(), dr["PrecoCusto"].ToString(), dr["PrecoUnitario"].ToString(), Convert.ToInt32(dr["Grupo"]));
                lista.Add(produto);
            }
            dr.Close();
            DbConnection.conn.Close();
            return lista;
        }
        public static List<Produto> GetProdutos(string filial)
        {
            string select = $"SELECT * from dbo.Produtos WHERE idFilial = '{filial}'";
            List<Produto> lista = new List<Produto>();
            SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
            if (DbConnection.conn.State == System.Data.ConnectionState.Closed)
                DbConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Produto produto = new Produto(dr["Nome"].ToString(), dr["Unidade"].ToString(), Convert.ToInt32(dr["Quantidade"]), dr["Codigo"].ToString(), dr["Laboratorio"].ToString(), dr["PrecoCusto"].ToString(), dr["PrecoUnitario"].ToString(), Convert.ToInt32(dr["Grupo"]));
                lista.Add(produto);
            }
            dr.Close();
            DbConnection.conn.Close();
            return lista;
        }
        public static List<Produto> GetProdutosPorNome(string nome)
        {
            string select = $"SELECT * from dbo.Produtos WHERE Nome LIKE '%{nome}%'";
            List<Produto> lista = new List<Produto>();
            SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
            if (DbConnection.conn.State == System.Data.ConnectionState.Closed)
                DbConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Produto produto = new Produto(dr["Nome"].ToString(), dr["Unidade"].ToString(), Convert.ToInt32(dr["Quantidade"]), dr["Codigo"].ToString(), dr["Laboratorio"].ToString(), dr["PrecoCusto"].ToString(), dr["PrecoUnitario"].ToString(), Convert.ToInt32(dr["Grupo"]));
                lista.Add(produto);
            }
            dr.Close();
            DbConnection.conn.Close();
            return lista;
        }
        public static List<Produto> GetProdutosPorNome(string nome, string filial)
        {
            string select = $"SELECT * from dbo.Produtos WHERE Nome LIKE '%{nome}%' AND idFilial = '{filial}'";
            List<Produto> lista = new List<Produto>();
            SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
            if (DbConnection.conn.State == System.Data.ConnectionState.Closed)
                DbConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Produto produto = new Produto(dr["Nome"].ToString(), dr["Unidade"].ToString(), Convert.ToInt32(dr["Quantidade"]), dr["Codigo"].ToString(), dr["Laboratorio"].ToString(), dr["PrecoCusto"].ToString(), dr["PrecoUnitario"].ToString(), Convert.ToInt32(dr["Grupo"]));
                lista.Add(produto);
            }
            dr.Close();
            DbConnection.conn.Close();
            return lista;
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
