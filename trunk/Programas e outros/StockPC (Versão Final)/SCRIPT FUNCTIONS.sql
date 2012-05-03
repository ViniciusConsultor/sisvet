
--Categoria==============================================================================================================

--INSERT:
CREATE OR REPLACE FUNCTION fnAddCategoria(nome_ character varying(30), descricao_ character varying(50)) RETURNS TEXT AS 
$$ 
BEGIN
	IF NOME_ IS NULL OR NOME_ = '' THEN
		RETURN '1|O Nome precisa ser informado!';
	ELSIF DESCRICAO_ IS NULL OR DESCRICAO_ = '' THEN
		RETURN '1|A Descrição precisa ser informada!';
	ELSE
		INSERT INTO tbcategoria (nome, descricao) values(nome_, descricao_);
		RETURN '0|Categoria adicionada com sucesso!';
	END IF;
END
$$ LANGUAGE PLPGSQL;

--UPDATE:
CREATE OR REPLACE FUNCTION fnUpdateCategoria(id_ integer, nome_ character varying(30), descricao_ character varying(50)) RETURNS TEXT AS
$$
BEGIN
	IF ID_ IS NULL OR NOT EXISTS(SELECT * FROM TBCATEGORIA WHERE ID = ID_) THEN
		RETURN '1|A Categoria informada não existe!';
	ELSIF NOME_ IS NULL OR NOME_ = '' THEN
		RETURN '1|O Nome precisa ser informado!';
	ELSIF DESCRICAO_ IS NULL OR DESCRICAO_ = '' THEN
		RETURN '1|A Descrição precisa ser informada!';
	ELSE
		UPDATE tbcategoria SET nome = nome_, descricao = descricao_ WHERE id = id_;
		RETURN '0|Categoria atualizada com sucesso!';
	END IF;
END
$$ LANGUAGE PLPGSQL;

--DELETE:
CREATE OR REPLACE FUNCTION fnDeleteCategoria(id_ integer) RETURNS TEXT AS
$$
BEGIN
	IF ID_ IS NULL OR NOT EXISTS(SELECT * FROM TBCATEGORIA WHERE ID = ID_)
	THEN
		RETURN '1|A Categoria informada não existe!';
	ELSE
		DELETE FROM tbcategoria WHERE id = id_;
		RETURN '0|Categoria excluída com sucesso!';
	END IF;
END
$$ LANGUAGE PLPGSQL;

--SELECT:
CREATE OR REPLACE FUNCTION fnGetCategorias() RETURNS SETOF TBCATEGORIA AS $$
DECLARE 
	linha tbcategoria%ROWTYPE;
BEGIN
	FOR linha in  SELECT * FROM tbcategoria LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;

CREATE OR REPLACE FUNCTION fnGetCategorias(nome_ character varying(30)) RETURNS SETOF TBCATEGORIA AS $$
DECLARE 
	linha tbcategoria%ROWTYPE;
BEGIN
	FOR linha in  SELECT * FROM tbcategoria where upper(nome) like upper(nome_) || '%' LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;

--Cidade=================================================================================================================

--INSERT:
-- drop FUNCTION fnAddCidade(nome_ character varying(30), estado_ character(2))
CREATE OR REPLACE FUNCTION fnAddCidade(nome_ character varying(30), estado_ character(2)) RETURNS TEXT AS 
$$ 
BEGIN
	IF NOME_ IS NULL OR NOME_ = '' THEN
		RETURN '1|O Nome precisa ser informado!';
	ELSIF ESTADO_ IS NULL OR ESTADO_ = '' THEN
		RETURN '1|O Estado precisa ser informado!';
	ELSE
		INSERT INTO TBCIDADE (NOME, ESTADO) VALUES(NOME_, ESTADO_);
		RETURN '0|Cidade adicionada com sucesso!';
	END IF;
END
$$ LANGUAGE PLPGSQL;

--UPDATE:
-- drop FUNCTION fnUpdateCidade(id_ integer, nome_ character varying(30), estado_ character(2))
CREATE OR REPLACE FUNCTION fnUpdateCidade(id_ integer, nome_ character varying(30), estado_ character(2)) RETURNS TEXT AS
$$
BEGIN
	IF ID_ IS NULL OR NOT EXISTS(SELECT * FROM TBCIDADE WHERE ID = ID_) THEN
		RETURN '1|A Cidade informada não existe!';
	ELSIF NOME_ IS NULL OR NOME_ = '' THEN
		RETURN '1|O Nome precisa ser informado!';
	ELSIF ESTADO_ IS NULL OR ESTADO_ = '' THEN
		RETURN '1|O Estado precisa ser informado!';
	ELSE
		UPDATE TBCIDADE SET NOME = NOME_, ESTADO = ESTADO_ WHERE ID = ID_;
		RETURN '0|Cidade atualizada com sucesso!';
	END IF;
END
$$ LANGUAGE PLPGSQL;

--DELETE:
-- drop FUNCTION fnDeleteCidade(id_ integer)
CREATE OR REPLACE FUNCTION fnDeleteCidade(id_ integer) RETURNS TEXT AS
$$
BEGIN
	IF ID_ IS NULL OR NOT EXISTS(SELECT * FROM tbcidade WHERE ID = ID_)
	THEN
		RETURN '1|A Cidade informada não existe!';
	ELSE
		DELETE FROM tbcidade WHERE id = id_;
		RETURN '0|Cidade excluída com sucesso!';
	END IF;
END
$$ LANGUAGE PLPGSQL;

--SELECT:
CREATE OR REPLACE FUNCTION fnGetCidades() RETURNS SETOF tbcidade AS $$
DECLARE 
	linha tbcidade%ROWTYPE;
BEGIN
	FOR linha in  SELECT * FROM tbcidade LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;

