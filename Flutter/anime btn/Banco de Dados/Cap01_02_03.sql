/* Script Banco de Dados e  criação da estrutura da tabela */
create database RecursosHumanos
go
use RecursosHumanos
go
create table Funcionario(
	idFuncionario int not null,
	nome varchar(50) not null,
	endereco varchar(100) null,
	cidade varchar(50) null,
	estado char(2) null,
	email varchar(100) null unique,
	dataNascto date null,
	cargo char(2) null,
	salario decimal(10,2) null,
	ativo bit,
	primary key (idFuncionario))
go
	select * from funcionario
go
	
--Capítulo 2 
  select * from funcionario
go
/* inserir dados na tabela */

-- insert into : insira o registro na tabela
-- update : atualiza um ou mais dados de um registro
-- delete : exclui um ou mais registros de uma tabela
-- select : filtrar registros de uma tabela
     -- distinct : elimina as duplicidades
	 -- where: especifica o critério de seleção de
	     -- registros
     -- order by classifica os dados 
insert into Funcionario 
(idFuncionario, nome, endereco, cidade, estado, email, dataNascto, cargo, salario, ativo)
values
(1, 'José da Silva', 'Av. São Paulo', 'Itu', 'SP', 'zesilva@yahoo.com.br',
'1991-02-24', 'Al',1000, 0),
(2, 'Byuhl Gueittys', 'Av. Maicroçofiti, 95', 'Janela', 'SP',
 'emeiodobiu@epow.com', '1965-12-25', 'PC', 2000,1),
(3,'Ana Pimenta','Rua da Saúde, 11','Jundiaí','SP','pimentinha@hotmail.com','1987-01-01','TI',750,1),
(4,'Mário Lopes','Rua Angélica, 143','Jundiaí','SP','mlopes@hotmail.com','1985-04-10','TI',750,0),
(5, 'Ana Maria Souza', 'Av. das Nações da Paz', 'ONU', 'US', 'iloveny@boom.com',
'1950-01-01','TI', 5000,1),
(6, 'Maria de Fátima', 'Rua das Maçãs', 'Apple City', 'US', 'me@me.com',
'1990-01-01','AL',2000,1), 
(7, 'José Maria de Oliveira', 'Av. das Nações da Paz', 'ONU', 'US', 'iloveny5@boom.com',
'1950-01-01','TI',5000,1),
(8, 'André dos Santos Maria', 'Rua das Maçãs', 'Apple City', 'US', 'me@me12.com',
'1990-01-01','AL',2400,0),
(9,'Jorge Luis Rodrigues','Av. da Saudade,1989','São Paulo','SP','jorgeluiz@yahoo.com.br',
'1990-05-05','PC',3000,1),
(10,'Ana Paula Camargo','Rua Costa e Silva, 33','Jundiaí','SP','apcamargo@gmail.com',
'1991-06-20','TI',1100,1),
(11,'Ivo Cunha','Rua Nicolau Coelho, 22','São Paulo', 'SP','cis@bol.com.br','1988-04-30',
'PC',2200,1) 
go

use RecursosHumanos
select * from funcionario

-- Capítulo 3
-- Consulta com operadores

-- +, *, -, /, %

select 3 * (2 + 5) 
select * from funcionario

select nome, salario, salario + 500 as bonussalario from funcionario
where cargo = 'TI'

update funcionario set salario = salario + 500
where cargo = 'TI'

select 3.0 / 2

-- Operadores Relacionais
-- >,<, >=, <=, =, <> ou !=

--Operadores Lógicos
--and, or e not
-- cond1  cond2 Resposta (and)
--	V		V		V
--	F		V		F
--  V		F		F
--	F		F		F

-- cond1  cond2 Resposta (or)
--	V		V		V
--	F		V		V
--  V		F		V
--	F		F		F

--	cond1	resposta (not)
--	V		F
--  F		V

select nome, salario from funcionario
where salario> 1000 and salario<5000

-- OPERADORES AUXILIARES
-- IS NULL verifica um campo vazio
-- BETWEEN verifica entre um valor e outro
-- in verifica se um valor existe na tabela
-- like verifica valor buscando seus semelhantes

select * from funcionario

select * from funcionario
where idade is null

select nome, cargo from funcionario
where cargo in('PC','TI')

select * from funcionario
where idade is not null

-- like curinga % e _
select nome from funcionario

select nome from funcionario
where nome like 'A%'

select nome from funcionario
where nome =  'Ana%'

select nome from funcionario
where nome like 'Ana%'


select * from funcionario


select upper (nome) as nomeMaiusculo from funcionario

select dataNascto, len (dataNascto) as nomeMes from funcionario

select datename(month, dataNascto) as dataMes, len (datename(month, dataNascto)) as nomeMes from funcionario

select replace (nome,' ', '-') from funcionario

select left(nome,3), right(nome, 3) from funcionario

select SQRT(len(nome)) from funcionario

select SUBSTRING(cidade,3,5)from funcionario

select replace (nome,' ', '') from funcionario

select ASCII(IdFuncionario) from funcionario where cidade = 'Campinas'

select ASCII(nome) from funcionario where day(dataNascto)>20

select left(RTRIM(cidade), 4) from funcionario
vgy

select RIGHT(LTRIM(cidade), 4) from funcionario

SELECT LOWER(cidade	) FROM funcionario

select nome, day (dataNascto) as dia, month (dataNascto) as mes, year (dataNascto) as ano from funcionario

/*select datename(month, dataNascto) as dataMes from funcionario
order by dataMes

select datename(month, dataNascto) as mes from funcionario
order by mes*/

select (idfuncionario), nome from funcionario 
where year (dataNascto) = 1987

select nome, day (dataNascto) as diaNasc from funcionario
where year (dataNascto) = 1988 and month (dataNascto) = 4


/*select nome,dateadd (month,2,getdate()) as acress from funcionario*/


select * from funcionario


SELECT nome, DATEDIFF(year, dataNascto, GETDATE()) as idade from funcionario

select idfuncionario, nome from funcionario 
where month (dataNascto) > 2 and month (dataNascto) <6 and year (dataNascto) = 1990


select nome, year (dataNascto) as ano from funcionario
where (estado) = 'SP'


select nome, year (dataNascto) as ano from funcionario
where year (dataNascto) < 1990

10.	Exiba cidade e estado dos funcionários que nasceram após 1989, sem repetir os dados.

/select cidade, estado from funcionario
where year (dataNascto) > 1989




