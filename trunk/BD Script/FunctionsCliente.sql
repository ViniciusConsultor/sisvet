CREATE OR REPLACE FUNCTION inserir_cliente(nomecliente varchar, datanascimentocliente date, enderecocliente varchar, rgcliente varchar, telefone char,
 exxpeditorrgcliente varchar, municipiocliente varchar, cpfcliente char) RETURNS integer AS $$
 begin
	insert into cliente (nome_cliente, data_nascimeto_cliente, endereco_cliente, rg_cliente, telefone_cliente, 
	exxpedidor_rg_cliente, municipio_cliente, cpf_cliente) values (nomecliente, datanascimentocliente, enderecocliente, rgcliente, telefone, exxpeditorrgcliente, 
	municipiocliente, cpfcliente);

	return (1);
 end;
$$language plpgsql;

CREATE OR REPLACE FUNCTION atualizar_cliente(nomecliente varchar, datanascimentocliente date, enderecocliente varchar, rgcliente varchar, telefone char,
 exxpeditorrgcliente varchar, municipiocliente varchar, cpfcliente char, codcliente int) RETURNS integer AS $$
 begin
	update cliente set nome_cliente = nomecliente, data_nascimeto_cliente = datanascimentocliente, endereco_cliente = enderecocliente, 
	rg_cliente = rgcliente, telefone_cliente = telefone, exxpedidor_rg_cliente = exxpeditorrgcliente, municipio_cliente = municipiocliente, 
	cpf_cliente = cpfcliente where cod_cliente = codcliente;

	return (1);
 end;
$$language plpgsql;

CREATE OR REPLACE FUNCTION deletar_cliente(codcliente int) RETURNS integer AS $$
begin
	delete from cliente where cod_cliente = codcliente;
	return (1);
end;
$$language plpgsql;	

