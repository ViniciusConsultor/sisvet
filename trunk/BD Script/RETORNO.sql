
CREATE OR REPLACE FUNCTION retorna_usuario()
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_usuario, nome_usuario, login, senha FROM usuario
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
  
CREATE OR REPLACE FUNCTION retorna_usuario(loginusu character varying, senhausu character varying)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_usuario, nome_usuario, login, senha FROM usuario WHERE login = loginusu and senha = senhausu
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE

CREATE OR REPLACE FUNCTION retorna_usuario(nomeusu character varying)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_usuario, nome_usuario, login, senha FROM usuario WHERE nome_usuario = nomeusu
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
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
 

 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
 
CREATE OR REPLACE FUNCTION retornacirurgiaintern(cod integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT ci.cod_cirurgia_intern, p.nome_paciente, T.descricao_tratamento, ci.descricao_procedimento, ci.data_cirurgia, ci.horario_cirurgia, ci.valor_cirurgia from paciente p inner join tratamento t on p.cod_paciente = t.cod_paciente_fk inner join cirurgia_enternacao ci on t.cod_tratamento_pk = ci.cod_tratamento_fk inner join cirurgia c on c.cod_cirurgia_pk = ci.cod_cirurgia_fk where p.cod_paciente =cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE

CREATE OR REPLACE FUNCTION retornacirurgiaintern()
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT ci.cod_cirurgia_intern, p.nome_paciente, T.descricao_tratamento, ci.descricao_procedimento, ci.data_cirurgia, ci.horario_cirurgia, ci.valor_cirurgia from paciente p inner join tratamento t on p.cod_paciente = t.cod_paciente_fk inner join cirurgia_enternacao ci on t.cod_tratamento_pk = ci.cod_tratamento_fk inner join cirurgia c on c.cod_cirurgia_pk = ci.cod_cirurgia_fk 
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE

CREATE OR REPLACE FUNCTION retornacirurgiainternacao(cod integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT ci.cod_cirurgia_intern, p.nome_paciente, T.descricao_tratamento, ci.descricao_procedimento, ci.data_cirurgia, ci.horario_cirurgia, ci.valor_cirurgia from paciente p inner join tratamento t on p.cod_paciente = t.cod_paciente_fk inner join cirurgia_enternacao ci on t.cod_tratamento_pk = ci.cod_tratamento_fk inner join cirurgia c on c.cod_cirurgia_pk = ci.cod_cirurgia_fk where p.cod_cirurgia_intern =cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
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
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
 
CREATE OR REPLACE FUNCTION retornaconsulta()
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_consulta, data_consulta, hora_consutla, nome_medico_veterinario, descricao_tipo_cconsulta, agendado, nome_paciente, prontuario_paciente  FROM consulta inner join paciente on cod_paciente_fk = cod_paciente inner join medico_veterinario on cod_medico_veterinario_fk = codigo_medico_vet_pk inner join tipo_consulta on cod_tipo_consulta_fk = cod_tipo_consulta
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 

END;
$BODY$
  LANGUAGE plpgsql VOLATILE
  
CREATE OR REPLACE FUNCTION retornaconsulta(cod character varying)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_consulta, data_consulta, hora_consutla, nome_medico_veterinario, descricao_tipo_cconsulta, agendado, nome_paciente, prontuario_paciente  FROM consulta inner join paciente on cod_paciente_fk = cod_paciente inner join medico_veterinario on cod_medico_veterinario_fk = codigo_medico_vet_pk inner join tipo_consulta on cod_tipo_consulta_fk = cod_tipo_consulta where nome_paciente like cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
 
CREATE OR REPLACE FUNCTION retornaconsulta(cod integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_consulta, data_consulta, hora_consutla, nome_medico_veterinario, descricao_tipo_cconsulta, agendado, nome_paciente, prontuario_paciente  FROM consulta inner join paciente on cod_paciente_fk = cod_paciente inner join medico_veterinario on cod_medico_veterinario_fk = codigo_medico_vet_pk inner join tipo_consulta on cod_tipo_consulta_fk = cod_tipo_consulta where cod_consulta = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 

 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
  
CREATE OR REPLACE FUNCTION retornaconsultaconta(cod integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT c.cod_consulta, c.data_consulta FROM consulta c  inner join paciente p on c.cod_paciente_fk = p.cod_paciente inner join cliente cli on cli.cod_cliente= p.cod_cliente_fk where cli.cod_cliente =cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 

 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
 
CREATE OR REPLACE FUNCTION retornaconta(codigo integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod,nome_cliente,descricao_tratamento,valor_total,data_pago  FROM custos inner join cliente on cod_cliente_fk = cod_cliente inner join tratamento on cod_tratamento_fk = cod_tratamento_pk where cod = codigo
    LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 END;
$BODY$
  LANGUAGE plpgsql VOLATILE
 
CREATE OR REPLACE FUNCTION retornaconta(codigo character varying)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod,nome_cliente,descricao_tratamento,valor_total,data_pago  FROM custos inner join cliente on cod_cliente_fk = cod_cliente inner join tratamento on cod_tratamento_fk = cod_tratamento_pk where nome_cliente like codigo
    LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 END;
$BODY$
  LANGUAGE plpgsql VOLATILE
 
CREATE OR REPLACE FUNCTION retornaconta()
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod,nome_cliente,descricao_tratamento,valor_total,data_pago  FROM custos inner join cliente on cod_cliente_fk = cod_cliente inner join tratamento on cod_tratamento_fk = cod_tratamento_pk 
    LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 END;
$BODY$
  LANGUAGE plpgsql VOLATILE
 
CREATE OR REPLACE FUNCTION retornacustos(codigo integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN 
  -- Vamos criar o LOOP para retornar a execução da query na tabela
  FOR RESU IN SELECT cod,nome_cliente,data_consulta,valor_total,data_pago  FROM custos inner join cliente on cod_cliente_fk = cod_cliente inner join consulta on cod_consulta_fk = cod_consulta WHERE cod = codigo
    LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 END;
$BODY$
  LANGUAGE plpgsql VOLATILE

CREATE OR REPLACE FUNCTION retornacustos()
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN 
  -- Vamos criar o LOOP para retornar a execução da query na tabela
  FOR RESU IN SELECT cod,nome_cliente,data_consulta,valor_total,data_pago  FROM custos inner join cliente on cod_cliente_fk = cod_cliente inner join consulta on cod_consulta_fk = cod_consulta 
    LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 END;
$BODY$
  LANGUAGE plpgsql VOLATILE
 
CREATE OR REPLACE FUNCTION retornadados(cod integer)
  RETURNS refcursor AS
$BODY$

 DECLARE resultado refcursor;
 reg record;
BEGIN
		OPEN resultado FOR
			SELECT cod_consulta from consulta where cod_paciente_fk = (SELECT cod_paciente FROM paciente inner join cliente on cod_cliente = cod_cliente_fk where cod_cliente =96);
	FETCH resultado INTO reg;
	RETURN reg;
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
  
CREATE OR REPLACE FUNCTION retornaexame()
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT  cod_exame_pk, tipo_exame, nome_laboratorio FROM exame inner join laboratorios on cod_laboratorio_fk =cod_laboratorio_pk
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
  
CREATE OR REPLACE FUNCTION retornaexame(cod character varying)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_exame_pk, tipo_exame, nome_laboratorio FROM exame inner join laboratorios on cod_laboratorio_fk =cod_laboratorio_pk where tipo_exame = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;

 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE

CREATE OR REPLACE FUNCTION retornaexame(cod integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_exame_pk, tipo_exame, nome_laboratorio FROM exame inner join laboratorios on cod_laboratorio_fk =cod_laboratorio_pk where cod_exame_pk = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;

 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE

CREATE OR REPLACE FUNCTION retornaexamelabo()
  RETURNS SETOF refcursor AS
$BODY$
DECLARE
EXAME CURSOR FOR SELECT p.nome_paciente, e.tipo_exame, l.descricao_exame, l.responsavel_exame, l.valor from paciente p inner join tratamento t on p.cod_paciente = t.cod_paciente_fk inner join laboratoriais l on t.cod_tratamento_pk = l.cod_tratameto_fk inner join exame e on e.cod_exame_pk = l.cod_exame_fk;
 	--um_empregado laboratorios%ROWTYPE;
reg RECORD;
	BEGIN
	OPEN EXAME;
	LOOP
		--FETCH cs_empregados INTO um_empregado;
		FETCH EXAME INTO reg;
	--RETURN NEXT um_empregado;
	
		RETURN NEXT EXAME;
		END LOOP;
	END;
$BODY$
  LANGUAGE plpgsql VOLATILE
 
CREATE OR REPLACE FUNCTION retornaexamelabo(codigo character varying)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT  descricao_tratamento, tipo_exame, descricao_exame, responsavel_exame,valor FROM laboratoriais inner join tratamento on cod_tratamento_pk = cod_tratameto_fk inner join exame on cod_exame_fk =cod_exame_pk where tipo_exame like codigo
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE

CREATE OR REPLACE FUNCTION retornaexamelabo(cod integer)
  RETURNS SETOF refcursor AS
$BODY$
DECLARE
EXAME CURSOR FOR SELECT p.nome_paciente, e.tipo_exame, l.descricao_exame, l.responsavel_exame, l.valor from paciente p inner join tratamento t on p.cod_paciente = t.cod_paciente_fk inner join laboratoriais l on t.cod_tratamento_pk = l.cod_tratameto_fk inner join exame e on e.cod_exame_pk = l.cod_exame_fk where p.cod_paciente =cod;
 	--um_empregado laboratorios%ROWTYPE;
reg RECORD;
	BEGIN
	OPEN EXAME;
	LOOP
		--FETCH cs_empregados INTO um_empregado;
		FETCH EXAME INTO reg;
	--RETURN NEXT um_empregado;
		RETURN NEXT EXAME;
		END LOOP;
	END;
$BODY$
  LANGUAGE plpgsql VOLATILE

CREATE OR REPLACE FUNCTION retornaexamelaboratorial()
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT p.nome_paciente, e.tipo_exame, l.descricao_exame, l.responsavel_exame, l.valor from paciente p inner join tratamento t on p.cod_paciente = t.cod_paciente_fk inner join laboratoriais l on t.cod_tratamento_pk = l.cod_tratameto_fk inner join exame e on e.cod_exame_pk = l.cod_exame_fk
 	  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
 
CREATE OR REPLACE FUNCTION retornaexamelabotext()
  RETURNS SETOF refcursor AS
$BODY$

DECLARE
EXAME CURSOR FOR SELECT (cod_tratameto_fk , cod_exame_fk ), p.nome_paciente, e.tipo_exame, l.descricao_exame, l.responsavel_exame, l.valor from paciente p inner join tratamento t on p.cod_paciente = t.cod_paciente_fk inner join laboratoriais l on t.cod_tratamento_pk = l.cod_tratameto_fk inner join exame e on e.cod_exame_pk = l.cod_exame_fk;
 
reg RECORD;
	BEGIN
	OPEN EXAME;
	LOOP
		FETCH EXAME INTO reg;
		RETURN NEXT EXAME;
		END LOOP;
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
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
  
CREATE OR REPLACE FUNCTION retornamed(cod integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_medicacao, codigo_medico_vet_pk, nome_medico_veterinario, especialidade_veterinario, crmv_veterinario,telefone_veterinario FROM medico_veterinario where codigo_medico_vet_pk = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
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
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
 
CREATE OR REPLACE FUNCTION retornamedicacao(cod character varying, cod2 character varying)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN

  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT descricao_tratamento,nome_remedio, qtd_aplicada, responsavel_medicacao, valor FROM  remedios INNER JOIN medicacao ON cod_remedio = cod_remedio_fk INNER JOIN tratamento on cod_tratamento_pk = cod_tratamento_fk where  descricao_tratamento = COD and nome_remedio = COD2
 LOOP
    -- O retorno de cada linha
    RETURN;
  END LOOP;
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
   
CREATE OR REPLACE FUNCTION retornamedicacao(cod integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT  m.cod_medicacao, p.nome_paciente, m.cod_tratamento_fk, r.nome_remedio, qtd_aplicada, m.responsavel_medicacao, m.valor FROM paciente p inner join tratamento t on p.cod_paciente = t.cod_paciente_fk inner join medicacao m on t.cod_tratamento_pk = m.cod_tratamento_fk inner join remedios r on r.cod_remedio = m.cod_remedio_fk where m.cod_medicacao = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
  
CREATE OR REPLACE FUNCTION retornamedicacao(cod character varying)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN

  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_medicacao, cod_tratamento_fk, cod_remedio_fk, qtd_aplicada, responsavel_medicacao, valor FROM medicacao INNER JOIN tratamento on cod_tratamento_pk = cod_tratamento_fk where  descricao_tratamento = cod
   LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
 
CREATE OR REPLACE FUNCTION retornamedicacao()
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro;
  FOR RESU IN SELECT m.cod_medicacao, p.nome_paciente, m.cod_tratamento_fk, r.nome_remedio, qtd_aplicada, m.responsavel_medicacao, m.valor FROM paciente p inner join tratamento t on p.cod_paciente = t.cod_paciente_fk inner join medicacao m on t.cod_tratamento_pk = m.cod_tratamento_fk inner join remedios r on r.cod_remedio = m.cod_remedio_fk 
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE

CREATE OR REPLACE FUNCTION retornamedicacao(cod text)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN

  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT descricao_tratamento, cod_remedio_fk, qtd_aplicada, responsavel_medicacao, valor FROM medicacao INNER JOIN tratamento on cod_tratamento_pk = cod_tratamento_fk where  descricao_tratamento = cod
   LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
  
CREATE OR REPLACE FUNCTION retornamedicacao2(cod integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro;
  FOR RESU IN SELECT m.cod_medicacao, p.nome_paciente, m.cod_tratamento_fk, r.nome_remedio, qtd_aplicada, m.responsavel_medicacao, m.valor FROM paciente p inner join tratamento t on p.cod_paciente = t.cod_paciente_fk inner join medicacao m on t.cod_tratamento_pk = m.cod_tratamento_fk inner join remedios r on r.cod_remedio = m.cod_remedio_fk where p.cod_paciente = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
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
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
  
CREATE OR REPLACE FUNCTION retornapactrat(cod integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
  FOR RESU IN SELECT cod_tratamento_pk,descricao_tratamento  FROM tratamento inner join paciente on cod_paciente = cod_paciente_fk WHERE cod_paciente = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
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
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE

CREATE OR REPLACE FUNCTION retornatipo(cod character varying)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_tipo_consulta, valor_consulta, descricao_tipo_cconsulta FROM tipo_consulta where descricao_tipo_cconsulta like cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
 
CREATE OR REPLACE FUNCTION retornatipo()
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_tipo_consulta, valor_consulta, descricao_tipo_cconsulta FROM tipo_consulta
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE

CREATE OR REPLACE FUNCTION retornatipo(cod integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_tipo_consulta, valor_consulta, descricao_tipo_cconsulta FROM tipo_consulta where cod_tipo_consulta = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
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
 
 
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
 
