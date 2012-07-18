
CREATE OR REPLACE FUNCTION atualizar_cirurgia(nome character varying, medico integer, codigo integer)
  RETURNS integer AS
$BODY$
 begin
	update cirurgia set  descricao_cirurgia = nome, medico_veterinario_fk = medico where cod_cirurgia_pk = codigo;

	return codigo;
 end;

$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION atualizar_cliente(nomecliente character varying, datanascimentocliente date, enderecocliente character varying, rgcliente character varying, telefone character, exxpeditorrgcliente character varying, municipiocliente character varying, cpfcliente character, codcliente integer)
  RETURNS integer AS
$BODY$
 begin
	update cliente set nome_cliente = nomecliente, data_nascimeto_cliente = datanascimentocliente, endereco_cliente = enderecocliente, 
	rg_cliente = rgcliente, telefone_cliente = telefone, exxpedidor_rg_cliente = exxpeditorrgcliente, municipio_cliente = municipiocliente, 
	cpf_cliente = cpfcliente where cod_cliente = codcliente;

	return codcliente;
 end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION atualizar_consulta(codigoconsulta integer, dataconsulta date, horaconsulta time without time zone, medicoveterinario integer, codigotipo integer, agendamento character, paciente integer, prontuario text)
  RETURNS integer AS
$BODY$
	begin
	update consulta set data_consulta = dataconsulta, hora_consutla = horaconsulta, cod_medico_veterinario_fk = medicoveterinario, 
	cod_tipo_consulta_fk = codigotipo, agendado = agendamento, cod_paciente_fk = paciente, prontuario_paciente = prontuario 
	where cod_consulta = codigoconsulta;
	
	return codigoconsulta;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION atualizar_custos(codcliente integer, codconsulta integer, valortotal numeric)
  RETURNS integer AS
$BODY$
	begin
	update custos set cod_consulta_fk = codconsulta, valor_Total = valortotal where cod_cliente_fk = codcliente;
	
	return codcliente;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION atualizar_exame(nome character varying, laboratorio integer, codigo integer)
  RETURNS integer AS
$BODY$
 begin
	update exame set  tipo_exame = nome, cod_laboratorio_fk = laboratorio where cod_exame_pk = codigo;

	return codigo;
 end;

$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION atualizar_laboratorio(nome character varying, telefone character varying, endereco character varying, municipio character varying, codigo integer)
  RETURNS integer AS
$BODY$
 begin
	update laboratorios set  nome_laboratorio = nome, telefone_laboratorio = telefone, endereco_laboratorio = endereco, municipio_laboratorio = municipio where cod_laboratorio_pk = codigo;

	return cod_laboratorio_pk;
 end;

$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION atualizar_med(nome_remedio character varying, valor_remedio numeric, qtd_estoque integer, categoria_remedio character varying)
  RETURNS integer AS
$BODY$
	declare
		cod integer;
	begin
	insert into remedio(verificar, nome_remedio, valor_remedio, qtd_estoque, categoria) VALUES
	( verificar, nome_remedio, valor_remedio, qtd_estoque, categoria);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;	

	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION atualizar_medicacao(cod_trat integer, cod_rem integer, qtd character varying, cod_resp character varying, valor_med numeric, verificar numeric)
  RETURNS integer AS
$BODY$
	begin
	update medicacao set  cod_tratamento_fk = cod_trat, cod_remedio_fk = cod_rem, 
	qtd_aplicada = qtd, responsavel_medicacao = cod_resp, valor = valor_med where medicacaoPK = verificar;

	return medicacaoPK;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION atualizar_medicacao(cod_trat integer, cod_rem integer, qtd character varying, cod_resp character varying, valor_med numeric, verificar integer)
  RETURNS integer AS
$BODY$
	begin
	update medicacao set  cod_tratamento_fk = cod_trat, cod_remedio_fk = cod_rem, 
	qtd_aplicada = qtd, responsavel_medicacao = cod_resp, valor = valor_med where medicacaoPK = verificar;

	return medicacaoPK;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION atualizar_medvet(codmedico integer, nomemedico character varying, especialidade character varying, crmv character varying, telefone character varying)
  RETURNS integer AS
