using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model.Consultas
{
    public class DbConnection
    {
        public static string nomeArquivoBD = @"C:\Users\Public\Documents\DB.sdf";

        public static SqlConnection connRemota = new SqlConnection("workstation id=TCC-Entra21.mssql.somee.com;packet size=4096;user id=Gustavo10_SQLLogin_1;pwd=dg6kzsavsg;data source=TCC-Entra21.mssql.somee.com;persist security info=False;initial catalog=TCC-Entra21");
        public static SqlCeConnection connLocal = new SqlCeConnection(string.Format("DataSource=\"{0}\"; Password='{1}'", nomeArquivoBD, ""));
        public static string connLocalString = string.Format("DataSource=\"{0}\"; Password='{1}'", nomeArquivoBD, "");

        public static void SetConnectionString()
        {
            Objetos.ConnectionStatic.connRemoto = connRemota;
            Objetos.ConnectionStatic.connLocal = connLocal;
        }

        //Funcoes genericas
        public static void Execute(string command)
        {
            if (DBHibrido.VerificaInternet == 1)
            {
                command = command.Replace("dbo.", "");
                //command = command.Replace("'", "");
                //string cmd2 = null;
                //if (command.Contains("INSERT"))
                //{
                //    int cont = 0;
                //    cmd2 = "";
                //    for (int i = 0; i < command.Length; i++)
                //    {
                //        if (cont == 1)
                //        {
                //            if (command[i - 1] == '(')
                //            {
                //                cmd2.Append('\'');
                //            }
                //            if (command[i + 1] == ')')
                //            {
                //                cmd2.Append('\'');
                //            }
                //        }
                //        if (command[i] == '(')
                //        {
                //            cont++;
                //        }
                //        if (command[i].ToString() != @"\")
                //            cmd2 += command[i];
                //    }
                //}
                //if (cmd2 != null)
                //    command = cmd2;
                SqlCeCommand cmd = new SqlCeCommand(command, Objetos.ConnectionStatic.connLocal);
                Objetos.ConnectionStatic.connLocal.Open();
                cmd.ExecuteNonQuery();
                Objetos.ConnectionStatic.connLocal.Close();
            }
            else
            {
                SqlCommand cmd = new SqlCommand(command, Objetos.ConnectionStatic.connRemoto);
                Objetos.ConnectionStatic.connRemoto.Open();
                cmd.ExecuteNonQuery();
                Objetos.ConnectionStatic.connRemoto.Close();
            }
        }
        /// <summary>
        /// Select all values from column from given table, table already includes dbo.
        /// </summary>
        /// <param name="column"></param>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<string> GenericSelectUnit(string column, string table)
        {
            if (DBHibrido.VerificaInternet == 1)
            {
                List<string> lista = new List<string>();
                string select = $"SELECT {column} from dbo.{table}";
                SqlCeCommand cmd = new SqlCeCommand(select, Objetos.ConnectionStatic.connLocal);
                Objetos.ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr[0].ToString());
                    //lista.Add(dr[column].ToString());
                }
                dr.Close();
                Objetos.ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                List<string> lista = new List<string>();
                string select = $"SELECT {column} from dbo.{table}";
                SqlCommand cmd = new SqlCommand(select, Objetos.ConnectionStatic.connRemoto);
                Objetos.ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(dr[0].ToString());
                    //lista.Add(dr[column].ToString());
                }
                dr.Close();
                Objetos.ConnectionStatic.connRemoto.Close();
                return lista;
            }
        }
    }
}
