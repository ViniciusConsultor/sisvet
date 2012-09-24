-- Function: inserir_tratamento(character varying, integer, integer)

-- DROP FUNCTION inserir_tratamento(character varying, integer, integer);

CREATE OR REPLACE FUNCTION inserir_tratamento(nome character varying,consulta integer)
  RETURNS integer AS
$BODY$

declare
		cod integer;
		
	begin
	insert into tratamento(descricao_tratamento, cod_consulta_fk) VALUES
	(nome, consulta);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;	

	end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION inserir_tratamento(character varying, integer)
  OWNER TO postgres;
