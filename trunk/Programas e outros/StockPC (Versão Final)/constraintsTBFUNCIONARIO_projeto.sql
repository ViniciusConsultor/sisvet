--EXEMPLO DE CONTRAINT
ALTER TABLE funcionario ADD COLUMN dat_admissao date; 
ALTER TABLE funcionario ADD COLUMN dat_desligamento date; 
ALTER TABLE funcionario ADD CONSTRAINT dat_desligamento_check CHECK (dat_desligamento >= dat_admissao); 

--CONSTRAINT VALIDA SEXO
ALTER TABLE tbfuncionario ADD CONSTRAINT valida_sexo CHECK(sexo = 'M' OR sexo = 'F'); 

--TESTAR SE A CONSTRAINT VALIDA_SEXO ESTA FUNCIONANDO
insert into tbfuncionario (nome, cpf, rg, endereco, telefone, email, cart_trabalho, login, senha, sexo)
values ('Joao',0987654321,88720421740,'rua joao',6677-0987,'joao@uol',13412342,'joao',088766,'M')

select * from tbfuncionario

--CONTRAINT NAO PERMITE QUE SEJA INSERIDO DOIS CPFS IGUAIS
ALTER TABLE TBFUNCIONARIO ADD CONSTRAINT ck_cpf UNIQUE(cpf);

--CONTRAINT NAO PERMITE QUE SEJA INSERIDO DOIS RGS IGUAIS
ALTER TABLE TBFUNCIONARIO ADD CONSTRAINT ck_rg UNIQUE(rg);

--CONTRAINT NAO PERMITE QUE SEJA INSERIDO DOIS EMAILS IGUAIS
ALTER TABLE TBFUNCIONARIO ADD CONSTRAINT ck_email UNIQUE(email);

--CONTRAINT NAO PERMITE QUE SEJA INSERIDO DOIS LOGINS IGUAIS
ALTER TABLE TBFUNCIONARIO ADD CONSTRAINT ck_login UNIQUE(login);

--CONTRAINT NAO PERMITE QUE SEJA INSERIDO DUAS CARTEIRA DE TRABALHO IGUAIS
ALTER TABLE TBFUNCIONARIO ADD CONSTRAINT ck_cart_trabalho UNIQUE(cart_trabalho);

--VALIDA EMAIL
ALTER TABLE TBFUNCIONARIO ADD CONSTRAINT valida_email CHECK(email ~* '^[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+[.][A-Za-z]+$');

--VALIDA CPF
ALTER TABLE TBFUNCIONARIO ADD CONSTRAINT valida_cpf CHECK (cpf ~* '^[0-9][0-9][0-9][.][0-9][0-9][0-9][.][0-9][0-9][0-9][-][0-9][0-9]+$');
select * from tbfuncionario

--VALIDA RG
ALTER TABLE TBFUNCIONARIO ADD CONSTRAINT valida_rg CHECK (rg ~* '^[0-9][0-9][.][0-9][0-9][0-9][.][0-9][0-9][0-9][-][0-9]+$');

--TESTAR SE A CONSTRAINT VALIDA_CPF ESTA FUNCIONANDO
insert into tbfuncionario (nome, cpf, rg, endereco, telefone, email, cart_trabalho, login, senha, sexo)
values ('Joao','333.333.333-33',8872042174,'rua joao',6677-0987,'joao@uol.com',13412342,'joao',088766,'M')

--VALIDA TELEFONE
ALTER TABLE TBFUNCIONARIO ADD CONSTRAINT valida_telefone CHECK (telefone ~* '^[(][0-9][0-9][)][0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]+$');

--TESTAR SE A CONSTRAINT VALIDA_TELEFONE ESTA FUNCIONANDO
insert into tbfuncionario (nome, cpf, rg, endereco, telefone, email, cart_trabalho, login, senha, sexo)
values ('Paulo','444.444.444-44',88745645,'rua joao','(43)9999-9999','paulo@uol.com',18812342,'paulo',088766,'M')



