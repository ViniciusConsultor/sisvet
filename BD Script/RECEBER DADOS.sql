
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
 
CREATE OR REPLACE FUNCTION receber_dadoscustos(verificar integer, codcliente integer, codconsulta integer, data_pago date, valortotal numeric)
  RETURNS integer AS
$BODY$
	begin
		if (verificar = 0) then
			return (select inserir_custos(codcliente, codconsulta, data_pago, valortotal));
		else
			return (select atualizar_custos(verificar, codcliente, codconsulta, data_pago, valortotal));
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
  
CREATE OR REPLACE FUNCTION receber_dadosexamelabo(tratamento integer, exame integer, descricao text, responsavel character varying, valor numeric, verificar integer)
  RETURNS integer AS
$BODY$
	begin		

		if (verificar = 0) then
			return (select inserir_examelabo(tratamento, exame, descricao, responsavel, valor));
		else 
			return (select atualizar_examelabo(tratamento, exame, descricao, responsavel,valor, verificar));
	
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
			return (select atualizar_medicacao(cod_trat, cod_rem, qtd, cod_resp, valor_remedio, verificar));
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
			return (select atualizar_med(nome_remedio, valor_remedio, qtd_estoque, categoria_remedio,verificar));
		end if;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;

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
  


CREATE OR REPLACE FUNCTION receber_dadostipoconsulta(verificar integer, valorconsulta numeric, desc_tipo character varying)
  RETURNS integer AS
$BODY$
	begin
		if (verificar = 0) then
			return (select inserir_tipoConsulta(valorconsulta, desc_tipo));
		else
			return (select atualizar_tipoConsulta(verificar, valorconsulta, desc_tipo));
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
 

CREATE OR REPLACE FUNCTION receber_dadosusuario(verificar integer, nomeusuario character varying, login character varying, senha character varying)
  RETURNS integer AS
$BODY$
	begin
		if (verificar = 0) then
			return (select inserir_usuario(nomeusuario, login, senha));
		else
			return (select atualizar_usuario(verificar, nomeusuario, login, senha));
		end if;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  