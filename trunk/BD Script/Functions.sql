-- CLIENTE 
-- add
CREATE OR REPLACE FUNCTION inserir_cliente(nomecliente varchar, datanascimentocliente date, enderecocliente varchar, rgcliente varchar, telefone char,
 exxpeditorrgcliente varchar, municipiocliente varchar, cpfcliente char) RETURNS integer AS $$
 begin
	insert into cliente (nome_cliente, data_nascimeto_cliente, endereco_cliente, rg_cliente, telefone_cliente, 
	exxpedidor_rg_cliente, municipio_cliente, cpf_cliente) values (nomecliente, datanascimentocliente, enderecocliente, rgcliente, telefone, exxpeditorrgcliente, 
	municipiocliente, cpfcliente);

	return (1);
 end;
$$language plpgsql;

-- atualizar
CREATE OR REPLACE FUNCTION atualizar_cliente(nomecliente varchar, datanascimentocliente date, enderecocliente varchar, rgcliente varchar, telefone char,
 exxpeditorrgcliente varchar, municipiocliente varchar, cpfcliente char, codcliente int) RETURNS integer AS $$
 begin
	update cliente set nome_cliente = nomecliente, data_nascimeto_cliente = datanascimentocliente, endereco_cliente = enderecocliente, 
	rg_cliente = rgcliente, telefone_cliente = telefone, exxpedidor_rg_cliente = exxpeditorrgcliente, municipio_cliente = municipiocliente, 
	cpf_cliente = cpfcliente where cod_cliente = codcliente;

	return (1);
 end;
$$language plpgsql;

-- deletar
CREATE OR REPLACE FUNCTION deletar_cliente(codcliente int) RETURNS integer AS $$
begin
	delete from cliente where cod_cliente = codcliente;
	return (1);
end;
$$language plpgsql;	

-- select
CREATE OR REPLACE FUNCTION fnGetCliente() RETURNS SETOF cliente AS $$
DECLARE 
	linha cliente%ROWTYPE;
BEGIN
	FOR linha in  SELECT * FROM cliente LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;




-- PACIENTE
-- add
CREATE OR REPLACE FUNCTION inserir_paciente(codclientefk int, rghvpaciente varchar, especiepaciente varchar, racapaciente varchar, nascimentopaciente date,
			pelagempaciente varchar, sexopaciente char, pacientecadastrado char, nomepaciente varchar) RETURNS integer AS $$
	begin
		insert into paciente (cod_cliente_fk, rghv_paciente, especie_paciente, raca_paciente, nascimento_paciente, pelagem_paciente, 
		sexo_paciente, paciente_castrado, nome_paciente) values (codclientefk, rghvpaciente, especiepaciente, racapaciente, 
		nascimentopaciente, pelagempaciente, sexopaciente, pacientecadastrado, nomepaciente);

		return 1;
	end;
$$language plpgsql;

-- atualizar
CREATE OR REPLACE FUNCTION atualizar_paciente(codclientefk int, rghvpaciente varchar, especiepaciente varchar, racapaciente varchar, nascimentopaciente date,
			pelagempaciente varchar, sexopaciente char, pacientecadastrado char, nomepaciente varchar, codpaciente integer) RETURNS integer AS $$
	begin
		update paciente set cod_cliente_fk = codclientefk, rghv_paciente = rghvpaciente, especie_paciente = especiepaciente, 
		raca_paciente = racapaciente, nascimento_paciente = nascimentopaciente, pelagem_paciente = pelagempaciente, sexo_paciente = sexopaciente,
		paciente_castrado = pacientecadastrado, nome_paciente = nomepaciente where cod_paciente = codpaciente;

		return 1;
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
CREATE OR REPLACE FUNCTION fnGetPaciente() RETURNS SETOF paciente AS $$
DECLARE 
	linha paciente%ROWTYPE;
BEGIN
	FOR linha in  SELECT * FROM paciente LOOP
		RETURN NEXT linha;
	END LOOP;
	RETURN;
END
$$LANGUAGE PLPGSQL;



