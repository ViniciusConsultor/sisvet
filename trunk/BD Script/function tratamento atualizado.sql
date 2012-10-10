-- Function: inserir_cliente(character varying, date, character varying, character varying, character, character varying, character varying, character)

-- DROP FUNCTION inserir_cliente(character varying, date, character varying, character varying, character, character varying, character varying, character);

CREATE OR REPLACE FUNCTION inserir_cliente(nomecliente character varying, datanascimentocliente date, enderecocliente character varying, rgcliente character varying, telefone character, exxpeditorrgcliente character varying, municipiocliente character varying, cpfcliente character)
  RETURNS character varying AS
$BODY$
 declare
	cod integer;
 begin
	begin
	insert into cliente (nome_cliente, data_nascimeto_cliente, endereco_cliente, rg_cliente, telefone_cliente, 
	exxpedidor_rg_cliente, municipio_cliente, cpf_cliente) values (nomecliente, datanascimentocliente, enderecocliente, rgcliente, telefone, exxpeditorrgcliente, 
	municipiocliente, cpfcliente);

	GET DIAGNOSTICS cod = RESULT_OID;
	--return cod;
	Exception 
        When check_violation Then
                  raise exception 'Erro de entrada de dados!!';
	end;
 end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION inserir_cliente(character varying, date, character varying, character varying, character, character varying, character varying, character)
  OWNER TO postgres;


-- Function: atualizar_cliente(character varying, date, character varying, character varying, character, character varying, character varying, character, integer)

-- DROP FUNCTION atualizar_cliente(character varying, date, character varying, character varying, character, character varying, character varying, character, integer);

CREATE OR REPLACE FUNCTION atualizar_cliente(nomecliente character varying, datanascimentocliente date, enderecocliente character varying, rgcliente character varying, telefone character, exxpeditorrgcliente character varying, municipiocliente character varying, cpfcliente character, codcliente integer)
  RETURNS integer AS
$BODY$
 begin
 begin
	update cliente set nome_cliente = nomecliente, data_nascimeto_cliente = datanascimentocliente, endereco_cliente = enderecocliente, 
	rg_cliente = rgcliente, telefone_cliente = telefone, exxpedidor_rg_cliente = exxpeditorrgcliente, municipio_cliente = municipiocliente, 
	cpf_cliente = cpfcliente where cod_cliente = codcliente;
Exception 
        When check_violation Then
                  raise exception 'Erro de entrada de dados!!';
	end;
	return codcliente;
 end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION atualizar_cliente(character varying, date, character varying, character varying, character, character varying, character varying, character, integer)
  OWNER TO postgres;


-- Function: atualizar_paciente(integer, character varying, character varying, character varying, date, character varying, character, character, character varying, integer)

-- DROP FUNCTION atualizar_paciente(integer, character varying, character varying, character varying, date, character varying, character, character, character varying, integer);

CREATE OR REPLACE FUNCTION atualizar_paciente(codclientefk integer, rghvpaciente character varying, especiepaciente character varying, racapaciente character varying, nascimentopaciente date, pelagempaciente character varying, sexopaciente character, pacientecadastrado character, nomepaciente character varying, codpaciente integer)
  RETURNS integer AS
$BODY$
	begin
	begin
		update paciente set cod_cliente_fk = codclientefk, rghv_paciente = rghvpaciente, especie_paciente = especiepaciente, 
		raca_paciente = racapaciente, nascimento_paciente = nascimentopaciente, pelagem_paciente = pelagempaciente, sexo_paciente = sexopaciente,
		paciente_castrado = pacientecadastrado, nome_paciente = nomepaciente where cod_paciente = codpaciente;
	Exception 
        When check_violation Then
                  raise exception 'Erro de entrada de dados!!';
	end;
		return codpaciente;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION atualizar_paciente(integer, character varying, character varying, character varying, date, character varying, character, character, character varying, integer)
  OWNER TO postgres;

-- Function: atualizar_medvet(integer, character varying, character varying, character varying, character varying)

-- DROP FUNCTION atualizar_medvet(integer, character varying, character varying, character varying, character varying);

CREATE OR REPLACE FUNCTION atualizar_medvet(codmedico integer, nomemedico character varying, especialidade character varying, crmv character varying, telefone character varying)
  RETURNS integer AS
$BODY$
	begin
	begin
	update medico_veterinario set nome_medico_veterinario = nomemedico, especialidade_veterinario = especialidade, 
	crmv_veterinario = crmv, telefone_veterinario = telefone where codigo_medico_vet_pk = codmedico;
	Exception 
        When check_violation Then
                  raise exception 'Erro de entrada de dados!!';
	end;
	return codmedico;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION atualizar_medvet(integer, character varying, character varying, character varying, character varying)
  OWNER TO postgres;

  -- Function: atualizar_laboratorio(character varying, character varying, character varying, character varying, integer)

-- DROP FUNCTION atualizar_laboratorio(character varying, character varying, character varying, character varying, integer);

CREATE OR REPLACE FUNCTION atualizar_laboratorio(nome character varying, telefone character varying, endereco character varying, municipio character varying, codigo integer)
  RETURNS integer AS
$BODY$
 begin
 begin
	update laboratorios set  nome_laboratorio = nome, telefone_laboratorio = telefone, endereco_laboratorio = endereco, municipio_laboratorio = municipio where cod_laboratorio_pk = codigo;
