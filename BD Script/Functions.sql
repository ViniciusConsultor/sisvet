-- CLIENTE 
-- add
CREATE OR REPLACE FUNCTION inserir_cliente(nomecliente varchar, datanascimentocliente date, enderecocliente varchar, rgcliente varchar, telefone char,
 exxpeditorrgcliente varchar, municipiocliente varchar, cpfcliente char) RETURNS integer AS $$
 begin
	insert into cliente (nome_cliente, data_nascimeto_cliente, endereco_cliente, rg_cliente, telefone_cliente, 
	exxpedidor_rg_cliente, municipio_cliente, cpf_cliente) values (nomecliente, datanascimentocliente, enderecocliente, rgcliente, telefone, exxpeditorrgcliente, 
	municipiocliente, cpfcliente);

	return (1);
 end;
$$language plpgsql;

-- atualizar
CREATE OR REPLACE FUNCTION atualizar_cliente(nomecliente varchar, datanascimentocliente date, enderecocliente varchar, rgcliente varchar, telefone char,
 exxpeditorrgcliente varchar, municipiocliente varchar, cpfcliente char, codcliente int) RETURNS integer AS $$
 begin
	update cliente set nome_cliente = nomecliente, data_nascimeto_cliente = datanascimentocliente, endereco_cliente = enderecocliente, 
	rg_cliente = rgcliente, telefone_cliente = telefone, exxpedidor_rg_cliente = exxpeditorrgcliente, municipio_cliente = municipiocliente, 
	cpf_cliente = cpfcliente where cod_cliente = codcliente;

	return (1);
 end;
$$language plpgsql;

-- deletar
CREATE OR REPLACE FUNCTION deletar_cliente(codcliente int) RETURNS integer AS $$
begin
	delete from cliente where cod_cliente = codcliente;
	return (1);
end;
$$language plpgsql;	

-- select
CREATE OR REPLACE FUNCTION fnGetCliente() RETURNS SETOF cliente AS $$
DECLARE 
	linha cliente%ROWTYPE;
BEGIN
	FOR linha in  SELECT * FROM cliente LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;

-- PACIENTE
-- add
CREATE OR REPLACE FUNCTION inserir_paciente(codclientefk int, rghvpaciente varchar, especiepaciente varchar, racapaciente varchar, nascimentopaciente date,
			pelagempaciente varchar, sexopaciente char, pacientecadastrado char, nomepaciente varchar) RETURNS integer AS $$
	begin
		insert into paciente (cod_cliente_fk, rghv_paciente, especie_paciente, raca_paciente, nascimento_paciente, pelagem_paciente, 
		sexo_paciente, paciente_castrado, nome_paciente) values (codclientefk, rghvpaciente, especiepaciente, racapaciente, 
		nascimentopaciente, pelagempaciente, sexopaciente, pacientecadastrado, nomepaciente);

		return 1;
	end;
$$language plpgsql;

-- atualizar
CREATE OR REPLACE FUNCTION atualizar_paciente(codclientefk int, rghvpaciente varchar, especiepaciente varchar, racapaciente varchar, nascimentopaciente date,
			pelagempaciente varchar, sexopaciente char, pacientecadastrado char, nomepaciente varchar, codpaciente integer) RETURNS integer AS $$
	begin
		update paciente set cod_cliente_fk = codclientefk, rghv_paciente = rghvpaciente, especie_paciente = especiepaciente, 
		raca_paciente = racapaciente, nascimento_paciente = nascimentopaciente, pelagem_paciente = pelagempaciente, sexo_paciente = sexopaciente,
		paciente_castrado = pacientecadastrado, nome_paciente = nomepaciente where cod_paciente = codpaciente;

		return 1;
	end;
$$language plpgsql;

-- deletar
CREATE OR REPLACE FUNCTION deletar_paciente(codpaciente int) RETURNS integer AS $$
	begin
		delete from paciente where cod_paciente = codpaciente;
		return 1;
	end;
$$language plpgsql;

-- select
CREATE OR REPLACE FUNCTION fnGetPaciente() RETURNS SETOF paciente AS $$
DECLARE 
	linha paciente%ROWTYPE;
BEGIN
	FOR linha in  SELECT * FROM paciente LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;

