using DAL.Model.Consultas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Graficos_DAL
    {
        public static List<string> GetCupons(List<DAL.Model.Objetos.Usuario> usuarios, string data)
        {
            List<string> lista = new List<string>();
            usuarios.Distinct();
            for (int i = 0; i < usuarios.Count; i++)
            {
                string select = $"SELECT CodigoCupom from dbo.Cupom WHERE Vendedor = '{usuarios[i].Nome}' AND Data LIKE '%{data}%'";
                SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
                if (DbConnection.conn.State == System.Data.ConnectionState.Closed)
                    DbConnection.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr["CodigoCupom"].ToString());
                }
                dr.Close();
                DbConnection.conn.Close();
            }
            return lista;
        }
        public static List<string> GetCupons(DAL.Model.Objetos.Usuario usuarios, string data)
        {
            List<string> lista = new List<string>();
            string select = $"SELECT CodigoCupom from dbo.Cupom WHERE Vendedor = '{usuarios.Nome}' AND Data LIKE '%{data}%'";
            SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
            if (DbConnection.conn.State == System.Data.ConnectionState.Closed)
                DbConnection.conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(dr["CodigoCupom"].ToString());
            }
            dr.Close();
            DbConnection.conn.Close();

            return lista;
        }
        public static List<Objetos.Produto> GetCodigosProduto(List<string> cupons)
        {
            List<Objetos.Produto> lista = new List<Objetos.Produto>();
            for (int i = 0; i < cupons.Count; i++)
            {
                string select = $"SELECT CodigoProduto, Quantidade from dbo.Vendas WHERE CodigoCupom = '{cupons[i]}'";
                SqlCommand cmd = new SqlCommand(select, DbConnection.conn);
                if (DbConnection.conn.State == System.Data.ConnectionState.Closed)
                    DbConnection.conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Objetos.Produto(Convert.ToInt32(dr["Quantidade"]), dr["CodigoProduto"].ToString()));
                }
                dr.Close();
                DbConnection.conn.Close();
            }
            return lista;
        }
    }
}
