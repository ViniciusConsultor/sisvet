create or replace function pagar_conta(codcusto integer) returns varchar AS
$BODY$

begin 
	delete from custos where cod_cliente_fk = codcusto;

	return "Efetuado baixa no sistema";
end;

$BODY$
language plpgsql

