Use ProjetoDS;

create table Pessoa(
idPessoa int primary key identity(1,1),
cargo varchar(100),
dtNascimento date,
sexo char(1),
ativo binary,
telFixo varchar(10),
telCelular varchar(13),
rg  varchar (13),
cpf varchar (13),
nome varchar (200),
userName varchar (100),
email varchar (200),
senha varchar (200));

select * from Pessoa;

ALTER TABLE Pessoa ALTER COLUMN ativo VARCHAR(5);

update Pessoa set ativo = 'true' where ativo ='false';

delete Pessoa where idPessoa = 3;