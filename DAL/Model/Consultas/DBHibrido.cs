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
            //if (File.Exists(DbConnection.nomeArquivoBD))
            //    File.Delete(DbConnection.nomeArquivoBD);
            if (!File.Exists(DbConnection.nomeArquivoBD))
            {
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
            List<Objetos.Caixa> caixasLocal = Caixa_DAL.GetTodosOsCaixas();
            List<Objetos.ContasPagar> contasPagarLocal = ContasPagar_DAL.GetTodasContasPagar();
            List<Objetos.ContasReceber> contasReceberLocal = ContasReceber_DAL.GetTodasContasReceber();
            List<Objetos.Convenio> conveniosLocal = Convenios_DAL.GetTodosConvenios();
            List<Objetos.Endereco> enderecosLocal = Enderecos_DAL.GetTodosEnderecos();
            List<Objetos.Produto> produtosLocal = Produtos_DAL.GetProdutos();
            List<Objetos.Requisicao> requisicoesLocal = Requisicoes_DAL.GetRequisicoes();
            List<Objetos.Unidades> unidadesLocal = Unidades_DAL.GetTodasUnidades();
            List<Objetos.Usuario> usuariosLocal = Usuarios_DAL.GetUsuarios();
            List<Objetos.Cupom> cupomLocal = Vendas_DAL.GetCupoms();
            List<Objetos.Venda> vendaLocal = Vendas_DAL.GetVendas();

            for (int i = 0; i < caixasOnline.Count; i++)
            {
                if (!caixasLocal.Contains(caixasOnline[i]))
                {                 
                    Caixa_DAL.InsertCaixa(caixasOnline[i].Data, caixasOnline[i].NumCaixa, caixasOnline[i].UsuarioAbertura, caixasOnline[i].UsuarioFechamento, caixasOnline[i].Valor, caixasOnline[i].EstadoCaixa, caixasOnline[i].idFilial, caixasOnline[i].ValorDinheiro, caixasOnline[i].ValorCredito, caixasOnline[i].ValorDebito);
                }
            }
            for (int i = 0; i < contasPagarOnline.Count; i++)
            {
                if (!contasPagarLocal.Contains(contasPagarOnline[i]))
                {
                    ContasPagar_DAL.InsereContasPagar(contasPagarOnline[i].NomeFornecedor, contasPagarOnline[i].Valor, contasPagarOnline[i].Vencimento, contasPagarOnline[i].idFilial);
                }
            }
            for (int i = 0; i < contasReceberOnline.Count; i++)
            {
                if (!contasReceberLocal.Contains(contasReceberOnline[i]))
                {
                    ContasReceber_DAL.InsereContasReceber(contasReceberOnline[i].NomeFornecedor, contasReceberOnline[i].Valor, contasReceberOnline[i].Vencimento, contasReceberOnline[i].idFilial);
                }
            }
            for (int i = 0; i < conveniosOnline.Count; i++)
            {
                if (!conveniosLocal.Contains(conveniosOnline[i]))
                {
                    Convenios_DAL.InsereConvenio(conveniosOnline[i].Nome, conveniosOnline[i].Desconto, conveniosOnline[i].idFilial);
                }
            }
            for (int i = 0; i < enderecosOnline.Count; i++)
            {
                if (!enderecosLocal.Contains(enderecosOnline[i]))
                {
                    Enderecos_DAL.InsereEndereco(enderecosOnline[i].enumEndereco, enderecosOnline[i].RazaoSocial, enderecosOnline[i].NomeFantasia, enderecosOnline[i].CNPJCPF, enderecosOnline[i].Contato, enderecosOnline[i].Rua, enderecosOnline[i].Numero, enderecosOnline[i].Complemento, enderecosOnline[i].Cidade, enderecosOnline[i].Estado, enderecosOnline[i].idFilial);
                }
            }
            for (int i = 0; i < produtosOnline.Count; i++)
            {
                if (!produtosLocal.Contains(produtosOnline[i]))
                {
                    Produtos_DAL.InsereProduto(produtosOnline[i].Nome, produtosOnline[i].Unidade, produtosOnline[i].Quantidade, produtosOnline[i].Codigo, produtosOnline[i].Laboratorio, produtosOnline[i].PrecoCusto, produtosOnline[i].PrecoUnitario, produtosOnline[i].Grupo, produtosOnline[i].idFilial);
                }
            }
            for (int i = 0; i < requisicoesOnline.Count; i++)
            {
                if (!requisicoesLocal.Contains(requisicoesOnline[i]))
                {
                    Requisicoes_DAL.InsertRequisicao(requisicoesOnline[i].Nome, requisicoesOnline[i].Filial, requisicoesOnline[i].Data, requisicoesOnline[i].Assunto, requisicoesOnline[i].Solicitacao, requisicoesOnline[i].Resposta);
                }
            }
            for (int i = 0; i < unidadesOnline.Count; i++)
            {
                if (!unidadesLocal.Contains(unidadesOnline[i]))
                {
                    Unidades_DAL.InsereUnidade(unidadesOnline[i].Nome, unidadesOnline[i].idFilial);
                }
            }
            for (int i = 0; i < cupomOnline.Count; i++)
            {
                if (!cupomLocal.Contains(cupomOnline[i]))
                {
                    Vendas_DAL.InsereCupom(cupomOnline[i].Data, cupomOnline[i].CodigoCupom, cupomOnline[i].FormaPagamento, cupomOnline[i].Vendedor, cupomOnline[i].Cliente, cupomOnline[i].ValorTotal);
                }
            }
            for (int i = 0; i < vendaOnline.Count; i++)
            {
                if (!vendaLocal.Contains(vendaOnline[i]))
                {
                    Vendas_DAL.InsertVenda(vendaOnline[i].CodigoCupom, vendaOnline[i].CodigoProduto, vendaOnline[i].Quantidade, vendaOnline[i].ValorUnitario);
                }
            }
            for (int i = 0; i < usuariosOnline.Count; i++)
            {
                if (!usuariosLocal.Contains(usuariosOnline[i]))
                {
                    Usuarios_DAL.InsereUsuario(usuariosOnline[i].Nome, usuariosOnline[i].Filial, usuariosOnline[i].Contato, usuariosOnline[i].NivelAcesso, usuariosOnline[i].Login, usuariosOnline[i].Senha);
                }
            }
        }
        public static void EnviarDados() //Clona do local para o online
        {

        }
    }
}
