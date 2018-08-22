CREATE DATABASE DBLojaLimpeza;

CREATE TABLE Categoria(
codigo int primary key not null,
nome varchar(50)
);


insert into Categoria
values('1','Banheira')
insert into Categoria
values('2','Pia')
insert into Categoria
values('3','Saboneteira')

select * from Categoria;