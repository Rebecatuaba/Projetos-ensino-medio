CREATE DATABASE Jorge

create table Clientes(
CodCli int identity,
Nome varchar(40) not null,
Contato varchar(30) not null,
Cargo varchar(30) not null,
Endereco varchar(60) not null,
Cidade varchar(15) not null,
Regiao varchar(15) not null,
CEP varchar(10) not null,
Pais varchar(15) not null,
Telefone varchar(24) not null,
Fax varchar(24) not null,
primary key(CodCli)
)

create table funcionarios(
CodFun int identity,
Sobrenome varchar(20) null,
Nome varchar(10) null,
Cargo varchar(30) null,
DataNasc date null,
Endereco varchar(60) null,
Cidade varchar(15) null,
CEP varchar(10) null,
Pais varchar(15) null,
Fone varchar(24) null,
Salario money null,
primary key(CodFun)
)

create table Pedidos( 
NumPed int identity,
CodCli char(5),
CodFun int identity,
DataPed date null,
DataEntrega date null,
Frete money null,
primary key(NumPed),
foreign key(CodCli) references Clientes(CodCli),
foreign key(CodFun) references funcionarios(CodFun)
)

create table Categorias(
CodCategoria int identity,
Descr varchar(15) null,
primary key(CodCategoria)
)


create table Fornecedores(
CodFor int identity,
Empresa varchar(40) null,
Contato varchar(30) null,
Cargo varchar(30) null,
Endereco varchar(50) null,
Cidade varchar(15) null,
primary key(CodFor)
)

create table Produtos(
CodProd int identity,
CodCategoria int identity,
CodFor int identity,
Descr varchar(40) null,
Preco money null,
Unidades smallint null,
Descontinuado bit null,
primary key(CodProd),
foreign key(CodCategoria) references Categorias(CodCategoria),
foreign key(CodFor) references Fornecedores (CodFor)
)

create table DetalhesPed(
NumPed int identity,
CodProd int identity,
Preco money null,
Qtde smallint null,
Desconto float null,
primary key(NumPed),
foreign key(CodProd) references Produtos (CodProd)
)