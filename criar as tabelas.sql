
--Create table Monitor(
-- Id_Monitor int NOT NULL IDENTITY(1,1) PRIMARY KEY,
--Nome varchar(100) not null,
--Cpf varchar(24)not null,
--rg varchar(24)not null,
--Telefone Varchar(24)not null,
--Diciplina varchar (24)not null,
--CargaHoraria int not null

--)
--create table CLIENTE(
--Id_Cliente int NOT NULL IDENTITY(1,1) PRIMARY KEY,
--Nome_Cliente varchar(100) not null,
--CPF varchar(24) not null,
--RG varchar (24) not null,
--Telefone varchar (24) not null

--)

--create table Curso(
--Id_Curso int NOT NULL IDENTITY(1,1) PRIMARY KEY,
--Nome_Curso varchar(50) not null,
--Carga_Horaria int not null,
--Numero_Vagas int not null,
--Nome_Professor varchar(100) not null

--)

--create table CursosMatriculados
--(
--Id_CursosM int NOT NULL IDENTITY(1,1) PRIMARY KEY,

--id_curso int,
--Cpf varchar(24) not null,
--Nome_Curso varchar (50) not null,
--Nome_Professor varchar (100) not null,
--Carga_Horaria int

--foreign key (Id_Curso) references curso(ID_Curso)  


--) --todas as tabelas acima



select * from cliente
select * from curso
select * from CursosMatriculados
select * from Monitor



--insert into CursosMatriculados (Id_Curso,cpf,nome_curso,Nome_professor,carga_horaria) values (1,'04049498197',(select Nome_Curso from Curso where Id_Curso=1),(select Nome_Professor from Curso where Id_Curso=1),(select Carga_Horaria from Curso where Id_Curso=1))
--delete CursosMatriculados where Id_Curso = 1 and cpf='04049498199'
--Select Nome_Curso as curso,Nome_professor as Professor, Carga_horaria as CH from CursosMatriculados where cpf='04049498197'
--insert into CursosMatriculados (Id_Cliente,Id_Curso) values ((select DISTINCT  id_cliente from CLIENTE where cpf = '04049498198'),(1))
--insert into CLIENTE (Nome_Cliente,CPF,rg,Telefone) values ('fabio','04049498198','2825188-2','65984417225')
--insert into Curso (Nome_Curso,Carga_Horaria,Numero_Vagas,Nome_Professor) values ('ingles',60,40,'Aloizio')
--insert into Curso (Nome_Curso,Carga_Horaria,Numero_Vagas,Nome_Professor) values ('Algoritimo',200,30,'jivago')
--insert into CursosMatriculados(nome_curso,nome_professor,Carga_Horaria,Cpf,Id_Curso) values ((select Nome_Curso from Curso where Id_Curso= Id_Curso),(select Nome_Professor from Curso where Id_Curso= Id_Curso),(select Carga_Horaria from Curso where Id_Curso= Id_Curso), cpf,id_curso)

