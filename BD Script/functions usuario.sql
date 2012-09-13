-- Function: inserir_usuario(character varying, character varying, character varying)

-- DROP FUNCTION inserir_usuario(character varying, character varying, character varying)

CREATE OR REPLACE FUNCTION inserir_usuario(nome character varying, login_usu character varying, senha_usu character varying)
  RETURNS integer AS
$BODY$
	declare
		cod integer;
	begin
	insert into usuario(nome_usuario, login, senha) VALUES (nome, login_usu, senha_usu);
	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;
	
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION inserir_usuario(character varying, character varying, character varying)
  OWNER TO postgres;



-- Function: atualizar_usuario(integer, character varying, character varying, character varying)

-- DROP FUNCTION atualizar_usuario(integer, character varying, character varying, character varying);

CREATE OR REPLACE FUNCTION atualizar_usuario(codusuario integer, nomeusuario character varying, loginusuario character varying, senhausuario character varying)
  RETURNS integer AS
$BODY$
	begin
	update usuario set nome_usuario = nomeusuario, login = loginusuario, senha = senhausuario where cod_usuario = codusuario;
	
	return codusuario;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION atualizar_usuario(integer, character varying, character varying, character varying)
  OWNER TO postgres;

-- Function: deletar_usuario(integer)

-- DROP FUNCTION deletar_usuario(integer);

CREATE OR REPLACE FUNCTION deletar_usuario(codusuario integer)
  RETURNS integer AS
$BODY$
	begin
		delete from usuario where cod_usuario = codusuario;
		return 1;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION deletar_usuario(integer)
  OWNER TO postgres;

-- Function: receber_dadosusuario(integer, character varying, character varying, character varying);

-- DROP FUNCTION receber_dadosusuario(integer, character varying, character varying, character varying);

CREATE OR REPLACE FUNCTION receber_dadosusuario(verificar integer, nomeusuario character varying, login character varying, senha character varying)
  RETURNS integer AS
$BODY$
	begin
		if (verificar = 0) then
			return (select inserir_usuario(nomeusuario, login, senha));
		else
			return (select atualizar_usuario(verificar, nomeusuario, login, senha));
		end if;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION receber_dadosusuario(integer, character varying, character varying, character varying)
  OWNER TO postgres;

-- Function: retorna_usuario()

-- DROP FUNCTION retorna_usuario();

CREATE OR REPLACE FUNCTION retorna_usuario()
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_usuario, nome_usuario, login, senha FROM usuario
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100
  ROWS 1000;
ALTER FUNCTION retorna_usuario()
  OWNER TO postgres;
  
 -- Function: retorna_usuario(character varying, character varying)

-- DROP FUNCTION retorna_usuario(character varying, character varying);

CREATE OR REPLACE FUNCTION retorna_usuario(loginusu character varying, senhausu character varying)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_usuario, nome_usuario, login, senha FROM usuario WHERE login = loginusu and senha = senhausu
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100
  ROWS 1000;
ALTER FUNCTION retorna_usuario(character varying, character varying)
  OWNER TO postgres;




-- Function: retorna_usuario(character varying)

-- DROP FUNCTION retorna_usuario(character varying);

CREATE OR REPLACE FUNCTION retorna_usuario(nomeusu character varying)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_usuario, nome_usuario, login, senha FROM usuario WHERE nome_usuario = nomeusu
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100
  ROWS 1000;
ALTER FUNCTION retorna_usuario(character varying)
  OWNER TO postgres;

  

 

