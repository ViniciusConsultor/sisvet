--EXEMPLO DE CONTRAINT
ALTER TABLE funcionario ADD COLUMN dat_admissao date; 
ALTER TABLE funcionario ADD COLUMN dat_desligamento date; 
ALTER TABLE funcionario ADD CONSTRAINT dat_desligamento_check CHECK (dat_desligamento >= dat_admissao); 


--CONTRAINT NAO PERMITE QUE SEJA INSERIDO DOIS CNPJs IGUAIS
ALTER TABLE TBFORNECEDOR ADD CONSTRAINT ck_cnpj UNIQUE(cnpj);

--CONTRAINT NAO PERMITE QUE SEJA INSERIDO DOIS EMAILS IGUAIS
ALTER TABLE TBFORNECEDOR ADD CONSTRAINT ck_email UNIQUE(email);
alter table tbfornecedor drop constraint ck_email

--VALIDA EMAIL
ALTER TABLE TBFORNECEDOR ADD CONSTRAINT valida_email CHECK(email ~* '^[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+[.][A-Za-z]+$');


--VALIDA TELEFONE
ALTER TABLE TBFORNECEDOR ADD CONSTRAINT valida_telefone CHECK (telefone ~* '^[(][0-9][0-9][)][0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]+$');

--VALIDA CNPJ
ALTER TABLE tbfornecedor ADD CONSTRAINT valida_cnpj CHECK (cnpj ~* '^[0-9][0-9][.][0-9][0-9][0-9][.][0-9][0-9][0-9][/][0-9][0-9][0-9][0-9][-][0-9][0-9]+$');

--TESTAR SE A CONSTRAINT VALIDA_TELEFONE ESTA FUNCIONANDO
insert into tbfornecedor (nome, cnpj, endereco, telefone, email, cidade_id_fk)
values ('Roberto','444.444.444-44', 'rua roberto','(43)9999-9999','roberto@uol.com',1)
select * from tbcidade
insert into tbcidade (nome, estado) values ('Londrina', 'PR')


