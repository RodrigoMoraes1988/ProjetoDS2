select * from Pessoa;

update Pessoa set cargo = 'adm'; 

truncate table Pessoa;

INSERT INTO Pessoa (cargo, dtNascimento, sexo, ativo, telFixo, telCelular, rg, cpf, nome, userName, email, senha)
VALUES ('func','1994-05-24','F',1,'1199999999','11994649523','111111111','22222222222','Pabline Fernandes Vaz','Pabline.Vaz','pabline.vaz@etec.sp.gov.br','54321');