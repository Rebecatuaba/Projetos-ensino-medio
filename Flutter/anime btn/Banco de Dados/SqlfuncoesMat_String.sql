use master

select power(2,3) as calculo

select * from Funcionario

select idfuncionario, power(idfuncionario,3) from funcionario
order by idfuncionario asc

select sqrt(25) as raiz

select round(7.54,1)

select round(7.16,1)

select log(sqrt(9))
SELECT ROUND (LOG(SQRT(9)),3) 

select pi()

select round(pi(),3)

select ascii('$')

select ascii('a') , ascii('m')

select len('  Hoje é q uinta-feira  A')

select left('Hoje é quinta-feira',4 )

select right('Hoje é quinta-feira',5 )

select substring('Hoje é quinta-feira',6,1 )

select replace(nome,'a','@') from funcionario

select nome from funcionario

select lower(nome) from funcionario

update funcionario set nome = upper(nome)

select ltrim('   José da Silva')

select rtrim('  José da Silva   ')



