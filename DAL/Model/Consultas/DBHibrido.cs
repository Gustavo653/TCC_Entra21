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
        public static bool VerificaConexaoInternet(long minimumSpeed)
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
                return false;

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                // discard because of standard reasons
                if ((ni.OperationalStatus != OperationalStatus.Up) ||
                    (ni.NetworkInterfaceType == NetworkInterfaceType.Loopback) ||
                    (ni.NetworkInterfaceType == NetworkInterfaceType.Tunnel))
                    continue;

                // this allow to filter modems, serial, etc.
                if (ni.Speed < minimumSpeed)
                    continue;

                // discard virtual cards (virtual box, virtual pc, etc.)
                if ((ni.Description.IndexOf("virtual", StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (ni.Name.IndexOf("virtual", StringComparison.OrdinalIgnoreCase) >= 0))
                    continue;

                // discard "Microsoft Loopback Adapter", it will not show as NetworkInterfaceType.Loopback but as Ethernet Card.
                if (ni.Description.Equals("Microsoft Loopback Adapter", StringComparison.OrdinalIgnoreCase))
                    continue;

                return true;
            }
            return false;
        }
        public static void GerarDBTabelas(string selecaoBD) //Cria o database e as tabelas
        {
            //if (File.Exists(DbConnection.nomeArquivoBD))
            //    File.Delete(DbConnection.nomeArquivoBD);
            if (!File.Exists(DbConnection.nomeArquivoBD))
            {
                EscolhaBD = 1;
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
                EscolhaBD = Convert.ToInt32(selecaoBD);
            }
        }
        public static void ReceberDados() //Clona do online para o local
        {
            if (VerificaConexaoInternet(10000000))
            {
                EscolhaBD = 2;
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

                EscolhaBD = 1;
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
                    else
                    {
                        if (caixasOnline.Count > caixasLocal.Count && !caixasLocal.Contains(caixasOnline[i]))
                        {
                            Caixa_DAL.InsertCaixa(caixasOnline[i].Data, caixasOnline[i].NumCaixa, caixasOnline[i].UsuarioAbertura, caixasOnline[i].UsuarioFechamento, caixasOnline[i].Valor, caixasOnline[i].EstadoCaixa, caixasOnline[i].idFilial, caixasOnline[i].ValorDinheiro, caixasOnline[i].ValorCredito, caixasOnline[i].ValorDebito);
                        }
                        else
                        {
                            Caixa_DAL.UpdateCaixa(caixasOnline[i].Data, caixasOnline[i].NumCaixa, caixasOnline[i].UsuarioAbertura, caixasOnline[i].UsuarioFechamento, caixasOnline[i].Valor, caixasOnline[i].EstadoCaixa, caixasOnline[i].idFilial, caixasOnline[i].ValorDinheiro, caixasOnline[i].ValorCredito, caixasOnline[i].ValorDebito, caixasLocal[i].Data, caixasLocal[i].idFilial, caixasLocal[i].Valor);
                        }
                    }
                }
                for (int i = 0; i < contasPagarOnline.Count; i++)
                {
                    if (!contasPagarLocal.Contains(contasPagarOnline[i]))
                    {
                        ContasPagar_DAL.InsereContasPagar(contasPagarOnline[i].NomeFornecedor, contasPagarOnline[i].Valor, contasPagarOnline[i].Vencimento, contasPagarOnline[i].idFilial);
                    }
                    else
                    {
                        if (contasPagarOnline.Count > contasPagarLocal.Count && !contasPagarLocal.Contains(contasPagarOnline[i]))
                        {
                            ContasPagar_DAL.InsereContasPagar(contasPagarOnline[i].NomeFornecedor, contasPagarOnline[i].Valor, contasPagarOnline[i].Vencimento, contasPagarOnline[i].idFilial);
                        }
                        else
                        {
                            ContasPagar_DAL.UpdateContasPagar(contasPagarOnline[i].NomeFornecedor, contasPagarOnline[i].Valor, contasPagarOnline[i].Vencimento, contasPagarOnline[i].idFilial, contasPagarLocal[i].NomeFornecedor, contasPagarLocal[i].Valor, contasPagarLocal[i].idFilial);
                        }
                    }
                }
                for (int i = 0; i < contasReceberOnline.Count; i++)
                {
                    if (!contasReceberLocal.Contains(contasReceberOnline[i]))
                    {
                        ContasReceber_DAL.InsereContasReceber(contasReceberOnline[i].NomeFornecedor, contasReceberOnline[i].Valor, contasReceberOnline[i].Vencimento, contasReceberOnline[i].idFilial);
                    }
                    else
                    {
                        if (contasReceberOnline.Count > contasReceberLocal.Count && !contasReceberLocal.Contains(contasReceberOnline[i]))
                        {
                            ContasReceber_DAL.InsereContasReceber(contasReceberOnline[i].NomeFornecedor, contasReceberOnline[i].Valor, contasReceberOnline[i].Vencimento, contasReceberOnline[i].idFilial);
                        }
                        else
                        {
                            ContasReceber_DAL.UpdateContasReceber(contasReceberOnline[i].NomeFornecedor, contasReceberOnline[i].Valor, contasReceberOnline[i].Vencimento, contasReceberOnline[i].idFilial, contasReceberLocal[i].NomeFornecedor, contasReceberLocal[i].Valor, contasReceberLocal[i].idFilial);
                        }
                    }
                }
                for (int i = 0; i < conveniosOnline.Count; i++)
                {
                    if (!conveniosLocal.Contains(conveniosOnline[i]))
                    {
                        Convenios_DAL.InsereConvenio(conveniosOnline[i].Nome, conveniosOnline[i].Desconto, conveniosOnline[i].idFilial);
                    }
                    else
                    {
                        if (conveniosOnline.Count > conveniosLocal.Count && !conveniosLocal.Contains(conveniosOnline[i]))
                        {
                            Convenios_DAL.InsereConvenio(conveniosOnline[i].Nome, conveniosOnline[i].Desconto, conveniosOnline[i].idFilial);
                        }
                        else
                        {
                            Convenios_DAL.UpdateConvenio(conveniosOnline[i].Nome, conveniosOnline[i].Desconto, conveniosOnline[i].idFilial, conveniosLocal[i].Nome, conveniosLocal[i].idFilial);
                        }
                    }
                }
                for (int i = 0; i < enderecosOnline.Count; i++)
                {
                    if (!enderecosLocal.Contains(enderecosOnline[i]))
                    {
                        Enderecos_DAL.InsereEndereco(enderecosOnline[i].enumEndereco, enderecosOnline[i].RazaoSocial, enderecosOnline[i].NomeFantasia, enderecosOnline[i].CNPJCPF, enderecosOnline[i].Contato, enderecosOnline[i].Rua, enderecosOnline[i].Numero, enderecosOnline[i].Complemento, enderecosOnline[i].Cidade, enderecosOnline[i].Estado, enderecosOnline[i].idFilial);
                    }
                    else
                    {
                        if (enderecosOnline.Count > enderecosLocal.Count && !enderecosLocal.Contains(enderecosOnline[i]))
                        {
                            Enderecos_DAL.InsereEndereco(enderecosOnline[i].enumEndereco, enderecosOnline[i].RazaoSocial, enderecosOnline[i].NomeFantasia, enderecosOnline[i].CNPJCPF, enderecosOnline[i].Contato, enderecosOnline[i].Rua, enderecosOnline[i].Numero, enderecosOnline[i].Complemento, enderecosOnline[i].Cidade, enderecosOnline[i].Estado, enderecosOnline[i].idFilial);
                        }
                        else
                        {
                            Enderecos_DAL.UpdateEndereco(enderecosOnline[i].enumEndereco, enderecosOnline[i].RazaoSocial, enderecosOnline[i].NomeFantasia, enderecosOnline[i].CNPJCPF, enderecosOnline[i].Contato, enderecosOnline[i].Rua, enderecosOnline[i].Numero, enderecosOnline[i].Complemento, enderecosOnline[i].Cidade, enderecosOnline[i].Estado, enderecosOnline[i].idFilial, enderecosLocal[i].Contato, enderecosLocal[i].enumEndereco);
                        }
                    }
                }
                for (int i = 0; i < produtosOnline.Count; i++)
                {
                    if (!produtosLocal.Contains(produtosOnline[i]))
                    {
                        Produtos_DAL.InsereProduto(produtosOnline[i].Nome, produtosOnline[i].Unidade, produtosOnline[i].Quantidade, produtosOnline[i].Codigo, produtosOnline[i].Laboratorio, produtosOnline[i].PrecoCusto, produtosOnline[i].PrecoUnitario, produtosOnline[i].Grupo, produtosOnline[i].idFilial);
                    }
                    else
                    {
                        if (produtosOnline.Count > produtosLocal.Count && !produtosLocal.Contains(produtosOnline[i]))
                        {
                            Produtos_DAL.InsereProduto(produtosOnline[i].Nome, produtosOnline[i].Unidade, produtosOnline[i].Quantidade, produtosOnline[i].Codigo, produtosOnline[i].Laboratorio, produtosOnline[i].PrecoCusto, produtosOnline[i].PrecoUnitario, produtosOnline[i].Grupo, produtosOnline[i].idFilial);
                        }
                        else
                        {
                            Produtos_DAL.UpdateProduto(produtosOnline[i].Nome, produtosOnline[i].Unidade, produtosOnline[i].Quantidade, produtosOnline[i].Codigo, produtosOnline[i].Laboratorio, produtosOnline[i].PrecoCusto, produtosOnline[i].PrecoUnitario, produtosOnline[i].Grupo, produtosOnline[i].idFilial, produtosLocal[i].Codigo, produtosLocal[i].idFilial);
                        }
                    }
                }
                for (int i = 0; i < requisicoesOnline.Count; i++)
                {
                    if (!requisicoesLocal.Contains(requisicoesOnline[i]))
                    {
                        Requisicoes_DAL.InsertRequisicao(requisicoesOnline[i].Nome, requisicoesOnline[i].Filial, requisicoesOnline[i].Data, requisicoesOnline[i].Assunto, requisicoesOnline[i].Solicitacao, requisicoesOnline[i].Resposta);
                    }
                    else
                    {
                        if (requisicoesOnline.Count > requisicoesLocal.Count && !requisicoesLocal.Contains(requisicoesOnline[i]))
                        {
                            Requisicoes_DAL.InsertRequisicao(requisicoesOnline[i].Nome, requisicoesOnline[i].Filial, requisicoesOnline[i].Data, requisicoesOnline[i].Assunto, requisicoesOnline[i].Solicitacao, requisicoesOnline[i].Resposta);
                        }
                        else
                        {
                            Requisicoes_DAL.UpdateRequisicao(requisicoesOnline[i].Nome, requisicoesOnline[i].Filial, requisicoesOnline[i].Data, requisicoesOnline[i].Assunto, requisicoesOnline[i].Solicitacao, requisicoesOnline[i].Resposta, requisicoesLocal[i].Nome, requisicoesLocal[i].Filial, requisicoesLocal[i].Data, requisicoesLocal[i].Assunto);
                        }
                    }
                }
                for (int i = 0; i < unidadesOnline.Count; i++)
                {
                    if (!unidadesLocal.Contains(unidadesOnline[i]))
                    {
                        Unidades_DAL.InsereUnidade(unidadesOnline[i].Nome, unidadesOnline[i].idFilial);
                    }
                    else
                    {
                        if (unidadesOnline.Count > unidadesLocal.Count && !unidadesLocal.Contains(unidadesOnline[i]))
                        {
                            Unidades_DAL.InsereUnidade(unidadesOnline[i].Nome, unidadesOnline[i].idFilial);
                        }
                        else
                        {
                            Unidades_DAL.AtualizaTodasUnidades(unidadesOnline[i].Nome, unidadesOnline[i].idFilial, unidadesLocal[i].Nome, unidadesLocal[i].idFilial);
                        }
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
                    else
                    {
                        if (usuariosOnline.Count > usuariosLocal.Count && !usuariosLocal.Contains(usuariosOnline[i]))
                        {
                            Usuarios_DAL.InsereUsuario(usuariosOnline[i].Nome, usuariosOnline[i].Filial, usuariosOnline[i].Contato, usuariosOnline[i].NivelAcesso, usuariosOnline[i].Login, usuariosOnline[i].Senha);
                        }
                        else
                        {
                            Usuarios_DAL.UpdateUsuario(usuariosOnline[i].Nome, usuariosOnline[i].Filial, usuariosOnline[i].Contato, usuariosOnline[i].NivelAcesso, usuariosOnline[i].Login, usuariosOnline[i].Senha, usuariosLocal[i].Contato, usuariosLocal[i].Login);
                        }
                    }
                }
            }
        }
        public static void EnviarDados() //Clona do local para o online
        {
            if (VerificaConexaoInternet(10000000))
            {
                EscolhaBD = 1;
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

                EscolhaBD = 2;
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


                for (int i = 0; i < caixasLocal.Count; i++)
                {
                    if (!caixasOnline.Contains(caixasLocal[i]))
                    {
                        Caixa_DAL.InsertCaixa(caixasLocal[i].Data, caixasLocal[i].NumCaixa, caixasLocal[i].UsuarioAbertura, caixasLocal[i].UsuarioFechamento, caixasLocal[i].Valor, caixasLocal[i].EstadoCaixa, caixasLocal[i].idFilial, caixasLocal[i].ValorDinheiro, caixasLocal[i].ValorCredito, caixasLocal[i].ValorDebito);
                    }
                    else
                    {
                        if (caixasLocal.Count > caixasOnline.Count && !caixasOnline.Contains(caixasLocal[i]))
                        {
                            Caixa_DAL.InsertCaixa(caixasLocal[i].Data, caixasLocal[i].NumCaixa, caixasLocal[i].UsuarioAbertura, caixasLocal[i].UsuarioFechamento, caixasLocal[i].Valor, caixasLocal[i].EstadoCaixa, caixasLocal[i].idFilial, caixasLocal[i].ValorDinheiro, caixasLocal[i].ValorCredito, caixasLocal[i].ValorDebito);
                        }
                        else
                        {
                            Caixa_DAL.UpdateCaixa(caixasLocal[i].Data, caixasLocal[i].NumCaixa, caixasLocal[i].UsuarioAbertura, caixasLocal[i].UsuarioFechamento, caixasLocal[i].Valor, caixasLocal[i].EstadoCaixa, caixasLocal[i].idFilial, caixasLocal[i].ValorDinheiro, caixasLocal[i].ValorCredito, caixasLocal[i].ValorDebito, caixasOnline[i].Data, caixasOnline[i].idFilial, caixasOnline[i].Valor);
                        }
                    }
                }
                for (int i = 0; i < contasPagarLocal.Count; i++)
                {
                    if (!contasPagarOnline.Contains(contasPagarLocal[i]))
                    {
                        ContasPagar_DAL.InsereContasPagar(contasPagarLocal[i].NomeFornecedor, contasPagarLocal[i].Valor, contasPagarLocal[i].Vencimento, contasPagarLocal[i].idFilial);
                    }
                    else
                    {
                        if (contasPagarLocal.Count > contasPagarOnline.Count && !contasPagarOnline.Contains(contasPagarLocal[i]))
                        {
                            ContasPagar_DAL.InsereContasPagar(contasPagarLocal[i].NomeFornecedor, contasPagarLocal[i].Valor, contasPagarLocal[i].Vencimento, contasPagarLocal[i].idFilial);
                        }
                        else
                        {
                            ContasPagar_DAL.UpdateContasPagar(contasPagarLocal[i].NomeFornecedor, contasPagarLocal[i].Valor, contasPagarLocal[i].Vencimento, contasPagarLocal[i].idFilial, contasPagarOnline[i].NomeFornecedor, contasPagarOnline[i].Valor, contasPagarOnline[i].idFilial);
                        }
                    }
                }
                for (int i = 0; i < contasReceberLocal.Count; i++)
                {
                    if (!contasReceberOnline.Contains(contasReceberLocal[i]))
                    {
                        ContasReceber_DAL.InsereContasReceber(contasReceberLocal[i].NomeFornecedor, contasReceberLocal[i].Valor, contasReceberLocal[i].Vencimento, contasReceberLocal[i].idFilial);
                    }
                    else
                    {
                        if (contasReceberLocal.Count > contasReceberOnline.Count && !contasReceberOnline.Contains(contasReceberLocal[i]))
                        {
                            ContasReceber_DAL.InsereContasReceber(contasReceberLocal[i].NomeFornecedor, contasReceberLocal[i].Valor, contasReceberLocal[i].Vencimento, contasReceberLocal[i].idFilial);
                        }
                        else
                        {
                            ContasReceber_DAL.UpdateContasReceber(contasReceberLocal[i].NomeFornecedor, contasReceberLocal[i].Valor, contasReceberLocal[i].Vencimento, contasReceberLocal[i].idFilial, contasReceberOnline[i].NomeFornecedor, contasReceberOnline[i].Valor, contasReceberOnline[i].idFilial);
                        }
                    }
                }
                for (int i = 0; i < conveniosLocal.Count; i++)
                {
                    if (!conveniosOnline.Contains(conveniosLocal[i]))
                    {
                        Convenios_DAL.InsereConvenio(conveniosLocal[i].Nome, conveniosLocal[i].Desconto, conveniosLocal[i].idFilial);
                    }
                    else
                    {
                        if (conveniosLocal.Count > conveniosOnline.Count && !conveniosOnline.Contains(conveniosLocal[i]))
                        {
                            Convenios_DAL.InsereConvenio(conveniosLocal[i].Nome, conveniosLocal[i].Desconto, conveniosLocal[i].idFilial);
                        }
                        else
                        {
                            Convenios_DAL.UpdateConvenio(conveniosLocal[i].Nome, conveniosLocal[i].Desconto, conveniosLocal[i].idFilial, conveniosOnline[i].Nome, conveniosOnline[i].idFilial);
                        }
                    }
                }
                for (int i = 0; i < enderecosLocal.Count; i++)
                {
                    if (!enderecosOnline.Contains(enderecosLocal[i]))
                    {
                        Enderecos_DAL.InsereEndereco(enderecosLocal[i].enumEndereco, enderecosLocal[i].RazaoSocial, enderecosLocal[i].NomeFantasia, enderecosLocal[i].CNPJCPF, enderecosLocal[i].Contato, enderecosLocal[i].Rua, enderecosLocal[i].Numero, enderecosLocal[i].Complemento, enderecosLocal[i].Cidade, enderecosLocal[i].Estado, enderecosLocal[i].idFilial);
                    }
                    else
                    {
                        if (enderecosLocal.Count > enderecosOnline.Count && !enderecosOnline.Contains(enderecosLocal[i]))
                        {
                            Enderecos_DAL.InsereEndereco(enderecosLocal[i].enumEndereco, enderecosLocal[i].RazaoSocial, enderecosLocal[i].NomeFantasia, enderecosLocal[i].CNPJCPF, enderecosLocal[i].Contato, enderecosLocal[i].Rua, enderecosLocal[i].Numero, enderecosLocal[i].Complemento, enderecosLocal[i].Cidade, enderecosLocal[i].Estado, enderecosLocal[i].idFilial);

                        }
                        else
                        {
                            Enderecos_DAL.UpdateEndereco(enderecosLocal[i].enumEndereco, enderecosLocal[i].RazaoSocial, enderecosLocal[i].NomeFantasia, enderecosLocal[i].CNPJCPF, enderecosLocal[i].Contato, enderecosLocal[i].Rua, enderecosLocal[i].Numero, enderecosLocal[i].Complemento, enderecosLocal[i].Cidade, enderecosLocal[i].Estado, enderecosLocal[i].idFilial, enderecosOnline[i].Contato, enderecosOnline[i].enumEndereco);
                        }
                    }
                }
                for (int i = 0; i < produtosLocal.Count; i++)
                {
                    if (!produtosOnline.Contains(produtosLocal[i]))
                    {
                        Produtos_DAL.InsereProduto(produtosLocal[i].Nome, produtosLocal[i].Unidade, produtosLocal[i].Quantidade, produtosLocal[i].Codigo, produtosLocal[i].Laboratorio, produtosLocal[i].PrecoCusto, produtosLocal[i].PrecoUnitario, produtosLocal[i].Grupo, produtosLocal[i].idFilial);
                    }
                    else
                    {
                        if (produtosLocal.Count > produtosOnline.Count && !produtosOnline.Contains(produtosLocal[i]))
                        {
                            Produtos_DAL.InsereProduto(produtosLocal[i].Nome, produtosLocal[i].Unidade, produtosLocal[i].Quantidade, produtosLocal[i].Codigo, produtosLocal[i].Laboratorio, produtosLocal[i].PrecoCusto, produtosLocal[i].PrecoUnitario, produtosLocal[i].Grupo, produtosLocal[i].idFilial);
                        }
                        else
                        {
                            Produtos_DAL.UpdateProduto(produtosLocal[i].Nome, produtosLocal[i].Unidade, produtosLocal[i].Quantidade, produtosLocal[i].Codigo, produtosLocal[i].Laboratorio, produtosLocal[i].PrecoCusto, produtosLocal[i].PrecoUnitario, produtosLocal[i].Grupo, produtosLocal[i].idFilial, produtosOnline[i].Codigo, produtosOnline[i].idFilial);
                        }
                    }
                }
                for (int i = 0; i < requisicoesLocal.Count; i++)
                {
                    if (!requisicoesOnline.Contains(requisicoesLocal[i]))
                    {
                        Requisicoes_DAL.InsertRequisicao(requisicoesLocal[i].Nome, requisicoesLocal[i].Filial, requisicoesLocal[i].Data, requisicoesLocal[i].Assunto, requisicoesLocal[i].Solicitacao, requisicoesLocal[i].Resposta);
                    }
                    else
                    {
                        if (requisicoesLocal.Count > requisicoesOnline.Count && !requisicoesOnline.Contains(requisicoesLocal[i]))
                        {
                            Requisicoes_DAL.InsertRequisicao(requisicoesLocal[i].Nome, requisicoesLocal[i].Filial, requisicoesLocal[i].Data, requisicoesLocal[i].Assunto, requisicoesLocal[i].Solicitacao, requisicoesLocal[i].Resposta);
                        }
                        else
                        {
                            Requisicoes_DAL.UpdateRequisicao(requisicoesLocal[i].Nome, requisicoesLocal[i].Filial, requisicoesLocal[i].Data, requisicoesLocal[i].Assunto, requisicoesLocal[i].Solicitacao, requisicoesLocal[i].Resposta, requisicoesOnline[i].Nome, requisicoesOnline[i].Filial, requisicoesOnline[i].Data, requisicoesOnline[i].Assunto);
                        }
                    }
                }
                for (int i = 0; i < unidadesLocal.Count; i++)
                {
                    if (!unidadesOnline.Contains(unidadesLocal[i]))
                    {
                        Unidades_DAL.InsereUnidade(unidadesLocal[i].Nome, unidadesLocal[i].idFilial);
                    }
                    else
                    {
                        if (unidadesLocal.Count > unidadesOnline.Count && !unidadesOnline.Contains(unidadesLocal[i]))
                        {
                            Unidades_DAL.InsereUnidade(unidadesLocal[i].Nome, unidadesLocal[i].idFilial);
                        }
                        else
                        {
                            Unidades_DAL.AtualizaTodasUnidades(unidadesLocal[i].Nome, unidadesLocal[i].idFilial, unidadesOnline[i].Nome, unidadesOnline[i].idFilial);
                        }
                    }
                }
                for (int i = 0; i < cupomLocal.Count; i++)
                {
                    if (!cupomOnline.Contains(cupomLocal[i]))
                    {
                        Vendas_DAL.InsereCupom(cupomLocal[i].Data, cupomLocal[i].CodigoCupom, cupomLocal[i].FormaPagamento, cupomLocal[i].Vendedor, cupomLocal[i].Cliente, cupomLocal[i].ValorTotal);
                    }
                }
                for (int i = 0; i < vendaLocal.Count; i++)
                {
                    if (!vendaOnline.Contains(vendaLocal[i]))
                    {
                        Vendas_DAL.InsertVenda(vendaLocal[i].CodigoCupom, vendaLocal[i].CodigoProduto, vendaLocal[i].Quantidade, vendaLocal[i].ValorUnitario);
                    }
                }
                for (int i = 0; i < usuariosLocal.Count; i++)
                {
                    if (!usuariosOnline.Contains(usuariosLocal[i]))
                    {
                        Usuarios_DAL.InsereUsuario(usuariosLocal[i].Nome, usuariosLocal[i].Filial, usuariosLocal[i].Contato, usuariosLocal[i].NivelAcesso, usuariosLocal[i].Login, usuariosLocal[i].Senha);
                    }
                    else
                    {
                        if (usuariosLocal.Count > usuariosOnline.Count && !usuariosOnline.Contains(usuariosLocal[i]))
                        {
                            Usuarios_DAL.InsereUsuario(usuariosLocal[i].Nome, usuariosLocal[i].Filial, usuariosLocal[i].Contato, usuariosLocal[i].NivelAcesso, usuariosLocal[i].Login, usuariosLocal[i].Senha);
                        }
                        else
                        {
                            Usuarios_DAL.UpdateUsuario(usuariosLocal[i].Nome, usuariosLocal[i].Filial, usuariosLocal[i].Contato, usuariosLocal[i].NivelAcesso, usuariosLocal[i].Login, usuariosLocal[i].Senha, usuariosOnline[i].Contato, usuariosOnline[i].Login);
                        }
                    }
                }
                EscolhaBD = 1;
            }
        }
        public static void ExecutarDelete()
        {
            if (VerificaConexaoInternet(10000000))
            {
                string caminhoDelete = @"C:\Users\Public\Documents\Delete.txt";
                if (File.Exists(caminhoDelete))
                {
                    StreamReader func2 = File.OpenText(caminhoDelete);
                    string[] linhas = File.ReadAllLines(caminhoDelete);
                    foreach (string linha in linhas)
                    {
                        EscolhaBD = 1;
                        DbConnection.Execute(linha);
                        EscolhaBD = 2;
                        DbConnection.Execute(linha);
                    }
                    func2.Close();
                    File.Delete(caminhoDelete);
                }
            }
        }
    }
}
