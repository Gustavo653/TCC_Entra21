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
    public class Requisicoes_DAL
    {
        public static List<Requisicao> GetRequisicoes()
        {
            if (DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from dbo.Requisicoes";
                List<Requisicao> lista = new List<Requisicao>();
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Requisicao requisicao = new Requisicao(dr["NomeUsuario"].ToString(), dr["Filial"].ToString(), dr["DataRequisicao"].ToString(), dr["Assunto"].ToString(), dr["Solicitacao"].ToString(), dr["RespostaRequisicao"].ToString());
                    lista.Add(requisicao);
                }
                dr.Close();
                ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Requisicoes";
                List<Requisicao> lista = new List<Requisicao>();
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Requisicao requisicao = new Requisicao(dr["NomeUsuario"].ToString(), dr["Filial"].ToString(), dr["DataRequisicao"].ToString(), dr["Assunto"].ToString(), dr["Solicitacao"].ToString(), dr["RespostaRequisicao"].ToString());
                    lista.Add(requisicao);
                }
                dr.Close();
                ConnectionStatic.connRemoto.Close();
                return lista;
            }
        }
        public static List<Requisicao> GetRequisicoesPorNome(string nome)
        {
            if (DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from dbo.Requisicoes WHERE NomeUsuario LIKE '%{nome}%'";
                List<Requisicao> lista = new List<Requisicao>();
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Requisicao requisicao = new Requisicao(dr["NomeUsuario"].ToString(), dr["Filial"].ToString(), dr["DataRequisicao"].ToString(), dr["Assunto"].ToString(), dr["Solicitacao"].ToString(), dr["RespostaRequisicao"].ToString());
                    lista.Add(requisicao);
                }
                dr.Close();
                ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Requisicoes WHERE NomeUsuario LIKE '%{nome}%'";
                List<Requisicao> lista = new List<Requisicao>();
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Requisicao requisicao = new Requisicao(dr["NomeUsuario"].ToString(), dr["Filial"].ToString(), dr["DataRequisicao"].ToString(), dr["Assunto"].ToString(), dr["Solicitacao"].ToString(), dr["RespostaRequisicao"].ToString());
                    lista.Add(requisicao);
                }
                dr.Close();
                ConnectionStatic.connRemoto.Close();
                return lista;
            }
        }
        public static List<Requisicao> VerificaSeUsuarioTemRequisicaoRespondida(string nome, string filial)
        {
            if(DBHibrido.VerificaInternet == 1)
            {
                string select = $"SELECT * from dbo.Requisicoes WHERE NomeUsuario = '{nome}' AND Filial = '{filial}' AND RespostaRequisicao NOT LIKE 'SemResposta'";
                List<Requisicao> lista = new List<Requisicao>();
                SqlCeCommand cmd = new SqlCeCommand(select, ConnectionStatic.connLocal);
                if (ConnectionStatic.connLocal.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connLocal.Open();
                SqlCeDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Requisicao requisicao = new Requisicao(dr["NomeUsuario"].ToString(), dr["Filial"].ToString(), dr["DataRequisicao"].ToString(), dr["Assunto"].ToString(), dr["Solicitacao"].ToString(), dr["RespostaRequisicao"].ToString());
                    lista.Add(requisicao);
                }
                dr.Close();
                ConnectionStatic.connLocal.Close();
                return lista;
            }
            else
            {
                string select = $"SELECT * from dbo.Requisicoes WHERE NomeUsuario = '{nome}' AND Filial = '{filial}' AND RespostaRequisicao NOT LIKE 'SemResposta'";
                List<Requisicao> lista = new List<Requisicao>();
                SqlCommand cmd = new SqlCommand(select, ConnectionStatic.connRemoto);
                if (ConnectionStatic.connRemoto.State == System.Data.ConnectionState.Closed)
                    ConnectionStatic.connRemoto.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Requisicao requisicao = new Requisicao(dr["NomeUsuario"].ToString(), dr["Filial"].ToString(), dr["DataRequisicao"].ToString(), dr["Assunto"].ToString(), dr["Solicitacao"].ToString(), dr["RespostaRequisicao"].ToString());
                    lista.Add(requisicao);
                }
                dr.Close();
                ConnectionStatic.connRemoto.Close();
                return lista;
            }
        }
        public static void RemoveRequisicao(string usuario, string assunto)
        {
            string delete = $"DELETE dbo.Requisicoes WHERE NomeUsuario = '{usuario}' AND Assunto = '{assunto}'";
            Consultas.DbConnection.Execute(delete);
        }
        public static void RegistrarRequisicao(string usuario, string filial, string data, string assunto, string solicitacao)
        {
            string insert = $"INSERT into dbo.Requisicoes(NomeUsuario, Filial, DataRequisicao, Assunto, Solicitacao, RespostaRequisicao) values ('{usuario}', '{filial}', '{data}', '{assunto}', '{solicitacao}', 'SemResposta')";
            Consultas.DbConnection.Execute(insert);
        }
        public static void ResponderRequisicao(string resposta, string usuario, string assunto)
        {
            string update = $"UPDATE dbo.Requisicoes Set RespostaRequisicao = '{resposta}' WHERE NomeUsuario = '{usuario}' AND Assunto = '{assunto}'";
            Consultas.DbConnection.Execute(update);
        }
    }
}
