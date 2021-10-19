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
        public static int EstadoPrograma { get; set; } = 0; //Verifica se o programa está sincronizando ou em funcionamento normal.
        public static string nomeArquivoBD = @"C:\Users\Public\Documents\FarmaTech\DB.sdf"; //Caminho do arquivo BD
        public static string caminhoCommands = @"C:\Users\Public\Documents\FarmaTech\Commands\Commands.txt"; //Caminho do arquivo commands.
        public static SqlConnection connRemota = new SqlConnection("workstation id=TCC-Entra21.mssql.somee.com;packet size=4096;user id=Gustavo10_SQLLogin_1;pwd=dg6kzsavsg;data source=TCC-Entra21.mssql.somee.com;persist security info=False;initial catalog=TCC-Entra21"); //Connection BD Online
        public static SqlCeConnection connLocal = new SqlCeConnection(string.Format("DataSource=\"{0}\"; Password='{1}'", nomeArquivoBD, "")); //Connection BD Local
        public static string connLocalString = string.Format("DataSource=\"{0}\"; Password='{1}'", nomeArquivoBD, ""); //String BD Local

        public static void SetConnectionString() //Seta as strings de conexão.
        {
            Objetos.ConnectionStatic.connRemoto = connRemota;
            Objetos.ConnectionStatic.connLocal = connLocal;
        }

        //Funcoes genericas
        public static void Execute(string command) 
        {
            if (DBHibrido.EscolhaBD == 1)
            {
                if (EstadoPrograma != 0) //Se for diferente de 0 gera o log dos commandsSql
                {
                    Log.GerarCommands(command);
                }
                command = command.Replace("dbo.", "");               
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
            if (DBHibrido.EscolhaBD == 1)
            {
                List<string> lista = new List<string>();
                string select = $"SELECT {column} from {table}";
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
