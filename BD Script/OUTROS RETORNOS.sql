
CREATE OR REPLACE FUNCTION carregacomboremedio()
  RETURNS SETOF refcursor AS
$BODY$
DECLARE
cs CURSOR FOR SELECT cod_remedio_fk from medicacao  ;
 	
reg RECORD;
BEGIN
OPEN cs;

FETCH cs INTO reg;

RETURN NEXT reg;
RETURN;
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
  
CREATE OR REPLACE FUNCTION carregacomboremedio(cod integer)
  RETURNS SETOF refcursor AS
$BODY$
DECLARE
cs CURSOR FOR SELECT cod_remedio_fk from medicacao  where cod_tratamento_fk = cod;
 	
reg RECORD;
BEGIN
OPEN cs;

FETCH cs INTO reg;

RETURN NEXT reg;
RETURN;
END;
$BODY$
  LANGUAGE plpgsql VOLATILE

CREATE OR REPLACE FUNCTION ret(cod date)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_consulta FROM consulta where data_consulta = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 

END;
$BODY$
  LANGUAGE plpgsql VOLATILE

CREATE OR REPLACE FUNCTION ret(cod integer)
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_consulta, data_consulta, hora_consutla, nome_medico_veterinario, descricao_tipo_cconsulta, agendado, nome_paciente, prontuario_paciente  FROM consulta inner join paciente on cod_paciente_fk = cod_paciente inner join medico_veterinario on cod_medico_veterinario_fk = codigo_medico_vet_pk inner join tipo_consulta on cod_tipo_consulta_fk = cod_tipo_consulta where cod_cliente_fk =cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 

END;
$BODY$
  LANGUAGE plpgsql VOLATILE
  
CREATE OR REPLACE FUNCTION ret()
  RETURNS SETOF record AS
$BODY$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_consulta, data_consulta, hora_consutla, nome_medico_veterinario, descricao_tipo_cconsulta, agendado, nome_paciente, prontuario_paciente  FROM consulta inner join paciente on cod_paciente_fk = cod_paciente inner join medico_veterinario on cod_medico_veterinario_fk = codigo_medico_vet_pk inner join tipo_consulta on cod_tipo_consulta_fk = cod_tipo_consulta where cod_cliente =cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 

END;
$BODY$
  LANGUAGE plpgsql VOLATILE
  
CREATE OR REPLACE FUNCTION testa_cursor()
  RETURNS SETOF refcursor AS
$BODY$
DECLARE
cs_empregados CURSOR FOR SELECT p.nome_paciente, e.tipo_exame, l.descricao_exame, l.responsavel_exame, l.valor from paciente p inner join tratamento t on p.cod_paciente = t.cod_paciente_fk inner join laboratoriais l on t.cod_tratamento_pk = l.cod_tratameto_fk inner join exame e on e.cod_exame_pk = l.cod_exame_fk;
 	
--um_empregado laboratorios%ROWTYPE;
reg RECORD;
BEGIN
OPEN cs_empregados;
--FETCH cs_empregados INTO um_empregado;
FETCH cs_empregados INTO reg;

--RETURN NEXT um_empregado;
RETURN NEXT reg;
RETURN;
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