CREATE OR REPLACE FUNCTION fnGetCidades(nome_ character varying(30)) RETURNS SETOF tbcidade AS $$
DECLARE 
	linha tbcidade%ROWTYPE;
BEGIN
	FOR linha in  SELECT * FROM tbcidade WHERE upper(nome) like upper(NOME_) || '%' LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;

--Fornecedor=============================================================================================================

--INSERT:
-- drop FUNCTION fnAddFornecedor(nome_ character varying(50), cnpj_ character(14), endereco_ character varying(50), telefone_ character(13), email_ character varying(50), cidade_id integer)
CREATE OR REPLACE FUNCTION fnAddFornecedor(nome_ character varying(50), cnpj_ character(18), endereco_ character varying(50), telefone_ character(13),
email_ character varying(50), cidade_id integer) RETURNS TEXT AS 
$$ 
BEGIN
	IF NOME_ IS NULL OR NOME_ = '' THEN
		RETURN '1|O Nome precisa ser informado!';
	ELSIF CNPJ_ IS NULL OR CNPJ_ = '' THEN
		RETURN '1|O CNPJ precisa ser informado!';
	ELSIF cnpj_ ~* '^[0-9][0-9][.][0-9][0-9][0-9][.][0-9][0-9][0-9][/][0-9][0-9][0-9][0-9][-][0-9][0-9]+$' = false THEN
		RETURN '1|CNPJ inválido!';
	ELSIF EXISTS(SELECT * FROM TBFORNECEDOR WHERE CNPJ = CNPJ_) THEN
		RETURN '1|O CNPJ informado já existe, informe outro!';
	ELSIF TELEFONE_ IS NOT NULL AND TELEFONE_ ~* '^[(][0-9][0-9][)][0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]+$' = FALSE THEN
		RETURN '1|Telefone inválido!';
	ELSIF EMAIL_ IS NOT NULL AND EMAIL_ ~* '^[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+[.][A-Za-z]+$' = FALSE THEN
		RETURN '1|E-mail inválido!';
	ELSIF NOT EXISTS(SELECT * FROM TBCIDADE WHERE ID = CIDADE_ID) THEN
		RETURN '1|A Cidade informada não existe!';
	ELSE
		INSERT INTO tbfornecedor (nome, cnpj, endereco, telefone, email, cidade_id_fk) values(nome_, cnpj_, endereco_, telefone_, email_, cidade_id);
		RETURN '0|Fornecedor adicionado com sucesso!';
	END IF;
END
$$ LANGUAGE PLPGSQL;

--UPDATE:
-- drop FUNCTION fnUpdateFornecedor(id_ integer, nome_ character varying(50), cnpj_ character(14), endereco_ character varying(50), telefone_ character(13), email_ character varying(50), cidade_id integer)
CREATE OR REPLACE FUNCTION fnUpdateFornecedor(id_ integer, nome_ character varying(50), cnpj_ character(18), endereco_ character varying(50), 
telefone_ character(13), email_ character varying(50), cidade_id integer) RETURNS TEXT AS
$$
BEGIN
	IF ID_ IS NULL OR NOT EXISTS(SELECT * FROM tbfornecedor WHERE ID = ID_) THEN
		RETURN '1|O Fornecedor informado não existe!';
	ELSIF NOME_ IS NULL OR NOME_ = '' THEN
		RETURN '1|O Nome precisa ser informado!';
	ELSIF CNPJ_ IS NULL OR CNPJ_ = '' THEN
		RETURN '1|O CNPJ precisa ser informado!';
	ELSIF cnpj_ ~* '^[0-9][0-9][.][0-9][0-9][0-9][.][0-9][0-9][0-9][/][0-9][0-9][0-9][0-9][-][0-9][0-9]+$' = false THEN
		RETURN '1|CNPJ inválido!';
	ELSIF EXISTS(SELECT * FROM TBFORNECEDOR WHERE CNPJ = CNPJ_) THEN
		RETURN '1|O CNPJ informado já existe, informe outro!';
	ELSIF TELEFONE_ IS NOT NULL AND TELEFONE_ ~* '^[(][0-9][0-9][)][0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]+$' = FALSE THEN
		RETURN '1|Telefone inválido!';
	ELSIF EMAIL_ IS NOT NULL AND EMAIL_ ~* '^[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+[.][A-Za-z]+$' = FALSE THEN
		RETURN '1|E-mail inválido!';
	ELSIF NOT EXISTS(SELECT * FROM TBCIDADE WHERE ID = CIDADE_ID) THEN
		RETURN '1|A Cidade informada não existe!';
	ELSE
		UPDATE tbfornecedor SET nome = nome_, cnpj = cnpj_, endereco = endereco_, telefone = telefone_, email = email_, cidade_id_fk = cidade_id
		WHERE id = id_;
		RETURN '0|Fornecedor atualizado com sucesso!';
	END IF;
END
$$ LANGUAGE PLPGSQL;

--DELETE:
-- drop FUNCTION fnDeleteFornecedor(id_ integer)
CREATE OR REPLACE FUNCTION fnDeleteFornecedor(id_ integer) RETURNS TEXT AS
$$
BEGIN
	IF ID_ IS NULL OR NOT EXISTS(SELECT * FROM tbfornecedor WHERE ID = ID_)
	THEN
		RETURN '1|O Fornecedor informado não existe!';
	ELSE
		DELETE FROM tbfornecedor WHERE id = id_;
		RETURN '0|Fornecedor excluído com sucesso!';
	END IF;
END
$$ LANGUAGE PLPGSQL;

--SELECT:
CREATE OR REPLACE FUNCTION fnGetFornecedores() RETURNS SETOF tbfornecedor AS $$
DECLARE 
	linha tbfornecedor%ROWTYPE;
BEGIN
	FOR linha in  SELECT * FROM tbfornecedor LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;


