using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;

namespace DAL.Model.Consultas
{
    public class DBHibrido
    {
        public static int VerificaInternet { get; set; }
        public static void GerarDBTabelas() //Cria o database e as tabelas
        {          
            if (!File.Exists(DbConnection.nomeArquivoBD))
            {
                SqlCeEngine SqlEng = new SqlCeEngine(DbConnection.connLocalString);
                SqlEng.CreateDatabase();
                SqlCeConnection cn = new SqlCeConnection(DbConnection.connLocalString);

                List<string> tabelas = new List<string>();
                tabelas.Add("create table dbo.Enderecos(idEndereco int not null identity(1, 1),enumEndereco int not null,RazaoSocial varchar(50) not null,NomeFantasia varchar(50) not null,Cnpj varchar(15) not null, Contato varchar(14) not null, Rua varchar(50) not null,Numero varchar(6) not null,Complemento varchar(50) not null,Cidade varchar(25),Estado varchar(2), idFilial varchar(50) not null)");
                tabelas.Add("create table dbo.Caixa(idCaixa int not null identity(1, 1),Data varchar(10) not null,Caixa varchar(3) not null,UsuarioAbertura varchar(50) not null,UsuarioFechamento varchar(50) not null,Valor varchar(8) not null,EstadoCaixa int not null,idFilial varchar(50) not null,ValorDinheiro varchar(8) not null,ValorCredito varchar(8) not null,ValorDebito varchar(8) not null)");
                tabelas.Add("create table dbo.Vendas(idVendas int not null identity(1, 1),CodigoCupom varchar(50) not null,CodigoProduto varchar(50) not null,Quantidade int not null,ValorUnitario varchar(8) not null)");
                tabelas.Add("create table dbo.Usuarios(idUsuario int not null identity(1, 1),Nome varchar(50) not null,Filial varchar(50) not null,Contato varchar(14) not null,NivelAcesso int not null,Login varchar(50) not null,Senha varchar(128) not null)INSERT into dbo.Usuarios(Nome, Filial, Contato, NivelAcesso, Login, Senha) values('Usuario1', 12, '5547900000000', 3, 'Admin', 'C94649567AEA10618C624BF8E8A3AF8DD443B33B928786C7BBFCD8AA5789BB6857B6585790C9BABCA576C8B94E7D38A3B87F42C972C2EE72A63C5870F09E60A5')");
                tabelas.Add("create table dbo.Unidades(idUnidade int not null identity(1, 1),Nome varchar(30) not null,idFilial varchar(50))");
                tabelas.Add("create table dbo.Requisicoes(idRequisicao int not null identity(1, 1),NomeUsuario varchar(50) not null,Filial varchar(50) not null,DataRequisicao varchar(11) not null,Assunto varchar(100) not null,Solicitacao varchar(100) not null,RespostaRequisicao varchar(100) not null)");
                tabelas.Add("create table dbo.Produtos(idProduto int not null identity(1, 1),Nome varchar(50) not null,Unidade varchar(20) not null,Quantidade int not null,Codigo varchar(20) not null,Laboratorio varchar(50) not null,PrecoCusto varchar(8) not null,PrecoUnitario varchar(8) not null,Grupo int not null,idFilial varchar(50))");
                tabelas.Add("create table dbo.Cupom(idCupom int not null identity(1, 1),Data varchar(10) not null,CodigoCupom varchar(50) not null,FormaPagamento int not null,Vendedor varchar(50) not null,Cliente varchar(50) not null,ValorTotal varchar(8) not null)");
                tabelas.Add("create table dbo.Convenios(idConvenio int not null identity(1, 1),Nome varchar(30) not null,Desconto varchar(5) not null)");
                tabelas.Add("create table dbo.ContasPagar(idContaPagar int not null identity(1, 1),NomeFornecedor VARCHAR(50) not null,Valor varchar(12) not null,Vencimento varchar(11) not null,idFilial varchar(50) not null)");
                tabelas.Add("create table dbo.ContasReceber(idContaReceber int not null identity(1, 1),NomeFornecedor VARCHAR(50) not null,Valor varchar(12) not null,Vencimento varchar(11) not null,idFilial varchar(50) not null)");
                foreach (var item in tabelas)
                {
                    Execute(cn, item);
                }     
            }
        }
        public static void ClonarOnlineLocal() //Clona do online para o local
        {
            SqlCeConnection cn = new SqlCeConnection(DbConnection.connLocalString);
            
        }
        public static void ClonarLocalOnline() //Clona do local para o online
        {

        }
        public static void Execute(SqlCeConnection cn, string sql)
        {
            cn.Open();
            SqlCeCommand cmd = new SqlCeCommand(sql, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
