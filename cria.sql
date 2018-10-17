Create table Monitor(
 Id_Monitor int NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nome varchar(100) not null,
Cpf varchar(24)not null,
rg varchar(24)not null,
Telefone Varchar(24)not null,
Diciplina varchar (24)not null,
CargaHoraria int not null

)
create table CLIENTE(
Id_Cliente int NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nome_Cliente varchar(100) not null,
CPF varchar(24) not null,
RG varchar (24) not null,
Telefone varchar (24) not null

)

create table Curso(
Id_Curso int NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nome_Curso varchar(50) not null,
Carga_Horaria int not null,
Numero_Vagas int not null,
Nome_Professor varchar(100) not null

)

create table CursosMatriculados
(
Id_CursosM int NOT NULL IDENTITY(1,1) PRIMARY KEY,

id_curso int,
Cpf varchar(24) not null,
Nome_Curso varchar (50) not null,
Nome_Professor varchar (100) not null,
Carga_Horaria int

foreign key (Id_Curso) references curso(ID_Curso)  


) --todas as tabelas acima