CREATE OR REPLACE FUNCTION fnGetFornecedores(nome_ character varying(50), cnpj_ character(18)) RETURNS SETOF tbfornecedor AS $$
DECLARE 
	linha tbfornecedor%ROWTYPE;
BEGIN
	FOR linha in  SELECT * FROM TBFORNECEDOR WHERE UPPER(NOME) LIKE UPPER(NOME_) || '%' AND CNPJ LIKE CNPJ_ || '%' LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;

select * from fngetfornecedores('', '40.000.000/0000-00')

--Funcionário============================================================================================================

--INSERT:
-- drop FUNCTION fnAddFuncionario(nome_ character varying(50), cpf_ character(11), rg_ character varying(20), endereco_ character varying(50),
-- telefone_ character(13), email_ character varying(50), cart_trabalho_ integer, login_ character varying(50), senha_ character varying(50), sexo_ character(1),
-- administrador_ boolean)

CREATE OR REPLACE FUNCTION fnAddFuncionario(nome_ character varying(50), cpf_ character(11), rg_ character varying(20), endereco_ character varying(50),
telefone_ character(13), email_ character varying(50), cart_trabalho_ character varying(20), login_ character varying(50), senha_ character varying(50), sexo_ character(1),
administrador_ boolean) RETURNS TEXT AS 
$$ 
BEGIN
	IF NOME_ IS NULL OR NOME_ = '' THEN
		RETURN '1|O Nome precisa ser informado!';
	ELSIF CPF_ IS NULL OR CPF_ = '' THEN
		RETURN '1|O CPF precisa ser informado!';
	ELSIF CPF_ ~* '^[0-9][0-9][0-9][.][0-9][0-9][0-9][.][0-9][0-9][0-9][-][0-9][0-9]+$' = FALSE THEN
		RETURN 'CPF inválido!';
	ELSIF EXISTS(SELECT * FROM TBFUNCIONARIO WHERE CPF = CPF_) THEN
		RETURN '1|O CPF informado já existe, informe outro!';
	ELSIF RG_ IS NULL OR RG_ = '' THEN
		RETURN '1|O RG precisa ser informado!';
	ELSIF RG_ ~* '^[0-9][0-9][.][0-9][0-9][0-9][.][0-9][0-9][0-9][-][0-9]+$' = FALSE THEN
		RETURN 'RG inválido!';
	ELSIF EXISTS(SELECT * FROM TBFUNCIONARIO WHERE RG = RG_) THEN
		RETURN '1|O RG informado já existe, informe outro!';
	ELSIF TELEFONE_ IS NOT NULL AND TELEFONE_ ~* '^[(][0-9][0-9][)][0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]+$' = FALSE THEN
		RETURN '1|Telefone inválido!';
	ELSIF EMAIL_ IS NOT NULL AND EMAIL_ ~* '^[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+[.][A-Za-z]+$' = FALSE THEN
		RETURN '1|E-mail inválido!';
	ELSIF cart_trabalho_ IS NULL OR cart_trabalho_ = '' THEN
		RETURN '1|O CTPS precisa ser informado!';
	ELSIF EXISTS(SELECT * FROM TBFUNCIONARIO WHERE cart_trabalho = cart_trabalho_) THEN
		RETURN '1|O CTPS informado já existe, informe outro!';
	ELSIF login_ IS NULL OR login_ = '' THEN
		RETURN '1|O Login precisa ser informado!';
	ELSIF EXISTS(SELECT * FROM TBFUNCIONARIO WHERE "login" = login_) THEN
		RETURN '1|O Login informado já existe, informe outro!';
	ELSIF SENHA_ IS NULL OR SENHA_ = '' THEN
		RETURN '1|A Senha precisa ser informada!';
	ELSIF SEXO_ IS NULL OR SEXO_ = '' OR SEXO_ != 'M' AND SEXO_ != 'F' THEN
		RETURN '1|Sexo inválido!';
	ELSIF ADMINISTRADOR_ IS NULL THEN
		RETURN '1|O Campo Administrador precisa ser informado!';
	ELSE
		INSERT INTO tbfuncionario (nome, cpf, rg, endereco, telefone, email, cart_trabalho, "login", senha, sexo, administrador) 
		VALUES(nome_, cpf_, rg_, endereco_, telefone_, email_, cart_trabalho_, login_, md5(senha_), sexo_, administrador_);

		RETURN '0|Funcionario adicionado com sucesso!';
	END IF;
END
$$ LANGUAGE PLPGSQL;

--UPDATE:
-- drop FUNCTION fnUpdateFuncionario(id_ integer, nome_ character varying(50), cpf_ character(11), rg_ character varying(20), endereco_ character varying(50),
-- telefone_ character(13), email_ character varying(50), cart_trabalho_ integer, login_ character varying(50), senha_ character varying(50), sexo_ character(1),
-- administrador_ boolean)

