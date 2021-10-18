using DAL.Model.Consultas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Caixa_DAL
    {
        public static List<Objetos.Caixa> GetTodosOsCaixas()
        {
            List<Objetos.Caixa> caixas = new List<Objetos.Caixa>();
            if (DBHibrido.EscolhaBD == 1)
            {
                string select = $"SELECT * from Caixa";
                SqlCeCommand cmd = new SqlCeCommand(select, Objetos.ConnectionStatic.connLocal);
                if (Objetos.ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    Objetos.ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Objetos.Caixa caixa = new Objetos.Caixa(dr["Data"].ToString(), dr["Caixa"].ToString(), dr["UsuarioAbertura"].ToString(), dr["UsuarioFechamento"].ToString(), dr["Valor"].ToString(), Convert.ToInt32(dr["EstadoCaixa"]), dr["idFilial"].ToString(), dr["ValorDinheiro"].ToString(), dr["ValorCredito"].ToString(), dr["ValorDebito"].ToString());
                    caixas.Add(caixa);
                }
                dr.Close();
                Objetos.ConnectionStatic.connLocal.Close();
                return caixas;
            }
            else
            {
                string select = $"SELECT * from dbo.Caixa";
                SqlCommand cmd = new SqlCommand(select, Objetos.ConnectionStatic.connRemoto);
                if (Objetos.ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    Objetos.ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Objetos.Caixa caixa = new Objetos.Caixa(dr["Data"].ToString(), dr["Caixa"].ToString(), dr["UsuarioAbertura"].ToString(), dr["UsuarioFechamento"].ToString(), dr["Valor"].ToString(), Convert.ToInt32(dr["EstadoCaixa"]), dr["idFilial"].ToString(), dr["ValorDinheiro"].ToString(), dr["ValorCredito"].ToString(), dr["ValorDebito"].ToString());
                    caixas.Add(caixa);
                }
                dr.Close();
                Objetos.ConnectionStatic.connRemoto.Close();
                return caixas;
            }
        }
        public static string GetValorCaixa(string data, string filial)
        {
            if (DBHibrido.EscolhaBD == 1)
            {
                string valor = null;
                string select = $"SELECT Valor from Caixa WHERE Data = '{data}' AND idFilial = '{filial}'";
                SqlCeCommand cmd = new SqlCeCommand(select, Objetos.ConnectionStatic.connLocal);
                if (Objetos.ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    Objetos.ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    valor = dr["Valor"].ToString();
                }
                dr.Close();
                Objetos.ConnectionStatic.connLocal.Close();
                return valor;
            }
            else
            {
                string valor = null;
                string select = $"SELECT Valor from dbo.Caixa WHERE Data = '{data}' AND idFilial = '{filial}'";
                SqlCommand cmd = new SqlCommand(select, Objetos.ConnectionStatic.connRemoto);
                if (Objetos.ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    Objetos.ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    valor = dr["Valor"].ToString();
                }
                dr.Close();
                Objetos.ConnectionStatic.connRemoto.Close();
                return valor;
            }
        }
        public static int GetCaixa(string data, string idFilial, int entradaSaida)
        {
            if (DBHibrido.EscolhaBD == 1)
            {
                List<int> caixas = new List<int>();
                string select = $"SELECT Caixa from Caixa WHERE Data = '{data}' AND idFilial = '{idFilial}'";
                SqlCeCommand cmd = new SqlCeCommand(select, Objetos.ConnectionStatic.connLocal);
                if (Objetos.ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    Objetos.ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    caixas.Add(Convert.ToInt32(dr["Caixa"]));
                }
                dr.Close();
                Objetos.ConnectionStatic.connLocal.Close();

                caixas.Sort();
                caixas.Reverse();

                if (caixas.Count == 0)
                {
                    return 1;
                }
                if (entradaSaida == 1)
                {
                    int caixa = caixas[0] + 1;
                    return caixa;
                }
                else
                {
                    return caixas[0];
                }
            }
            else
            {
                List<int> caixas = new List<int>();
                string select = $"SELECT Caixa from dbo.Caixa WHERE Data = '{data}' AND idFilial = '{idFilial}'";
                SqlCommand cmd = new SqlCommand(select, Objetos.ConnectionStatic.connRemoto);
                if (Objetos.ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    Objetos.ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    caixas.Add(Convert.ToInt32(dr["Caixa"]));
                }
                dr.Close();
                Objetos.ConnectionStatic.connRemoto.Close();

                caixas.Sort();
                caixas.Reverse();

                if (caixas.Count == 0)
                {
                    return 1;
                }
                if (entradaSaida == 1)
                {
                    int caixa = caixas[0] + 1;
                    return caixa;
                }
                else
                {
                    return caixas[0];
                }
            }
        }
        public static bool VerificaEstadoCaixa(string data, string idFilial)
        {
            if (DBHibrido.EscolhaBD == 1)
            {
                string select = $"SELECT EstadoCaixa from Caixa WHERE Data = '{data}' AND idFilial = '{idFilial}' AND EstadoCaixa = '1'";
                SqlCeCommand cmd = new SqlCeCommand(select, Objetos.ConnectionStatic.connLocal);
                if (Objetos.ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    Objetos.ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["EstadoCaixa"].ToString() == "1")
                    {
                        dr.Close();
                        Objetos.ConnectionStatic.connLocal.Close();
                        return true;
                    }
                }
                dr.Close();
                Objetos.ConnectionStatic.connLocal.Close();
                return false;
            }
            else
            {
                string select = $"SELECT EstadoCaixa from dbo.Caixa WHERE Data = '{data}' AND idFilial = '{idFilial}' AND EstadoCaixa = '1'";
                SqlCommand cmd = new SqlCommand(select, Objetos.ConnectionStatic.connRemoto);
                if (Objetos.ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    Objetos.ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr["EstadoCaixa"].ToString() == "1")
                    {
                        dr.Close();
                        Objetos.ConnectionStatic.connRemoto.Close();
                        return true;
                    }
                }
                dr.Close();
                Objetos.ConnectionStatic.connRemoto.Close();
                return false;
            }
        }
        public static void AbreCaixa(string data, string usuario, string valor, string idFilial)
        {
            string operacao = $"INSERT into dbo.Caixa (Data, Caixa, UsuarioAbertura, UsuarioFechamento, Valor, EstadoCaixa, idFilial, ValorDinheiro, ValorCredito, ValorDebito) values ('{data}', '{GetCaixa(data, idFilial, 1)}', '{usuario}', 'Vazio', '{valor}', '1', '{idFilial}', '0', '0', '0')";
            DbConnection.Execute(operacao);
        }
        public static void InsertCaixa(string data, string caixa, string usuarioAbertura, string usuarioFechamento, string valor, int estadoCaixa, string idFilial, string valorDinheiro, string valorCredito, string valorDebito)
        {
            string operacao = $"INSERT into dbo.Caixa (Data, Caixa, UsuarioAbertura, UsuarioFechamento, Valor, EstadoCaixa, idFilial, ValorDinheiro, ValorCredito, ValorDebito) values ('{data}', '{caixa}', '{usuarioAbertura}', '{usuarioFechamento}', '{valor}', {estadoCaixa}, '{idFilial}', '{valorDinheiro}', '{valorCredito}', '{valorDebito}')";
            DbConnection.Execute(operacao);
        }
        public static void UpdateCaixa(string data, string caixa, string usuarioAbertura, string usuarioFechamento, string valor, int estadoCaixa, string idFilial, string valorDinheiro, string valorCredito, string valorDebito, string whereData, string whereidFilial, string whereValor)
        {
            string update = $"UPDATE dbo.Caixa Set Data = '{data}', Caixa = '{caixa}', UsuarioAbertura = '{usuarioAbertura}', UsuarioFechamento = '{usuarioFechamento}', Valor = '{valor}', EstadoCaixa = {estadoCaixa}, idFilial = '{idFilial}', ValorDinheiro = '{valorDinheiro}', ValorCredito = '{valorCredito}', ValorDebito = '{valorDebito}' WHERE Data = '{whereData}' AND idFilial = '{whereidFilial}' AND Valor = '{whereValor}'";
        }
        public static void AtualizaCaixa(string data, string valor, string idFilial)
        {
            string valorCaixa = GetValorCaixa(data, idFilial);
            string update;
            if (Convert.ToDouble(valor) < 0)
            {
                valor = valor.Replace("-", "");
                valor = valor.Replace(",", ".");
                update = $"UPDATE dbo.Caixa Set Valor = '{Convert.ToDouble(valorCaixa) - Convert.ToDouble(valor)}' WHERE Data = '{data}' AND idFilial = '{idFilial}'";
            }
            else
            {
                valor = valor.Replace(",", ".");
                update = $"UPDATE dbo.Caixa Set Valor = '{Convert.ToDouble(valorCaixa) + Convert.ToDouble(valor)}' WHERE Data = '{data}' AND idFilial = '{idFilial}'";
            }
            DbConnection.Execute(update);
        }
        public static void FechaCaixa(string data, string caixa, string valorDinheiro, string valorCredito, string valorDebito, string idFilial, string usuarioFechamento)
        {
            string update = $"UPDATE dbo.Caixa Set UsuarioFechamento = '{usuarioFechamento}', EstadoCaixa = '0', ValorDinheiro = '{valorDinheiro}', ValorCredito = '{valorCredito}', ValorDebito = '{valorDebito}' WHERE Data = '{data}' AND Caixa = '{caixa}' AND idFilial = '{idFilial}'";
            DbConnection.Execute(update);
        }
    }
}
