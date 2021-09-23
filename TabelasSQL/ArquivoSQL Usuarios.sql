create table dbo.Usuarios
(
idUsuario int not null identity(1,1),
Nome varchar(50) not null,
Filial int not null, 
Cargo varchar(30) not null,
Contato varchar(14) not null,
NivelAcesso int not null,
Login varchar(50) not null, 
Senha varchar(128) not null
)

INSERT into dbo.Usuarios(Nome, Filial, Cargo, Contato, NivelAcesso, Login, Senha) values('Usuario1', 12, 'Funcionario', '5547900000000', 1, 'Admin', 'C94649567AEA10618C624BF8E8A3AF8DD443B33B928786C7BBFCD8AA5789BB6857B6585790C9BABCA576C8B94E7D38A3B87F42C972C2EE72A63C5870F09E60A5')