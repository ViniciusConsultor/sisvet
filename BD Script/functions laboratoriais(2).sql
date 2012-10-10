create or replace function atualizar_laboratoriais(cod integer, tratamento integer, exame integer,
descricao text, responsavel character varying, valorexame numeric) returns integer as 

$BODY$

begin
	update laboratoriais set cod_tratamento_fk = tratamento, cod_exame_fk = exame,
	descricao_exame = descricao, responsavel_exame = responsavel, valor = valorexame where
	cod_laboratoriais = cod;

	return cod;
end;

$BODY$
language plpgsql;

create or replace function receber_dadoslaboratoriais(verificar integer, tratamento integer,
exame integer, descricao text, responsavel character varying, valor numeric) returns integer as 

$BODY$

begin
	if(verificar = 0) then
		return(select inserir_exame(tratamento, exame, descricao, responsavel, valor));
	else
		return(select atualizar_exame(verificar, tratamento, exame, descricao, responsavel, valor));
	end if;
end;

$BODY$
language plpgsql;