CREATE OR REPLACE FUNCTION fnUpdateFuncionario(id_ integer, nome_ character varying(50), cpf_ character(11), rg_ character varying(20), endereco_ character varying(50),
telefone_ character(13), email_ character varying(50), cart_trabalho_ character varying(20), login_ character varying(50), senha_ character varying(50), sexo_ character(1),
administrador_ boolean) RETURNS TEXT AS 
$$ 
BEGIN
	IF ID_ IS NULL OR NOT EXISTS(SELECT * FROM tbfuncionario WHERE ID = ID_) THEN
		RETURN '1|O Funcionario informado não existe!';
	ELSIF NOME_ IS NULL OR NOME_ = '' THEN
		RETURN '1|O Nome precisa ser informado!';
	ELSIF CPF_ IS NULL OR CPF_ = '' THEN
		RETURN '1|O CPF precisa ser informado!';
	ELSIF CPF_ ~* '^[0-9][0-9][0-9][.][0-9][0-9][0-9][.][0-9][0-9][0-9][-][0-9][0-9]+$' = FALSE THEN
		RETURN 'CPF inválido!';
	ELSIF EXISTS(SELECT * FROM TBFUNCIONARIO WHERE CPF = CPF_ and id != id_) THEN
		RETURN '1|O CPF informado já existe, informe outro!';
	ELSIF RG_ IS NULL OR RG_ = '' THEN
		RETURN '1|O RG precisa ser informado!';
	ELSIF RG_ ~* '^[0-9][0-9][.][0-9][0-9][0-9][.][0-9][0-9][0-9][-][0-9]+$' = FALSE THEN
		RETURN 'RG inválido!';
	ELSIF EXISTS(SELECT * FROM TBFUNCIONARIO WHERE RG = RG_ and id != id_) THEN
		RETURN '1|O RG informado já existe, informe outro!';
	ELSIF TELEFONE_ IS NOT NULL AND TELEFONE_ ~* '^[(][0-9][0-9][)][0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]+$' = FALSE THEN
		RETURN '1|Telefone inválido!';
	ELSIF EMAIL_ IS NOT NULL AND EMAIL_ ~* '^[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+[.][A-Za-z]+$' = FALSE THEN
		RETURN '1|E-mail inválido!';
	ELSIF cart_trabalho_ IS NULL OR cart_trabalho_ = '' THEN
		RETURN '1|O CTPS precisa ser informado!';
	ELSIF EXISTS(SELECT * FROM TBFUNCIONARIO WHERE cart_trabalho = cart_trabalho_ and id != id_) THEN
		RETURN '1|O CTPS informado já existe, informe outro!';
	ELSIF login_ IS NULL OR login_ = '' THEN
		RETURN '1|O Login precisa ser informado!';
	ELSIF EXISTS(SELECT * FROM TBFUNCIONARIO WHERE "login" = login_ and id != id_) THEN
		RETURN '1|O Login informado já existe, informe outro!';
	ELSIF SENHA_ IS NULL OR SENHA_ = '' THEN
		RETURN '1|A Senha precisa ser informada!';
	ELSIF SEXO_ IS NULL OR SEXO_ = '' OR SEXO_ != 'M' AND SEXO_ != 'F' THEN
		RETURN '1|Sexo inválido!';
	ELSIF ADMINISTRADOR_ IS NULL THEN
		RETURN '1|O Campo Administrador precisa ser informado!';
	ELSE
		UPDATE tbfuncionario SET nome = nome_, cpf = cpf_, rg = rg_, endereco = endereco_, telefone = telefone_, email = email_, cart_trabalho = cart_trabalho_,
		"login" = login_, senha = md5(senha_), sexo = sexo_, administrador = administrador_
		WHERE id = id_;
		
		RETURN '0|Funcionario atualizado com sucesso!';
	END IF;
END
$$ LANGUAGE PLPGSQL;

--DELETE:
-- drop FUNCTION fnDeleteFuncionario(id_ integer)

CREATE OR REPLACE FUNCTION fnDeleteFuncionario(id_ integer) RETURNS TEXT AS
$$
BEGIN
	IF ID_ IS NULL OR NOT EXISTS(SELECT * FROM tbfuncionario WHERE ID = ID_)
	THEN
		RETURN '1|O Funcionário informado não existe!';
	ELSE
		DELETE FROM tbfuncionario WHERE id = id_;
		RETURN '0|Funcionário excluído com sucesso!';
	END IF;
END
$$ LANGUAGE PLPGSQL;

--SELECT:
CREATE OR REPLACE FUNCTION fnGetFuncionarios() RETURNS SETOF tbfuncionario AS $$
DECLARE 
	linha tbfuncionario%ROWTYPE;
BEGIN
	FOR linha in  SELECT * FROM tbfuncionario LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;


CREATE OR REPLACE FUNCTION fnGetFuncionarios(nome_ character varying(50), cpf_ character(11), rg_ character varying(20)) RETURNS SETOF tbfuncionario AS $$
DECLARE 
	linha tbfuncionario%ROWTYPE;
BEGIN
	FOR linha in  SELECT * FROM tbfuncionario WHERE UPPER(NOME) LIKE UPPER(NOME_) || '%' AND CPF LIKE CPF_ || '%' AND RG LIKE RG_ || '%' LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;


--Item Pedido============================================================================================================

--INSERT:
CREATE OR REPLACE FUNCTION fnValidaAddItem_Pedido(produto_id integer, pedido_id integer, qtde_solicitada_ integer) RETURNS TEXT AS
$$
BEGIN
	IF NOT EXISTS(SELECT * FROM TBPRODUTO WHERE ID = PRODUTO_ID) THEN
		RETURN '1|O Produto informado não existe!';
	ELSIF NOT EXISTS(SELECT * FROM TBPEDIDO WHERE ID = PEDIDO_ID) THEN
		RETURN '1|O Pedido informado não existe!';
	ELSIF QTDE_SOLICITADA_ <= 0 THEN
		RETURN '1|A Quantia Solicitada é inválida!';
	ELSE
		RETURN '0|';
	END IF;
END
$$ LANGUAGE PLPGSQL;
		

CREATE OR REPLACE FUNCTION fnAddItem_pedido(produto_id integer[], pedido_id integer, qtde_solicitada_ integer[]) RETURNS VOID AS
$$
DECLARE
	i integer;
	VALOR_ INTEGER;
	verifica integer;
-- 	GET DIAGNOSTICS DIG := ROW_COUNT;
BEGIN
	FOR i IN 1..array_upper(produto_id, 1) LOOP
		VALOR_ := (SELECT VALOR_CUSTO FROM TBPRODUTO WHERE ID = PRODUTO_ID[i]) * QTDE_SOLICITADA_[i];
	
		INSERT INTO tbitem_pedido (id_produto_fk, id_pedido_fk, qtde_solicitada, valor)
		VALUES(produto_id[i], pedido_id, qtde_solicitada_[i], VALOR_);

		UPDATE TBPEDIDO SET TOTAL_PEDIDO = TOTAL_PEDIDO + VALOR_ WHERE ID = PEDIDO_ID;

		VALOR_ := 0;
	END LOOP;
