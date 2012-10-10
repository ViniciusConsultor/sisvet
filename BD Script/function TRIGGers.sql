CREATE OR REPLACE FUNCTION insere_contaexame()
  RETURNS trigger AS
$BODY$

declare 
cod_consulta integer;
valor_lab numeric;

begin
	cod_consulta = (select cod_consulta_fk from tratamento where cod_tratamento_pk = new.cod_tratameto_fk);

	valor_lab = (select valortotal from custos where cod_consulta_fk = cod_consulta);
	valor_lab = valor_lab + new.valor;
	
	update custos set valortotal = valor_lab where cod_consulta_fk = cod_consulta;

	return null;
end;

$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION insere_contaexame()
  OWNER TO postgres;


 
CREATE TRIGGER gatilho_inserir_exame
  AFTER INSERT
  ON laboratoriais
  FOR EACH ROW
  EXECUTE PROCEDURE insere_contaexame(); 

CREATE OR REPLACE FUNCTION insere_contamedicacao()
  RETURNS trigger AS
$BODY$

declare 
cod_consulta integer;
valor_medicacao numeric;

begin
	cod_consulta = (select cod_consulta_fk from tratamento where cod_tratamento_pk = new.cod_tratamento_fk);

	valor_medicacao = (select valortotal from custos where cod_consulta_fk = cod_consulta);
	valor_medicacao = valor_medicacao + new.valor;
	
	update custos set valortotal = valor_medicacao where cod_consulta_fk = cod_consulta;

	return null;
end;

$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION insere_contamedicacao()
  OWNER TO postgres;

CREATE TRIGGER gatilho_inserir_medicacao
  AFTER INSERT
  ON medicacao
  FOR EACH ROW
  EXECUTE PROCEDURE insere_contamedicacao(); 

CREATE OR REPLACE FUNCTION insere_contacirurgia()
  RETURNS trigger AS
$BODY$

declare 
cod_consulta integer;
valor_proc numeric;

begin
	cod_consulta = (select cod_consulta_fk from tratamento where cod_tratamento_pk = new.cod_tratamento_fk);

	valor_proc = (select valortotal from custos where cod_consulta_fk = cod_consulta);
	valor_proc = valor_proc + new.valor_cirurgia;
	
	update custos set valortotal = valor_proc where cod_consulta_fk = cod_consulta;

	return null;
end;

$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION insere_contacirurgia()
  OWNER TO postgres;  

 CREATE TRIGGER gatilho_inserir_cirurgia
  AFTER INSERT
  ON cirurgia_enternacao
  FOR EACH ROW
  EXECUTE PROCEDURE insere_contacirurgia(); 


CREATE OR REPLACE FUNCTION atualiza_contaexame()
  RETURNS trigger AS
$BODY$

begin 	
	update custos set valortotal = new.valor where cod_consulta_fk = (select cod_consulta_fk from tratamento where cod_tratamento_pk = new.cod_tratamento_fk);
	
	return null;	
end;

$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION atualiza_contaexame()
  OWNER TO postgres;

CREATE TRIGGER gatilho_atualizar_exame
  AFTER UPDATE
  ON laboratoriais
  FOR EACH ROW
  EXECUTE PROCEDURE atualiza_contaexame();  


  CREATE OR REPLACE FUNCTION atualiza_contamedicacao()
  RETURNS trigger AS
$BODY$

begin 	
	update custos set valortotal = new.valor where cod_consulta_fk = (select cod_consulta_fk from tratamento where cod_tratamento_pk = new.cod_tratamento_fk);
	
	return null;	
end;

$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION atualiza_contamedicacao()
  OWNER TO postgres;

CREATE TRIGGER gatilho_atualizar_medicacao
  AFTER UPDATE
  ON medicacao
  FOR EACH ROW
  EXECUTE PROCEDURE atualiza_contamedicacao();



 CREATE OR REPLACE FUNCTION atualiza_contacirurgia()
  RETURNS trigger AS
$BODY$

begin 	
	update custos set valortotal = new.valor_cirurgia where cod_consulta_fk = (select cod_consulta_fk from tratamento where cod_tratamento_pk = new.cod_tratamento_fk);
	
	return null;	
end;

$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION atualiza_contacirurgia()
  OWNER TO postgres;

CREATE TRIGGER gatilho_atualizar_cirurgia
  AFTER UPDATE
  ON cirurgia_enternacao
  FOR EACH ROW
  EXECUTE PROCEDURE atualiza_contacirurgia(); 


 