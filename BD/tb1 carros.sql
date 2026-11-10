create database concessionaria

use concessionaria

create table veiculo(
chasi varchar(17) not null,
marca varchar(10) not null,
modelo varchar(20) not null,
anofabri int,
anomodelo int,
combustivel varchar(20)
primary key(chasi))