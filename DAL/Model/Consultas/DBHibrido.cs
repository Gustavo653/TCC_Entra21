using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using System.Net.NetworkInformation;

namespace DAL.Model.Consultas
{
    public class DBHibrido
    {
        public static int EscolhaBD { get; set; } = 1;//Inserir try catch para alterar seu valor
        public static bool VerificaConexaoInternet(long velocidadeMinima)
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
                return false;

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                // descarta por razões comuns
                if ((ni.OperationalStatus != OperationalStatus.Up) ||
                    (ni.NetworkInterfaceType == NetworkInterfaceType.Loopback) ||
                    (ni.NetworkInterfaceType == NetworkInterfaceType.Tunnel))
                    continue;

                // Permite filtrar modens
                if (ni.Speed < velocidadeMinima)
                    continue;

                // Descarta placa de rede virtual (VM)
                if ((ni.Description.IndexOf("virtual", StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (ni.Name.IndexOf("virtual", StringComparison.OrdinalIgnoreCase) >= 0))
                    continue;

                // Descarta "Microsoft Loopback Adapter", mostrará se tem conexão via cabo de rede.
                if (ni.Description.Equals("Microsoft Loopback Adapter", StringComparison.OrdinalIgnoreCase))
                    continue;

                return true;
            }
            return false;
        }
        public static void GerarDBTabelas(string selecaoBD) //Cria o database e as tabelas no BD local
        {
            if (!File.Exists(DbConnection.nomeArquivoBD))
            {
                DbConnection.EstadoPrograma = 0; //Muda o estado do programa para sincronização
                EscolhaBD = 1; //Muda para o BD local
                SqlCeEngine SqlEng = new SqlCeEngine(DbConnection.connLocalString);
                SqlEng.CreateDatabase(); //Cria o arquivo e o DataBase

                List<string> tabelas = new List<string>(); //Cria as tabelas no BD local
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
                EscolhaBD = Convert.ToInt32(selecaoBD);
                DbConnection.EstadoPrograma = 1; //Muda o estado do programa para a utilização novamente
            }
        }
        public static void ReceberDados() //Clona do online para o local
        {
            if (VerificaConexaoInternet(10000000))
            {
                if (File.Exists(DbConnection.nomeArquivoBD))
                    File.Delete(DbConnection.nomeArquivoBD); //Descarta o BD local anterior 
                GerarDBTabelas(EscolhaBD.ToString()); //Gera o BD local novamente
                DbConnection.EstadoPrograma = 0; //Muda o estado para sincronização
                EscolhaBD = 2; //Seleciona o BD  remoto
                List<Objetos.Caixa> caixasOnline = Caixa_DAL.GetTodosOsCaixas();
                List<Objetos.ContasPagar> contasPagarOnline = ContasPagar_DAL.GetTodasContasPagar();
                List<Objetos.ContasReceber> contasReceberOnline = ContasReceber_DAL.GetTodasContasReceber();
                List<Objetos.Convenio> conveniosOnline = Convenios_DAL.GetTodosConvenios();
                List<Objetos.Endereco> enderecosOnline = Enderecos_DAL.GetTodosEnderecos();
                List<Objetos.Produto> produtosOnline = Produtos_DAL.GetTodosProdutos();
                List<Objetos.Requisicao> requisicoesOnline = Requisicoes_DAL.GetRequisicoes();
                List<Objetos.Unidades> unidadesOnline = Unidades_DAL.GetTodasUnidades();
                List<Objetos.Usuario> usuariosOnline = Usuarios_DAL.GetUsuarios();
                List<Objetos.Cupom> cupomOnline = Vendas_DAL.GetCupoms();
                List<Objetos.Venda> vendaOnline = Vendas_DAL.GetVendas();

                EscolhaBD = 1; //Seleciona o BD local
                //Percorre o BD remoto e preenche o BD local
                for (int i = 0; i < caixasOnline.Count; i++)
                {
                    Caixa_DAL.InsertCaixa(caixasOnline[i].Data, caixasOnline[i].NumCaixa, caixasOnline[i].UsuarioAbertura, caixasOnline[i].UsuarioFechamento, caixasOnline[i].Valor, caixasOnline[i].EstadoCaixa, caixasOnline[i].idFilial, caixasOnline[i].ValorDinheiro, caixasOnline[i].ValorCredito, caixasOnline[i].ValorDebito);
                }
                for (int i = 0; i < contasPagarOnline.Count; i++)
                {
                    ContasPagar_DAL.InsereContasPagar(contasPagarOnline[i].NomeFornecedor, contasPagarOnline[i].Valor, contasPagarOnline[i].Vencimento, contasPagarOnline[i].idFilial);
                }
                for (int i = 0; i < contasReceberOnline.Count; i++)
                {
                    ContasReceber_DAL.InsereContasReceber(contasReceberOnline[i].NomeFornecedor, contasReceberOnline[i].Valor, contasReceberOnline[i].Vencimento, contasReceberOnline[i].idFilial);
                }
                for (int i = 0; i < conveniosOnline.Count; i++)
                {
                    Convenios_DAL.InsereConvenio(conveniosOnline[i].Nome, conveniosOnline[i].Desconto, conveniosOnline[i].idFilial);
                }
                for (int i = 0; i < enderecosOnline.Count; i++)
                {
                    Enderecos_DAL.InsereEndereco(enderecosOnline[i].enumEndereco, enderecosOnline[i].RazaoSocial, enderecosOnline[i].NomeFantasia, enderecosOnline[i].CNPJCPF, enderecosOnline[i].Contato, enderecosOnline[i].Rua, enderecosOnline[i].Numero, enderecosOnline[i].Complemento, enderecosOnline[i].Cidade, enderecosOnline[i].Estado, enderecosOnline[i].idFilial);
                }
                for (int i = 0; i < produtosOnline.Count; i++)
                {
                    Produtos_DAL.InsereProduto(produtosOnline[i].Nome, produtosOnline[i].Unidade, produtosOnline[i].Quantidade, produtosOnline[i].Codigo, produtosOnline[i].Laboratorio, produtosOnline[i].PrecoCusto, produtosOnline[i].PrecoUnitario, produtosOnline[i].Grupo, produtosOnline[i].idFilial);
                }
                for (int i = 0; i < requisicoesOnline.Count; i++)
                {
                    Requisicoes_DAL.InsertRequisicao(requisicoesOnline[i].Nome, requisicoesOnline[i].Filial, requisicoesOnline[i].Data, requisicoesOnline[i].Assunto, requisicoesOnline[i].Solicitacao, requisicoesOnline[i].Resposta);
                }
                for (int i = 0; i < unidadesOnline.Count; i++)
                {
                    Unidades_DAL.InsereUnidade(unidadesOnline[i].Nome, unidadesOnline[i].idFilial);
                }
                for (int i = 0; i < cupomOnline.Count; i++)
                {
                    Vendas_DAL.InsereCupom(cupomOnline[i].Data, cupomOnline[i].CodigoCupom, cupomOnline[i].FormaPagamento, cupomOnline[i].Vendedor, cupomOnline[i].Cliente, cupomOnline[i].ValorTotal);
                }
                for (int i = 0; i < vendaOnline.Count; i++)
                {
                    Vendas_DAL.InsertVenda(vendaOnline[i].CodigoCupom, vendaOnline[i].CodigoProduto, vendaOnline[i].Quantidade, vendaOnline[i].ValorUnitario);
                }
                for (int i = 0; i < usuariosOnline.Count; i++)
                {
                    Usuarios_DAL.InsereUsuario(usuariosOnline[i].Nome, usuariosOnline[i].Filial, usuariosOnline[i].Contato, usuariosOnline[i].NivelAcesso, usuariosOnline[i].Login, usuariosOnline[i].Senha);
                }
                DbConnection.EstadoPrograma = 1; //Volta ao estado normal da execução
            }
        }
        public static void ExecutarCommands() //Executa os comandos pendentes
        {
            if (VerificaConexaoInternet(10000000))
            {
                if (File.Exists(DbConnection.caminhoCommands))
                {
                    StreamReader func2 = File.OpenText(DbConnection.caminhoCommands);
                    string[] linhas = File.ReadAllLines(DbConnection.caminhoCommands);
                    foreach (string linha in linhas)
                    {
                        EscolhaBD = 2;
                        DbConnection.Execute(linha);
                    }
                    func2.Close();
                    File.Delete(DbConnection.caminhoCommands);
                }
            }
        }
    }
}