$BODY$
	begin
	update medico_veterinario set nome_medico_veterinario = nomemedico, especialidade_veterinario = especialidade, 
	crmv_veterinario = crmv, telefone_veterinario = telefone where codigo_medico_vet_pk = codmedico;

	return codmedico;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION atualizar_paciente(codclientefk integer, rghvpaciente character varying, especiepaciente character varying, racapaciente character varying, nascimentopaciente date, pelagempaciente character varying, sexopaciente character, pacientecadastrado character, nomepaciente character varying, codpaciente integer)
  RETURNS integer AS
$BODY$
	begin
		update paciente set cod_cliente_fk = codclientefk, rghv_paciente = rghvpaciente, especie_paciente = especiepaciente, 
		raca_paciente = racapaciente, nascimento_paciente = nascimentopaciente, pelagem_paciente = pelagempaciente, sexo_paciente = sexopaciente,
		paciente_castrado = pacientecadastrado, nome_paciente = nomepaciente where cod_paciente = codpaciente;

		return codpaciente;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE



CREATE OR REPLACE FUNCTION atualizar_tipoconsulta(codtipoconsulta integer, valorconsulta numeric)
  RETURNS integer AS
$BODY$
	begin
	update tipo_consulta set valor_consulta = valorconsulta where cod_tipo_consulta = codtipoconsulta;
	
	return codtipoconsulta;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE

CREATE OR REPLACE FUNCTION atualizar_tratamento(nome character varying, pac integer, medico integer, codigo integer)
  RETURNS integer AS
$BODY$
 begin
	update tratamento set  descricao_tratamento = nome, cod_paciente_fk = pac, cod_veterinario_fk = medico where cod_tratamento_pk = codigo;

	return codigo;
 end;

$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION deletar_cliente(codcliente integer)
  RETURNS integer AS
$BODY$
begin
	delete from cliente where cod_cliente = codcliente;
	return (1);
end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION deletar_consulta(codigoconsulta integer)
  RETURNS integer AS
$BODY$
	begin
	delete from consulta where cod_consulta = codigoconsulta;

	return 1;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION deletar_exame(cod integer)
  RETURNS integer AS
$BODY$
begin
	delete from exame where cod_exame_pk = cod;
	return (1);
end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION deletar_laboratorio(cod integer)
  RETURNS integer AS
$BODY$
begin
	delete from laboratorios where cod_laboratorio_pk = cod;
	return (1);
end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION deletar_medvet(codmedico integer)
  RETURNS integer AS
$BODY$
	begin
	delete from medico_veterinario where codigo_medico_vet_pk = codmedico;

	return 1;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION deletar_paciente(codpaciente integer)
  RETURNS integer AS
$BODY$
	begin
		delete from paciente where cod_paciente = codpaciente;
		return 1;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION deletar_remedio(cod integer)
  RETURNS integer AS
$BODY$
begin
	delete from remedios where cod_remedio = cod;
	return (1);
end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION deletar_tipoconsulta(codtipoconsulta integer)
  RETURNS integer AS
$BODY$
	begin
	delete from tipo_consulta where cod_tipo_consulta = codtipoconsulta;

	return 1;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION inserir_cirurgia(nome character varying, medico integer)
  RETURNS integer AS
$BODY$

declare
		cod integer;
		
	begin
	insert into cirurgia(descricao_cirurgia, medico_veterinario_fk) VALUES
	( nome, medico);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;	

	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION inserir_cliente(nomecliente character varying, datanascimentocliente date, enderecocliente character varying, rgcliente character varying, telefone character, exxpeditorrgcliente character varying, municipiocliente character varying, cpfcliente character)
  RETURNS integer AS
$BODY$
 declare
	cod integer;
 begin
	insert into cliente (nome_cliente, data_nascimeto_cliente, endereco_cliente, rg_cliente, telefone_cliente, 
	exxpedidor_rg_cliente, municipio_cliente, cpf_cliente) values (nomecliente, datanascimentocliente, enderecocliente, rgcliente, telefone, exxpeditorrgcliente, 
	municipiocliente, cpfcliente);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;
 end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION inserir_consulta(dataconsulta date, horaconsulta time without time zone, medicoveterinario integer, codigotipo integer, agendamento character, paciente integer, prontuario text)
  RETURNS integer AS
