-- Function: receber_dadosexame(character varying, integer, integer)

-- DROP FUNCTION receber_dadosexame(character varying, integer, integer);

CREATE OR REPLACE FUNCTION receber_dadosexame(nome character varying, laboratorio integer, descricao character varying, valor numeric, verificar integer)
  RETURNS integer AS
$BODY$
	begin		

		if (verificar = 0) then
			return (select inserir_exame(nome, laboratorio, descricao, valor));
		else 
			return (select atualizar_exame(nome, laboratorio, descricao, valor, verificar));
	
		end if;

	end;
 $BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION receber_dadosexame(character varying, integer, integer)
  OWNER TO postgres;

-- Function: inserir_exame(character varying, integer)

-- DROP FUNCTION inserir_exame(character varying, integer);

CREATE OR REPLACE FUNCTION inserir_exame(nome character varying, laboratorio integer, descricao character varying, valor numeric)
  RETURNS integer AS
$BODY$

declare
		cod integer;
		
	begin
	insert into exame(tipo_exame, cod_laboratorio_fk, nome_responsavel, valor_exame) VALUES
	(nome, laboratorio, descricao, valor);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;	

	end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION inserir_exame(character varying, integer)
  OWNER TO postgres;

-- Function: atualizar_exame(character varying, integer, integer)

-- DROP FUNCTION atualizar_exame(character varying, integer, integer);

CREATE OR REPLACE FUNCTION atualizar_exame(nome character varying, laboratorio integer, descricao character varying, valor numeric, codigo integer)
  RETURNS integer AS
$BODY$
 begin
	update exame set  tipo_exame = nome, cod_laboratorio_fk = laboratorio, nome_responsavel = descricao, valor_exame = valor where cod_exame_pk = codigo;

	return codigo;
 end;

$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION atualizar_exame(character varying, integer, integer)
  OWNER TO postgres;