SELECT e.nome AS "Nome Empregado", e.estado AS "UF", e.email AS "Email Empregado", d.nome_dep AS "Nome Dependente", d.sexo AS "Sexo" FROM empregados e INNER JOIN dependentes d ON
e.codigo_emp = d.cod_emp_fk WHERE (e.codigo_emp = '1' AND d.sexo = 'F') OR (e.codigo_emp = '2' AND d.sexo = 'F'); 

-- Select Inner Join para juntar 2 tabelas e trazer resultados especificos.

CREATE OR REPLACE FUNCTION Inserir_empregado(integer, text, text, text)
RETURNS integer AS $$
if (select * from empregados where cod_emp = $1) IS NOT NULL THEN
	UPDATE empregados set nome=$2, estado=$3, email=$4 where cod_emp = $1; 
	else
		INSERT INTO empregados VALUES($1, $2, $3, $4);
END IF;
SELECT $1;
$$ LANGUAGE SQL;

 -- FUNCAO PARA INSERIR EMPREGADOS. 
 
SELECT Inserir_empregado(6, 'TESTE', 'PR', 'teste@teste');

 -- CHAMADA DA FUNCAO ACIMA.