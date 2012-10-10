create or replace function insere_contamedicacao() returns trigger as 
$BODY$

declare 
cod_consulta integer;
valor_medicacao integer;

begin
	cod_consulta = (select cod_consulta_fk from tratamento where cod_tratamento_pk = new.cod_tratamento_fk);

	valor_medicacao = (select valor_Total from custos where cod_tratamento_fk = cod_consulta);
	valor_medicacao = valor_medicacao + new.valor;
	
	select receber_dadosmedicacao((select cod_custo from custos where cod_tratamendo_fk = cod_consulta), cod_consulta, valor_medicacao);
end;

$BODY$
language plpgsql;

create trigger triggerinsertmedicacao after insert on medicacao for each row execute procedure insere_contamedicacao();

-- Function: update_conta()

-- DROP FUNCTION update_conta();

CREATE OR REPLACE FUNCTION update_contamedicacao()
  RETURNS trigger AS
$BODY$
declare 
cod_consulta integer;
begin 
	
	cod_consulta = (select cod_consulta_fk from tratamento where cod_tratamento_pk = new.cod_tratamento_fk);

	select receber_dadoscustos((select cod_custo from custos where cod_tratamendo_fk = cod_consulta), cod_consulta, new.valor);

		
end;

$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION update_conta()
  OWNER TO postgres;

create trigger triggerupdatemedicacao after update on medicacao for each row execute procedure update_contamedicacao();