-- MEDICOS
-- Add:
CREATE OR REPLACE FUNCTION inserir_medVet(nomemedico varchar, especialidade varchar, crmv varchar, telefone varchar) RETURNS integer AS $$
	begin
	insert into medico_veterinario(nome_medico_veterinario, especialidade_veterinario, crmv_veterinario, telefone_veterinario) VALUES
	(nomemedico, especialidade, crmv, telefone);

	return 1;
	end;
$$language plpgsql;

-- Atualizar:
CREATE OR REPLACE FUNCTION atualizar_medVet(codmedico int, nomemedico varchar, especialidade varchar, crmv varchar, telefone varchar) RETURNS integer AS $$
	begin
	update medico_veterinario set nome_medico_veterinario = nomemedico, especialidade_veterinario = especialidade, 
	crmv_veterinario = crmv, telefone_veterinario = telefone where codigo_medico_vet_pk = codmedico;

	return 1;
	end;
$$language plpgsql;

-- Deletar:
CREATE OR REPLACE FUNCTION deletar_medVet(codmedico int) RETURNS integer AS $$
	begin
	delete from medico_veterinario where codigo_medico_vet_pk = codmedico;

	return 1;
	end;
$$language plpgsql;

-- Select
CREATE OR REPLACE FUNCTION fnGetMedVet() RETURNS SETOF medico_veterinario AS $$
DECLARE 
	linha medico_veterinario%ROWTYPE;
BEGIN
	FOR linha in  SELECT * FROM medico_veterinario LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;

-- CONSULTA
-- Add:
CREATE OR REPLACE FUNCTION inserir_consulta(dataconsulta varchar, horaconsulta varchar, medicoveterinario int, codigotipo int,
	agendamento char, paciente int, prontuario text) RETURNS integer AS $$
	begin
	insert into consulta(data_consulta, hora_consutla, cod_medico_veterinario_fk, cod_tipo_consulta_fk, agendado, cod_paciente_fk,
	prontuario_paciente) VALUES (dataconsulta, horaconsulta, medicoveterinario, codigotipo, agendamento, paciente, prontuario);

	return 1;
	end;
$$language plpgsql; 

-- Atualizar:
CREATE OR REPLACE FUNCTION atualizar_consulta(codigoconsulta int, dataconsulta varchar, horaconsulta varchar, medicoveterinario int, codigotipo int,
	agendamento char, paciente int, prontuario text) RETURNS integer AS $$
	begin
	update consulta set data_consulta = dataconsulta, hora_consutla = horaconsulta, cod_medico_veterinario_fk = medicoveterinario, 
	cod_tipo_consulta_fk = codigotipo, agendado = agendamento, cod_paciente_fk = paciente, prontuario_paciente = prontuario 
	where codigo_consulta = codigoconsulta;
	
	return 1;
	end;
$$language plpgsql; 

-- Deletar:
CREATE OR REPLACE FUNCTION deletar_consulta(codigoconsulta int) RETURNS integer AS $$
	begin
	delete from consulta where codigo_consulta = codigoconsulta;

	return 1;
	end;
$$language plpgsql;

-- Select:
CREATE OR REPLACE FUNCTION fnGetConsulta() RETURNS SETOF consulta AS $$
DECLARE 
	linha consulta%ROWTYPE;
BEGIN
	FOR linha in  SELECT * FROM consulta LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;

-- TIPO DE CONSULTA
-- Add:
CREATE OR REPLACE FUNCTION inserir_tipoConsulta(valorconsulta numeric) RETURNS integer AS $$
	begin
	insert into tipo_consulta(valor_consulta) VALUES (valorconsulta);

	return 1;
	end;
$$language plpgsql;

-- Atualizar:
CREATE OR REPLACE FUNCTION atualizar_tipoConsulta(codtipoconsulta int, valorconsulta numeric) RETURNS integer AS $$
	begin
	update tipo_consulta set valor_consulta = valorconsulta where cod_tipo_consulta = codtipoconsulta;
	
	return 1;
	end;
$$language plpgsql;

-- Deletar:
CREATE OR REPLACE FUNCTION deletar_tipoConsulta(codtipoconsulta int) RETURNS integer AS $$
	begin
	delete from tipo_consulta where cod_tipo_consulta = codtipoconsulta;

	return 1;
	end;
$$language plpgsql;

-- Select:
CREATE OR REPLACE FUNCTION fnGetTipoConsulta() RETURNS SETOF tipo_consulta AS $$
DECLARE 
	linha tipo_consulta%ROWTYPE;
BEGIN
	FOR linha in  SELECT * FROM tipo_consulta LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;

-- CUSTOS
-- Add:

