
CREATE OR REPLACE FUNCTION inserir_tipoconsulta(valorconsulta numeric, desc_tipo character varying)
  RETURNS integer AS
$BODY$
	declare
		cod integer;
	begin
		insert into tipo_consulta(valor_consulta, descricao_tipo_consulta) VALUES (valorconsulta, desc_tipo);
		GET DIAGNOSTICS cod = RESULT_OID;

		return cod;
	end;
$BODY$
  LANGUAGE plpgsql VOLATILE