END
$$ LANGUAGE PLPGSQL;

--UPDATE:
CREATE OR REPLACE FUNCTION fnValidaUpdateItem_Pedido(id_ integer, produto_id integer, qtde_solicitada_ integer) RETURNS TEXT AS
$$
BEGIN
	IF NOT EXISTS(SELECT * FROM TBITEM_PEDIDO WHERE ID = ID_) THEN
		RETURN '1|O Item de Pedido informado não existe!';
	ELSIF NOT EXISTS(SELECT * FROM TBPRODUTO WHERE ID = PRODUTO_ID) THEN
		RETURN '1|O Produto informado não existe!';
	ELSIF QTDE_SOLICITADA_ <= 0 THEN
		RETURN '1|A Quantia Solicitada é inválida!';
	ELSE
		RETURN '0|';
	END IF;
END
$$ LANGUAGE PLPGSQL;


CREATE OR REPLACE FUNCTION fnUpdateItem_pedido(id_ integer[], produto_id integer[], qtde_solicitada_ integer[]) RETURNS VOID AS
$$
DECLARE
	i integer;
	VALOR_ INTEGER;
BEGIN
	FOR i IN 1..ARRAY_UPPER(ID_, 1) LOOP
		VALOR_ := (SELECT VALOR_CUSTO FROM TBPRODUTO WHERE ID = PRODUTO_ID[i]) * QTDE_SOLICITADA_[i]; 
	
		UPDATE tbitem_pedido SET id_produto_fk = produto_id[i], qtde_solicitada = qtde_solicitada_[i], 
		VALOR = VALOR_
		WHERE id = id_[i];

		UPDATE TBPEDIDO SET TOTAL_PEDIDO = TOTAL_PEDIDO + VALOR_ WHERE ID = PEDIDO_ID;

		VALOR_ := 0;
	END LOOP;
END
$$ LANGUAGE PLPGSQL;

--DELETE:
CREATE OR REPLACE FUNCTION fnValidaDeleteItem_pedido(id_ integer) RETURNS TEXT AS
$$
BEGIN
	IF NOT EXISTS(SELECT * FROM TBITEM_PEDIDO WHERE ID = ID_) THEN
		RETURN '1|O Item de Pedido informado não existe!';
	ELSE
		RETURN '0|';
	END IF;
END
$$ LANGUAGE PLPGSQL;

CREATE OR REPLACE FUNCTION fnDeleteItem_pedido(id_ integer[], PEDIDO_ID INTEGER) RETURNS VOID AS
$$
DECLARE
	i integer;
BEGIN
	FOR i IN 1..array_upper(id_, 1) LOOP
		UPDATE TBPEDIDO SET TOTAL_PEDIDO = TOTAL_PEDIDO - (SELECT VALOR_CUSTO FROM TBITEM_PEDIDO WHERE ID = ID_[i]) WHERE ID = PEDIDO_ID;
	
		DELETE FROM tbitem_pedido WHERE id = id_[i];
	END LOOP;
END
$$ LANGUAGE PLPGSQL;

--SELECT:
CREATE OR REPLACE FUNCTION fnGetItems_Pedido(pedido_id integer) RETURNS SETOF tbitem_pedido AS $$
DECLARE 
	linha tbitem_pedido%ROWTYPE;
BEGIN
	FOR linha in SELECT * FROM tbitem_pedido WHERE id_pedido_fk = pedido_id LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;


CREATE OR REPLACE FUNCTION fnGetItems_Pedido(pedido_id integer, produto_id integer) RETURNS SETOF tbitem_pedido AS $$
DECLARE 
	linha tbitem_pedido%ROWTYPE;
BEGIN
	FOR linha in SELECT * FROM tbitem_pedido WHERE id_pedido_fk = pedido_id AND id_produto_fk = produto_id LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;

--Pedido================================================================================================================

--INSERT:
--Validar Data no Postgre:

--Valida datas no formato dd/mm/yyyy
--^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/(\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/(\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/(\d{2}))|(29\/02\/((0[48]|[2468][048]|[13579][26])|(00))))$
--
--Valida datas no formato mm/dd/yyyy ou mm-dd-yyyy
--^(((((((0?[13578])|(1[02]))[\.\-/]?((0?[1-9])|([12]\d)|(3[01])))|(((0?[469])|(11))[\.\-/]?((0?[1-9])|([12]\d)|(30)))|((0?2)[\.\-/]?((0?[1-9])|(1\d)|(2[0-8]))))[\.\-/]?(((19)|(20))?([\d][\d]))))|((0?2)[\.\-/]?(29)[\.\-/]?(((19)|(20))?(([02468][048])|([13579][26])))))$

CREATE OR REPLACE FUNCTION fnAddPedido(funcionario_id integer, fornecedor_id integer, data_ date, entregue_ boolean) RETURNS TEXT AS
$$
DECLARE
	VERIFICA INTEGER;
BEGIN
	IF NOT EXISTS(SELECT * FROM TBFUNCIONARIO WHERE ID = FUNCIONARIO_ID) THEN
		RETURN '1|O Funcionário informado não existe!';
	ELSIF NOT EXISTS(SELECT * FROM TBFORNECEDOR WHERE ID = FORNECEDOR_ID) THEN
		RETURN '1|O Fornecedor informado não existe!';
	ELSIF DATA_ IS NULL THEN
		RETURN '1|A Data precisa ser informada!';
	ELSIF ENTREGUE_ IS NULL THEN
		RETURN '1|O Campo Entregue precisa ser informado!';
	ELSE
		INSERT INTO tbpedido (funcionario_id_fk, fornecedor_id_fk, "data", total_pedido, entregue)
		VALUES(funcionario_id, fornecedor_id, data_, 0, entregue_);
		RETURN '0|Pedido adicionado com sucesso!';
	END IF;
