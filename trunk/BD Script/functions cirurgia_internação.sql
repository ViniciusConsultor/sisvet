create or replace function atualizar_cirurgiainternacao(internacao integer,
tratamento integer, cirurgia integer, descricaoprocedimento character varying,
datacirurgia date, horacirurgia time without time zone, valor numeric) 
returns integer as 
$BODY$

begin
	update cirurgia_internacao set cod_tratamento_fk = tratamento,
	cod_cirurgia_fk = cirurgia, descricao_procedimento = descricaoprocedimento,
	data_cirurgia = datacirurgia, horario_cirurgia = horacirurgia,
	valor_cirurgia = valor where cod_internacao = internacao;

	return internacao; 
end;
$BODY$
language plpgsql;

create or replace function receber_dados_cirurgiainternacao(verificar integer,
tratamento integer, cirurgia integer, descricao character varying, datacirurgia character varying,
horacirurgia character varying, valor character varying) returns integer as 
$BODY$

begin
	if(verificar = 0) then
		return (select inserir_cirurgiainternacao(tratamento, cirurgia, descricao,
		datacirurgia, horacirurgia, valor));
	else
		return (select atualizar_cirurgiainternacao(verificar, tratamento, cirurgia,
		descricao, datacirurgia, horacirurgia, valor));
	end if;
end;

$BODY$
language plpgsql; 