$BODY$
	declare
		cod integer;
	begin
	insert into consulta(data_consulta, hora_consutla, cod_medico_veterinario_fk, cod_tipo_consulta_fk, agendado, cod_paciente_fk,
	prontuario_paciente) VALUES (dataconsulta, horaconsulta, medicoveterinario, codigotipo, agendamento, paciente, prontuario);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;
	
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION inserir_custos(codconsulta integer, valortotal numeric)
  RETURNS integer AS
$BODY$
	declare
		cod integer;
	begin
	insert into custos(cod_consulta_fk, valor_Total) VALUES (codconsulta, valortotal);
	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;
	
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION inserir_exame(nome character varying, laboratorio integer)
  RETURNS integer AS
$BODY$

declare
		cod integer;
		
	begin
	insert into exame(tipo_exame, cod_laboratorio_fk) VALUES
	( nome, laboratorio);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;	

	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION inserir_laboratorio(nome character varying, telefone character varying, endereco character varying, municipio character varying)
  RETURNS integer AS
$BODY$

declare
		cod integer;
		
	begin
	insert into laboratorios(nome_laboratorio, telefone_laboratorio, endereco_laboratorio, municipio_laboratorio) VALUES
	( nome, telefone, endereco, municipio);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;	

	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION inserir_med(nome_remedio character varying, valor_remedio numeric, qtd_estoque integer, categoria_remedio character varying)
  RETURNS integer AS
$BODY$
	declare
		cod integer;
	begin
	insert into remedios( nome_remedio, valor_remedio, qtd_estoque, categoria_remedio) VALUES
	( nome_remedio, valor_remedio, qtd_estoque, categoria_remedio);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;	

	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION inserir_medicacao(cod_trat integer, cod_rem integer, qtd character varying, cod_resp character varying, valor numeric)
  RETURNS integer AS
$BODY$
	declare
		cod integer;
	begin
	insert into medicacao( cod_tratamento_fk, cod_remedio_fk, qtd_aplicada, responsavel_medicacao, valor) VALUES
	( cod_trat,  cod_rem, qtd, cod_resp, valor);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;	

	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION inserir_medvet(nomemedico character varying, especialidade character varying, crmv character varying, telefone character varying)
  RETURNS integer AS
$BODY$
	declare
		cod integer;
	begin
	insert into medico_veterinario(nome_medico_veterinario, especialidade_veterinario, crmv_veterinario, telefone_veterinario) VALUES
	(nomemedico, especialidade, crmv, telefone);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;	

	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION inserir_paciente(codclientefk integer, rghvpaciente character varying, especiepaciente character varying, racapaciente character varying, nascimentopaciente date, pelagempaciente character varying, sexopaciente character, pacientecadastrado character, nomepaciente character varying)
  RETURNS integer AS
$BODY$
	declare
		cod integer;
	begin
		insert into paciente (cod_cliente_fk, rghv_paciente, especie_paciente, raca_paciente, nascimento_paciente, pelagem_paciente, 
		sexo_paciente, paciente_castrado, nome_paciente) values (codclientefk, rghvpaciente, especiepaciente, racapaciente, 
		nascimentopaciente, pelagempaciente, sexopaciente, pacientecadastrado, nomepaciente);

		GET DIAGNOSTICS cod = RESULT_OID;
		return cod;

	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION inserir_tipoconsulta(valorconsulta numeric)
  RETURNS integer AS
$BODY$
	declare
		cod integer;
	begin
		insert into tipo_consulta(valor_consulta) VALUES (valorconsulta);
		GET DIAGNOSTICS cod = RESULT_OID;

		return cod;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION inserir_tratamento(nome character varying, paciente integer, medico integer)
  RETURNS integer AS
$BODY$

declare
		cod integer;
		
	begin
	insert into tratamento(descricao_tratamento, cod_paciente_fk, cod_veterinario_fk) VALUES
	( nome, paciente, medico);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;	

	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION receber_dadoscirurgia(nome character varying, medico integer, verificar integer)
  RETURNS integer AS
$BODY$
	begin		

		if (verificar = 0) then
			return (select inserir_cirurgia(nome, medico));
		else 
			return (select atualizar_cirurgia(nome, medico, verificar));
	
		end if;

	end;
 $BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION receber_dadoscliente(nomecliente character varying, datanascimentocliente date, enderecocliente character varying, rgcliente character varying, telefone character, expeditorrg character varying, municipiocliente character varying, cpfcliente character, verificar integer)
  RETURNS integer AS