Exception 
        When check_violation Then
                  raise exception 'Erro de entrada de dados!!';
	end;
	return cod_laboratorio_pk;
 end;

$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION atualizar_laboratorio(character varying, character varying, character varying, character varying, integer)
  OWNER TO postgres;


-- Function: atualizar_consulta(integer, date, time without time zone, integer, integer, character, integer, text)

-- DROP FUNCTION atualizar_consulta(integer, date, time without time zone, integer, integer, character, integer, text);

CREATE OR REPLACE FUNCTION atualizar_consulta(codigoconsulta integer, dataconsulta date, horaconsulta time without time zone, medicoveterinario integer, codigotipo integer, agendamento character, paciente integer, prontuario text)
  RETURNS integer AS
$BODY$
	begin
	begin
	update consulta set data_consulta = dataconsulta, hora_consutla = horaconsulta, cod_medico_veterinario_fk = medicoveterinario, 
	cod_tipo_consulta_fk = codigotipo, agendado = agendamento, cod_paciente_fk = paciente, prontuario_paciente = prontuario 
	where cod_consulta = codigoconsulta;
	Exception 
        When check_violation Then
                  raise exception 'Erro de entrada de dados!!';
	end;
	return codigoconsulta;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION atualizar_consulta(integer, date, time without time zone, integer, integer, character, integer, text)
  OWNER TO postgres;

-- Function: inserir_paciente(integer, character varying, character varying, character varying, date, character varying, character, character, character varying)

-- DROP FUNCTION inserir_paciente(integer, character varying, character varying, character varying, date, character varying, character, character, character varying);

CREATE OR REPLACE FUNCTION inserir_paciente(codclientefk integer, rghvpaciente character varying, especiepaciente character varying, racapaciente character varying, nascimentopaciente date, pelagempaciente character varying, sexopaciente character, pacientecadastrado character, nomepaciente character varying)
  RETURNS integer AS
$BODY$
	declare
		cod integer;
	begin
	begin
		insert into paciente (cod_cliente_fk, rghv_paciente, especie_paciente, raca_paciente, nascimento_paciente, pelagem_paciente, 
		sexo_paciente, paciente_castrado, nome_paciente) values (codclientefk, rghvpaciente, especiepaciente, racapaciente, 
		nascimentopaciente, pelagempaciente, sexopaciente, pacientecadastrado, nomepaciente);
	Exception 
        When check_violation Then
                  raise exception 'Erro de entrada de dados!!';
	end;
		GET DIAGNOSTICS cod = RESULT_OID;
		return cod;

	end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION inserir_paciente(integer, character varying, character varying, character varying, date, character varying, character, character, character varying)
  OWNER TO postgres;

-- Function: inserir_medvet(character varying, character varying, character varying, character varying)

-- DROP FUNCTION inserir_medvet(character varying, character varying, character varying, character varying);

CREATE OR REPLACE FUNCTION inserir_medvet(nomemedico character varying, especialidade character varying, crmv character varying, telefone character varying)
  RETURNS integer AS
$BODY$
	declare
		cod integer;
	begin
	begin
	insert into medico_veterinario(nome_medico_veterinario, especialidade_veterinario, crmv_veterinario, telefone_veterinario) VALUES
	(nomemedico, especialidade, crmv, telefone);
	Exception 
        When check_violation Then
                  raise exception 'Erro de entrada de dados!!';
	end;
	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;	

	end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION inserir_medvet(character varying, character varying, character varying, character varying)
  OWNER TO postgres;


-- Function: inserir_laboratorio(character varying, character varying, character varying, character varying)

-- DROP FUNCTION inserir_laboratorio(character varying, character varying, character varying, character varying);

CREATE OR REPLACE FUNCTION inserir_laboratorio(nome character varying, telefone character varying, endereco character varying, municipio character varying)
  RETURNS integer AS
$BODY$

declare
		cod integer;
		
	begin
	begin
	insert into laboratorios(nome_laboratorio, telefone_laboratorio, endereco_laboratorio, municipio_laboratorio) VALUES
	( nome, telefone, endereco, municipio);
	Exception 
        When check_violation Then
                  raise exception 'Erro de entrada de dados!!';
	end;
	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;	

	end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION inserir_laboratorio(character varying, character varying, character varying, character varying)
  OWNER TO postgres;


-- Function: inserir_consulta(date, time without time zone, integer, integer, character, integer, text)

-- DROP FUNCTION inserir_consulta(date, time without time zone, integer, integer, character, integer, text);

CREATE OR REPLACE FUNCTION inserir_consulta(dataconsulta date, horaconsulta time without time zone, medicoveterinario integer, codigotipo integer, agendamento character, paciente integer, prontuario text)
  RETURNS integer AS
$BODY$
	declare
		cod integer;
	begin
	begin
	insert into consulta(data_consulta, hora_consutla, cod_medico_veterinario_fk, cod_tipo_consulta_fk, agendado, cod_paciente_fk,
	prontuario_paciente) VALUES (dataconsulta, horaconsulta, medicoveterinario, codigotipo, agendamento, paciente, prontuario);
	Exception 
        When check_violation Then
                  raise exception 'Erro de entrada de dados!!';
	end;
	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;
	
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION inserir_consulta(date, time without time zone, integer, integer, character, integer, text)
  OWNER TO postgres;


