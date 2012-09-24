-- Function: pagar_conta(integer)

-- DROP FUNCTION pagar_conta(integer);

CREATE OR REPLACE FUNCTION pagar_conta(codcusto integer, codconsulta integer)
  RETURNS character varying AS
$BODY$

begin 
	delete from custos where cod_cliente_fk = codcusto and cod_tratamento_fk = codconsulta;

	return "Efetuado baixa no sistema";
end;

$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION pagar_conta(integer)
  OWNER TO postgres;
