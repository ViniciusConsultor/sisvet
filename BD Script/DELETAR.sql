
CREATE OR REPLACE FUNCTION deletar_cliente(codcliente integer)
  RETURNS integer AS
$BODY$
begin
	delete from cliente where cod_cliente = codcliente;
	return (1);
end;
$BODY$
  LANGUAGE plpgsql VOLATILE
 REATE OR REPLACE FUNCTION deletar_consulta(codigoconsulta integer)
  RETURNS integer AS
$BODY$
	begin
	delete from consulta where cod_consulta = codigoconsulta;

	return 1;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE
 
CREATE OR REPLACE FUNCTION deletar_custos(codigo integer)
  RETURNS integer AS
$BODY$
	begin
	delete from custos where cod = codigo;

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
  
CREATE OR REPLACE FUNCTION deletar_usuario(codusuario integer)
  RETURNS integer AS
$BODY$
	begin
		delete from usuario where cod_usuario = codusuario;
		return 1;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE
  COST 100;