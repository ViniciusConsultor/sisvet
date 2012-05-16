-- CLIENTE 
-- receber dados
CREATE OR REPLACE FUNCTION receber_dadosCliente(nomecliente varchar, datanascimentocliente date, enderecocliente varchar, rgcliente varchar, telefone char,
 expeditorrg varchar, municipiocliente varchar, cpfcliente char, verificar int) RETURNS integer AS $$
	begin		

		if (verificar = 0) then
			return (select inserir_cliente(nomecliente, datanascimentocliente, enderecocliente, rgcliente, telefone, expeditorrg,
				municipiocliente, cpfcliente));
		else 
			return (select atualizar_cliente(nomecliente, datanascimentocliente, enderecocliente, rgcliente, telefone, expeditorrg,
				municipiocliente, cpfcliente, verificar));
		end if;

	end;
 $$language plpgsql;
 
 -- adicionar 
CREATE OR REPLACE FUNCTION inserir_cliente(nomecliente varchar, datanascimentocliente date, enderecocliente varchar, rgcliente varchar, telefone char,
 exxpeditorrgcliente varchar, municipiocliente varchar, cpfcliente char) RETURNS integer AS $$
 declare
	cod integer;
 begin
	insert into cliente (nome_cliente, data_nascimeto_cliente, endereco_cliente, rg_cliente, telefone_cliente, 
	exxpedidor_rg_cliente, municipio_cliente, cpf_cliente) values (nomecliente, datanascimentocliente, enderecocliente, rgcliente, telefone, exxpeditorrgcliente, 
	municipiocliente, cpfcliente);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;
 end;
$$language plpgsql;

-- atualizar
CREATE OR REPLACE FUNCTION atualizar_cliente(nomecliente varchar, datanascimentocliente date, enderecocliente varchar, rgcliente varchar, telefone char,
 exxpeditorrgcliente varchar, municipiocliente varchar, cpfcliente char, codcliente int) RETURNS integer AS $$
 begin
	update cliente set nome_cliente = nomecliente, data_nascimeto_cliente = datanascimentocliente, endereco_cliente = enderecocliente, 
	rg_cliente = rgcliente, telefone_cliente = telefone, exxpedidor_rg_cliente = exxpeditorrgcliente, municipio_cliente = municipiocliente, 
	cpf_cliente = cpfcliente where cod_cliente = codcliente;

	return codcliente;
 end;
$$language plpgsql;

-- deletar
CREATE OR REPLACE FUNCTION deletar_cliente(codcliente int) RETURNS integer AS $$
begin
	delete from cliente where cod_cliente = codcliente;
	return (1);
end;
$$language plpgsql;	

-- Carregar grid
CREATE OR REPLACE FUNCTION carregarGridCliente() RETURNS SETOF cliente AS $$
DECLARE 
	linha cliente%ROWTYPE;
BEGIN
	FOR linha in  SELECT * FROM cliente LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;

-- Carregar campos
CREATE OR REPLACE FUNCTION carregarCamposCliente(cod int) RETURNS SETOF cliente AS $$
	DECLARE 
	linha record;
BEGIN
	FOR linha in  SELECT * FROM cliente where cod_cliente = cod LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$language plpgsql;





-- PACIENTE
-- receber dados
CREATE OR REPLACE FUNCTION receber_dadosPaciente(codclientefk int, rghvpaciente varchar, especiepaciente varchar, racapaciente varchar, nascimentopaciente date,
			pelagempaciente varchar, sexopaciente char, pacientecadastrado char, nomepaciente varchar, verificar int) 
			RETURNS integer AS $$
	begin
		if (verificar = 0) then
			return (select inserir_paciente(codclientefk, rghvpaciente, especiepaciente, racapaciente, nascimentopaciente,	pelagempaciente,
			sexopaciente, pacientecadastrado, nomepaciente));
		else
			return (select atualizar_paciente(codclientefk, rghvpaciente, especiepaciente, racapaciente, nascimentopaciente,	pelagempaciente,
			sexopaciente, pacientecadastrado, nomepaciente, verificar));
		end if;
	end;
$$language plpgsql;

-- adicionar
CREATE OR REPLACE FUNCTION inserir_paciente(codclientefk int, rghvpaciente varchar, especiepaciente varchar, racapaciente varchar, nascimentopaciente date,
			pelagempaciente varchar, sexopaciente char, pacientecadastrado char, nomepaciente varchar) RETURNS integer AS $$
	declare
		cod integer;
	begin
		insert into paciente (cod_cliente_fk, rghv_paciente, especie_paciente, raca_paciente, nascimento_paciente, pelagem_paciente, 
		sexo_paciente, paciente_castrado, nome_paciente) values (codclientefk, rghvpaciente, especiepaciente, racapaciente, 
		nascimentopaciente, pelagempaciente, sexopaciente, pacientecadastrado, nomepaciente);

		GET DIAGNOSTICS cod = RESULT_OID;
		return cod;

	end;
$$language plpgsql;

