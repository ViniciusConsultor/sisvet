-- Function: inserir_custos(integer, numeric)

-- DROP FUNCTION inserir_custos(integer, numeric);

CREATE OR REPLACE FUNCTION inserir_custos(codconsulta integer, valortotal numeric)
  RETURNS integer AS
$BODY$
	declare
		cod integer;
	begin
	insert into custos(cod_cliente_fk, cod_tratamento_fk, valor_Total) VALUES ((select cod_cliente_fk from paciente where cod_paciente = (select cod_paciente_fk from consulta where cod_consulta = codconsulta)),codconsulta, valortotal);
	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;
	
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION inserir_custos(integer, numeric)
  OWNER TO postgres;

CREATE OR REPLACE FUNCTION atualizar_custos(codcliente integer, codconsulta integer, valortotal numeric)
  RETURNS integer AS
$BODY$
	begin
	
	update custos set cod_cliente_fk = (select cod_cliente_fk from paciente where cod_paciente = codcliente), valor_Total = valortotal where cod_consulta_fk = codconsulta;
	
	return codcliente;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION atualizar_custos(integer, integer, numeric)
  OWNER TO postgres;


create or replace function receber_dadoscustos(verificar integer, codconsulta integer, codtipo integer) RETURNS integer AS
$BODY$
begin
	if (verificar = 0) then
		return (select inserir_custos(codconsulta, (select valor_consulta from tipo_consulta where cod_tipo_consulta = codtipo)));
	else
		return (select atualizar_custos(verificar, codconsulta, (select valor_consulta from tipo_consulta where cod_tipo_consulta = codtipo)));
	end if;	
end;
$BODY$ language plpgsql;
ALTER FUNCTION receber_dadoscustos(integer, integer, numeric)
OWNER TO postgres;


create or replace function insere_conta() RETURNS trigger AS 
$BODY$

begin 
	
	if NEW.cod_tipo_consulta_fk = '1' then
		select receber_dadoscustos(0, new.cod_consulta, 1);
	else
		select receber_dadoscustos(0, new.cod_consulta, 2);
	end if;
		
end;

$BODY$ LANGUAGE plpgsql;

create or replace function update_conta() RETURNS trigger AS 
$BODY$

begin 
	
	if NEW.cod_tipo_consulta_fk = '1' then
		select receber_dadoscustos(new.cod_paciente_fk, new.cod_consulta, 1);
	else
		select receber_dadoscustos(new.cod_paciente_fk, new.cod_consulta, 2);
	end if;
		
end;

$BODY$ LANGUAGE plpgsql;

create trigger gatilho_update_conta AFTER update ON consulta FOR EACH ROW execute procedure update_conta();