END
$$ LANGUAGE PLPGSQL;

--UPDATE: -> o Pedido só pode ser ATUALIZADO se estiver efetivado(coluna: entregue)
CREATE OR REPLACE FUNCTION fnUpdatePedido(id_ integer, funcionario_id integer, fornecedor_id integer, data_ date, entregue_ boolean) RETURNS TEXT AS
$$
BEGIN
	IF NOT EXISTS(SELECT * FROM TBPEDIDO WHERE ID = ID_) THEN
		RETURN '1|O Pedido informado não existe!';
	ELSIF NOT EXISTS(SELECT * FROM TBFUNCIONARIO WHERE ID = FUNCIONARIO_ID) THEN
		RETURN '1|O Funcionário informado não existe!';
	ELSIF NOT EXISTS(SELECT * FROM TBFORNECEDOR WHERE ID = FORNECEDOR_ID) THEN
		RETURN '1|O Fornecedor informado não existe!';
	ELSIF DATA_ IS NULL THEN
		RETURN '1|A Data precisa ser informada!';
	ELSIF TOTAL_PEDIDO_ <= 0 THEN
		RETURN '1|A Quantidade Total do Pedido é inválida!';
	ELSIF AUTORIZADO_ IS NULL THEN
		RETURN '1|O Campo Autorizado precisa ser informado!';
	ELSIF ENTREGUE_ IS NULL THEN
		RETURN '1|O Campo Entregue precisa ser informado!';
	ELSE
		IF (SELECT ENTREGUE FROM TBPEDIDO WHERE ID = ID_) = FALSE THEN
			UPDATE tbpedido SET funcionario_id_fk = funcionario_id, fornecedor_id_fk = fornecedor_id, "data" = data_,
			total_pedido = (SELECT SUM(VALOR) FROM TBITEM_PEDIDO where id_pedido_fk = id_), entregue = entregue_
			WHERE id = id_;
		ELSE
			UPDATE tbpedido SET funcionario_id_fk = funcionario_id, fornecedor_id_fk = fornecedor_id, "data" = data_,
			total_pedido = (SELECT SUM(VALOR) FROM TBITEM_PEDIDO where id_pedido_fk = id_)
			WHERE id = id_;
		END IF;
		RETURN '0|Pedido atualizado com sucesso!';
	END IF;
END
$$ LANGUAGE PLPGSQL;

--DELETE:
-- drop FUNCTION fnDeletePedido(id_ integer)

CREATE OR REPLACE FUNCTION fnDeletePedido(id_ integer) RETURNS TEXT AS
$$
BEGIN
	IF NOT EXISTS(SELECT * FROM TBPEDIDO WHERE ID = ID_) THEN
		RETURN '1|O Pedido informado não existe!';
	ELSE
		DELETE FROM tbpedido CASCADE WHERE id = id_;
	END IF;
END
$$ LANGUAGE PLPGSQL;

--SELECT:
CREATE OR REPLACE FUNCTION fnGetPedidos() RETURNS SETOF tbpedido AS $$
DECLARE 
	linha tbpedido%ROWTYPE;
BEGIN
	FOR linha in SELECT * FROM tbpedido LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;


CREATE OR REPLACE FUNCTION fnGetPedidos(funcionario_id integer) RETURNS SETOF tbpedido AS $$
DECLARE 
	linha tbpedido%ROWTYPE;
BEGIN
	FOR linha in SELECT * FROM tbpedido WHERE FUNCIONARIO_ID_FK = FUNCIONARIO_ID LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;


CREATE OR REPLACE FUNCTION fnGetPedidos(fornecedor_id integer, situacao integer) RETURNS SETOF tbpedido AS $$
DECLARE 
	linha tbpedido%ROWTYPE;
BEGIN
	IF SITUACAO = 0 THEN
		FOR linha in SELECT * FROM tbpedido WHERE fornecedor_id_fk = fornecedor_id LOOP
			RETURN NEXT linha;
		END LOOP;
	ELSIF SITUACAO = 1 THEN
		FOR linha in SELECT * FROM tbpedido WHERE fornecedor_id_fk = fornecedor_id AND entregue = TRUE LOOP
			RETURN NEXT linha;
		END LOOP;
	ELSIF SITUACAO = 2 THEN
		FOR linha in SELECT * FROM tbpedido WHERE fornecedor_id_fk = fornecedor_id AND entregue = FALSE LOOP
			RETURN NEXT linha;
		END LOOP;
	END IF;
	RETURN;
END
$$LANGUAGE PLPGSQL;


CREATE OR REPLACE FUNCTION fnGetPedidos(funcionario_id integer, fornecedor_id integer, situacao integer) RETURNS SETOF tbpedido AS $$
DECLARE 
	linha tbpedido%ROWTYPE;
BEGIN
	IF SITUACAO = 0 THEN
		FOR linha in SELECT * FROM tbpedido WHERE funcionario_id_fk = funcionario_id and fornecedor_id_fk = fornecedor_id LOOP
			RETURN NEXT linha;
		END LOOP;
	ELSIF SITUACAO = 1 THEN
		FOR linha in SELECT * FROM tbpedido WHERE funcionario_id_fk = funcionario_id and fornecedor_id_fk = fornecedor_id AND entregue = TRUE LOOP
			RETURN NEXT linha;
		END LOOP;
	ELSIF SITUACAO = 2 THEN
		FOR linha in SELECT * FROM tbpedido WHERE funcionario_id_fk = funcionario_id and fornecedor_id_fk = fornecedor_id AND entregue = FALSE LOOP
			RETURN NEXT linha;
		END LOOP;
	END IF;
	RETURN;