-- atualizar
CREATE OR REPLACE FUNCTION atualizar_paciente(codclientefk int, rghvpaciente varchar, especiepaciente varchar, racapaciente varchar, nascimentopaciente date,
			pelagempaciente varchar, sexopaciente char, pacientecadastrado char, nomepaciente varchar, codpaciente integer) RETURNS integer AS $$
	begin
		update paciente set cod_cliente_fk = codclientefk, rghv_paciente = rghvpaciente, especie_paciente = especiepaciente, 
		raca_paciente = racapaciente, nascimento_paciente = nascimentopaciente, pelagem_paciente = pelagempaciente, sexo_paciente = sexopaciente,
		paciente_castrado = pacientecadastrado, nome_paciente = nomepaciente where cod_paciente = codpaciente;

		return codpaciente;
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
CREATE OR REPLACE FUNCTION carregarGridPaciente() RETURNS SETOF paciente AS $$
DECLARE 
	linha paciente%ROWTYPE;
BEGIN
	FOR linha in  SELECT * FROM paciente LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;

-- carregar campos
CREATE OR REPLACE FUNCTION carregarCamposPaciente(cod int) RETURNS SETOF paciente AS $$
DECLARE 
	linha record;
BEGIN
	FOR linha in  SELECT * FROM paciente where cod_paciente = cod LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;





-- MEDICOS
-- receber dados
CREATE OR REPLACE FUNCTION receber_dadosMedico(nomemedico varchar, especialidade varchar, crmv varchar, telefone varchar, verificar int) RETURNS integer AS $$
	begin
		if (verificar = 0) then
			return (select inserir_medVet(nomemedico, especialidade, crmv, telefone));
		else
			return (select atualizar_medVet(verificar, nomemedico, especialidade, crmv, telefone));
		end if;
	end;
$$language plpgsql;

-- adicionar:
CREATE OR REPLACE FUNCTION inserir_medVet(nomemedico varchar, especialidade varchar, crmv varchar, telefone varchar) RETURNS integer AS $$
	declare
		cod integer;
	begin
	insert into medico_veterinario(nome_medico_veterinario, especialidade_veterinario, crmv_veterinario, telefone_veterinario) VALUES
	(nomemedico, especialidade, crmv, telefone);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;	

	end;
$$language plpgsql;

-- Atualizar:
CREATE OR REPLACE FUNCTION atualizar_medVet(codmedico int, nomemedico varchar, especialidade varchar, crmv varchar, telefone varchar) RETURNS integer AS $$
	begin
	update medico_veterinario set nome_medico_veterinario = nomemedico, especialidade_veterinario = especialidade, 
	crmv_veterinario = crmv, telefone_veterinario = telefone where codigo_medico_vet_pk = codmedico;

	return codmedico;
	end;
$$language plpgsql;

-- Deletar:
CREATE OR REPLACE FUNCTION deletar_medVet(codmedico int) RETURNS integer AS $$
	begin
	delete from medico_veterinario where codigo_medico_vet_pk = codmedico;

	return 1;
	end;
$$language plpgsql;

-- carregar grid
CREATE OR REPLACE FUNCTION carregarGridMedVet() RETURNS SETOF medico_veterinario AS $$
DECLARE 
	linha medico_veterinario%ROWTYPE;
BEGIN
	FOR linha in  SELECT * FROM medico_veterinario LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;

-- carregar campos
CREATE OR REPLACE FUNCTION carregarCamposMedVet(cod int) RETURNS SETOF medico_veterinario AS $$
DECLARE 
	linha record;
BEGIN
	FOR linha in  SELECT * FROM medico_veterinario where codigo_medico_vet_pk = cod LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;





-- CONSULTA
-- receber dados 
CREATE OR REPLACE FUNCTION receber_dadosConsulta(verificar int, dataconsulta date, horaconsulta time without time zone, medicoveterinario int, codigotipo int,
	agendamento char, paciente int, prontuario text) RETURNS integer AS $$
	begin
		if (verificar = 0) then
			return (select inserir_consulta(dataconsulta, horaconsulta, medicoveterinario, codigotipo, agendamento, paciente, prontuario));
		else
			return (select atualizar_consulta(verificar, dataconsulta, horaconsulta, medicoveterinario, codigotipo, agendamento, paciente, prontuario));
		end if;

	end;
$$language plpgsql;

-- Adicionar:
CREATE OR REPLACE FUNCTION inserir_consulta(dataconsulta date, horaconsulta time without time zone, medicoveterinario int, codigotipo int,
	agendamento char, paciente int, prontuario text) RETURNS integer AS $$
	declare
		cod integer;
	begin
	insert into consulta(data_consulta, hora_consutla, cod_medico_veterinario_fk, cod_tipo_consulta_fk, agendado, cod_paciente_fk,
	prontuario_paciente) VALUES (dataconsulta, horaconsulta, medicoveterinario, codigotipo, agendamento, paciente, prontuario);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;
	
	end;
$$language plpgsql; 

