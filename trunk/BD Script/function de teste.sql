select receber_dadoscliente('Ola', '31/03/2000', 'ola', '1234','(43)8888-3333', 'SSPPR', 'Curitiba', '004.980.760-90', 65);
select * from cliente;

select receber_dadospaciente(65, '123456/1234', 'cachorro', 'labrador', '31/03/2000', 'bege', 'm', 'n', 'rex', 1);
select * from paciente;

select receber_dadosmedico('Maurao', 'Geriatria', '1234567-PR', '(43)8888-3333', 1);
select * from medico_veterinario;

select receber_dadostipoconsulta(2, '40.00');
select * from tipo_consulta;

ALTER SEQUENCE tipo_consulta_cod_tipo_consulta_seq RESTART 1;


select receber_dadosconsulta(0, '03/10/12', '22:00', 1, 2, 'N', 1, 'FOI IDENTIFICADO QUE O CACHORRO do wagner tem muito mais que HEMORROIDAS');
select * from consulta;

select * from custos;