END
$$LANGUAGE PLPGSQL;


CREATE OR REPLACE FUNCTION fnGetPedidos(data_ date, situacao integer) RETURNS SETOF tbpedido AS $$
DECLARE 
	linha tbpedido%ROWTYPE;
BEGIN
	IF SITUACAO = 0 THEN
		FOR linha in SELECT * FROM tbpedido WHERE funcionario_id_fk = funcionario_id and fornecedor_id_fk = fornecedor_id LOOP
			RETURN NEXT linha;
		END LOOP;
	ELSIF SITUACAO = 1 THEN
		FOR linha in SELECT * FROM tbpedido WHERE funcionario_id_fk = funcionario_id and fornecedor_id_fk = fornecedor_id AND entregue = TRUE LOOP
			RETURN NEXT linha;
		END LOOP;
	ELSIF SITUACAO = 2 THEN
		FOR linha in SELECT * FROM tbpedido WHERE funcionario_id_fk = funcionario_id and fornecedor_id_fk = fornecedor_id AND entregue = FALSE LOOP
			RETURN NEXT linha;
		END LOOP;
	END IF;
	RETURN;
END
$$LANGUAGE PLPGSQL;



--Produto===============================================================================================================

--INSERT:
-- drop FUNCTION fnAddProduto(descricao_ character varying(50), valor_custo_ real, valor_venda_ real, qtde_total_ integer, 
-- categoria_id integer)

CREATE OR REPLACE FUNCTION fnAddProduto(descricao_ character varying(50), valor_custo_ real, valor_venda_ real, qtde_total_ integer,
categoria_id integer) RETURNS TEXT AS
$$
BEGIN
	IF DESCRICAO_ IS NULL OR DESCRICAO_ = '' THEN
		RETURN '1|A Descrição precisa ser informada';
	ELSIF VALOR_CUSTO_ <= 0 THEN
		RETURN '1|O Valor de Custo informado é inválido!';
	ELSIF VALOR_VENDA_ <= 0 THEN
		RETURN '1|O Valor de Venda informado é inválido!';
	ELSIF VALOR_VENDA_ <= VALOR_CUSTO_ THEN
		RETURN '1|O Valor de Venda não pode menor ou igual ao Valor de Custo!';
	ELSIF QTDE_TOTAL_ < 0 THEN
		RETURN '1|A Quantidade não pode ter valor negativo!';
	ELSIF NOT EXISTS(SELECT * FROM TBCATEGORIA WHERE ID = CATEGORIA_ID) THEN
		RETURN '1|A Categoria informada não existe!';
	ELSE
		INSERT INTO tbproduto (descricao, valor_custo, valor_venda, qtde_total, categoria_id_fk)
		VALUES(descricao_, valor_custo_, valor_venda_, qtde_total_, categoria_id);

		RETURN '0|Produto adicionado com sucesso!';
	END IF;
END
$$ LANGUAGE PLPGSQL;


--UPDATE:
-- drop FUNCTION fnUpdateProduto(id_ integer, descricao_ character varying(50), valor_custo_ real, valor_venda_ real, qtde_total_ integer, 
-- categoria_id integer)

CREATE OR REPLACE FUNCTION fnUpdateProduto(id_ integer, descricao_ character varying(50), valor_custo_ real, valor_venda_ real, qtde_total_ integer, 
categoria_id integer) RETURNS TEXT AS
$$
BEGIN
	IF ID_ IS NULL OR NOT EXISTS(SELECT * FROM TBPRODUTO WHERE ID = ID_) THEN
		RETURN '1|O Produto informado não existe!';
	ELSIF DESCRICAO_ IS NULL OR DESCRICAO_ = '' THEN
		RETURN '1|A Descrição precisa ser informada';
	ELSIF VALOR_CUSTO_ <= 0 THEN
		RETURN '1|O Valor de Custo informado é inválido!';
	ELSIF VALOR_VENDA_ <= 0 THEN
		RETURN '1|O Valor de Venda informado é inválido!';
	ELSIF VALOR_VENDA_ <= VALOR_CUSTO_ THEN
		RETURN '1|O Valor de Venda não pode menor ou igual ao Valor de Custo!';
	ELSIF QTDE_TOTAL_ < 0 THEN
		RETURN '1|A Quantidade não pode ter valor negativo!';
	ELSIF NOT EXISTS(SELECT * FROM TBCATEGORIA WHERE ID = CATEGORIA_ID) THEN
		RETURN '1|A Categoria informada não existe!';
	ELSE
		UPDATE tbproduto 
		SET descricao = descricao_, valor_custo = valor_custo_, valor_venda = valor_venda_, qtde_total = qtde_total_, categoria_id_fk = categoria_id
		WHERE id = id_;

		RETURN '0|Produto atualizado com sucesso!';
	END IF;
END
$$ LANGUAGE PLPGSQL;

--DELETE:
-- DROP FUNCTION fnDeleteProduto(id_ integer)

CREATE OR REPLACE FUNCTION fnDeleteProduto(id_ integer) RETURNS TEXT AS
$$
BEGIN
	IF ID_ IS NULL OR NOT EXISTS(SELECT * FROM TBPRODUTO WHERE ID = ID_) THEN
		RETURN '1|O Produto informado não existe!';
	ELSE
		DELETE FROM tbproduto WHERE id = id_;
		RETURN '0|Produto excluído com sucesso!';
	END IF;
END
$$ LANGUAGE PLPGSQL;

--SELECT:
CREATE OR REPLACE FUNCTION fnGetProdutos() RETURNS SETOF tbproduto AS $$
DECLARE 
	linha tbproduto%ROWTYPE;