$BODY$
	begin		

		if (verificar = 0) then
			return (select inserir_cliente(nomecliente, datanascimentocliente, enderecocliente, rgcliente, telefone, expeditorrg,
				municipiocliente, cpfcliente));
		else 
			return (select atualizar_cliente(nomecliente, datanascimentocliente, enderecocliente, rgcliente, telefone, expeditorrg,
				municipiocliente, cpfcliente, verificar));
		end if;

	end;
 $BODY$
  LANGUAGE plpgsql VOLATILE

CREATE OR REPLACE FUNCTION receber_dadosconsulta(verificar integer, dataconsulta date, horaconsulta time without time zone, medicoveterinario integer, codigotipo integer, agendamento character, paciente integer, prontuario text)
  RETURNS integer AS
$BODY$
	begin
		if (verificar = 0) then
			return (select inserir_consulta(dataconsulta, horaconsulta, medicoveterinario, codigotipo, agendamento, paciente, prontuario));
		else
			return (select atualizar_consulta(verificar, dataconsulta, horaconsulta, medicoveterinario, codigotipo, agendamento, paciente, prontuario));
		end if;

	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION receber_dadoscustos(verificar integer, codconsulta integer, valortotal numeric)
  RETURNS integer AS
$BODY$
	begin
		if (verificar = 0) then
			return (select inserir_custos(codconsulta, valortotal));
		else
			return (select atualizar_custos(verificar, codconsulta, valortotal));
		end if;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION receber_dadosexame(nome character varying, laboratorio integer, verificar integer)
  RETURNS integer AS
$BODY$
	begin		

		if (verificar = 0) then
			return (select inserir_exame(nome, laboratorio));
		else 
			return (select atualizar_exame(nome, laboratorio, verificar));
	
		end if;

	end;
 $BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION receber_dadoslaboratorio(nome character varying, telefone character varying, endereco character varying, municipio character varying, verificar integer)
  RETURNS integer AS
$BODY$
	begin		

		if (verificar = 0) then
			return (select inserir_laboratorio(nome, telefone, endereco, municipio));
		else 
			return (select atualizar_laboratorio(nome, telefone, endereco, municipio, verificar));
	
		end if;

	end;
 $BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION receber_dadosmedicacao(cod_trat integer, cod_rem integer, qtd character varying, cod_resp character varying, valor_remedio numeric, verificar integer)
  RETURNS integer AS
$BODY$
	begin
		if (verificar = 0) then
			return (select inserir_medicacao(cod_trat, cod_rem, qtd, cod_resp, valor_remedio));
		else
			return (select atualizar_medicacao(verificar, cod_trat, cod_rem, qtd, cod_resp, valor_remedio));
		end if;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION receber_dadosmedicamento(nome_remedio character varying, valor_remedio numeric, qtd_estoque integer, categoria_remedio character varying, verificar integer)
  RETURNS integer AS
$BODY$
	begin
		if (verificar = 0) then
			return (select inserir_med(nome_remedio, valor_remedio, qtd_estoque, categoria_remedio));
		else
			return (select atualizar_med(verificar, nome_remedio, valor_remedio, qtd_estoque, categoria_remedio));
		end if;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION receber_dadosmedico(nomemedico character varying, especialidade character varying, crmv character varying, telefone character varying, verificar integer)
  RETURNS integer AS
$BODY$
	begin
		if (verificar = 0) then
			return (select inserir_medVet(nomemedico, especialidade, crmv, telefone));
		else
			return (select atualizar_medVet(verificar, nomemedico, especialidade, crmv, telefone));
		end if;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION receber_dadospaciente(codclientefk integer, rghvpaciente character varying, especiepaciente character varying, racapaciente character varying, nascimentopaciente date, pelagempaciente character varying, sexopaciente character, pacientecadastrado character, nomepaciente character varying, verificar integer)
  RETURNS integer AS
$BODY$
	begin
		if (verificar = 0) then
			return (select inserir_paciente(codclientefk, rghvpaciente, especiepaciente, racapaciente, nascimentopaciente,	pelagempaciente,
			sexopaciente, pacientecadastrado, nomepaciente));
		else
			return (select atualizar_paciente(codclientefk, rghvpaciente, especiepaciente, racapaciente, nascimentopaciente,	pelagempaciente,
			sexopaciente, pacientecadastrado, nomepaciente, verificar));
		end if;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION receber_dadostipoconsulta(verificar integer, valorconsulta numeric)
  RETURNS integer AS