-- Atualizar:
CREATE OR REPLACE FUNCTION atualizar_consulta(codigoconsulta int, dataconsulta date, horaconsulta time without time zone, medicoveterinario int, codigotipo int,
	agendamento char, paciente int, prontuario text) RETURNS integer AS $$
	begin
	update consulta set data_consulta = dataconsulta, hora_consutla = horaconsulta, cod_medico_veterinario_fk = medicoveterinario, 
	cod_tipo_consulta_fk = codigotipo, agendado = agendamento, cod_paciente_fk = paciente, prontuario_paciente = prontuario 
	where cod_consulta = codigoconsulta;
	
	return codigoconsulta;
	end;
$$language plpgsql; 

-- Deletar:
CREATE OR REPLACE FUNCTION deletar_consulta(codigoconsulta int) RETURNS integer AS $$
	begin
	delete from consulta where cod_consulta = codigoconsulta;

	return 1;
	end;
$$language plpgsql;

-- carregar grid:
CREATE OR REPLACE FUNCTION carregarGridConsulta() RETURNS SETOF consulta AS $$
DECLARE 
	linha consulta%ROWTYPE;
BEGIN
	FOR linha in  SELECT * FROM consulta LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;

-- carregar campos:
CREATE OR REPLACE FUNCTION carregarCamposConsulta(cod int) RETURNS SETOF consulta AS $$
DECLARE 
	linha record;
BEGIN
	FOR linha in  SELECT * FROM consulta where cod_consulta = cod LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;





-- TIPO DE CONSULTA
-- receber dados
CREATE OR REPLACE FUNCTION receber_dadosTipoConsulta(verificar int, valorconsulta numeric) RETURNS integer AS $$
	begin
		if (verificar = 0) then
			return (select inserir_tipoConsulta(valorconsulta));
		else
			return (select atualizar_tipoConsulta(verificar, valorconsulta));
		end if;
	end;
$$language plpgsql;

-- Adicionar:
CREATE OR REPLACE FUNCTION inserir_tipoConsulta(valorconsulta numeric) RETURNS integer AS $$
	declare
		cod integer;
	begin
		insert into tipo_consulta(valor_consulta) VALUES (valorconsulta);
		GET DIAGNOSTICS cod = RESULT_OID;

		return cod;
	end;
$$language plpgsql;

-- Atualizar:
CREATE OR REPLACE FUNCTION atualizar_tipoConsulta(codtipoconsulta int, valorconsulta numeric) RETURNS integer AS $$
	begin
	update tipo_consulta set valor_consulta = valorconsulta where cod_tipo_consulta = codtipoconsulta;
	
	return codtipoconsulta;
	end;
$$language plpgsql;

-- Deletar:
CREATE OR REPLACE FUNCTION deletar_tipoConsulta(codtipoconsulta int) RETURNS integer AS $$
	begin
	delete from tipo_consulta where cod_tipo_consulta = codtipoconsulta;

	return 1;
	end;
$$language plpgsql;

-- carregar grid:
CREATE OR REPLACE FUNCTION carregarGridTipoConsulta() RETURNS SETOF tipo_consulta AS $$
DECLARE 
	linha tipo_consulta%ROWTYPE;
BEGIN
	FOR linha in  SELECT * FROM tipo_consulta LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;

-- carregar campos:
CREATE OR REPLACE FUNCTION carregarCamposTipoConsulta(cod int) RETURNS SETOF tipo_consulta AS $$
DECLARE 
	linha record;
BEGIN
	FOR linha in  SELECT * FROM tipo_consulta where cod_tipo_consulta = cod LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;





-- CUSTOS
-- receber dados
CREATE OR REPLACE FUNCTION receber_dadosCustos(verificar int, codconsulta int, valortotal numeric) RETURNS integer AS $$
	begin
		if (verificar = 0) then
			return (select inserir_custos(codconsulta, valortotal));
		else
			return (select atualizar_custos(verificar, codconsulta, valortotal));
		end if;
	end;
$$language plpgsql;

-- Adicionar:
CREATE OR REPLACE FUNCTION inserir_custos(codconsulta int, valortotal numeric) RETURNS integer AS $$
	declare
		cod integer;
	begin
	insert into custos(cod_consulta_fk, valor_Total) VALUES (codconsulta, valortotal);
	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;
	
	end;
$$language plpgsql;

-- Atualizar:
CREATE OR REPLACE FUNCTION atualizar_custos(codcliente int, codconsulta int, valortotal numeric) RETURNS integer AS $$
	begin
	update custos set cod_consulta_fk = codconsulta, valor_Total = valortotal where cod_cliente_fk = codcliente;
	
	return codcliente;
	end;
$$language plpgsql;

-- carregar grid:
CREATE OR REPLACE FUNCTION carregarGridCustos() RETURNS SETOF custos AS $$
DECLARE 
	linha custos%ROWTYPE;
BEGIN
	FOR linha in  SELECT * FROM custos LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;

-- carregar campos:
CREATE OR REPLACE FUNCTION carregarCamposCustos(cod int) RETURNS SETOF custos AS $$
DECLARE 
	linha record;
BEGIN
	FOR linha in  SELECT * FROM custos where cod_cliente_fk = cod LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;


