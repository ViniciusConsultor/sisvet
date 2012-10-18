
CREATE OR REPLACE FUNCTION carregapaciente()
  RETURNS SETOF refcursor AS
$BODY$
DECLARE
cs CURSOR FOR SELECT cod_paciente, nome_paciente,especie_paciente from paciente  inner join consulta on cod_paciente = cod_paciente_fk;
 	
reg RECORD;
BEGIN
OPEN cs;

FETCH cs INTO reg;

RETURN NEXT reg;
RETURN;
END;
$BODY$
  LANGUAGE plpgsql VOLATILE
  
CREATE OR REPLACE FUNCTION carregapaciente(cod integer)
  RETURNS SETOF refcursor AS
$BODY$
DECLARE
cs CURSOR FOR SELECT cod_paciente, nome_paciente,especie_paciente from paciente  inner join consulta on cod_paciente = cod_paciente_fk where cod_consulta = cod;
 	
reg RECORD;
BEGIN
OPEN cs;

FETCH cs INTO reg;

RETURN NEXT reg;
RETURN;
END;
$BODY$
  LANGUAGE plpgsql VOLATILE