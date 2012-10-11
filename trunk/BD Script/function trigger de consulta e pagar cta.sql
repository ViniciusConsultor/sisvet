CREATE OR REPLACE FUNCTION atualiza_conta()
  RETURNS trigger AS
$BODY$

begin 	
	update custos set valortotal = (select valor_consulta from tipo_consulta where cod_tipo_consulta = new.cod_tipo_consulta_fk) where cod_consulta_fk = new.cod_consulta;
	
	return null;	
end;

$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION atualiza_conta()
  OWNER TO postgres;

CREATE TRIGGER gatilho_atualizar_conta
  AFTER UPDATE
  ON consulta
  FOR EACH ROW
  EXECUTE PROCEDURE atualiza_conta();  

 --DROP TRIGGER gatilho_inserir_conta ON consulta;
 -- Function: insere_conta()

-- DROP FUNCTION insere_conta();

CREATE OR REPLACE FUNCTION insere_conta()
  RETURNS trigger AS
$BODY$

begin 
	insert into custos(cod_consulta_fk, valortotal, cod_cliente_fk, dataconsulta) values (new.cod_consulta,
	 (select valor_consulta from tipo_consulta where cod_tipo_consulta = new.cod_tipo_consulta_fk),
	 (select cod_cliente_fk from paciente where cod_paciente = (select cod_paciente_fk from consulta where cod_consulta = new.cod_consulta)),
	 (select data_consulta from consulta where cod_consulta = new.cod_consulta));
	
	return null;	
end;

$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION insere_conta()
  OWNER TO postgres;


CREATE TRIGGER gatilho_inserir_conta
  AFTER INSERT
  ON consulta
  FOR EACH ROW
  EXECUTE PROCEDURE insere_conta();

DROP TRIGGER gatilho_inserir_conta ON consulta;

DROP TRIGGER gatilho_inserir_cirurgia ON cirurgia_enternacao;
DROP TRIGGER gatilho_inserir_exame ON laboratoriais;
DROP TRIGGER gatilho_inserir_medicacao ON medicacao;

-- Function: pagar_conta(integer, integer)

-- DROP FUNCTION pagar_conta(integer, integer);

CREATE OR REPLACE FUNCTION pagar_conta(codcusto integer)
  RETURNS character varying AS
$BODY$

begin 
	delete from custos where cod_custo = codcusto;

	return "Efetuado baixa no sistema";
end;

$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION pagar_conta(integer)
  OWNER TO postgres;
