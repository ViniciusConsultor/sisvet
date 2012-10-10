CREATE OR REPLACE FUNCTION inserir_remedio(
nome character varying, valor numeric, estoque integer,
categoria character varying) RETURNS integer AS
$BODY$

	declare 
		cod integer;
	begin
		insert into remedios(nome_remedio,
		valor_remedio, qtd_estoque, 
		categoria_remedio) values (nome,
		valor, estoque, categoria);

		GET DIAGNOSTICS cod = RESULT_OID;
		return cod;

	end;

$BODY$
LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION atualizar_remedio(
nome character varying, valor numeric, estoque integer,
categoria character varying, cod integer)
RETURNS integer AS
$BODY$
	begin
		update remedios set 
		nome_remedio = nome, valor_remedio =
		valor, qtd_estoque = estoque, 
		categoria_remedio = categoria where
		cod_remedio = cod;

		return cod;
	end;
$BODY$
LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION deletar_remedio(cod integer)
RETURNS integer AS
$BODY$
	begin
		delete from remedios where cod_remedio = cod;
		return (1);
	end;
$BODY$
LANGUAGE plpgsql;

CREATE OR REPLACE FUNCTION receber_dadosremedio(
nome character varying, valor numeric, estoque integer,
categoria character varying, verificar integer)
RETURNS integer AS
$BODY$
	begin
		if(verificar = 0) then
			return(select inserir_remedio(nome, valor, estoque, categoria));
		else
			return(select atualizar_remedio(nome, valor, estoque, categoria, verificar));
		end if;
	end;
$BODY$
LANGUAGE plpgsql;








