$BODY$
	begin
		if (verificar = 0) then
			return (select inserir_tipoConsulta(valorconsulta));
		else
			return (select atualizar_tipoConsulta(verificar, valorconsulta));
		end if;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION receber_dadostratamento(nome character varying, pac integer, medico integer, verificar integer)
  RETURNS integer AS
$BODY$
	begin		

		if (verificar = 0) then
			return (select inserir_tratamento(nome, pac, medico));
		else 
			return (select atualizar_tratamento(nome, pac, medico, verificar));
	
		end if;

	end;
 $BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retorna_linhas()
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_cliente, nome_cliente, data_nascimeto_cliente FROM cliente
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE

CREATE OR REPLACE FUNCTION retorna_linhas(cod integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_cliente, nome_cliente, data_nascimento_cliente FROM cliente WHERE cod_cliente = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornacirurgia(cod integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_cirurgia_pk, descricao_cirurgia, nome_medico_veterinario  FROM cirurgia inner join medico_veterinario on medico_veterinario_FK = codigo_medico_vet_pk WHERE cod_cirurgia_pk = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornacirurgia()
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_cirurgia_pk, descricao_cirurgia, nome_medico_veterinario  FROM cirurgia inner join medico_veterinario on medico_veterinario_FK = codigo_medico_vet_pk
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornacirurgia(cod character varying)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_cirurgia_pk, descricao_cirurgia, nome_medico_veterinario  FROM cirurgia inner join medico_veterinario on medico_veterinario_FK = codigo_medico_vet_pk WHERE descricao_cirurgia like cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornacli(cod character varying)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_cliente, nome_cliente, data_nascimeto_cliente, endereco_cliente, rg_cliente, telefone_cliente,exxpedidor_rg_cliente, municipio_cliente, cpf_cliente FROM cliente where nome_cliente like cod
  
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornacli()
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_cliente, nome_cliente, data_nascimeto_cliente, endereco_cliente, rg_cliente, telefone_cliente,exxpedidor_rg_cliente, municipio_cliente, cpf_cliente FROM cliente
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE



CREATE OR REPLACE FUNCTION retornacli(cod integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_cliente, nome_cliente, data_nascimeto_cliente, endereco_cliente, rg_cliente, telefone_cliente,exxpedidor_rg_cliente, municipio_cliente, cpf_cliente FROM cliente WHERE cod_cliente = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornaconsulta(cod character varying)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_consulta, data_consulta, hora_consutla, nome_medico_veterinario, tipo, agendado, nome_paciente, prontuario_paciente  FROM consulta inner join paciente on cod_paciente_fk = cod_paciente inner join medico_veterinario on cod_medico_veterinario_fk = codigo_medico_vet_pk inner join tipo_consulta on cod_tipo_consulta_fk = cod_tipo_consulta where nome_paciente like cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornaconsulta()
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_consulta, data_consulta, hora_consutla, nome_medico_veterinario, tipo, agendado, nome_paciente, prontuario_paciente  FROM consulta inner join paciente on cod_paciente_fk = cod_paciente inner join medico_veterinario on cod_medico_veterinario_fk = codigo_medico_vet_pk inner join tipo_consulta on cod_tipo_consulta_fk = cod_tipo_consulta
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornaconsulta(cod integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_consulta, data_consulta, hora_consutla, nome_medico_veterinario, tipo, agendado, nome_paciente, prontuario_paciente  FROM consulta inner join paciente on cod_paciente_fk = cod_paciente inner join medico_veterinario on cod_medico_veterinario_fk = codigo_medico_vet_pk inner join tipo_consulta on cod_tipo_consulta_fk = cod_tipo_consulta where cod_consulta = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornaexame()
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT  cod_exame_pk, tipo_exame, cod_laboratorio_fk FROM exame
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornaexame(cod integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_exame_pk, tipo_exame, cod_laboratorio_fk FROM exame where cod_exame_pk	= cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornalab()
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_laboratorio_pk, nome_laboratorio, telefone_laboratorio, endereco_laboratorio,municipio_laboratorio FROM laboratorios
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornalab(cod character)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_laboratorio_pk, nome_laboratorio, telefone_laboratorio, endereco_laboratorio,municipio_laboratorio FROM laboratorios where nome_laboratorio like cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornalab(cod integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_laboratorio_pk, nome_laboratorio, telefone_laboratorio, endereco_laboratorio,municipio_laboratorio FROM laboratorios where cod_laboratorio_pk	= cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornamed(cod integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT codigo_medico_vet_pk, nome_medico_veterinario, especialidade_veterinario, crmv_veterinario,telefone_veterinario FROM medico_veterinario where codigo_medico_vet_pk = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornamed()
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT codigo_medico_vet_pk, nome_medico_veterinario, especialidade_veterinario, crmv_veterinario,telefone_veterinario FROM medico_veterinario
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornamed(cod character)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT codigo_medico_vet_pk, nome_medico_veterinario, especialidade_veterinario, crmv_veterinario,telefone_veterinario FROM medico_veterinario where nome_medico_veterinario like cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornamedicacao(cod integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT MEDICAÇÃOpk, cod_tratamento_fk, cod_remedio_fk, qtd_aplicada, responsavel_medicacao, valor FROM medicacao where medicacao_PK = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornamedicacao()
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT descricao_tratamento, nome_remedio, qtd_aplicada, responsavel_medicacao, valor FROM medicacao inner join tratamento on cod_tratamento_fk =cod_tratamento_pk inner join remedios on cod_remedio_FK = cod_remedio
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornapac()
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_paciente, nome_paciente, nascimento_paciente, rghv_paciente, especie_paciente, raca_paciente,pelagem_paciente, sexo_paciente, paciente_castrado, nome_cliente  FROM paciente inner join cliente on cod_cliente_fk = cod_cliente
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornapac(cod character varying)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_paciente, nome_paciente, nascimento_paciente, rghv_paciente, especie_paciente, raca_paciente,pelagem_paciente, sexo_paciente, paciente_castrado, nome_cliente  FROM paciente inner join cliente on cod_cliente_fk = cod_cliente WHERE nome_paciente like cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornapac(cod integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_paciente, nome_paciente, nascimento_paciente, rghv_paciente, especie_paciente, raca_paciente,pelagem_paciente, sexo_paciente, paciente_castrado, nome_cliente  FROM paciente inner join cliente on cod_cliente_fk = cod_cliente WHERE cod_paciente = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornarem()
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_remedio, nome_remedio, valor_remedio, qtd_estoque, categoria_remedio FROM remedios
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornarem(cod character varying)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_remedio, nome_remedio, valor_remedio, qtd_estoque, categoria_remedio FROM remedios where nome_remedio like cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornarem(cod integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_remedio, nome_remedio, valor_remedio, qtd_estoque, categoria_remedio FROM remedios where cod_remedio = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornatipo()
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_tipo_consulta, valor_consulta, tipo FROM tipo_consulta
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornatipo(cod integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_tipo_consulta, valor_consulta, tipo FROM tipo_consulta where cod_tipo_consulta = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornatipo(cod character varying)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_tipo_consulta, valor_consulta, tipo FROM tipo_consulta where tipo like cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornatratamento(cod character varying)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_tratamento_pk, descricao_tratamento, nome_paciente, nome_medico_veterinario  FROM tratamento inner join paciente on cod_paciente = cod_paciente_fk  inner join medico_veterinario on cod_veterinario_fk = codigo_medico_vet_pk WHERE descricao_tratamento like cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornatratamento(cod integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_tratamento_pk, descricao_tratamento, nome_paciente, nome_medico_veterinario  FROM tratamento inner join paciente on cod_paciente_fk = cod_paciente inner join medico_veterinario on cod_veterinario_fk = codigo_medico_vet_pk WHERE cod_tratamento_pk = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE


CREATE OR REPLACE FUNCTION retornatratamento()
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_tratamento_pk, descricao_tratamento, nome_paciente, nome_medico_veterinario  FROM tratamento inner join paciente on cod_paciente_fk = cod_paciente inner join medico_veterinario on cod_veterinario_fk = codigo_medico_vet_pk 
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
RETURN  NEXT RESU;
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE