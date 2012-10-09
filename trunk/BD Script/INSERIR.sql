
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
 
CREATE OR REPLACE FUNCTION inserir_custos(codcliente integer, codconsulta integer, datapago date, valortotal numeric)
  RETURNS integer AS
$BODY$
	declare
		cod integer;
	begin
	insert into custos(cod_cliente_fk, cod_consulta_fk, data_pago, valor_Total) VALUES (codcliente, codconsulta, datapago, valortotal);
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
 
CREATE OR REPLACE FUNCTION inserir_examelabo(tratamento integer, exame integer, descricao text, responsavel character varying, valor numeric)
  RETURNS integer AS
$BODY$
	declare
		cod integer;
	begin
		insert into laboratoriais(cod_tratameto_fk, cod_exame_fk,descricao_exame,responsavel_exame,valor) VALUES
			( tratamento, exame,descricao,responsavel,valor);
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

CREATE OR REPLACE FUNCTION inserir_tipoconsulta(valorconsulta numeric, desc_tipo character varying)
  RETURNS integer AS
$BODY$
	declare
		cod integer;
	begin
		insert into tipo_consulta(valor_consulta, descricao_tipo_cconsulta) VALUES (valorconsulta, desc_tipo);
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
	return COD;	

	end;
$BODY$
  LANGUAGE plpgsql VOLATILE

CREATE OR REPLACE FUNCTION inserir_usuario(nome character varying, login_usu character varying, senha_usu character varying)
  RETURNS integer AS
$BODY$
	declare
		cod integer;
	begin
	insert into usuario(nome_usuario, login, senha) VALUES (nome, login_usu, senha_usu);
	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;
	
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  