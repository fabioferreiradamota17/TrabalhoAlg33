select * from CLIENTE

update cliente set Telefone= '111' where cpf = 'fda'

Create table Monitor(
 Id_Monitor int NOT NULL IDENTITY(1,1) PRIMARY KEY,
Nome varchar(100) not null,
Cpf varchar(24)not null,
rg varchar(24)not null,
Telefone Varchar(24)not null,
Diciplina varchar (24)not null,
CargaHoraria int not null

)

insert into Monitor(CargaHoraria) values (10)


select * from Monitor