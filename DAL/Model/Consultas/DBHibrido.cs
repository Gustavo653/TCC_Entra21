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
            if (File.Exists(DbConnection.nomeArquivoBD))
                File.Delete(DbConnection.nomeArquivoBD);

            SqlCeEngine SqlEng = new SqlCeEngine(DbConnection.connLocalString);
            SqlEng.CreateDatabase();

            List<string> tabelas = new List<string>();
            tabelas.Add("create table Enderecos(idEndereco int not null identity(1, 1),enumEndereco int not null,RazaoSocial nvarchar(50) not null,NomeFantasia nvarchar(50) not null,Cnpj nvarchar(15) not null, Contato nvarchar(14) not null, Rua nvarchar(50) not null,Numero nvarchar(6) not null,Complemento nvarchar(50) not null,Cidade nvarchar(25),Estado nvarchar(2), idFilial nvarchar(50) not null)");
            tabelas.Add("create table Caixa(idCaixa int not null identity(1, 1),Data nvarchar(10) not null,Caixa nvarchar(3) not null,UsuarioAbertura nvarchar(50) not null,UsuarioFechamento nvarchar(50) not null,Valor nvarchar(8) not null,EstadoCaixa int not null,idFilial nvarchar(50) not null,ValorDinheiro nvarchar(8) not null,ValorCredito nvarchar(8) not null,ValorDebito nvarchar(8) not null)");
            tabelas.Add("create table Vendas(idVendas int not null identity(1, 1),CodigoCupom nvarchar(50) not null,CodigoProduto nvarchar(50) not null,Quantidade int not null,ValorUnitario nvarchar(8) not null)");
            tabelas.Add("create table Usuarios(idUsuario int not null identity(1, 1),Nome nvarchar(50) not null,Filial nvarchar(50) not null,Contato nvarchar(14) not null,NivelAcesso int not null,Login nvarchar(50) not null,Senha nvarchar(128) not null)");
            tabelas.Add("create table Unidades(idUnidade int not null identity(1, 1),Nome nvarchar(30) not null,idFilial nvarchar(50))");
            tabelas.Add("create table Requisicoes(idRequisicao int not null identity(1, 1),NomeUsuario nvarchar(50) not null,Filial nvarchar(50) not null,DataRequisicao nvarchar(11) not null,Assunto nvarchar(100) not null,Solicitacao nvarchar(100) not null,RespostaRequisicao nvarchar(100) not null)");
            tabelas.Add("create table Produtos(idProduto int not null identity(1, 1),Nome nvarchar(50) not null,Unidade nvarchar(20) not null,Quantidade int not null,Codigo nvarchar(20) not null,Laboratorio nvarchar(50) not null,PrecoCusto nvarchar(8) not null,PrecoUnitario nvarchar(8) not null,Grupo int not null,idFilial nvarchar(50))");
            tabelas.Add("create table Cupom(idCupom int not null identity(1, 1),Data nvarchar(10) not null,CodigoCupom nvarchar(50) not null,FormaPagamento int not null,Vendedor nvarchar(50) not null,Cliente nvarchar(50) not null,ValorTotal nvarchar(8) not null)");
            tabelas.Add("create table Convenios(idConvenio int not null identity(1, 1),Nome nvarchar(30) not null,Desconto nvarchar(5) not null, idFilial nvarchar(50))");
            tabelas.Add("create table ContasPagar(idContaPagar int not null identity(1, 1),NomeFornecedor nvarchar(50) not null,Valor nvarchar(12) not null,Vencimento nvarchar(11) not null,idFilial nvarchar(50) not null)");
            tabelas.Add("create table ContasReceber(idContaReceber int not null identity(1, 1),NomeFornecedor nvarchar(50) not null,Valor nvarchar(12) not null,Vencimento nvarchar(11) not null,idFilial nvarchar(50) not null)");
            foreach (var item in tabelas)
            {
                DbConnection.Execute(item);
            }

        }
        public static void ReceberDados() //Clona do online para o local
        {
            VerificaInternet = 2;
            List<Objetos.Caixa> caixasOnline = Caixa_DAL.GetTodosOsCaixas();
            List<Objetos.ContasPagar> contasPagarOnline = ContasPagar_DAL.GetTodasContasPagar();
            List<Objetos.ContasReceber> contasReceberOnline = ContasReceber_DAL.GetTodasContasReceber();
            List<Objetos.Convenio> conveniosOnline = Convenios_DAL.GetTodosConvenios();
            List<Objetos.Endereco> enderecosOnline = Enderecos_DAL.GetTodosEnderecos();
            List<Objetos.Produto> produtosOnline = Produtos_DAL.GetProdutos();
            List<Objetos.Requisicao> requisicoesOnline = Requisicoes_DAL.GetRequisicoes();
            List<Objetos.Unidades> unidadesOnline = Unidades_DAL.GetTodasUnidades();
            List<Objetos.Usuario> usuariosOnline = Usuarios_DAL.GetUsuarios();
            List<Objetos.Cupom> cupomOnline = Vendas_DAL.GetCupoms();
            List<Objetos.Venda> vendaOnline = Vendas_DAL.GetVendas();
            VerificaInternet = 1;
            foreach (var item in caixasOnline)
            {
                Caixa_DAL.InsertCaixa(item.Data, item.NumCaixa, item.UsuarioAbertura, item.UsuarioFechamento, item.Valor, item.EstadoCaixa, item.idFilial, item.ValorDinheiro, item.ValorCredito, item.ValorDebito);
            }
            foreach (var item in contasPagarOnline)
            {
                ContasPagar_DAL.InsereContasPagar(item.NomeFornecedor, item.Valor, item.Vencimento, item.idFilial);
            }
            foreach (var item in contasReceberOnline)
            {
                ContasPagar_DAL.InsereContasPagar(item.NomeFornecedor, item.Valor, item.Vencimento, item.idFilial);
            }
            foreach (var item in conveniosOnline)
            {
                Convenios_DAL.InsereConvenio(item.Nome, item.Desconto, item.idFilial);
            }
            foreach (var item in enderecosOnline)
            {
                Enderecos_DAL.InsereEndereco(item.enumEndereco, item.RazaoSocial, item.NomeFantasia, item.CNPJCPF, item.Contato, item.Rua, item.Numero, item.Complemento, item.Cidade, item.Estado, item.idFilial);
            }
            foreach (var item in produtosOnline)
            {
                Produtos_DAL.InsereProduto(item.Nome, item.Unidade, item.Quantidade, item.Codigo, item.Laboratorio, item.PrecoCusto, item.PrecoUnitario, item.Grupo, item.idFilial);
            }
            foreach (var item in requisicoesOnline)
            {
                Requisicoes_DAL.InsertRequisicao(item.Nome, item.Filial, item.Data, item.Assunto, item.Solicitacao, item.Resposta);
            }
            foreach (var item in unidadesOnline)
            {
                Unidades_DAL.InsereUnidade(item.Nome, item.idFilial);
            }
            foreach (var item in cupomOnline)
            {
                Vendas_DAL.InsereCupom(item.Data, item.CodigoCupom, item.FormaPagamento, item.Vendedor, item.Cliente, item.ValorTotal);
            }
            foreach (var item in vendaOnline)
            {
                Vendas_DAL.InsertVenda(item.CodigoCupom, item.CodigoProduto, item.Quantidade, item.ValorUnitario);
            }
            foreach (var item in usuariosOnline)
            {
                Usuarios_DAL.InsereUsuario(item.Nome, item.Filial, item.Contato, item.NivelAcesso, item.Login, item.Senha);
            }
        }
        public static void EnviarDados() //Clona do local para o online
        {

        }
    }
}
