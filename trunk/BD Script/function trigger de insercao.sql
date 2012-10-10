 --DROP TRIGGER gatilho_inserir_conta ON consulta;
 -- Function: insere_conta()

-- DROP FUNCTION insere_conta();

CREATE OR REPLACE FUNCTION insere_conta()
  RETURNS trigger AS
$BODY$

begin 
	insert into custos(cod_consulta_fk, valortotal) values (new.cod_consulta, (select valor_consulta from tipo_consulta where cod_tipo_consulta = new.cod_tipo_consulta_fk));
	
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



  -- Function: insere_containternacao()
 --DROP FUNCTION insere_containternacao();

CREATE OR REPLACE FUNCTION insere_containternacao()
  RETURNS trigger AS
$BODY$

declare 
cod_consulta integer;
valor_cirurgia integer;

begin
	cod_consulta = (select cod_consulta_fk from tratamento where cod_tratamento_pk = new.cod_tratamento_fk);

	valor_cirurgia = (select valortotal from custos where cod_consulta_fk = cod_consulta);
	valor_cirurgia = valor_cirurgia + new.valor_cirurgia;
	
	update custos set valortotal = valor_cirurgia where cod_consulta_fk = cod_consulta;
end;

$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION insere_containternacao()
  OWNER TO postgres;

   --DROP TRIGGER triggerinsertinternacao ON cirurgia_enternacao;

CREATE TRIGGER triggerinsertinternacao
  AFTER INSERT
  ON cirurgia_enternacao
  FOR EACH ROW
  EXECUTE PROCEDURE insere_containternacao();

  -- Function: insere_contalaboratoriais()

-- DROP FUNCTION insere_contalaboratoriais();

CREATE OR REPLACE FUNCTION insere_contalaboratoriais()
  RETURNS trigger AS
$BODY$

declare 
cod_consulta integer;
valor_exame integer;

begin
	cod_consulta = (select cod_consulta_fk from tratamento where cod_tratamento_pk = new.cod_tratamento_fk);

	valor_exame = (select valortotal from custos where cod_consulta_fk = cod_consulta);
	valor_exame = valor_exame + new.valor;
	
	update custos set valortotal = valor_exame where cod_consulta_fk = cod_consulta;
end;

$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION insere_contalaboratoriais()
  OWNER TO postgres;

 -- DROP TRIGGER triggerinsertlaboratoriais ON laboratoriais;

CREATE TRIGGER triggerinsertlaboratoriais
  AFTER INSERT
  ON laboratoriais
  FOR EACH ROW
  EXECUTE PROCEDURE insere_contalaboratoriais();


 -- Function: insere_contamedicacao()

-- DROP FUNCTION insere_contamedicacao();

CREATE OR REPLACE FUNCTION insere_contamedicacao()
  RETURNS trigger AS
$BODY$

declare 
cod_consulta integer;
valor_medicacao integer;

begin
	cod_consulta = (select cod_consulta_fk from tratamento where cod_tratamento_pk = new.cod_tratamento_fk);

	valor_medicacao = (select valortotal from custos where cod_consulta_fk = cod_consulta);
	valor_medicacao = valor_medicacao + new.valor;
	
	update custos set valortotal = valor_medicacao where cod_consulta_fk = cod_consulta;
end;

$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION insere_contamedicacao()
  OWNER TO postgres;

--DROP TRIGGER triggerinsertmedicacao ON medicacao;

CREATE TRIGGER triggerinsertmedicacao
  AFTER INSERT
  ON medicacao
  FOR EACH ROW
  EXECUTE PROCEDURE insere_contamedicacao();
