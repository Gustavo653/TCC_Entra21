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
        public static int VerificaInternet { get; set; } = 2;//Inserir try catch para alterar seu valor
        public static void GerarDBTabelas() //Cria o database e as tabelas
        {          
            if (!File.Exists(DbConnection.nomeArquivoBD))
            {
                SqlCeEngine SqlEng = new SqlCeEngine(DbConnection.connLocalString);
                SqlEng.CreateDatabase();

                List<string> tabelas = new List<string>();
                tabelas.Add("create table Enderecos(idEndereco int not null identity(1, 1),enumEndereco int not null,RazaoSocial nvarchar(50) not null,NomeFantasia nvarchar(50) not null,Cnpj nvarchar(15) not null, Contato nvarchar(14) not null, Rua nvarchar(50) not null,Numero nvarchar(6) not null,Complemento nvarchar(50) not null,Cidade nvarchar(25),Estado nvarchar(2), idFilial nvarchar(50) not null)");
                tabelas.Add("create table Caixa(idCaixa int not null identity(1, 1),Data nvarchar(10) not null,Caixa nvarchar(3) not null,UsuarioAbertura nvarchar(50) not null,UsuarioFechamento nvarchar(50) not null,Valor nvarchar(8) not null,EstadoCaixa int not null,idFilial nvarchar(50) not null,ValorDinheiro nvarchar(8) not null,ValorCredito nvarchar(8) not null,ValorDebito nvarchar(8) not null)");
                tabelas.Add("create table Vendas(idVendas int not null identity(1, 1),CodigoCupom nvarchar(50) not null,CodigoProduto nvarchar(50) not null,Quantidade int not null,ValorUnitario nvarchar(8) not null)");
                tabelas.Add("create table Usuarios(idUsuario int not null identity(1, 1),Nome nvarchar(50) not null,Filial nvarchar(50) not null,Contato nvarchar(14) not null,NivelAcesso int not null,Login nvarchar(50) not null,Senha nvarchar(128) not null)INSERT into Usuarios(Nome, Filial, Contato, NivelAcesso, Login, Senha) values('Usuario1', 12, '5547900000000', 3, 'Admin', 'C94649567AEA10618C624BF8E8A3AF8DD443B33B928786C7BBFCD8AA5789BB6857B6585790C9BABCA576C8B94E7D38A3B87F42C972C2EE72A63C5870F09E60A5')");
                tabelas.Add("create table Unidades(idUnidade int not null identity(1, 1),Nome nvarchar(30) not null,idFilial nvarchar(50))");
                tabelas.Add("create table Requisicoes(idRequisicao int not null identity(1, 1),NomeUsuario nvarchar(50) not null,Filial nvarchar(50) not null,DataRequisicao nvarchar(11) not null,Assunto nvarchar(100) not null,Solicitacao nvarchar(100) not null,RespostaRequisicao nvarchar(100) not null)");
                tabelas.Add("create table Produtos(idProduto int not null identity(1, 1),Nome nvarchar(50) not null,Unidade nvarchar(20) not null,Quantidade int not null,Codigo nvarchar(20) not null,Laboratorio nvarchar(50) not null,PrecoCusto nvarchar(8) not null,PrecoUnitario nvarchar(8) not null,Grupo int not null,idFilial nvarchar(50))");
                tabelas.Add("create table Cupom(idCupom int not null identity(1, 1),Data nvarchar(10) not null,CodigoCupom nvarchar(50) not null,FormaPagamento int not null,Vendedor nvarchar(50) not null,Cliente nvarchar(50) not null,ValorTotal nvarchar(8) not null)");
                tabelas.Add("create table Convenios(idConvenio int not null identity(1, 1),Nome nvarchar(30) not null,Desconto nvarchar(5) not null)");
                tabelas.Add("create table ContasPagar(idContaPagar int not null identity(1, 1),NomeFornecedor nvarchar(50) not null,Valor nvarchar(12) not null,Vencimento nvarchar(11) not null,idFilial nvarchar(50) not null)");
                tabelas.Add("create table ContasReceber(idContaReceber int not null identity(1, 1),NomeFornecedor nvarchar(50) not null,Valor nvarchar(12) not null,Vencimento nvarchar(11) not null,idFilial nvarchar(50) not null)");
                foreach (var item in tabelas)
                {
                    DbConnection.Execute(item);
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
    }
}
