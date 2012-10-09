CREATE OR REPLACE FUNCTION atualizar_cirurgia(nome character varying, medico integer, codigo integer)
  RETURNS integer AS
$BODY$
 begin
	update cirurgia set  descricao_cirurgia = nome, medico_veterinario_fk = medico where cod_cirurgia_pk = codigo;

	return codigo;
 end;

$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION atualizar_cirurgia(character varying, integer, integer)
  OWNER TO postgres;

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

  
CREATE OR REPLACE FUNCTION atualizar_custos(verificar integer, codcliente integer, codconsulta integer, datapago date, valortotal numeric)
  RETURNS integer AS
$BODY$
	begin
	update custos set cod_cliente_fk = codcliente, cod_consulta_fk = codconsulta,data_pago = datapago, valor_Total = valortotal where cod = verificar;
	
	return codcliente;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;
ALTER FUNCTION atualizar_custos(integer, integer, integer, date, numeric)
  OWNER TO postgres;

CREATE OR REPLACE FUNCTION atualizar_exame(nome character varying, laboratorio integer, codigo integer)
  RETURNS integer AS
$BODY$
 begin
	update exame set  tipo_exame = nome, cod_laboratorio_fk = laboratorio where cod_exame_pk = codigo;

	return codigo;
 end;

$BODY$
  LANGUAGE plpgsql VOLATILE



 
CREATE OR REPLACE FUNCTION atualizar_examelabo(tratamento integer, exame integer, descricao text, responsavel character varying, codigo integer)
  RETURNS integer AS
$BODY$
 begin
	update exame set  cod_tratamento_fk = tratamento, cod_exame_fk = exame,descricao_exame = descricao, responsavel_exame = responsavel,valor = valor where laboratoriaisPK = codigo;

	return codigo;
 end;

$BODY$
  LANGUAGE plpgsql VOLATILE
CREATE OR REPLACE FUNCTION atualizar_laboratorio(nome character varying, telefone character varying, endereco character varying, municipio character varying, codigo integer)
  RETURNS integer AS
$BODY$
 begin
	update laboratorios set  nome_laboratorio = nome, telefone_laboratorio = telefone, endereco_laboratorio = endereco, municipio_laboratorio = municipio where  cod_laboratorio_pk = codigo;
	return codigo;
 end;
$BODY$
  LANGUAGE plpgsql VOLATILE

CREATE OR REPLACE FUNCTION atualizar_med(nome character varying, valor numeric, qtd_est integer, categoria character varying, verificar integer)
  RETURNS integer AS
$BODY$
	
	begin
	
update remedios set  nome_remedio = nome, valor_remedio = valor, qtd_estoque = qtd_est,categoria_remedio = categoria where cod_remedio = verificar;

	return verificar;

	end;
$BODY$
  LANGUAGE plpgsql VOLATILE

CREATE OR REPLACE FUNCTION atualizar_medicacao(cod_trat integer, cod_rem integer, qtd character varying, cod_resp character varying, valor_med numeric, verificar integer)
  RETURNS integer AS
$BODY$
	begin
	update medicacao set  cod_tratamento_fk = cod_trat, cod_remedio_fk = cod_rem, 
	qtd_aplicada = qtd, responsavel_medicacao = cod_resp, valor = valor_med where cod_medicacao = verificar;

	return cod_medicacao;
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


  
CREATE OR REPLACE FUNCTION atualizar_tipoconsulta(codtipoconsulta integer, valorconsulta numeric, descricao character varying)
  RETURNS integer AS
$BODY$
	begin
	update tipo_consulta set valor_consulta = valorconsulta ,descricao_tipo_cconsulta = descricao where cod_tipo_consulta = codtipoconsulta;
	
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


  
CREATE OR REPLACE FUNCTION atualizar_usuario(codusuario integer, nomeusuario character varying, loginusuario character varying, senhausuario character varying)
  RETURNS integer AS
$BODY$
	begin
	update usuario set nome_usuario = nomeusuario, login = loginusuario, senha = senhausuario where cod_usuario = codusuario;
	
	return codusuario;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE
 