create or replace function inserir_laboratoriais(tratamento integer, exame integer, descricao text,
responsavel character varying, valor numeric)
returns integer as 
$BODY$

declare 
	cod integer;
begin
	insert into laboratoriais(cod_tratamento_fk, cod_exame_fk, descricao_exame, responsavel_exame,
	valor) values (tratamento, exame, descricao, responsavel, valor);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;
end;

$BODY$
language plpgsql;
