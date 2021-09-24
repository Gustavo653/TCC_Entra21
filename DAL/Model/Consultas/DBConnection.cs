using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Consultas
{
    class DbConnection
    {
        //internal static SqlConnection conn = new SqlConnection("Data Source=BUE205D20;Initial Catalog=BDTurmaManha;Persist Security Info=True;User ID=guest01;Password=@Senac2021");
        //internal static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-9OFNM36;Initial Catalog=master;Integrated Security=True");
        internal static SqlConnection conn = new SqlConnection("workstation id=TCC-Entra21.mssql.somee.com;packet size=4096;user id=Gustavo10_SQLLogin_1;pwd=dg6kzsavsg;data source=TCC-Entra21.mssql.somee.com;persist security info=False;initial catalog=TCC-Entra21");

        //Funcoes genericas
        private static void Execute(string command)
        {
            SqlCommand cmd = new SqlCommand(command, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// Select all values from column from given table, table already includes dbo.
        /// </summary>
        /// <param name="column"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<string> GenericSelectUnit(string column, string table)
        {
            List<string> lista = new List<string>();
            string select = $"SELECT {column} from dbo.{table}";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(dr[0].ToString());
                //lista.Add(dr[column].ToString());
            }
            dr.Close();
            conn.Close();
            return lista;
        }
        /// <summary>
        /// Select all values from column from given table and WHERE Condition, table already includes dbo.
        /// </summary>
        /// <param name="column"></param>
        /// <param name="table"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        public static List<string> GenericSelectUnit(string column, string table, string where)
        {
            List<string> lista = new List<string>();
            string select = $"SELECT {column} from dbo.{table} WHERE {where}";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(dr[0].ToString());
                //lista.Add(dr[column].ToString());
            }
            dr.Close();
            conn.Close();
            return lista;
        }

        public static List<string[]> GenericSelectAll(string table)
        {
            List<string[]> lista = new List<string[]>();
            string select = $"SELECT * from dbo.{table}";
            SqlCommand cmd = new SqlCommand(select, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string[] vetor = new string[dr.FieldCount];
                for (int i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = dr[i].ToString();
                }
                lista.Add(vetor);
            }
            dr.Close();
            conn.Close();
            return lista;
        }
    }
}
