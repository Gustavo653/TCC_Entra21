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
        public static List<string> GetVendedorECodigoCupom(string data)
        {
            string select = $"SELECT * from dbo.Cupom WHERE Data = '{data}'";
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
    }
}