BEGIN
	FOR linha in  SELECT * FROM tbproduto LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;


CREATE OR REPLACE FUNCTION fnGetProdutos(descricao_ character varying(50), categoria_id integer) RETURNS SETOF tbproduto AS $$
DECLARE 
	linha tbproduto%ROWTYPE;
BEGIN
	IF CATEGORIA_ID != 0 THEN
		FOR LINHA IN  SELECT * FROM TBPRODUTO WHERE UPPER(DESCRICAO) LIKE UPPER(DESCRICAO_) || '%' AND CATEGORIA_ID_FK = CATEGORIA_ID LOOP
			RETURN NEXT linha;
		END LOOP;
	ELSE
		FOR LINHA IN  SELECT * FROM TBPRODUTO WHERE UPPER(DESCRICAO) LIKE UPPER(DESCRICAO_) || '%' LOOP
			RETURN NEXT linha;
		END LOOP;
	END IF;
	
	RETURN;
END
$$LANGUAGE PLPGSQL;


--(FUNÇÕES UTILITÁRIAS)========================================================================================================

CREATE OR REPLACE FUNCTION fnValidaUsuario(login_ character varying, senha_ character varying) RETURNS INT AS
$$
BEGIN
     RETURN (SELECT id FROM tbfuncionario WHERE login = login_ and senha = md5(senha_));
END
$$ LANGUAGE plpgsql;


CREATE OR REPLACE FUNCTION fnIsAdmin(id_ int) RETURNS BOOLEAN AS
$$
BEGIN
	RETURN (SELECT administrador FROM tbfuncionario where id = id_);
END
$$ LANGUAGE plpgsql;


CREATE OR REPLACE FUNCTION fnGetEstados() RETURNS SETOF TEXT AS
$$
DECLARE
	LINHA TEXT;
BEGIN
	FOR LINHA IN SELECT unnest(ARRAY['AC', 'AL', 'AP', 'AM', 'BA', 'CE', 'DF', 'ES', 'GO', 'MA', 'MT', 'MS', 'MG',
	                                'PA', 'PB', 'PR', 'PE', 'PI', 'RJ', 'RN', 'RS', 'RO', 'RR', 'SC', 'SP', 'SE', 'TO']) LOOP
		RETURN NEXT LINHA;
	END LOOP;
	RETURN;
END
$$ LANGUAGE PLPGSQL;


CREATE OR REPLACE FUNCTION fnGetName_Cidades() RETURNS SETOF TEXT AS
$$
DECLARE
	LINHA TEXT;
BEGIN
	FOR LINHA IN SELECT ID || '|' || NOME FROM TBCIDADE LOOP
		RETURN NEXT LINHA;
	END LOOP;
	RETURN;
END
$$ LANGUAGE PLPGSQL;


CREATE OR REPLACE FUNCTION fnGetName_Categorias() RETURNS SETOF TEXT AS
$$
DECLARE
	LINHA TEXT;
BEGIN
	FOR LINHA IN SELECT ID || '|' || DESCRICAO FROM TBCATEGORIA LOOP
		RETURN NEXT LINHA;
	END LOOP;
	RETURN;
END
$$ LANGUAGE PLPGSQL;


CREATE OR REPLACE FUNCTION fnGetName_Funcionarios() RETURNS SETOF TEXT AS
$$
DECLARE 
	LINHA TEXT;
BEGIN
	FOR LINHA IN SELECT ID || '|' || NOME FROM TBFUNCIONARIO LOOP
		RETURN NEXT LINHA;
	END LOOP;
	RETURN;
END
$$ LANGUAGE PLPGSQL;


CREATE OR REPLACE FUNCTION fnGetName_Fornecedores() RETURNS SETOF TEXT AS
$$
DECLARE 
	LINHA TEXT;
BEGIN
	FOR LINHA IN SELECT ID || '|' || NOME FROM TBFORNECEDOR LOOP
		RETURN NEXT LINHA;
	END LOOP;
	RETURN;
END
$$ LANGUAGE PLPGSQL;


CREATE OR REPLACE FUNCTION fnGetName_Produtos() RETURNS SETOF TEXT AS
$$
DECLARE 
	LINHA TEXT;
BEGIN
	FOR LINHA IN SELECT ID || '|' || DESCRICAO FROM TBPRODUTO LOOP
		RETURN NEXT LINHA;
	END LOOP;
	RETURN;
END
$$ LANGUAGE PLPGSQL;


CREATE OR REPLACE FUNCTION fnGetPreco_Produto(id_ integer) RETURNS SETOF TEXT AS
$$
DECLARE 
	LINHA TEXT;
BEGIN
	FOR LINHA IN SELECT valor_custo DESCRICAO FROM TBPRODUTO where id = id_ LOOP
		RETURN NEXT LINHA;
	END LOOP;
	RETURN;
END
$$ LANGUAGE PLPGSQL;



-- CREATE OR REPLACE FUNCTION foo() RETURNS integer[] AS
-- $$
-- DECLARE
--   _arr integer[];
-- BEGIN
--   FOR i IN 1..4 LOOP
--     _arr = array_cat(_arr, ARRAY[[i, i+10]]);
--   END LOOP;
-- 
--   RETURN _arr;
-- END;
-- $$
-- LANGUAGE plpgsql;

-- nome character varying(50) NOT NULL,
--   cpf character(14) NOT NULL,
--   rg character varying(20) NOT NULL,
--   endereco character varying(50),
--   telefone character(13),
--   email character varying(50),
--   cart_trabalho integer,
--   "login" character varying(50),
--   senha character varying(50),
--   sexo character(1),
--   administrador boolean,
-- 
-- select fnaddfuncionario('Usuário', '111.222.333-55', '123.456.789-1', 'rua 1', '(43)3344-5566', 'usuario@linesys.com.br', '2', 'usuario', 'user123', 'm', 'false');