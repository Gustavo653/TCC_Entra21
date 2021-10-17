create table dbo.Caixa
(
idCaixa int not null identity(1,1),
Data varchar(10) not null,
Caixa varchar(3) not null,
UsuarioAbertura varchar(50) not null,
UsuarioFechamento varchar(50) not null,
Valor varchar(8) not null,
EstadoCaixa int not null,
idFilial varchar(50) not null,
ValorDinheiro varchar(8) not null,
ValorCredito varchar(8) not null,
ValorDebito varchar(8) not null
)
create table dbo.ContasPagar
(
idContaPagar int not null identity(1,1),
NomeFornecedor VARCHAR(50) not null, 
Valor varchar(12) not null,
Vencimento varchar(11) not null,
idFilial varchar(50) not null
)
create table dbo.Vendas
(
idVendas int not null identity(1,1),
CodigoCupom varchar(50) not null,
CodigoProduto varchar(50) not null,
Quantidade int not null,
ValorUnitario varchar(8) not null
)
create table dbo.Usuarios
(
idUsuario int not null identity(1,1),
Nome varchar(50) not null,
Filial varchar(50) not null,
Contato varchar(14) not null,
NivelAcesso int not null,
Login varchar(50) not null,
Senha varchar(128) not null
)
create table dbo.Unidades
(
idUnidade int not null identity(1,1),
Nome varchar(30) not null,
idFilial varchar(50)
)
create table dbo.Requisicoes
(
idRequisicao int not null identity(1,1),
NomeUsuario varchar(50) not null,
Filial varchar(50) not null,
DataRequisicao varchar(11) not null,
Assunto varchar(100) not null,
Solicitacao varchar(100) not null,
RespostaRequisicao varchar(100) not null
)
create table dbo.Produtos
(
idProduto int not null identity(1,1),
Nome varchar(50) not null,
Unidade varchar(20) not null,
Quantidade int not null,
Codigo varchar(20) not null,
Laboratorio varchar(50) not null,
PrecoCusto varchar(8) not null,
PrecoUnitario varchar(8) not null, 
Grupo int not null,
idFilial varchar(50)
)
create table dbo.Enderecos
(
idEndereco int not null identity(1,1),
enumEndereco int not null,
RazaoSocial varchar(50) not null,
NomeFantasia varchar(50) not null,
Cnpj varchar(15) not null,
Contato varchar(14) not null,
Rua varchar(50) not null,
Numero varchar(6) not null,
Complemento varchar(50) not null,
Cidade varchar(25),
Estado varchar(2),
idFilial varchar(50) not null
)
create table dbo.Cupom
(
idCupom int not null identity(1,1),
Data varchar(10) not null,
CodigoCupom varchar(50) not null,
FormaPagamento int not null,
Vendedor varchar(50) not null,
Cliente varchar(50) not null,
ValorTotal varchar(8) not null
)
create table dbo.Convenios
(
idConvenio int not null identity(1,1),
Nome varchar(30) not null,
Desconto varchar(5) not null
)
create table dbo.ContasReceber
(
idContaReceber int not null identity(1,1),
NomeFornecedor VARCHAR(50) not null,
Valor varchar(12) not null,
Vencimento varchar(11) not null,
idFilial varchar(50) not null
)