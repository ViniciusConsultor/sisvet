--
-- PostgreSQL database dump
--

-- Dumped from database version 9.1.3
-- Dumped by pg_dump version 9.1.3
-- Started on 2012-10-10 22:31:59

SET statement_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;

--
-- TOC entry 191 (class 3079 OID 11639)
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- TOC entry 2185 (class 0 OID 0)
-- Dependencies: 191
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


SET search_path = public, pg_catalog;

--
-- TOC entry 203 (class 1255 OID 26058)
-- Dependencies: 712 6
-- Name: atualiza_conta(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION atualiza_conta() RETURNS trigger
    LANGUAGE plpgsql
    AS $$

begin 	
	update custos set valortotal = (select valor_consulta from tipo_consulta where cod_tipo_consulta = new.cod_tipo_consulta_fk) where cod_consulta_fk = new.cod_consulta;
	
	return null;	
end;

$$;


ALTER FUNCTION public.atualiza_conta() OWNER TO postgres;

--
-- TOC entry 204 (class 1255 OID 26059)
-- Dependencies: 712 6
-- Name: atualiza_contacirurgia(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION atualiza_contacirurgia() RETURNS trigger
    LANGUAGE plpgsql
    AS $$

begin 	
	update custos set valortotal = new.valor_cirurgia where cod_consulta_fk = (select cod_consulta_fk from tratamento where cod_tratamento_pk = new.cod_tratamento_fk);
	
	return null;	
end;

$$;


ALTER FUNCTION public.atualiza_contacirurgia() OWNER TO postgres;

--
-- TOC entry 205 (class 1255 OID 26060)
-- Dependencies: 6 712
-- Name: atualiza_contaexame(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION atualiza_contaexame() RETURNS trigger
    LANGUAGE plpgsql
    AS $$

begin 	
	update custos set valortotal = new.valor where cod_consulta_fk = (select cod_consulta_fk from tratamento where cod_tratamento_pk = new.cod_tratamento_fk);
	
	return null;	
end;

$$;


ALTER FUNCTION public.atualiza_contaexame() OWNER TO postgres;

--
-- TOC entry 206 (class 1255 OID 26061)
-- Dependencies: 6 712
-- Name: atualiza_contamedicacao(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION atualiza_contamedicacao() RETURNS trigger
    LANGUAGE plpgsql
    AS $$

begin 	
	update custos set valortotal = new.valor where cod_consulta_fk = (select cod_consulta_fk from tratamento where cod_tratamento_pk = new.cod_tratamento_fk);
	
	return null;	
end;

$$;


ALTER FUNCTION public.atualiza_contamedicacao() OWNER TO postgres;

--
-- TOC entry 207 (class 1255 OID 26062)
-- Dependencies: 712 6
-- Name: atualizar_cirurgia(character varying, integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION atualizar_cirurgia(nome character varying, medico integer, codigo integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
 begin
	update cirurgia set  descricao_cirurgia = nome, medico_veterinario_fk = medico where cod_cirurgia_pk = codigo;

	return codigo;
 end;

$$;


ALTER FUNCTION public.atualizar_cirurgia(nome character varying, medico integer, codigo integer) OWNER TO postgres;

--
-- TOC entry 208 (class 1255 OID 26063)
-- Dependencies: 6 712
-- Name: atualizar_cirurgiainternacao(integer, integer, integer, character varying, date, time without time zone, numeric); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION atualizar_cirurgiainternacao(internacao integer, tratamento integer, cirurgia integer, descricaoprocedimento character varying, datacirurgia date, horacirurgia time without time zone, valor numeric) RETURNS integer
    LANGUAGE plpgsql
    AS $$

begin
	update cirurgia_internacao set cod_tratamento_fk = tratamento,
	cod_cirurgia_fk = cirurgia, descricao_procedimento = descricaoprocedimento,
	data_cirurgia = datacirurgia, horario_cirurgia = horacirurgia,
	valor_cirurgia = valor where cod_internacao = internacao;

	return internacao; 
end;
$$;


ALTER FUNCTION public.atualizar_cirurgiainternacao(internacao integer, tratamento integer, cirurgia integer, descricaoprocedimento character varying, datacirurgia date, horacirurgia time without time zone, valor numeric) OWNER TO postgres;

--
-- TOC entry 209 (class 1255 OID 26064)
-- Dependencies: 6 712
-- Name: atualizar_cliente(character varying, date, character varying, character varying, character, character varying, character varying, character, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION atualizar_cliente(nomecliente character varying, datanascimentocliente date, enderecocliente character varying, rgcliente character varying, telefone character, exxpeditorrgcliente character varying, municipiocliente character varying, cpfcliente character, codcliente integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
 begin
 begin
	update cliente set nome_cliente = nomecliente, data_nascimeto_cliente = datanascimentocliente, endereco_cliente = enderecocliente, 
	rg_cliente = rgcliente, telefone_cliente = telefone, exxpedidor_rg_cliente = exxpeditorrgcliente, municipio_cliente = municipiocliente, 
	cpf_cliente = cpfcliente where cod_cliente = codcliente;
Exception 
        When check_violation Then
                  raise exception 'Erro de entrada de dados!!';
	end;
	return codcliente;
 end;
$$;


ALTER FUNCTION public.atualizar_cliente(nomecliente character varying, datanascimentocliente date, enderecocliente character varying, rgcliente character varying, telefone character, exxpeditorrgcliente character varying, municipiocliente character varying, cpfcliente character, codcliente integer) OWNER TO postgres;

--
-- TOC entry 211 (class 1255 OID 26065)
-- Dependencies: 712 6
-- Name: atualizar_consulta(integer, date, time without time zone, integer, integer, character, integer, text); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION atualizar_consulta(codigoconsulta integer, dataconsulta date, horaconsulta time without time zone, medicoveterinario integer, codigotipo integer, agendamento character, paciente integer, prontuario text) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin
	begin
	update consulta set data_consulta = dataconsulta, hora_consutla = horaconsulta, cod_medico_veterinario_fk = medicoveterinario, 
	cod_tipo_consulta_fk = codigotipo, agendado = agendamento, cod_paciente_fk = paciente, prontuario_paciente = prontuario 
	where cod_consulta = codigoconsulta;
	Exception 
        When check_violation Then
                  raise exception 'Erro de entrada de dados!!';
	end;
	return codigoconsulta;
	end;
$$;


ALTER FUNCTION public.atualizar_consulta(codigoconsulta integer, dataconsulta date, horaconsulta time without time zone, medicoveterinario integer, codigotipo integer, agendamento character, paciente integer, prontuario text) OWNER TO postgres;

--
-- TOC entry 212 (class 1255 OID 26066)
-- Dependencies: 6 712
-- Name: atualizar_custos(integer, integer, numeric); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION atualizar_custos(codcliente integer, codconsulta integer, valortotal numeric) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin
	
	update custos set cod_cliente_fk = (select cod_cliente_fk from paciente where cod_paciente = codcliente), valor_Total = valortotal where cod_consulta_fk = codconsulta;
	
	return codcliente;
	end;
$$;


ALTER FUNCTION public.atualizar_custos(codcliente integer, codconsulta integer, valortotal numeric) OWNER TO postgres;

--
-- TOC entry 213 (class 1255 OID 26067)
-- Dependencies: 712 6
-- Name: atualizar_custos(integer, integer, integer, numeric); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION atualizar_custos(custo integer, codcliente integer, codconsulta integer, valortotal numeric) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin
	
	update custos set cod_cliente_fk = (select cod_cliente_fk from paciente where cod_paciente = 
	(select cod_paciente_fk from consulta where cod_consulta = codconsulta)), valor_Total = valortotal, cod_consulta_fk = codconsulta where cod_custo = custo;
	
	return custo;
	end;
$$;


ALTER FUNCTION public.atualizar_custos(custo integer, codcliente integer, codconsulta integer, valortotal numeric) OWNER TO postgres;

--
-- TOC entry 214 (class 1255 OID 26068)
-- Dependencies: 6 712
-- Name: atualizar_exame(character varying, integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION atualizar_exame(nome character varying, laboratorio integer, codigo integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
 begin
	update exame set  tipo_exame = nome, cod_laboratorio_fk = laboratorio where cod_exame_pk = codigo;

	return codigo;
 end;

$$;


ALTER FUNCTION public.atualizar_exame(nome character varying, laboratorio integer, codigo integer) OWNER TO postgres;

--
-- TOC entry 215 (class 1255 OID 26069)
-- Dependencies: 712 6
-- Name: atualizar_exame(character varying, integer, character varying, numeric, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION atualizar_exame(nome character varying, laboratorio integer, descricao character varying, valor numeric, codigo integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
 begin
	update exame set  tipo_exame = nome, cod_laboratorio_fk = laboratorio, nome_responsavel = descricao, valor_exame = valor where cod_exame_pk = codigo;

	return codigo;
 end;

$$;


ALTER FUNCTION public.atualizar_exame(nome character varying, laboratorio integer, descricao character varying, valor numeric, codigo integer) OWNER TO postgres;

--
-- TOC entry 216 (class 1255 OID 26070)
-- Dependencies: 6 712
-- Name: atualizar_laboratoriais(integer, integer, integer, text, character varying, numeric); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION atualizar_laboratoriais(cod integer, tratamento integer, exame integer, descricao text, responsavel character varying, valorexame numeric) RETURNS integer
    LANGUAGE plpgsql
    AS $$

begin
	update laboratoriais set cod_tratamento_fk = tratamento, cod_exame_fk = exame,
	descricao_exame = descricao, responsavel_exame = responsavel, valor = valorexame where
	cod_laboratoriais = cod;

	return cod;
end;

$$;


ALTER FUNCTION public.atualizar_laboratoriais(cod integer, tratamento integer, exame integer, descricao text, responsavel character varying, valorexame numeric) OWNER TO postgres;

--
-- TOC entry 217 (class 1255 OID 26071)
-- Dependencies: 712 6
-- Name: atualizar_laboratorio(character varying, character varying, character varying, character varying, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION atualizar_laboratorio(nome character varying, telefone character varying, endereco character varying, municipio character varying, codigo integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
 begin
 begin
	update laboratorios set  nome_laboratorio = nome, telefone_laboratorio = telefone, endereco_laboratorio = endereco, municipio_laboratorio = municipio where cod_laboratorio_pk = codigo;
Exception 
        When check_violation Then
                  raise exception 'Erro de entrada de dados!!';
	end;
	return cod_laboratorio_pk;
 end;

$$;


ALTER FUNCTION public.atualizar_laboratorio(nome character varying, telefone character varying, endereco character varying, municipio character varying, codigo integer) OWNER TO postgres;

--
-- TOC entry 218 (class 1255 OID 26072)
-- Dependencies: 6 712
-- Name: atualizar_med(character varying, numeric, integer, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION atualizar_med(nome_remedio character varying, valor_remedio numeric, qtd_estoque integer, categoria_remedio character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	declare
		cod integer;
	begin
	insert into remedio(verificar, nome_remedio, valor_remedio, qtd_estoque, categoria) VALUES
	( verificar, nome_remedio, valor_remedio, qtd_estoque, categoria);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;	

	end;
$$;


ALTER FUNCTION public.atualizar_med(nome_remedio character varying, valor_remedio numeric, qtd_estoque integer, categoria_remedio character varying) OWNER TO postgres;

--
-- TOC entry 219 (class 1255 OID 26073)
-- Dependencies: 6 712
-- Name: atualizar_medicacao(integer, integer, character varying, character varying, numeric, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION atualizar_medicacao(cod_trat integer, cod_rem integer, qtd character varying, cod_resp character varying, valor_med numeric, verificar integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin
	update medicacao set  cod_tratamento_fk = cod_trat, cod_remedio_fk = cod_rem, 
	qtd_aplicada = qtd, responsavel_medicacao = cod_resp, valor = valor_med where medicacaoPK = verificar;

	return medicacaoPK;
	end;
$$;


ALTER FUNCTION public.atualizar_medicacao(cod_trat integer, cod_rem integer, qtd character varying, cod_resp character varying, valor_med numeric, verificar integer) OWNER TO postgres;

--
-- TOC entry 220 (class 1255 OID 26074)
-- Dependencies: 712 6
-- Name: atualizar_medvet(integer, character varying, character varying, character varying, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION atualizar_medvet(codmedico integer, nomemedico character varying, especialidade character varying, crmv character varying, telefone character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin
	begin
	update medico_veterinario set nome_medico_veterinario = nomemedico, especialidade_veterinario = especialidade, 
	crmv_veterinario = crmv, telefone_veterinario = telefone where codigo_medico_vet_pk = codmedico;
	Exception 
        When check_violation Then
                  raise exception 'Erro de entrada de dados!!';
	end;
	return codmedico;
	end;
$$;


ALTER FUNCTION public.atualizar_medvet(codmedico integer, nomemedico character varying, especialidade character varying, crmv character varying, telefone character varying) OWNER TO postgres;

--
-- TOC entry 221 (class 1255 OID 26075)
-- Dependencies: 712 6
-- Name: atualizar_paciente(integer, character varying, character varying, character varying, date, character varying, character, character, character varying, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION atualizar_paciente(codclientefk integer, rghvpaciente character varying, especiepaciente character varying, racapaciente character varying, nascimentopaciente date, pelagempaciente character varying, sexopaciente character, pacientecadastrado character, nomepaciente character varying, codpaciente integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin
	begin
		update paciente set cod_cliente_fk = codclientefk, rghv_paciente = rghvpaciente, especie_paciente = especiepaciente, 
		raca_paciente = racapaciente, nascimento_paciente = nascimentopaciente, pelagem_paciente = pelagempaciente, sexo_paciente = sexopaciente,
		paciente_castrado = pacientecadastrado, nome_paciente = nomepaciente where cod_paciente = codpaciente;
	Exception 
        When check_violation Then
                  raise exception 'Erro de entrada de dados!!';
	end;
		return codpaciente;
	end;
$$;


ALTER FUNCTION public.atualizar_paciente(codclientefk integer, rghvpaciente character varying, especiepaciente character varying, racapaciente character varying, nascimentopaciente date, pelagempaciente character varying, sexopaciente character, pacientecadastrado character, nomepaciente character varying, codpaciente integer) OWNER TO postgres;

--
-- TOC entry 222 (class 1255 OID 26076)
-- Dependencies: 6 712
-- Name: atualizar_remedio(character varying, numeric, integer, character varying, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION atualizar_remedio(nome character varying, valor numeric, estoque integer, categoria character varying, cod integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin
		update remedios set 
		nome_remedio = nome, valor_remedio =
		valor, qtd_estoque = estoque, 
		categoria_remedio = categoria where
		cod_remedio = cod;

		return cod;
	end;
$$;


ALTER FUNCTION public.atualizar_remedio(nome character varying, valor numeric, estoque integer, categoria character varying, cod integer) OWNER TO postgres;

--
-- TOC entry 223 (class 1255 OID 26077)
-- Dependencies: 6 712
-- Name: atualizar_tipoconsulta(integer, numeric); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION atualizar_tipoconsulta(codtipoconsulta integer, valorconsulta numeric) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin
	update tipo_consulta set valor_consulta = valorconsulta where cod_tipo_consulta = codtipoconsulta;
	
	return codtipoconsulta;
	end;
$$;


ALTER FUNCTION public.atualizar_tipoconsulta(codtipoconsulta integer, valorconsulta numeric) OWNER TO postgres;

--
-- TOC entry 224 (class 1255 OID 26078)
-- Dependencies: 6 712
-- Name: atualizar_tratamento(character varying, integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION atualizar_tratamento(nome character varying, consulta integer, codigo integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
 begin
	update tratamento set  descricao_tratamento = nome, cod_consulta_fk = consulta where cod_tratamento_pk = codigo;

	return codigo;
 end;

$$;


ALTER FUNCTION public.atualizar_tratamento(nome character varying, consulta integer, codigo integer) OWNER TO postgres;

--
-- TOC entry 225 (class 1255 OID 26079)
-- Dependencies: 712 6
-- Name: atualizar_tratamento(character varying, integer, integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION atualizar_tratamento(nome character varying, pac integer, medico integer, codigo integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
 begin
	update tratamento set  descricao_tratamento = nome, cod_paciente_fk = pac, cod_veterinario_fk = medico where cod_tratamento_pk = codigo;

	return codigo;
 end;

$$;


ALTER FUNCTION public.atualizar_tratamento(nome character varying, pac integer, medico integer, codigo integer) OWNER TO postgres;

--
-- TOC entry 210 (class 1255 OID 26080)
-- Dependencies: 6 712
-- Name: atualizar_usuario(integer, character varying, character varying, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION atualizar_usuario(codusuario integer, nomeusuario character varying, loginusuario character varying, senhausuario character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin
	update usuario set nome_usuario = nomeusuario, login = loginusuario, senha = senhausuario where cod_usuario = codusuario;
	
	return codusuario;
	end;
$$;


ALTER FUNCTION public.atualizar_usuario(codusuario integer, nomeusuario character varying, loginusuario character varying, senhausuario character varying) OWNER TO postgres;

--
-- TOC entry 226 (class 1255 OID 26081)
-- Dependencies: 6 712
-- Name: carregacomboremedio(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION carregacomboremedio() RETURNS SETOF refcursor
    LANGUAGE plpgsql
    AS $$
DECLARE
cs CURSOR FOR SELECT cod_remedio_fk from medicacao  ;
 	
reg RECORD;
BEGIN
OPEN cs;

FETCH cs INTO reg;

RETURN NEXT reg;
RETURN;
END;
$$;


ALTER FUNCTION public.carregacomboremedio() OWNER TO postgres;

--
-- TOC entry 227 (class 1255 OID 26082)
-- Dependencies: 712 6
-- Name: carregacomboremedio(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION carregacomboremedio(cod integer) RETURNS SETOF refcursor
    LANGUAGE plpgsql
    AS $$
DECLARE
cs CURSOR FOR SELECT cod_remedio_fk from medicacao  where cod_tratamento_fk = cod;
 	
reg RECORD;
BEGIN
OPEN cs;

FETCH cs INTO reg;

RETURN NEXT reg;
RETURN;
END;
$$;


ALTER FUNCTION public.carregacomboremedio(cod integer) OWNER TO postgres;

--
-- TOC entry 228 (class 1255 OID 26083)
-- Dependencies: 712 6
-- Name: deletar_cliente(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION deletar_cliente(codcliente integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	delete from cliente where cod_cliente = codcliente;
	return (1);
end;
$$;


ALTER FUNCTION public.deletar_cliente(codcliente integer) OWNER TO postgres;

--
-- TOC entry 229 (class 1255 OID 26084)
-- Dependencies: 712 6
-- Name: deletar_consulta(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION deletar_consulta(codigoconsulta integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin
	delete from consulta where cod_consulta = codigoconsulta;

	return 1;
	end;
$$;


ALTER FUNCTION public.deletar_consulta(codigoconsulta integer) OWNER TO postgres;

--
-- TOC entry 230 (class 1255 OID 26085)
-- Dependencies: 6 712
-- Name: deletar_custos(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION deletar_custos(cod integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	delete from custos where cod_tratamento_fk = cod;
	return (1);
end;
$$;


ALTER FUNCTION public.deletar_custos(cod integer) OWNER TO postgres;

--
-- TOC entry 231 (class 1255 OID 26086)
-- Dependencies: 6 712
-- Name: deletar_exame(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION deletar_exame(cod integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	delete from exame where cod_exame_pk = cod;
	return (1);
end;
$$;


ALTER FUNCTION public.deletar_exame(cod integer) OWNER TO postgres;

--
-- TOC entry 232 (class 1255 OID 26087)
-- Dependencies: 6 712
-- Name: deletar_laboratorio(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION deletar_laboratorio(cod integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	delete from laboratorios where cod_laboratorio_pk = cod;
	return (1);
end;
$$;


ALTER FUNCTION public.deletar_laboratorio(cod integer) OWNER TO postgres;

--
-- TOC entry 233 (class 1255 OID 26088)
-- Dependencies: 712 6
-- Name: deletar_medvet(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION deletar_medvet(codmedico integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin
	delete from medico_veterinario where codigo_medico_vet_pk = codmedico;

	return 1;
	end;
$$;


ALTER FUNCTION public.deletar_medvet(codmedico integer) OWNER TO postgres;

--
-- TOC entry 234 (class 1255 OID 26089)
-- Dependencies: 6 712
-- Name: deletar_paciente(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION deletar_paciente(codpaciente integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin
		delete from paciente where cod_paciente = codpaciente;
		return 1;
	end;
$$;


ALTER FUNCTION public.deletar_paciente(codpaciente integer) OWNER TO postgres;

--
-- TOC entry 235 (class 1255 OID 26090)
-- Dependencies: 6 712
-- Name: deletar_remedio(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION deletar_remedio(cod integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	delete from remedios where cod_remedio = cod;
	return (1);
end;
$$;


ALTER FUNCTION public.deletar_remedio(cod integer) OWNER TO postgres;

--
-- TOC entry 236 (class 1255 OID 26091)
-- Dependencies: 6 712
-- Name: deletar_tipoconsulta(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION deletar_tipoconsulta(codtipoconsulta integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin
	delete from tipo_consulta where cod_tipo_consulta = codtipoconsulta;

	return 1;
	end;
$$;


ALTER FUNCTION public.deletar_tipoconsulta(codtipoconsulta integer) OWNER TO postgres;

--
-- TOC entry 237 (class 1255 OID 26092)
-- Dependencies: 6 712
-- Name: deletar_usuario(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION deletar_usuario(codusuario integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin
		delete from usuario where cod_usuario = codusuario;
		return 1;
	end;
$$;


ALTER FUNCTION public.deletar_usuario(codusuario integer) OWNER TO postgres;

--
-- TOC entry 238 (class 1255 OID 26093)
-- Dependencies: 6 712
-- Name: insere_conta(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION insere_conta() RETURNS trigger
    LANGUAGE plpgsql
    AS $$

begin 
	insert into custos(cod_consulta_fk, valortotal, cod_cliente_fk, dataconsulta) values (new.cod_consulta,
	 (select valor_consulta from tipo_consulta where cod_tipo_consulta = new.cod_tipo_consulta_fk),
	 (select cod_cliente_fk from paciente where cod_paciente = (select cod_paciente_fk from consulta where cod_consulta = new.cod_consulta)),
	 (select data_consulta from consulta where cod_consulta = new.cod_consulta));
	
	return null;	
end;

$$;


ALTER FUNCTION public.insere_conta() OWNER TO postgres;

--
-- TOC entry 239 (class 1255 OID 26094)
-- Dependencies: 6 712
-- Name: insere_contacirurgia(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION insere_contacirurgia() RETURNS trigger
    LANGUAGE plpgsql
    AS $$

declare 
cod_consulta integer;
valor_proc numeric;

begin
	cod_consulta = (select cod_consulta_fk from tratamento where cod_tratamento_pk = new.cod_tratamento_fk);

	valor_proc = (select valortotal from custos where cod_consulta_fk = cod_consulta);
	valor_proc = valor_proc + new.valor_cirurgia;
	
	update custos set valortotal = valor_proc where cod_consulta_fk = cod_consulta;

	return null;
end;

$$;


ALTER FUNCTION public.insere_contacirurgia() OWNER TO postgres;

--
-- TOC entry 240 (class 1255 OID 26095)
-- Dependencies: 6 712
-- Name: insere_contaexame(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION insere_contaexame() RETURNS trigger
    LANGUAGE plpgsql
    AS $$

declare 
cod_consulta integer;
valor_lab numeric;

begin
	cod_consulta = (select cod_consulta_fk from tratamento where cod_tratamento_pk = new.cod_tratameto_fk);

	valor_lab = (select valortotal from custos where cod_consulta_fk = cod_consulta);
	valor_lab = valor_lab + new.valor;
	
	update custos set valortotal = valor_lab where cod_consulta_fk = cod_consulta;

	return null;
end;

$$;


ALTER FUNCTION public.insere_contaexame() OWNER TO postgres;

--
-- TOC entry 241 (class 1255 OID 26096)
-- Dependencies: 6 712
-- Name: insere_contalaboratoriais(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION insere_contalaboratoriais() RETURNS trigger
    LANGUAGE plpgsql
    AS $$

declare 
cod_consulta integer;
valor_exame integer;

begin
	cod_consulta = (select cod_consulta_fk from tratamento where cod_tratamento_pk = new.cod_tratamento_fk);

	valor_exame = (select valortotal from custos where cod_consulta_fk = cod_consulta);
	valor_exame = valor_exame + new.valor;
	
	update custos set valortotal = valor_exame where cod_consulta_fk = cod_consulta;
end;

$$;


ALTER FUNCTION public.insere_contalaboratoriais() OWNER TO postgres;

--
-- TOC entry 242 (class 1255 OID 26097)
-- Dependencies: 6 712
-- Name: insere_contamedicacao(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION insere_contamedicacao() RETURNS trigger
    LANGUAGE plpgsql
    AS $$

declare 
cod_consulta integer;
valor_medicacao numeric;

begin
	cod_consulta = (select cod_consulta_fk from tratamento where cod_tratamento_pk = new.cod_tratamento_fk);

	valor_medicacao = (select valortotal from custos where cod_consulta_fk = cod_consulta);
	valor_medicacao = valor_medicacao + new.valor;
	
	update custos set valortotal = valor_medicacao where cod_consulta_fk = cod_consulta;

	return null;
end;

$$;


ALTER FUNCTION public.insere_contamedicacao() OWNER TO postgres;

--
-- TOC entry 243 (class 1255 OID 26098)
-- Dependencies: 6 712
-- Name: inserir_cirurgia(character varying, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION inserir_cirurgia(nome character varying, medico integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$

declare
		cod integer;
		
	begin
	insert into cirurgia(descricao_cirurgia, medico_veterinario_fk) VALUES
	( nome, medico);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;	

	end;
$$;


ALTER FUNCTION public.inserir_cirurgia(nome character varying, medico integer) OWNER TO postgres;

--
-- TOC entry 244 (class 1255 OID 26099)
-- Dependencies: 6 712
-- Name: inserir_cirurgiainternacao(integer, integer, character varying, date, time without time zone, numeric); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION inserir_cirurgiainternacao(tratamento integer, cirurgia integer, descricao character varying, datacirurgia date, horacirurgia time without time zone, valor numeric) RETURNS integer
    LANGUAGE plpgsql
    AS $$

declare
	cod integer;

begin
	insert into cirurgia_enternacao(cod_tratamento_fk,
	cod_cirurgia_fk, descricao_procedimento, data_cirurgia,
	horario_cirurgia, valor_cirurgia) values (tratamento,
	cirurgia, descricao, datacirurgia, horacirurgia, valor);

	GET DIAGNOSTICS cod = RESULT_OID;

	return cod;
end;

$$;


ALTER FUNCTION public.inserir_cirurgiainternacao(tratamento integer, cirurgia integer, descricao character varying, datacirurgia date, horacirurgia time without time zone, valor numeric) OWNER TO postgres;

--
-- TOC entry 246 (class 1255 OID 26100)
-- Dependencies: 6 712
-- Name: inserir_cliente(character varying, date, character varying, character varying, character, character varying, character varying, character); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION inserir_cliente(nomecliente character varying, datanascimentocliente date, enderecocliente character varying, rgcliente character varying, telefone character, exxpeditorrgcliente character varying, municipiocliente character varying, cpfcliente character) RETURNS character varying
    LANGUAGE plpgsql
    AS $$
 declare
	cod integer;
 begin
	begin
	insert into cliente (nome_cliente, data_nascimeto_cliente, endereco_cliente, rg_cliente, telefone_cliente, 
	exxpedidor_rg_cliente, municipio_cliente, cpf_cliente) values (nomecliente, datanascimentocliente, enderecocliente, rgcliente, telefone, exxpeditorrgcliente, 
	municipiocliente, cpfcliente);

	GET DIAGNOSTICS cod = RESULT_OID;
	--return cod;
	Exception 
        When check_violation Then
                  raise exception 'Erro de entrada de dados!!';
	end;
 end;
$$;


ALTER FUNCTION public.inserir_cliente(nomecliente character varying, datanascimentocliente date, enderecocliente character varying, rgcliente character varying, telefone character, exxpeditorrgcliente character varying, municipiocliente character varying, cpfcliente character) OWNER TO postgres;

--
-- TOC entry 247 (class 1255 OID 26101)
-- Dependencies: 6 712
-- Name: inserir_consulta(date, time without time zone, integer, integer, character, integer, text); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION inserir_consulta(dataconsulta date, horaconsulta time without time zone, medicoveterinario integer, codigotipo integer, agendamento character, paciente integer, prontuario text) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	declare
		cod integer;
	begin
	begin
	insert into consulta(data_consulta, hora_consutla, cod_medico_veterinario_fk, cod_tipo_consulta_fk, agendado, cod_paciente_fk,
	prontuario_paciente) VALUES (dataconsulta, horaconsulta, medicoveterinario, codigotipo, agendamento, paciente, prontuario);
	Exception 
        When check_violation Then
                  raise exception 'Erro de entrada de dados!!';
	end;
	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;
	
	end;
$$;


ALTER FUNCTION public.inserir_consulta(dataconsulta date, horaconsulta time without time zone, medicoveterinario integer, codigotipo integer, agendamento character, paciente integer, prontuario text) OWNER TO postgres;

--
-- TOC entry 248 (class 1255 OID 26102)
-- Dependencies: 6 712
-- Name: inserir_custos(integer, numeric); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION inserir_custos(codconsulta integer, valortotal numeric) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	declare
		cod integer;
	begin
	insert into custos(cod_tratamento_fk, "valor_Total") VALUES (codconsulta, valortotal);
	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;
	
	end;
$$;


ALTER FUNCTION public.inserir_custos(codconsulta integer, valortotal numeric) OWNER TO postgres;

--
-- TOC entry 249 (class 1255 OID 26103)
-- Dependencies: 6 712
-- Name: inserir_exame(character varying, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION inserir_exame(nome character varying, laboratorio integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$

declare
		cod integer;
		
	begin
	insert into exame(tipo_exame, cod_laboratorio_fk) VALUES
	( nome, laboratorio);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;	

	end;
$$;


ALTER FUNCTION public.inserir_exame(nome character varying, laboratorio integer) OWNER TO postgres;

--
-- TOC entry 250 (class 1255 OID 26104)
-- Dependencies: 6 712
-- Name: inserir_exame(character varying, integer, character varying, numeric); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION inserir_exame(nome character varying, laboratorio integer, descricao character varying, valor numeric) RETURNS integer
    LANGUAGE plpgsql
    AS $$

declare
		cod integer;
		
	begin
	insert into exame(tipo_exame, cod_laboratorio_fk, nome_responsavel, valor_exame) VALUES
	(nome, laboratorio, descricao, valor);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;	

	end;
$$;


ALTER FUNCTION public.inserir_exame(nome character varying, laboratorio integer, descricao character varying, valor numeric) OWNER TO postgres;

--
-- TOC entry 251 (class 1255 OID 26105)
-- Dependencies: 6 712
-- Name: inserir_laboratoriais(integer, integer, text, character varying, numeric); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION inserir_laboratoriais(tratamento integer, exame integer, descricao text, responsavel character varying, valor numeric) RETURNS integer
    LANGUAGE plpgsql
    AS $$

declare 
	cod integer;
begin
	insert into laboratoriais(cod_tratamento_fk, cod_exame_fk, descricao_exame, responsavel_exame,
	valor) values (tratamento, exame, descricao, responsavel, valor);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;
end;

$$;


ALTER FUNCTION public.inserir_laboratoriais(tratamento integer, exame integer, descricao text, responsavel character varying, valor numeric) OWNER TO postgres;

--
-- TOC entry 252 (class 1255 OID 26106)
-- Dependencies: 6 712
-- Name: inserir_laboratorio(character varying, character varying, character varying, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION inserir_laboratorio(nome character varying, telefone character varying, endereco character varying, municipio character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$

declare
		cod integer;
		
	begin
	begin
	insert into laboratorios(nome_laboratorio, telefone_laboratorio, endereco_laboratorio, municipio_laboratorio) VALUES
	( nome, telefone, endereco, municipio);
	Exception 
        When check_violation Then
                  raise exception 'Erro de entrada de dados!!';
	end;
	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;	

	end;
$$;


ALTER FUNCTION public.inserir_laboratorio(nome character varying, telefone character varying, endereco character varying, municipio character varying) OWNER TO postgres;

--
-- TOC entry 253 (class 1255 OID 26107)
-- Dependencies: 6 712
-- Name: inserir_med(character varying, numeric, integer, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION inserir_med(nome_remedio character varying, valor_remedio numeric, qtd_estoque integer, categoria_remedio character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	declare
		cod integer;
	begin
	insert into remedios( nome_remedio, valor_remedio, qtd_estoque, categoria_remedio) VALUES
	( nome_remedio, valor_remedio, qtd_estoque, categoria_remedio);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;	

	end;
$$;


ALTER FUNCTION public.inserir_med(nome_remedio character varying, valor_remedio numeric, qtd_estoque integer, categoria_remedio character varying) OWNER TO postgres;

--
-- TOC entry 254 (class 1255 OID 26108)
-- Dependencies: 712 6
-- Name: inserir_medicacao(integer, integer, character varying, character varying, numeric); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION inserir_medicacao(cod_trat integer, cod_rem integer, qtd character varying, cod_resp character varying, valor numeric) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	declare
		cod integer;
	begin
	insert into medicacao( cod_tratamento_fk, cod_remedio_fk, qtd_aplicada, responsavel_medicacao, valor) VALUES
	( cod_trat,  cod_rem, qtd, cod_resp, valor);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;	

	end;
$$;


ALTER FUNCTION public.inserir_medicacao(cod_trat integer, cod_rem integer, qtd character varying, cod_resp character varying, valor numeric) OWNER TO postgres;

--
-- TOC entry 255 (class 1255 OID 26109)
-- Dependencies: 6 712
-- Name: inserir_medvet(character varying, character varying, character varying, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION inserir_medvet(nomemedico character varying, especialidade character varying, crmv character varying, telefone character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	declare
		cod integer;
	begin
	begin
	insert into medico_veterinario(nome_medico_veterinario, especialidade_veterinario, crmv_veterinario, telefone_veterinario) VALUES
	(nomemedico, especialidade, crmv, telefone);
	Exception 
        When check_violation Then
                  raise exception 'Erro de entrada de dados!!';
	end;
	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;	

	end;
$$;


ALTER FUNCTION public.inserir_medvet(nomemedico character varying, especialidade character varying, crmv character varying, telefone character varying) OWNER TO postgres;

--
-- TOC entry 256 (class 1255 OID 26110)
-- Dependencies: 6 712
-- Name: inserir_paciente(integer, character varying, character varying, character varying, date, character varying, character, character, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION inserir_paciente(codclientefk integer, rghvpaciente character varying, especiepaciente character varying, racapaciente character varying, nascimentopaciente date, pelagempaciente character varying, sexopaciente character, pacientecadastrado character, nomepaciente character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	declare
		cod integer;
	begin
	begin
		insert into paciente (cod_cliente_fk, rghv_paciente, especie_paciente, raca_paciente, nascimento_paciente, pelagem_paciente, 
		sexo_paciente, paciente_castrado, nome_paciente) values (codclientefk, rghvpaciente, especiepaciente, racapaciente, 
		nascimentopaciente, pelagempaciente, sexopaciente, pacientecadastrado, nomepaciente);
	Exception 
        When check_violation Then
                  raise exception 'Erro de entrada de dados!!';
	end;
		GET DIAGNOSTICS cod = RESULT_OID;
		return cod;

	end;
$$;


ALTER FUNCTION public.inserir_paciente(codclientefk integer, rghvpaciente character varying, especiepaciente character varying, racapaciente character varying, nascimentopaciente date, pelagempaciente character varying, sexopaciente character, pacientecadastrado character, nomepaciente character varying) OWNER TO postgres;

--
-- TOC entry 257 (class 1255 OID 26111)
-- Dependencies: 6 712
-- Name: inserir_remedio(character varying, numeric, integer, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION inserir_remedio(nome character varying, valor numeric, estoque integer, categoria character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$

	declare 
		cod integer;
	begin
		insert into remedios(nome_remedio,
		valor_remedio, qtd_estoque, 
		categoria_remedio) values (nome,
		valor, estoque, categoria);

		GET DIAGNOSTICS cod = RESULT_OID;
		return cod;

	end;

$$;


ALTER FUNCTION public.inserir_remedio(nome character varying, valor numeric, estoque integer, categoria character varying) OWNER TO postgres;

--
-- TOC entry 258 (class 1255 OID 26112)
-- Dependencies: 6 712
-- Name: inserir_tipoconsulta(numeric); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION inserir_tipoconsulta(valorconsulta numeric) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	declare
		cod integer;
	begin
		insert into tipo_consulta(valor_consulta) VALUES (valorconsulta);
		GET DIAGNOSTICS cod = RESULT_OID;

		return cod;
	end;
$$;


ALTER FUNCTION public.inserir_tipoconsulta(valorconsulta numeric) OWNER TO postgres;

--
-- TOC entry 259 (class 1255 OID 26113)
-- Dependencies: 712 6
-- Name: inserir_tratamento(character varying, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION inserir_tratamento(nome character varying, consulta integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$

declare
		cod integer;
		
	begin
	insert into tratamento(descricao_tratamento, cod_consulta_fk) VALUES
	(nome, consulta);

	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;	

	end;
$$;


ALTER FUNCTION public.inserir_tratamento(nome character varying, consulta integer) OWNER TO postgres;

--
-- TOC entry 245 (class 1255 OID 26114)
-- Dependencies: 712 6
-- Name: inserir_tratamento(character varying, integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION inserir_tratamento(nome character varying, paciente integer, medico integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$

declare
		cod integer;
		
	begin
	insert into tratamento(descricao_tratamento, cod_paciente_fk, cod_veterinario_fk) VALUES
	( nome, paciente, medico);

	GET DIAGNOSTICS cod = RESULT_OID;
	return COD;	

	end;
$$;


ALTER FUNCTION public.inserir_tratamento(nome character varying, paciente integer, medico integer) OWNER TO postgres;

--
-- TOC entry 260 (class 1255 OID 26115)
-- Dependencies: 6 712
-- Name: inserir_usuario(character varying, character varying, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION inserir_usuario(nome character varying, login_usu character varying, senha_usu character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	declare
		cod integer;
	begin
	insert into usuario(nome_usuario, login, senha) VALUES (nome, login_usu, senha_usu);
	GET DIAGNOSTICS cod = RESULT_OID;
	return cod;
	
	end;
$$;


ALTER FUNCTION public.inserir_usuario(nome character varying, login_usu character varying, senha_usu character varying) OWNER TO postgres;

--
-- TOC entry 261 (class 1255 OID 26116)
-- Dependencies: 6 712
-- Name: pagar_conta(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION pagar_conta(codcusto integer) RETURNS character varying
    LANGUAGE plpgsql
    AS $$

begin 
	delete from custos where cod_custo = codcusto;

	return "Efetuado baixa no sistema";
end;

$$;


ALTER FUNCTION public.pagar_conta(codcusto integer) OWNER TO postgres;

--
-- TOC entry 262 (class 1255 OID 26117)
-- Dependencies: 712 6
-- Name: receber_dados_cirurgiainternacao(integer, integer, integer, character varying, character varying, character varying, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION receber_dados_cirurgiainternacao(verificar integer, tratamento integer, cirurgia integer, descricao character varying, datacirurgia character varying, horacirurgia character varying, valor character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$

begin
	if(verificar = 0) then
		return (select inserir_cirurgiainternacao(tratamento, cirurgia, descricao,
		datacirurgia, horacirurgia, valor));
	else
		return (select atualizar_cirurgiainternacao(verificar, tratamento, cirurgia,
		descricao, datacirurgia, horacirurgia, valor));
	end if;
	if check_violation then
		raise exception 'violacao';
	end if;
	
end;

$$;


ALTER FUNCTION public.receber_dados_cirurgiainternacao(verificar integer, tratamento integer, cirurgia integer, descricao character varying, datacirurgia character varying, horacirurgia character varying, valor character varying) OWNER TO postgres;

--
-- TOC entry 263 (class 1255 OID 26118)
-- Dependencies: 6 712
-- Name: receber_dadoscirurgia(character varying, integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION receber_dadoscirurgia(nome character varying, medico integer, verificar integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin		

		if (verificar = 0) then
			return (select inserir_cirurgia(nome, medico));
		else 
			return (select atualizar_cirurgia(nome, medico, verificar));
	
		end if;

	end;
 $$;


ALTER FUNCTION public.receber_dadoscirurgia(nome character varying, medico integer, verificar integer) OWNER TO postgres;

--
-- TOC entry 264 (class 1255 OID 26119)
-- Dependencies: 712 6
-- Name: receber_dadoscliente(character varying, date, character varying, character varying, character, character varying, character varying, character, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION receber_dadoscliente(nomecliente character varying, datanascimentocliente date, enderecocliente character varying, rgcliente character varying, telefone character, expeditorrg character varying, municipiocliente character varying, cpfcliente character, verificar integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin		
		
		if (verificar = 0) then
			return (select inserir_cliente(nomecliente, datanascimentocliente, enderecocliente, rgcliente, telefone, expeditorrg,
				municipiocliente, cpfcliente));
		        
		else 
			return (select atualizar_cliente(nomecliente, datanascimentocliente, enderecocliente, rgcliente, telefone, expeditorrg,
				municipiocliente, cpfcliente, verificar));
		end if;

		
		
	end;
 $$;


ALTER FUNCTION public.receber_dadoscliente(nomecliente character varying, datanascimentocliente date, enderecocliente character varying, rgcliente character varying, telefone character, expeditorrg character varying, municipiocliente character varying, cpfcliente character, verificar integer) OWNER TO postgres;

--
-- TOC entry 265 (class 1255 OID 26120)
-- Dependencies: 712 6
-- Name: receber_dadosconsulta(integer, date, time without time zone, integer, integer, character, integer, text); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION receber_dadosconsulta(verificar integer, dataconsulta date, horaconsulta time without time zone, medicoveterinario integer, codigotipo integer, agendamento character, paciente integer, prontuario text) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin
		if (verificar = 0) then
			return (select inserir_consulta(dataconsulta, horaconsulta, medicoveterinario, codigotipo, agendamento, paciente, prontuario));
		else
			return (select atualizar_consulta(verificar, dataconsulta, horaconsulta, medicoveterinario, codigotipo, agendamento, paciente, prontuario));
		end if;

	end;
$$;


ALTER FUNCTION public.receber_dadosconsulta(verificar integer, dataconsulta date, horaconsulta time without time zone, medicoveterinario integer, codigotipo integer, agendamento character, paciente integer, prontuario text) OWNER TO postgres;

--
-- TOC entry 266 (class 1255 OID 26121)
-- Dependencies: 6 712
-- Name: receber_dadoscustos(integer, integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION receber_dadoscustos(verificar integer, codconsulta integer, codtipo integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
begin
	if (verificar = 0) then
		return (select inserir_custos(codconsulta, (select valor_consulta from tipo_consulta where cod_tipo_consulta = codtipo)));
	else
		return (select atualizar_custos(verificar, codconsulta, (select valor_consulta from tipo_consulta where cod_tipo_consulta = codtipo)));
	end if;	
end;
$$;


ALTER FUNCTION public.receber_dadoscustos(verificar integer, codconsulta integer, codtipo integer) OWNER TO postgres;

--
-- TOC entry 267 (class 1255 OID 26122)
-- Dependencies: 6 712
-- Name: receber_dadosexame(character varying, integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION receber_dadosexame(nome character varying, laboratorio integer, verificar integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin		

		if (verificar = 0) then
			return (select inserir_exame(nome, laboratorio));
		else 
			return (select atualizar_exame(nome, laboratorio, verificar));
	
		end if;

	end;
 $$;


ALTER FUNCTION public.receber_dadosexame(nome character varying, laboratorio integer, verificar integer) OWNER TO postgres;

--
-- TOC entry 268 (class 1255 OID 26123)
-- Dependencies: 712 6
-- Name: receber_dadosexame(character varying, integer, character varying, numeric, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION receber_dadosexame(nome character varying, laboratorio integer, descricao character varying, valor numeric, verificar integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin		

		if (verificar = 0) then
			return (select inserir_exame(nome, laboratorio, descricao, valor));
		else 
			return (select atualizar_exame(nome, laboratorio, descricao, valor, verificar));
	
		end if;

	end;
 $$;


ALTER FUNCTION public.receber_dadosexame(nome character varying, laboratorio integer, descricao character varying, valor numeric, verificar integer) OWNER TO postgres;

--
-- TOC entry 269 (class 1255 OID 26124)
-- Dependencies: 6 712
-- Name: receber_dadoslaboratoriais(integer, integer, integer, text, character varying, numeric); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION receber_dadoslaboratoriais(verificar integer, tratamento integer, exame integer, descricao text, responsavel character varying, valor numeric) RETURNS integer
    LANGUAGE plpgsql
    AS $$

begin
	if(verificar = 0) then
		return(select inserir_exame(tratamento, exame, descricao, responsavel, valor));
	else
		return(select atualizar_exame(verificar, tratamento, exame, descricao, responsavel, valor));
	end if;
end;

$$;


ALTER FUNCTION public.receber_dadoslaboratoriais(verificar integer, tratamento integer, exame integer, descricao text, responsavel character varying, valor numeric) OWNER TO postgres;

--
-- TOC entry 270 (class 1255 OID 26125)
-- Dependencies: 6 712
-- Name: receber_dadoslaboratorio(character varying, character varying, character varying, character varying, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION receber_dadoslaboratorio(nome character varying, telefone character varying, endereco character varying, municipio character varying, verificar integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin		

		if (verificar = 0) then
			return (select inserir_laboratorio(nome, telefone, endereco, municipio));
		else 
			return (select atualizar_laboratorio(nome, telefone, endereco, municipio, verificar));
	
		end if;

	end;
 $$;


ALTER FUNCTION public.receber_dadoslaboratorio(nome character varying, telefone character varying, endereco character varying, municipio character varying, verificar integer) OWNER TO postgres;

--
-- TOC entry 271 (class 1255 OID 26126)
-- Dependencies: 6 712
-- Name: receber_dadosmedicacao(integer, integer, character varying, character varying, numeric, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION receber_dadosmedicacao(cod_trat integer, cod_rem integer, qtd character varying, cod_resp character varying, valor_remedio numeric, verificar integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin
		if (verificar = 0) then
			return (select inserir_medicacao(cod_trat, cod_rem, qtd, cod_resp, valor_remedio));
		else
			return (select atualizar_medicacao(cod_trat, cod_rem, qtd, cod_resp, valor_remedio, verificar));
		end if;
	end;
$$;


ALTER FUNCTION public.receber_dadosmedicacao(cod_trat integer, cod_rem integer, qtd character varying, cod_resp character varying, valor_remedio numeric, verificar integer) OWNER TO postgres;

--
-- TOC entry 272 (class 1255 OID 26127)
-- Dependencies: 6 712
-- Name: receber_dadosmedicamento(character varying, numeric, integer, character varying, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION receber_dadosmedicamento(nome_remedio character varying, valor_remedio numeric, qtd_estoque integer, categoria_remedio character varying, verificar integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin
		if (verificar = 0) then
			return (select inserir_med(nome_remedio, valor_remedio, qtd_estoque, categoria_remedio));
		else
			return (select atualizar_med(verificar, nome_remedio, valor_remedio, qtd_estoque, categoria_remedio));
		end if;
	end;
$$;


ALTER FUNCTION public.receber_dadosmedicamento(nome_remedio character varying, valor_remedio numeric, qtd_estoque integer, categoria_remedio character varying, verificar integer) OWNER TO postgres;

--
-- TOC entry 273 (class 1255 OID 26128)
-- Dependencies: 6 712
-- Name: receber_dadosmedico(character varying, character varying, character varying, character varying, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION receber_dadosmedico(nomemedico character varying, especialidade character varying, crmv character varying, telefone character varying, verificar integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin
		if (verificar = 0) then
			return (select inserir_medVet(nomemedico, especialidade, crmv, telefone));
		else
			return (select atualizar_medVet(verificar, nomemedico, especialidade, crmv, telefone));
		end if;
	end;
$$;


ALTER FUNCTION public.receber_dadosmedico(nomemedico character varying, especialidade character varying, crmv character varying, telefone character varying, verificar integer) OWNER TO postgres;

--
-- TOC entry 275 (class 1255 OID 26129)
-- Dependencies: 6 712
-- Name: receber_dadospaciente(integer, character varying, character varying, character varying, date, character varying, character, character, character varying, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION receber_dadospaciente(codclientefk integer, rghvpaciente character varying, especiepaciente character varying, racapaciente character varying, nascimentopaciente date, pelagempaciente character varying, sexopaciente character, pacientecadastrado character, nomepaciente character varying, verificar integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin
		if (verificar = 0) then
			return (select inserir_paciente(codclientefk, rghvpaciente, especiepaciente, racapaciente, nascimentopaciente,	pelagempaciente,
			sexopaciente, pacientecadastrado, nomepaciente));
		else
			return (select atualizar_paciente(codclientefk, rghvpaciente, especiepaciente, racapaciente, nascimentopaciente,	pelagempaciente,
			sexopaciente, pacientecadastrado, nomepaciente, verificar));
		end if;
	end;
$$;


ALTER FUNCTION public.receber_dadospaciente(codclientefk integer, rghvpaciente character varying, especiepaciente character varying, racapaciente character varying, nascimentopaciente date, pelagempaciente character varying, sexopaciente character, pacientecadastrado character, nomepaciente character varying, verificar integer) OWNER TO postgres;

--
-- TOC entry 276 (class 1255 OID 26130)
-- Dependencies: 6 712
-- Name: receber_dadosremedio(character varying, numeric, integer, character varying, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION receber_dadosremedio(nome character varying, valor numeric, estoque integer, categoria character varying, verificar integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin
		if(verificar = 0) then
			return(select inserir_remedio(nome, valor, estoque, categoria));
		else
			return(select atualizar_remedio(nome, valor, estoque, categoria, verificar));
		end if;
	end;
$$;


ALTER FUNCTION public.receber_dadosremedio(nome character varying, valor numeric, estoque integer, categoria character varying, verificar integer) OWNER TO postgres;

--
-- TOC entry 277 (class 1255 OID 26131)
-- Dependencies: 6 712
-- Name: receber_dadostipoconsulta(integer, numeric); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION receber_dadostipoconsulta(verificar integer, valorconsulta numeric) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin
		if (verificar = 0) then
			return (select inserir_tipoConsulta(valorconsulta));
		else
			return (select atualizar_tipoConsulta(verificar, valorconsulta));
		end if;
	end;
$$;


ALTER FUNCTION public.receber_dadostipoconsulta(verificar integer, valorconsulta numeric) OWNER TO postgres;

--
-- TOC entry 278 (class 1255 OID 26132)
-- Dependencies: 6 712
-- Name: receber_dadostratamento(character varying, integer, integer, integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION receber_dadostratamento(nome character varying, pac integer, medico integer, verificar integer) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin		

		if (verificar = 0) then
			return (select inserir_tratamento(nome, pac, medico));
		else 
			return (select atualizar_tratamento(nome, pac, medico, verificar));
	
		end if;

	end;
 $$;


ALTER FUNCTION public.receber_dadostratamento(nome character varying, pac integer, medico integer, verificar integer) OWNER TO postgres;

--
-- TOC entry 279 (class 1255 OID 26133)
-- Dependencies: 6 712
-- Name: receber_dadosusuario(integer, character varying, character varying, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION receber_dadosusuario(verificar integer, nomeusuario character varying, login character varying, senha character varying) RETURNS integer
    LANGUAGE plpgsql
    AS $$
	begin
		if (verificar = 0) then
			return (select inserir_usuario(nomeusuario, login, senha));
		else
			return (select atualizar_usuario(verificar, nomeusuario, login, senha));
		end if;
	end;
$$;


ALTER FUNCTION public.receber_dadosusuario(verificar integer, nomeusuario character varying, login character varying, senha character varying) OWNER TO postgres;

--
-- TOC entry 280 (class 1255 OID 26134)
-- Dependencies: 6 712
-- Name: ret(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION ret() RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_consulta, data_consulta, hora_consutla, nome_medico_veterinario, descricao_tipo_cconsulta, agendado, nome_paciente, prontuario_paciente  FROM consulta inner join paciente on cod_paciente_fk = cod_paciente inner join medico_veterinario on cod_medico_veterinario_fk = codigo_medico_vet_pk inner join tipo_consulta on cod_tipo_consulta_fk = cod_tipo_consulta where cod_cliente =cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 

END;
$$;


ALTER FUNCTION public.ret() OWNER TO postgres;

--
-- TOC entry 281 (class 1255 OID 26135)
-- Dependencies: 6 712
-- Name: ret(date); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION ret(cod date) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_consulta FROM consulta where data_consulta = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 

END;
$$;


ALTER FUNCTION public.ret(cod date) OWNER TO postgres;

--
-- TOC entry 282 (class 1255 OID 26136)
-- Dependencies: 6 712
-- Name: ret(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION ret(cod integer) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_consulta, data_consulta, hora_consutla, nome_medico_veterinario, descricao_tipo_cconsulta, agendado, nome_paciente, prontuario_paciente  FROM consulta inner join paciente on cod_paciente_fk = cod_paciente inner join medico_veterinario on cod_medico_veterinario_fk = codigo_medico_vet_pk inner join tipo_consulta on cod_tipo_consulta_fk = cod_tipo_consulta where cod_cliente_fk =cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 

END;
$$;


ALTER FUNCTION public.ret(cod integer) OWNER TO postgres;

--
-- TOC entry 283 (class 1255 OID 26137)
-- Dependencies: 6 712
-- Name: retorna_usuario(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retorna_usuario() RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_usuario, nome_usuario, login, senha FROM usuario
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retorna_usuario() OWNER TO postgres;

--
-- TOC entry 284 (class 1255 OID 26138)
-- Dependencies: 712 6
-- Name: retorna_usuario(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retorna_usuario(nomeusu character varying) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_usuario, nome_usuario, login, senha FROM usuario WHERE nome_usuario = nomeusu
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retorna_usuario(nomeusu character varying) OWNER TO postgres;

--
-- TOC entry 285 (class 1255 OID 26139)
-- Dependencies: 6 712
-- Name: retorna_usuario(character varying, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retorna_usuario(loginusu character varying, senhausu character varying) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_usuario, nome_usuario, login, senha FROM usuario WHERE login = loginusu and senha = senhausu
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retorna_usuario(loginusu character varying, senhausu character varying) OWNER TO postgres;

--
-- TOC entry 286 (class 1255 OID 26140)
-- Dependencies: 6 712
-- Name: retornacirurgia(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornacirurgia() RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_cirurgia_pk, descricao_cirurgia, nome_medico_veterinario  FROM cirurgia inner join medico_veterinario on medico_veterinario_FK = codigo_medico_vet_pk
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornacirurgia() OWNER TO postgres;

--
-- TOC entry 287 (class 1255 OID 26141)
-- Dependencies: 6 712
-- Name: retornacirurgia(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornacirurgia(cod integer) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_cirurgia_pk, descricao_cirurgia, nome_medico_veterinario  FROM cirurgia inner join medico_veterinario on medico_veterinario_FK = codigo_medico_vet_pk WHERE cod_cirurgia_pk = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 

 
END;
$$;


ALTER FUNCTION public.retornacirurgia(cod integer) OWNER TO postgres;

--
-- TOC entry 288 (class 1255 OID 26142)
-- Dependencies: 6 712
-- Name: retornacirurgia(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornacirurgia(cod character varying) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_cirurgia_pk, descricao_cirurgia, nome_medico_veterinario  FROM cirurgia inner join medico_veterinario on medico_veterinario_FK = codigo_medico_vet_pk WHERE descricao_cirurgia like cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
END;
$$;


ALTER FUNCTION public.retornacirurgia(cod character varying) OWNER TO postgres;

--
-- TOC entry 289 (class 1255 OID 26143)
-- Dependencies: 6 712
-- Name: retornacirurgiaintern(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornacirurgiaintern() RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT ci.cod_cirurgia_intern, p.nome_paciente, T.descricao_tratamento, ci.descricao_procedimento, ci.data_cirurgia, ci.horario_cirurgia, ci.valor_cirurgia from paciente p inner join tratamento t on p.cod_paciente = t.cod_paciente_fk inner join cirurgia_enternacao ci on t.cod_tratamento_pk = ci.cod_tratamento_fk inner join cirurgia c on c.cod_cirurgia_pk = ci.cod_cirurgia_fk 
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornacirurgiaintern() OWNER TO postgres;

--
-- TOC entry 290 (class 1255 OID 26144)
-- Dependencies: 6 712
-- Name: retornacirurgiaintern(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornacirurgiaintern(cod integer) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT ci.cod_cirurgia_intern, p.nome_paciente, T.descricao_tratamento, ci.descricao_procedimento, ci.data_cirurgia, ci.horario_cirurgia, ci.valor_cirurgia from paciente p inner join tratamento t on p.cod_paciente = t.cod_paciente_fk inner join cirurgia_enternacao ci on t.cod_tratamento_pk = ci.cod_tratamento_fk inner join cirurgia c on c.cod_cirurgia_pk = ci.cod_cirurgia_fk where p.cod_paciente =cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornacirurgiaintern(cod integer) OWNER TO postgres;

--
-- TOC entry 291 (class 1255 OID 26145)
-- Dependencies: 6 712
-- Name: retornacirurgiainternacao(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornacirurgiainternacao(cod integer) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT ci.cod_cirurgia_intern, p.nome_paciente, T.descricao_tratamento, ci.descricao_procedimento, ci.data_cirurgia, ci.horario_cirurgia, ci.valor_cirurgia from paciente p inner join tratamento t on p.cod_paciente = t.cod_paciente_fk inner join cirurgia_enternacao ci on t.cod_tratamento_pk = ci.cod_tratamento_fk inner join cirurgia c on c.cod_cirurgia_pk = ci.cod_cirurgia_fk where p.cod_cirurgia_intern =cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornacirurgiainternacao(cod integer) OWNER TO postgres;

--
-- TOC entry 292 (class 1255 OID 26146)
-- Dependencies: 6 712
-- Name: retornacli(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornacli() RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_cliente, nome_cliente, data_nascimeto_cliente, endereco_cliente, rg_cliente, telefone_cliente,exxpedidor_rg_cliente, municipio_cliente, cpf_cliente FROM cliente
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornacli() OWNER TO postgres;

--
-- TOC entry 293 (class 1255 OID 26147)
-- Dependencies: 6 712
-- Name: retornacli(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornacli(cod character varying) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_cliente, nome_cliente, data_nascimeto_cliente, endereco_cliente, rg_cliente, telefone_cliente,exxpedidor_rg_cliente, municipio_cliente, cpf_cliente FROM cliente where nome_cliente like cod
  
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornacli(cod character varying) OWNER TO postgres;

--
-- TOC entry 294 (class 1255 OID 26148)
-- Dependencies: 6 712
-- Name: retornacli(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornacli(cod integer) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_cliente, nome_cliente, data_nascimeto_cliente, endereco_cliente, rg_cliente, telefone_cliente,exxpedidor_rg_cliente, municipio_cliente, cpf_cliente FROM cliente WHERE cod_cliente = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornacli(cod integer) OWNER TO postgres;

--
-- TOC entry 295 (class 1255 OID 26149)
-- Dependencies: 712 6
-- Name: retornaconsulta(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornaconsulta() RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_consulta, data_consulta, hora_consutla, nome_medico_veterinario, descricao_tipo_cconsulta, agendado, nome_paciente, prontuario_paciente  FROM consulta inner join paciente on cod_paciente_fk = cod_paciente inner join medico_veterinario on cod_medico_veterinario_fk = codigo_medico_vet_pk inner join tipo_consulta on cod_tipo_consulta_fk = cod_tipo_consulta
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 

END;
$$;


ALTER FUNCTION public.retornaconsulta() OWNER TO postgres;

--
-- TOC entry 296 (class 1255 OID 26150)
-- Dependencies: 712 6
-- Name: retornaconsulta(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornaconsulta(cod character varying) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_consulta, data_consulta, hora_consutla, nome_medico_veterinario, descricao_tipo_cconsulta, agendado, nome_paciente, prontuario_paciente  FROM consulta inner join paciente on cod_paciente_fk = cod_paciente inner join medico_veterinario on cod_medico_veterinario_fk = codigo_medico_vet_pk inner join tipo_consulta on cod_tipo_consulta_fk = cod_tipo_consulta where nome_paciente like cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornaconsulta(cod character varying) OWNER TO postgres;

--
-- TOC entry 297 (class 1255 OID 26151)
-- Dependencies: 6 712
-- Name: retornaconsulta(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornaconsulta(cod integer) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_consulta, data_consulta, hora_consutla, nome_medico_veterinario, descricao_tipo_cconsulta, agendado, nome_paciente, prontuario_paciente  FROM consulta inner join paciente on cod_paciente_fk = cod_paciente inner join medico_veterinario on cod_medico_veterinario_fk = codigo_medico_vet_pk inner join tipo_consulta on cod_tipo_consulta_fk = cod_tipo_consulta where cod_consulta = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 

 
END;
$$;


ALTER FUNCTION public.retornaconsulta(cod integer) OWNER TO postgres;

--
-- TOC entry 298 (class 1255 OID 26152)
-- Dependencies: 6 712
-- Name: retornaconsultaconta(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornaconsultaconta(cod integer) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT c.cod_consulta, c.data_consulta FROM consulta c  inner join paciente p on c.cod_paciente_fk = p.cod_paciente inner join cliente cli on cli.cod_cliente= p.cod_cliente_fk where cli.cod_cliente =cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 

 
END;
$$;


ALTER FUNCTION public.retornaconsultaconta(cod integer) OWNER TO postgres;

--
-- TOC entry 299 (class 1255 OID 26153)
-- Dependencies: 712 6
-- Name: retornaconta(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornaconta() RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod,nome_cliente,descricao_tratamento,valor_total,data_pago  FROM custos inner join cliente on cod_cliente_fk = cod_cliente inner join tratamento on cod_tratamento_fk = cod_tratamento_pk 
    LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 END;
$$;


ALTER FUNCTION public.retornaconta() OWNER TO postgres;

--
-- TOC entry 300 (class 1255 OID 26154)
-- Dependencies: 6 712
-- Name: retornaconta(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornaconta(codigo integer) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod,nome_cliente,descricao_tratamento,valor_total,data_pago  FROM custos inner join cliente on cod_cliente_fk = cod_cliente inner join tratamento on cod_tratamento_fk = cod_tratamento_pk where cod = codigo
    LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 END;
$$;


ALTER FUNCTION public.retornaconta(codigo integer) OWNER TO postgres;

--
-- TOC entry 301 (class 1255 OID 26155)
-- Dependencies: 6 712
-- Name: retornaconta(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornaconta(codigo character varying) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod,nome_cliente,descricao_tratamento,valor_total,data_pago  FROM custos inner join cliente on cod_cliente_fk = cod_cliente inner join tratamento on cod_tratamento_fk = cod_tratamento_pk where nome_cliente like codigo
    LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 END;
$$;


ALTER FUNCTION public.retornaconta(codigo character varying) OWNER TO postgres;

--
-- TOC entry 302 (class 1255 OID 26156)
-- Dependencies: 6 712
-- Name: retornacustos(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornacustos() RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN 
  -- Vamos criar o LOOP para retornar a execução da query na tabela
  FOR RESU IN SELECT cod,nome_cliente,data_consulta,valor_total,data_pago  FROM custos inner join cliente on cod_cliente_fk = cod_cliente inner join consulta on cod_consulta_fk = cod_consulta 
    LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 END;
$$;


ALTER FUNCTION public.retornacustos() OWNER TO postgres;

--
-- TOC entry 303 (class 1255 OID 26157)
-- Dependencies: 6 712
-- Name: retornacustos(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornacustos(codigo integer) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN 
  -- Vamos criar o LOOP para retornar a execução da query na tabela
  FOR RESU IN SELECT cod,nome_cliente,data_consulta,valor_total,data_pago  FROM custos inner join cliente on cod_cliente_fk = cod_cliente inner join consulta on cod_consulta_fk = cod_consulta WHERE cod = codigo
    LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 END;
$$;


ALTER FUNCTION public.retornacustos(codigo integer) OWNER TO postgres;

--
-- TOC entry 304 (class 1255 OID 26158)
-- Dependencies: 6 712
-- Name: retornadados(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornadados(cod integer) RETURNS refcursor
    LANGUAGE plpgsql
    AS $$

 DECLARE resultado refcursor;
 reg record;
BEGIN
		OPEN resultado FOR
			SELECT cod_consulta from consulta where cod_paciente_fk = (SELECT cod_paciente FROM paciente inner join cliente on cod_cliente = cod_cliente_fk where cod_cliente =96);
	FETCH resultado INTO reg;
	RETURN reg;
END;
$$;


ALTER FUNCTION public.retornadados(cod integer) OWNER TO postgres;

--
-- TOC entry 305 (class 1255 OID 26159)
-- Dependencies: 6 712
-- Name: retornaexame(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornaexame() RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT  cod_exame_pk, tipo_exame, nome_laboratorio FROM exame inner join laboratorios on cod_laboratorio_fk =cod_laboratorio_pk
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornaexame() OWNER TO postgres;

--
-- TOC entry 306 (class 1255 OID 26160)
-- Dependencies: 6 712
-- Name: retornaexame(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornaexame(cod integer) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_exame_pk, tipo_exame, nome_laboratorio FROM exame inner join laboratorios on cod_laboratorio_fk =cod_laboratorio_pk where cod_exame_pk = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;

 
END;
$$;


ALTER FUNCTION public.retornaexame(cod integer) OWNER TO postgres;

--
-- TOC entry 307 (class 1255 OID 26161)
-- Dependencies: 6 712
-- Name: retornaexame(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornaexame(cod character varying) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_exame_pk, tipo_exame, nome_laboratorio FROM exame inner join laboratorios on cod_laboratorio_fk =cod_laboratorio_pk where tipo_exame = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;

 
END;
$$;


ALTER FUNCTION public.retornaexame(cod character varying) OWNER TO postgres;

--
-- TOC entry 308 (class 1255 OID 26162)
-- Dependencies: 6 712
-- Name: retornaexamelabo(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornaexamelabo() RETURNS SETOF refcursor
    LANGUAGE plpgsql
    AS $$
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
$$;


ALTER FUNCTION public.retornaexamelabo() OWNER TO postgres;

--
-- TOC entry 309 (class 1255 OID 26163)
-- Dependencies: 6 712
-- Name: retornaexamelabo(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornaexamelabo(codigo character varying) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT  descricao_tratamento, tipo_exame, descricao_exame, responsavel_exame,valor FROM laboratoriais inner join tratamento on cod_tratamento_pk = cod_tratameto_fk inner join exame on cod_exame_fk =cod_exame_pk where tipo_exame like codigo
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornaexamelabo(codigo character varying) OWNER TO postgres;

--
-- TOC entry 310 (class 1255 OID 26164)
-- Dependencies: 6 712
-- Name: retornaexamelabo(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornaexamelabo(cod integer) RETURNS SETOF refcursor
    LANGUAGE plpgsql
    AS $$
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
$$;


ALTER FUNCTION public.retornaexamelabo(cod integer) OWNER TO postgres;

--
-- TOC entry 311 (class 1255 OID 26165)
-- Dependencies: 6 712
-- Name: retornaexamelaboratorial(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornaexamelaboratorial() RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT p.nome_paciente, e.tipo_exame, l.descricao_exame, l.responsavel_exame, l.valor from paciente p inner join tratamento t on p.cod_paciente = t.cod_paciente_fk inner join laboratoriais l on t.cod_tratamento_pk = l.cod_tratameto_fk inner join exame e on e.cod_exame_pk = l.cod_exame_fk
 	  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornaexamelaboratorial() OWNER TO postgres;

--
-- TOC entry 312 (class 1255 OID 26166)
-- Dependencies: 6 712
-- Name: retornaexamelabotext(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornaexamelabotext() RETURNS SETOF refcursor
    LANGUAGE plpgsql
    AS $$

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
$$;


ALTER FUNCTION public.retornaexamelabotext() OWNER TO postgres;

--
-- TOC entry 313 (class 1255 OID 26167)
-- Dependencies: 6 712
-- Name: retornalab(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornalab() RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_laboratorio_pk, nome_laboratorio, telefone_laboratorio, endereco_laboratorio,municipio_laboratorio FROM laboratorios
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornalab() OWNER TO postgres;

--
-- TOC entry 314 (class 1255 OID 26168)
-- Dependencies: 6 712
-- Name: retornalab(character); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornalab(cod character) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_laboratorio_pk, nome_laboratorio, telefone_laboratorio, endereco_laboratorio,municipio_laboratorio FROM laboratorios where nome_laboratorio like cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornalab(cod character) OWNER TO postgres;

--
-- TOC entry 315 (class 1255 OID 26169)
-- Dependencies: 712 6
-- Name: retornalab(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornalab(cod integer) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_laboratorio_pk, nome_laboratorio, telefone_laboratorio, endereco_laboratorio,municipio_laboratorio FROM laboratorios where cod_laboratorio_pk	= cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornalab(cod integer) OWNER TO postgres;

--
-- TOC entry 316 (class 1255 OID 26170)
-- Dependencies: 6 712
-- Name: retornamed(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornamed() RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT codigo_medico_vet_pk, nome_medico_veterinario, especialidade_veterinario, crmv_veterinario,telefone_veterinario FROM medico_veterinario
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornamed() OWNER TO postgres;

--
-- TOC entry 317 (class 1255 OID 26171)
-- Dependencies: 6 712
-- Name: retornamed(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornamed(cod integer) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_medicacao, codigo_medico_vet_pk, nome_medico_veterinario, especialidade_veterinario, crmv_veterinario,telefone_veterinario FROM medico_veterinario where codigo_medico_vet_pk = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornamed(cod integer) OWNER TO postgres;

--
-- TOC entry 318 (class 1255 OID 26172)
-- Dependencies: 6 712
-- Name: retornamed(character); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornamed(cod character) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT codigo_medico_vet_pk, nome_medico_veterinario, especialidade_veterinario, crmv_veterinario,telefone_veterinario FROM medico_veterinario where nome_medico_veterinario like cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornamed(cod character) OWNER TO postgres;

--
-- TOC entry 319 (class 1255 OID 26173)
-- Dependencies: 6 712
-- Name: retornamedicacao(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornamedicacao() RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro;
  FOR RESU IN SELECT m.cod_medicacao, p.nome_paciente, m.cod_tratamento_fk, r.nome_remedio, qtd_aplicada, m.responsavel_medicacao, m.valor FROM paciente p inner join tratamento t on p.cod_paciente = t.cod_paciente_fk inner join medicacao m on t.cod_tratamento_pk = m.cod_tratamento_fk inner join remedios r on r.cod_remedio = m.cod_remedio_fk 
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornamedicacao() OWNER TO postgres;

--
-- TOC entry 320 (class 1255 OID 26174)
-- Dependencies: 6 712
-- Name: retornamedicacao(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornamedicacao(cod integer) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT  m.cod_medicacao, p.nome_paciente, m.cod_tratamento_fk, r.nome_remedio, qtd_aplicada, m.responsavel_medicacao, m.valor FROM paciente p inner join tratamento t on p.cod_paciente = t.cod_paciente_fk inner join medicacao m on t.cod_tratamento_pk = m.cod_tratamento_fk inner join remedios r on r.cod_remedio = m.cod_remedio_fk where m.cod_medicacao = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornamedicacao(cod integer) OWNER TO postgres;

--
-- TOC entry 321 (class 1255 OID 26175)
-- Dependencies: 6 712
-- Name: retornamedicacao(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornamedicacao(cod character varying) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN

  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_medicacao, cod_tratamento_fk, cod_remedio_fk, qtd_aplicada, responsavel_medicacao, valor FROM medicacao INNER JOIN tratamento on cod_tratamento_pk = cod_tratamento_fk where  descricao_tratamento = cod
   LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornamedicacao(cod character varying) OWNER TO postgres;

--
-- TOC entry 322 (class 1255 OID 26176)
-- Dependencies: 6 712
-- Name: retornamedicacao(text); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornamedicacao(cod text) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN

  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT descricao_tratamento, cod_remedio_fk, qtd_aplicada, responsavel_medicacao, valor FROM medicacao INNER JOIN tratamento on cod_tratamento_pk = cod_tratamento_fk where  descricao_tratamento = cod
   LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornamedicacao(cod text) OWNER TO postgres;

--
-- TOC entry 323 (class 1255 OID 26177)
-- Dependencies: 6 712
-- Name: retornamedicacao(character varying, character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornamedicacao(cod character varying, cod2 character varying) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN

  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT descricao_tratamento,nome_remedio, qtd_aplicada, responsavel_medicacao, valor FROM  remedios INNER JOIN medicacao ON cod_remedio = cod_remedio_fk INNER JOIN tratamento on cod_tratamento_pk = cod_tratamento_fk where  descricao_tratamento = COD and nome_remedio = COD2
 LOOP
    -- O retorno de cada linha
    RETURN;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornamedicacao(cod character varying, cod2 character varying) OWNER TO postgres;

--
-- TOC entry 324 (class 1255 OID 26178)
-- Dependencies: 6 712
-- Name: retornamedicacao2(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornamedicacao2(cod integer) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro;
  FOR RESU IN SELECT m.cod_medicacao, p.nome_paciente, m.cod_tratamento_fk, r.nome_remedio, qtd_aplicada, m.responsavel_medicacao, m.valor FROM paciente p inner join tratamento t on p.cod_paciente = t.cod_paciente_fk inner join medicacao m on t.cod_tratamento_pk = m.cod_tratamento_fk inner join remedios r on r.cod_remedio = m.cod_remedio_fk where p.cod_paciente = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornamedicacao2(cod integer) OWNER TO postgres;

--
-- TOC entry 325 (class 1255 OID 26179)
-- Dependencies: 6 712
-- Name: retornapac(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornapac() RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_paciente, nome_paciente, nascimento_paciente, rghv_paciente, especie_paciente, raca_paciente,pelagem_paciente, sexo_paciente, paciente_castrado, nome_cliente  FROM paciente inner join cliente on cod_cliente_fk = cod_cliente
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornapac() OWNER TO postgres;

--
-- TOC entry 326 (class 1255 OID 26180)
-- Dependencies: 6 712
-- Name: retornapac(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornapac(cod character varying) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_paciente, nome_paciente, nascimento_paciente, rghv_paciente, especie_paciente, raca_paciente,pelagem_paciente, sexo_paciente, paciente_castrado, nome_cliente  FROM paciente inner join cliente on cod_cliente_fk = cod_cliente WHERE nome_paciente like cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornapac(cod character varying) OWNER TO postgres;

--
-- TOC entry 327 (class 1255 OID 26181)
-- Dependencies: 712 6
-- Name: retornapac(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornapac(cod integer) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_paciente, nome_paciente, nascimento_paciente, rghv_paciente, especie_paciente, raca_paciente,pelagem_paciente, sexo_paciente, paciente_castrado, nome_cliente  FROM paciente inner join cliente on cod_cliente_fk = cod_cliente WHERE cod_paciente = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornapac(cod integer) OWNER TO postgres;

--
-- TOC entry 328 (class 1255 OID 26182)
-- Dependencies: 6 712
-- Name: retornapactrat(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornapactrat(cod integer) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
  FOR RESU IN SELECT cod_tratamento_pk,descricao_tratamento  FROM tratamento inner join paciente on cod_paciente = cod_paciente_fk WHERE cod_paciente = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornapactrat(cod integer) OWNER TO postgres;

--
-- TOC entry 329 (class 1255 OID 26183)
-- Dependencies: 712 6
-- Name: retornarem(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornarem() RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_remedio, nome_remedio, valor_remedio, qtd_estoque, categoria_remedio FROM remedios
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornarem() OWNER TO postgres;

--
-- TOC entry 330 (class 1255 OID 26184)
-- Dependencies: 6 712
-- Name: retornarem(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornarem(cod character varying) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_remedio, nome_remedio, valor_remedio, qtd_estoque, categoria_remedio FROM remedios where nome_remedio like cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornarem(cod character varying) OWNER TO postgres;

--
-- TOC entry 331 (class 1255 OID 26185)
-- Dependencies: 712 6
-- Name: retornarem(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornarem(cod integer) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_remedio, nome_remedio, valor_remedio, qtd_estoque, categoria_remedio FROM remedios where cod_remedio = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornarem(cod integer) OWNER TO postgres;

--
-- TOC entry 332 (class 1255 OID 26186)
-- Dependencies: 712 6
-- Name: retornatipo(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornatipo() RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_tipo_consulta, valor_consulta, descricao_tipo_cconsulta FROM tipo_consulta
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornatipo() OWNER TO postgres;

--
-- TOC entry 333 (class 1255 OID 26187)
-- Dependencies: 6 712
-- Name: retornatipo(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornatipo(cod integer) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_tipo_consulta, valor_consulta, descricao_tipo_cconsulta FROM tipo_consulta where cod_tipo_consulta = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornatipo(cod integer) OWNER TO postgres;

--
-- TOC entry 274 (class 1255 OID 26188)
-- Dependencies: 712 6
-- Name: retornatipo(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornatipo(cod character varying) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_tipo_consulta, valor_consulta, descricao_tipo_cconsulta FROM tipo_consulta where descricao_tipo_cconsulta like cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornatipo(cod character varying) OWNER TO postgres;

--
-- TOC entry 334 (class 1255 OID 26189)
-- Dependencies: 712 6
-- Name: retornatratamento(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornatratamento() RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_tratamento_pk, descricao_tratamento, nome_paciente, nome_medico_veterinario  FROM tratamento inner join paciente on cod_paciente_fk = cod_paciente inner join medico_veterinario on cod_veterinario_fk = codigo_medico_vet_pk 
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornatratamento() OWNER TO postgres;

--
-- TOC entry 335 (class 1255 OID 26190)
-- Dependencies: 712 6
-- Name: retornatratamento(character varying); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornatratamento(cod character varying) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_tratamento_pk, descricao_tratamento, nome_paciente, nome_medico_veterinario  FROM tratamento inner join paciente on cod_paciente = cod_paciente_fk  inner join medico_veterinario on cod_veterinario_fk = codigo_medico_vet_pk WHERE descricao_tratamento like cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornatratamento(cod character varying) OWNER TO postgres;

--
-- TOC entry 336 (class 1255 OID 26191)
-- Dependencies: 6 712
-- Name: retornatratamento(integer); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION retornatratamento(cod integer) RETURNS SETOF record
    LANGUAGE plpgsql
    AS $$
DECLARE RESU    RECORD; -- Variavel que armazenará o retorno da query
BEGIN
 
  -- Vamos criar o LOOP para retornar a execução da query na tabela cadastro
  FOR RESU IN SELECT cod_tratamento_pk, descricao_tratamento, nome_paciente, nome_medico_veterinario  FROM tratamento inner join paciente on cod_paciente_fk = cod_paciente inner join medico_veterinario on cod_veterinario_fk = codigo_medico_vet_pk WHERE cod_tratamento_pk = cod
  LOOP
    -- O retorno de cada linha
    RETURN NEXT RESU;
  END LOOP;
 
 
END;
$$;


ALTER FUNCTION public.retornatratamento(cod integer) OWNER TO postgres;

--
-- TOC entry 337 (class 1255 OID 26192)
-- Dependencies: 6 712
-- Name: testa_cursor(); Type: FUNCTION; Schema: public; Owner: postgres
--

CREATE FUNCTION testa_cursor() RETURNS SETOF refcursor
    LANGUAGE plpgsql
    AS $$
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
$$;


ALTER FUNCTION public.testa_cursor() OWNER TO postgres;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 161 (class 1259 OID 26193)
-- Dependencies: 6
-- Name: cirurgia; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE cirurgia (
    cod_cirurgia_pk integer NOT NULL,
    descricao_cirurgia character varying(100) NOT NULL,
    medico_veterinario_fk integer NOT NULL
);


ALTER TABLE public.cirurgia OWNER TO postgres;

--
-- TOC entry 162 (class 1259 OID 26196)
-- Dependencies: 161 6
-- Name: cirurgia_cod_cirurgia_pk_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE cirurgia_cod_cirurgia_pk_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.cirurgia_cod_cirurgia_pk_seq OWNER TO postgres;

--
-- TOC entry 2186 (class 0 OID 0)
-- Dependencies: 162
-- Name: cirurgia_cod_cirurgia_pk_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE cirurgia_cod_cirurgia_pk_seq OWNED BY cirurgia.cod_cirurgia_pk;


--
-- TOC entry 2187 (class 0 OID 0)
-- Dependencies: 162
-- Name: cirurgia_cod_cirurgia_pk_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('cirurgia_cod_cirurgia_pk_seq', 1, true);


--
-- TOC entry 163 (class 1259 OID 26198)
-- Dependencies: 6
-- Name: cirurgia_enternacao; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE cirurgia_enternacao (
    cod_tratamento_fk integer NOT NULL,
    cod_cirurgia_fk integer NOT NULL,
    descricao_procedimento text NOT NULL,
    data_cirurgia date,
    horario_cirurgia time without time zone,
    valor_cirurgia numeric(10,2),
    cod_internacao integer NOT NULL
);


ALTER TABLE public.cirurgia_enternacao OWNER TO postgres;

--
-- TOC entry 164 (class 1259 OID 26204)
-- Dependencies: 6 163
-- Name: cirurgia_enternacao_cod_internacao_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE cirurgia_enternacao_cod_internacao_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.cirurgia_enternacao_cod_internacao_seq OWNER TO postgres;

--
-- TOC entry 2188 (class 0 OID 0)
-- Dependencies: 164
-- Name: cirurgia_enternacao_cod_internacao_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE cirurgia_enternacao_cod_internacao_seq OWNED BY cirurgia_enternacao.cod_internacao;


--
-- TOC entry 2189 (class 0 OID 0)
-- Dependencies: 164
-- Name: cirurgia_enternacao_cod_internacao_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('cirurgia_enternacao_cod_internacao_seq', 6, true);


--
-- TOC entry 165 (class 1259 OID 26206)
-- Dependencies: 2075 2076 2077 2078 6
-- Name: cliente; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE cliente (
    cod_cliente integer NOT NULL,
    nome_cliente character varying(50) NOT NULL,
    data_nascimeto_cliente date NOT NULL,
    endereco_cliente character varying(100) NOT NULL,
    rg_cliente character varying(15) NOT NULL,
    telefone_cliente character(13) NOT NULL,
    exxpedidor_rg_cliente character(5) NOT NULL,
    municipio_cliente character varying(50) NOT NULL,
    cpf_cliente character(14) NOT NULL,
    CONSTRAINT cpf CHECK ((cpf_cliente ~* '^([0-9]{3})(.)([0-9]{3})(.)([0-9]{3})(-)([0-9]{2})+$'::text)),
    CONSTRAINT expedidor CHECK ((exxpedidor_rg_cliente ~* '^([A-z,a-z]{5})+$'::text)),
    CONSTRAINT nome CHECK (((nome_cliente)::text ~* '^([A-Z])+$'::text)),
    CONSTRAINT telefone CHECK ((telefone_cliente ~* '^[(][0-9][0-9][)][0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]+$'::text))
);


ALTER TABLE public.cliente OWNER TO postgres;

--
-- TOC entry 166 (class 1259 OID 26213)
-- Dependencies: 165 6
-- Name: cliente_cod_cliente_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE cliente_cod_cliente_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.cliente_cod_cliente_seq OWNER TO postgres;

--
-- TOC entry 2190 (class 0 OID 0)
-- Dependencies: 166
-- Name: cliente_cod_cliente_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE cliente_cod_cliente_seq OWNED BY cliente.cod_cliente;


--
-- TOC entry 2191 (class 0 OID 0)
-- Dependencies: 166
-- Name: cliente_cod_cliente_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('cliente_cod_cliente_seq', 68, true);


--
-- TOC entry 167 (class 1259 OID 26215)
-- Dependencies: 2080 6
-- Name: consulta; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE consulta (
    cod_consulta integer NOT NULL,
    data_consulta date NOT NULL,
    hora_consutla time without time zone NOT NULL,
    cod_medico_veterinario_fk integer NOT NULL,
    cod_tipo_consulta_fk integer NOT NULL,
    agendado character(1) NOT NULL,
    cod_paciente_fk integer NOT NULL,
    prontuario_paciente text,
    CONSTRAINT agendado CHECK ((agendado ~* '^([s,n,S,N])+$'::text))
);


ALTER TABLE public.consulta OWNER TO postgres;

--
-- TOC entry 168 (class 1259 OID 26222)
-- Dependencies: 6 167
-- Name: consulta_cod_consulta_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE consulta_cod_consulta_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.consulta_cod_consulta_seq OWNER TO postgres;

--
-- TOC entry 2192 (class 0 OID 0)
-- Dependencies: 168
-- Name: consulta_cod_consulta_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE consulta_cod_consulta_seq OWNED BY consulta.cod_consulta;


--
-- TOC entry 2193 (class 0 OID 0)
-- Dependencies: 168
-- Name: consulta_cod_consulta_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('consulta_cod_consulta_seq', 16, true);


--
-- TOC entry 169 (class 1259 OID 26224)
-- Dependencies: 6
-- Name: custos; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE custos (
    cod_consulta_fk integer NOT NULL,
    valortotal numeric(10,2),
    cod_custo integer NOT NULL,
    cod_cliente_fk integer NOT NULL,
    dataconsulta date NOT NULL
);


ALTER TABLE public.custos OWNER TO postgres;

--
-- TOC entry 170 (class 1259 OID 26227)
-- Dependencies: 169 6
-- Name: custos_cod_custo_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE custos_cod_custo_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.custos_cod_custo_seq OWNER TO postgres;

--
-- TOC entry 2194 (class 0 OID 0)
-- Dependencies: 170
-- Name: custos_cod_custo_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE custos_cod_custo_seq OWNED BY custos.cod_custo;


--
-- TOC entry 2195 (class 0 OID 0)
-- Dependencies: 170
-- Name: custos_cod_custo_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('custos_cod_custo_seq', 7, true);


--
-- TOC entry 171 (class 1259 OID 26229)
-- Dependencies: 6
-- Name: exame; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE exame (
    tipo_exame text NOT NULL,
    cod_exame_pk integer NOT NULL,
    cod_laboratorio_fk integer NOT NULL,
    nome_responsavel text,
    valor_exame numeric(10,2)
);


ALTER TABLE public.exame OWNER TO postgres;

--
-- TOC entry 172 (class 1259 OID 26235)
-- Dependencies: 6 171
-- Name: exame_cod_exame_pk_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE exame_cod_exame_pk_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.exame_cod_exame_pk_seq OWNER TO postgres;

--
-- TOC entry 2196 (class 0 OID 0)
-- Dependencies: 172
-- Name: exame_cod_exame_pk_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE exame_cod_exame_pk_seq OWNED BY exame.cod_exame_pk;


--
-- TOC entry 2197 (class 0 OID 0)
-- Dependencies: 172
-- Name: exame_cod_exame_pk_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('exame_cod_exame_pk_seq', 1, true);


--
-- TOC entry 173 (class 1259 OID 26237)
-- Dependencies: 6
-- Name: laboratoriais; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE laboratoriais (
    cod_tratameto_fk integer NOT NULL,
    cod_exame_fk integer NOT NULL,
    descricao_exame text NOT NULL,
    responsavel_exame character varying(50) NOT NULL,
    valor numeric(10,2),
    cod_laboratoriais integer NOT NULL
);


ALTER TABLE public.laboratoriais OWNER TO postgres;

--
-- TOC entry 174 (class 1259 OID 26243)
-- Dependencies: 173 6
-- Name: laboratoriais_cod_laboratoriais_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE laboratoriais_cod_laboratoriais_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.laboratoriais_cod_laboratoriais_seq OWNER TO postgres;

--
-- TOC entry 2198 (class 0 OID 0)
-- Dependencies: 174
-- Name: laboratoriais_cod_laboratoriais_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE laboratoriais_cod_laboratoriais_seq OWNED BY laboratoriais.cod_laboratoriais;


--
-- TOC entry 2199 (class 0 OID 0)
-- Dependencies: 174
-- Name: laboratoriais_cod_laboratoriais_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('laboratoriais_cod_laboratoriais_seq', 3, true);


--
-- TOC entry 175 (class 1259 OID 26245)
-- Dependencies: 2085 6
-- Name: laboratorios; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE laboratorios (
    cod_laboratorio_pk integer NOT NULL,
    nome_laboratorio character varying(50) NOT NULL,
    telefone_laboratorio character(13) NOT NULL,
    endereco_laboratorio character varying(100) NOT NULL,
    municipio_laboratorio character varying(50) NOT NULL,
    CONSTRAINT telefone CHECK ((telefone_laboratorio ~* '^[(]([0-9]{2})[)]([0-9]{4})[-]([0-9]{4})$'::text))
);


ALTER TABLE public.laboratorios OWNER TO postgres;

--
-- TOC entry 176 (class 1259 OID 26249)
-- Dependencies: 175 6
-- Name: laboratorios_cod_laboratorio_pk_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE laboratorios_cod_laboratorio_pk_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.laboratorios_cod_laboratorio_pk_seq OWNER TO postgres;

--
-- TOC entry 2200 (class 0 OID 0)
-- Dependencies: 176
-- Name: laboratorios_cod_laboratorio_pk_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE laboratorios_cod_laboratorio_pk_seq OWNED BY laboratorios.cod_laboratorio_pk;


--
-- TOC entry 2201 (class 0 OID 0)
-- Dependencies: 176
-- Name: laboratorios_cod_laboratorio_pk_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('laboratorios_cod_laboratorio_pk_seq', 1, true);


--
-- TOC entry 177 (class 1259 OID 26251)
-- Dependencies: 6
-- Name: medicacao; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE medicacao (
    cod_tratamento_fk integer NOT NULL,
    cod_remedio_fk integer NOT NULL,
    qtd_aplicada character varying(20) NOT NULL,
    responsavel_medicacao character varying(50) NOT NULL,
    valor numeric(10,2) NOT NULL,
    tipo_responsavel character varying(20)
);


ALTER TABLE public.medicacao OWNER TO postgres;

--
-- TOC entry 178 (class 1259 OID 26254)
-- Dependencies: 177 6
-- Name: medicacao_cod_medicacao_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE medicacao_cod_medicacao_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.medicacao_cod_medicacao_seq OWNER TO postgres;

--
-- TOC entry 2202 (class 0 OID 0)
-- Dependencies: 178
-- Name: medicacao_cod_medicacao_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE medicacao_cod_medicacao_seq OWNED BY medicacao.cod_tratamento_fk;


--
-- TOC entry 2203 (class 0 OID 0)
-- Dependencies: 178
-- Name: medicacao_cod_medicacao_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('medicacao_cod_medicacao_seq', 1, false);


--
-- TOC entry 179 (class 1259 OID 26256)
-- Dependencies: 2087 2088 6
-- Name: medico_veterinario; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE medico_veterinario (
    codigo_medico_vet_pk integer NOT NULL,
    nome_medico_veterinario character varying(50) NOT NULL,
    especialidade_veterinario character varying(50),
    crmv_veterinario character varying(10) NOT NULL,
    telefone_veterinario character varying(13) NOT NULL,
    CONSTRAINT crmv CHECK (((crmv_veterinario)::text ~* '^([0-9]{7})(-)([A-Z]{2})+$'::text)),
    CONSTRAINT telefone CHECK (((telefone_veterinario)::text ~* '^[(]([0-9]{2})[)]([0-9]{4})[-]([0-9]{4})$'::text))
);


ALTER TABLE public.medico_veterinario OWNER TO postgres;

--
-- TOC entry 180 (class 1259 OID 26261)
-- Dependencies: 179 6
-- Name: medico_veterinario_codigo_medico_vet_pk_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE medico_veterinario_codigo_medico_vet_pk_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.medico_veterinario_codigo_medico_vet_pk_seq OWNER TO postgres;

--
-- TOC entry 2204 (class 0 OID 0)
-- Dependencies: 180
-- Name: medico_veterinario_codigo_medico_vet_pk_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE medico_veterinario_codigo_medico_vet_pk_seq OWNED BY medico_veterinario.codigo_medico_vet_pk;


--
-- TOC entry 2205 (class 0 OID 0)
-- Dependencies: 180
-- Name: medico_veterinario_codigo_medico_vet_pk_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('medico_veterinario_codigo_medico_vet_pk_seq', 1, true);


--
-- TOC entry 181 (class 1259 OID 26263)
-- Dependencies: 2090 2091 2092 6
-- Name: paciente; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE paciente (
    cod_paciente integer NOT NULL,
    cod_cliente_fk integer NOT NULL,
    rghv_paciente character varying(11) NOT NULL,
    especie_paciente character varying(50) NOT NULL,
    raca_paciente character varying(25),
    nascimento_paciente date,
    pelagem_paciente character varying(50) NOT NULL,
    sexo_paciente character(1) NOT NULL,
    paciente_castrado character(1),
    nome_paciente character varying(50),
    CONSTRAINT castrado CHECK ((paciente_castrado ~* '^[S,N]+$'::text)),
    CONSTRAINT rghv CHECK (((rghv_paciente)::text ~* '^([0-9]{6})[/]([0-4]{4})+$'::text)),
    CONSTRAINT sexo CHECK ((sexo_paciente ~* '^[M,F]+$'::text))
);


ALTER TABLE public.paciente OWNER TO postgres;

--
-- TOC entry 182 (class 1259 OID 26269)
-- Dependencies: 6 181
-- Name: paciente_cod_paciente_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE paciente_cod_paciente_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.paciente_cod_paciente_seq OWNER TO postgres;

--
-- TOC entry 2206 (class 0 OID 0)
-- Dependencies: 182
-- Name: paciente_cod_paciente_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE paciente_cod_paciente_seq OWNED BY paciente.cod_paciente;


--
-- TOC entry 2207 (class 0 OID 0)
-- Dependencies: 182
-- Name: paciente_cod_paciente_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('paciente_cod_paciente_seq', 1, true);


--
-- TOC entry 183 (class 1259 OID 26271)
-- Dependencies: 6
-- Name: remedios; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE remedios (
    cod_remedio integer NOT NULL,
    nome_remedio character varying(50) NOT NULL,
    valor_remedio numeric(10,2) NOT NULL,
    qtd_estoque integer NOT NULL,
    categoria_remedio character varying(50) NOT NULL
);


ALTER TABLE public.remedios OWNER TO postgres;

--
-- TOC entry 184 (class 1259 OID 26274)
-- Dependencies: 6 183
-- Name: remedios_cod_remedio_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE remedios_cod_remedio_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.remedios_cod_remedio_seq OWNER TO postgres;

--
-- TOC entry 2208 (class 0 OID 0)
-- Dependencies: 184
-- Name: remedios_cod_remedio_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE remedios_cod_remedio_seq OWNED BY remedios.cod_remedio;


--
-- TOC entry 2209 (class 0 OID 0)
-- Dependencies: 184
-- Name: remedios_cod_remedio_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('remedios_cod_remedio_seq', 1, true);


--
-- TOC entry 185 (class 1259 OID 26276)
-- Dependencies: 6
-- Name: tipo_consulta; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE tipo_consulta (
    cod_tipo_consulta integer NOT NULL,
    valor_consulta numeric(10,2) NOT NULL,
    descricao_tipo_cconsulta character varying(20)
);


ALTER TABLE public.tipo_consulta OWNER TO postgres;

--
-- TOC entry 186 (class 1259 OID 26279)
-- Dependencies: 6 185
-- Name: tipo_consulta_cod_tipo_consulta_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE tipo_consulta_cod_tipo_consulta_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.tipo_consulta_cod_tipo_consulta_seq OWNER TO postgres;

--
-- TOC entry 2210 (class 0 OID 0)
-- Dependencies: 186
-- Name: tipo_consulta_cod_tipo_consulta_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE tipo_consulta_cod_tipo_consulta_seq OWNED BY tipo_consulta.cod_tipo_consulta;


--
-- TOC entry 2211 (class 0 OID 0)
-- Dependencies: 186
-- Name: tipo_consulta_cod_tipo_consulta_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('tipo_consulta_cod_tipo_consulta_seq', 2, true);


--
-- TOC entry 187 (class 1259 OID 26281)
-- Dependencies: 6
-- Name: tratamento; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE tratamento (
    cod_tratamento_pk integer NOT NULL,
    descricao_tratamento text,
    cod_consulta_fk integer NOT NULL
);


ALTER TABLE public.tratamento OWNER TO postgres;

--
-- TOC entry 188 (class 1259 OID 26287)
-- Dependencies: 187 6
-- Name: tratamento_cod_tratamento_pk_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE tratamento_cod_tratamento_pk_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.tratamento_cod_tratamento_pk_seq OWNER TO postgres;

--
-- TOC entry 2212 (class 0 OID 0)
-- Dependencies: 188
-- Name: tratamento_cod_tratamento_pk_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE tratamento_cod_tratamento_pk_seq OWNED BY tratamento.cod_tratamento_pk;


--
-- TOC entry 2213 (class 0 OID 0)
-- Dependencies: 188
-- Name: tratamento_cod_tratamento_pk_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('tratamento_cod_tratamento_pk_seq', 1, true);


--
-- TOC entry 189 (class 1259 OID 26289)
-- Dependencies: 2097 2098 2099 6
-- Name: usuario; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE usuario (
    cod_usuario integer NOT NULL,
    nome_usuario character varying(100) NOT NULL,
    login character varying(50) NOT NULL,
    senha character varying(12) NOT NULL,
    CONSTRAINT login CHECK (((login)::text ~* '^([A-Za-z0-9.,-@_*&])+$'::text)),
    CONSTRAINT nome CHECK (((nome_usuario)::text ~* '^([A-Za-záéíóúçÁÉÍÓÚãõÃÕ, ])+$'::text)),
    CONSTRAINT senha CHECK (((senha)::text ~* '^([A-Za-z0-9.,-@_*&])+$'::text))
);


ALTER TABLE public.usuario OWNER TO postgres;

--
-- TOC entry 190 (class 1259 OID 26295)
-- Dependencies: 6 189
-- Name: usuario_cod_usuario_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE usuario_cod_usuario_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.usuario_cod_usuario_seq OWNER TO postgres;

--
-- TOC entry 2214 (class 0 OID 0)
-- Dependencies: 190
-- Name: usuario_cod_usuario_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE usuario_cod_usuario_seq OWNED BY usuario.cod_usuario;


--
-- TOC entry 2215 (class 0 OID 0)
-- Dependencies: 190
-- Name: usuario_cod_usuario_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('usuario_cod_usuario_seq', 1, false);


--
-- TOC entry 2072 (class 2604 OID 26297)
-- Dependencies: 162 161
-- Name: cod_cirurgia_pk; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY cirurgia ALTER COLUMN cod_cirurgia_pk SET DEFAULT nextval('cirurgia_cod_cirurgia_pk_seq'::regclass);


--
-- TOC entry 2073 (class 2604 OID 26298)
-- Dependencies: 164 163
-- Name: cod_internacao; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY cirurgia_enternacao ALTER COLUMN cod_internacao SET DEFAULT nextval('cirurgia_enternacao_cod_internacao_seq'::regclass);


--
-- TOC entry 2074 (class 2604 OID 26299)
-- Dependencies: 166 165
-- Name: cod_cliente; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY cliente ALTER COLUMN cod_cliente SET DEFAULT nextval('cliente_cod_cliente_seq'::regclass);


--
-- TOC entry 2079 (class 2604 OID 26300)
-- Dependencies: 168 167
-- Name: cod_consulta; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY consulta ALTER COLUMN cod_consulta SET DEFAULT nextval('consulta_cod_consulta_seq'::regclass);


--
-- TOC entry 2081 (class 2604 OID 26301)
-- Dependencies: 170 169
-- Name: cod_custo; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY custos ALTER COLUMN cod_custo SET DEFAULT nextval('custos_cod_custo_seq'::regclass);


--
-- TOC entry 2082 (class 2604 OID 26302)
-- Dependencies: 172 171
-- Name: cod_exame_pk; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY exame ALTER COLUMN cod_exame_pk SET DEFAULT nextval('exame_cod_exame_pk_seq'::regclass);


--
-- TOC entry 2083 (class 2604 OID 26303)
-- Dependencies: 174 173
-- Name: cod_laboratoriais; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY laboratoriais ALTER COLUMN cod_laboratoriais SET DEFAULT nextval('laboratoriais_cod_laboratoriais_seq'::regclass);


--
-- TOC entry 2084 (class 2604 OID 26304)
-- Dependencies: 176 175
-- Name: cod_laboratorio_pk; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY laboratorios ALTER COLUMN cod_laboratorio_pk SET DEFAULT nextval('laboratorios_cod_laboratorio_pk_seq'::regclass);


--
-- TOC entry 2086 (class 2604 OID 26305)
-- Dependencies: 180 179
-- Name: codigo_medico_vet_pk; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY medico_veterinario ALTER COLUMN codigo_medico_vet_pk SET DEFAULT nextval('medico_veterinario_codigo_medico_vet_pk_seq'::regclass);


--
-- TOC entry 2089 (class 2604 OID 26306)
-- Dependencies: 182 181
-- Name: cod_paciente; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY paciente ALTER COLUMN cod_paciente SET DEFAULT nextval('paciente_cod_paciente_seq'::regclass);


--
-- TOC entry 2093 (class 2604 OID 26307)
-- Dependencies: 184 183
-- Name: cod_remedio; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY remedios ALTER COLUMN cod_remedio SET DEFAULT nextval('remedios_cod_remedio_seq'::regclass);


--
-- TOC entry 2094 (class 2604 OID 26308)
-- Dependencies: 186 185
-- Name: cod_tipo_consulta; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY tipo_consulta ALTER COLUMN cod_tipo_consulta SET DEFAULT nextval('tipo_consulta_cod_tipo_consulta_seq'::regclass);


--
-- TOC entry 2095 (class 2604 OID 26309)
-- Dependencies: 188 187
-- Name: cod_tratamento_pk; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY tratamento ALTER COLUMN cod_tratamento_pk SET DEFAULT nextval('tratamento_cod_tratamento_pk_seq'::regclass);


--
-- TOC entry 2096 (class 2604 OID 26310)
-- Dependencies: 190 189
-- Name: cod_usuario; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY usuario ALTER COLUMN cod_usuario SET DEFAULT nextval('usuario_cod_usuario_seq'::regclass);


--
-- TOC entry 2165 (class 0 OID 26193)
-- Dependencies: 161
-- Data for Name: cirurgia; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY cirurgia (cod_cirurgia_pk, descricao_cirurgia, medico_veterinario_fk) FROM stdin;
1	o cachorro foi ressuscitado	1
\.


--
-- TOC entry 2166 (class 0 OID 26198)
-- Dependencies: 163
-- Data for Name: cirurgia_enternacao; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY cirurgia_enternacao (cod_tratamento_fk, cod_cirurgia_fk, descricao_procedimento, data_cirurgia, horario_cirurgia, valor_cirurgia, cod_internacao) FROM stdin;
1	1	aaa	2012-10-10	08:00:00	20.00	6
\.


--
-- TOC entry 2167 (class 0 OID 26206)
-- Dependencies: 165
-- Data for Name: cliente; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY cliente (cod_cliente, nome_cliente, data_nascimeto_cliente, endereco_cliente, rg_cliente, telefone_cliente, exxpedidor_rg_cliente, municipio_cliente, cpf_cliente) FROM stdin;
64	teste	1991-10-31	teste	8888888	(43)9999-9999	ssppr	teste	051.272.219-69
65	Ola	2000-03-31	ola	1234	(43)8888-3333	SSPPR	Curitiba	004.980.760-90
\.


--
-- TOC entry 2168 (class 0 OID 26215)
-- Dependencies: 167
-- Data for Name: consulta; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY consulta (cod_consulta, data_consulta, hora_consutla, cod_medico_veterinario_fk, cod_tipo_consulta_fk, agendado, cod_paciente_fk, prontuario_paciente) FROM stdin;
11	2012-10-03	19:00:00	1	2	N	1	FOI IDENTIFICADO QUE O CACHORRO TEM HEMORROIDAS
14	2012-10-03	18:00:00	1	2	N	1	FOI IDENTIFICADO QUE O CACHORRO do wagner tem HEMORROIDAS
15	2012-10-03	22:00:00	1	2	N	1	FOI IDENTIFICADO QUE O CACHORRO do wagner tem muito mais que HEMORROIDAS
13	2012-10-10	08:00:00	1	2	n	1	O CACHORRO MORREU
16	2012-09-20	14:00:00	1	2	N	1	teste
\.


--
-- TOC entry 2169 (class 0 OID 26224)
-- Dependencies: 169
-- Data for Name: custos; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY custos (cod_consulta_fk, valortotal, cod_custo, cod_cliente_fk, dataconsulta) FROM stdin;
16	40.00	7	65	2012-09-20
\.


--
-- TOC entry 2170 (class 0 OID 26229)
-- Dependencies: 171
-- Data for Name: exame; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY exame (tipo_exame, cod_exame_pk, cod_laboratorio_fk, nome_responsavel, valor_exame) FROM stdin;
prostata	1	1	thiago	30.00
\.


--
-- TOC entry 2171 (class 0 OID 26237)
-- Dependencies: 173
-- Data for Name: laboratoriais; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY laboratoriais (cod_tratameto_fk, cod_exame_fk, descricao_exame, responsavel_exame, valor, cod_laboratoriais) FROM stdin;
1	1	sucesso	phyllipe	30.00	3
\.


--
-- TOC entry 2172 (class 0 OID 26245)
-- Dependencies: 175
-- Data for Name: laboratorios; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY laboratorios (cod_laboratorio_pk, nome_laboratorio, telefone_laboratorio, endereco_laboratorio, municipio_laboratorio) FROM stdin;
1	farms	(43)8888-8888	rua teste, 15	CORNELIO
\.


--
-- TOC entry 2173 (class 0 OID 26251)
-- Dependencies: 177
-- Data for Name: medicacao; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY medicacao (cod_tratamento_fk, cod_remedio_fk, qtd_aplicada, responsavel_medicacao, valor, tipo_responsavel) FROM stdin;
1	1	1	enrique	15.50	enfermeiro
\.


--
-- TOC entry 2174 (class 0 OID 26256)
-- Dependencies: 179
-- Data for Name: medico_veterinario; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY medico_veterinario (codigo_medico_vet_pk, nome_medico_veterinario, especialidade_veterinario, crmv_veterinario, telefone_veterinario) FROM stdin;
1	Maurao	Geriatria	1234567-PR	(43)8888-3333
\.


--
-- TOC entry 2175 (class 0 OID 26263)
-- Dependencies: 181
-- Data for Name: paciente; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY paciente (cod_paciente, cod_cliente_fk, rghv_paciente, especie_paciente, raca_paciente, nascimento_paciente, pelagem_paciente, sexo_paciente, paciente_castrado, nome_paciente) FROM stdin;
1	65	123456/1234	cachorro	labrador	2000-03-31	bege	m	n	rex
\.


--
-- TOC entry 2176 (class 0 OID 26271)
-- Dependencies: 183
-- Data for Name: remedios; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY remedios (cod_remedio, nome_remedio, valor_remedio, qtd_estoque, categoria_remedio) FROM stdin;
1	ressuscit	15.50	3	bruta
\.


--
-- TOC entry 2177 (class 0 OID 26276)
-- Dependencies: 185
-- Data for Name: tipo_consulta; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY tipo_consulta (cod_tipo_consulta, valor_consulta, descricao_tipo_cconsulta) FROM stdin;
1	20.00	\N
2	40.00	\N
\.


--
-- TOC entry 2178 (class 0 OID 26281)
-- Dependencies: 187
-- Data for Name: tratamento; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY tratamento (cod_tratamento_pk, descricao_tratamento, cod_consulta_fk) FROM stdin;
1	cirurgia para ressuscitar o dog	13
\.


--
-- TOC entry 2179 (class 0 OID 26289)
-- Dependencies: 189
-- Data for Name: usuario; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY usuario (cod_usuario, nome_usuario, login, senha) FROM stdin;
\.


--
-- TOC entry 2101 (class 2606 OID 26312)
-- Dependencies: 161 161
-- Name: cirurgiaPK; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY cirurgia
    ADD CONSTRAINT "cirurgiaPK" PRIMARY KEY (cod_cirurgia_pk);


--
-- TOC entry 2103 (class 2606 OID 26314)
-- Dependencies: 163 163
-- Name: cirurgia_enternacao_cod_internacao_key; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY cirurgia_enternacao
    ADD CONSTRAINT cirurgia_enternacao_cod_internacao_key UNIQUE (cod_internacao);


--
-- TOC entry 2107 (class 2606 OID 26316)
-- Dependencies: 165 165
-- Name: cod_cliPk; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY cliente
    ADD CONSTRAINT "cod_cliPk" PRIMARY KEY (cod_cliente);


--
-- TOC entry 2131 (class 2606 OID 26318)
-- Dependencies: 181 181
-- Name: cod_pacPK; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY paciente
    ADD CONSTRAINT "cod_pacPK" PRIMARY KEY (cod_paciente);


--
-- TOC entry 2135 (class 2606 OID 26320)
-- Dependencies: 185 185
-- Name: cod_tipo_consultaPK; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY tipo_consulta
    ADD CONSTRAINT "cod_tipo_consultaPK" PRIMARY KEY (cod_tipo_consulta);


--
-- TOC entry 2139 (class 2606 OID 26322)
-- Dependencies: 189 189
-- Name: cod_usuarioPK; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY usuario
    ADD CONSTRAINT "cod_usuarioPK" PRIMARY KEY (cod_usuario);


--
-- TOC entry 2129 (class 2606 OID 26324)
-- Dependencies: 179 179
-- Name: cod_veterinarioPK; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY medico_veterinario
    ADD CONSTRAINT "cod_veterinarioPK" PRIMARY KEY (codigo_medico_vet_pk);


--
-- TOC entry 2111 (class 2606 OID 26326)
-- Dependencies: 167 167
-- Name: codconsultaunique; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY consulta
    ADD CONSTRAINT codconsultaunique UNIQUE (cod_consulta);


--
-- TOC entry 2113 (class 2606 OID 26328)
-- Dependencies: 167 167 167 167
-- Name: consultaPK; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY consulta
    ADD CONSTRAINT "consultaPK" PRIMARY KEY (data_consulta, hora_consutla, cod_medico_veterinario_fk);


--
-- TOC entry 2115 (class 2606 OID 26330)
-- Dependencies: 169 169
-- Name: consultapk; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY custos
    ADD CONSTRAINT consultapk PRIMARY KEY (cod_consulta_fk);


--
-- TOC entry 2109 (class 2606 OID 26332)
-- Dependencies: 165 165
-- Name: cpf_cliUN; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY cliente
    ADD CONSTRAINT "cpf_cliUN" UNIQUE (cpf_cliente);


--
-- TOC entry 2117 (class 2606 OID 26334)
-- Dependencies: 169 169
-- Name: custos_cod_custo_key; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY custos
    ADD CONSTRAINT custos_cod_custo_key UNIQUE (cod_custo);


--
-- TOC entry 2105 (class 2606 OID 26336)
-- Dependencies: 163 163 163
-- Name: enternacaoPK; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY cirurgia_enternacao
    ADD CONSTRAINT "enternacaoPK" PRIMARY KEY (cod_tratamento_fk, cod_cirurgia_fk);


--
-- TOC entry 2119 (class 2606 OID 26338)
-- Dependencies: 171 171
-- Name: examePK; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY exame
    ADD CONSTRAINT "examePK" PRIMARY KEY (cod_exame_pk);


--
-- TOC entry 2121 (class 2606 OID 26340)
-- Dependencies: 173 173 173
-- Name: laboratoriaisPK; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY laboratoriais
    ADD CONSTRAINT "laboratoriaisPK" PRIMARY KEY (cod_tratameto_fk, cod_exame_fk);


--
-- TOC entry 2125 (class 2606 OID 26342)
-- Dependencies: 175 175
-- Name: laboratorioPK; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY laboratorios
    ADD CONSTRAINT "laboratorioPK" PRIMARY KEY (cod_laboratorio_pk);


--
-- TOC entry 2141 (class 2606 OID 26344)
-- Dependencies: 189 189
-- Name: login_usuarioUN; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY usuario
    ADD CONSTRAINT "login_usuarioUN" UNIQUE (login);


--
-- TOC entry 2127 (class 2606 OID 26346)
-- Dependencies: 177 177 177
-- Name: medicacaoPK; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY medicacao
    ADD CONSTRAINT "medicacaoPK" PRIMARY KEY (cod_tratamento_fk, cod_remedio_fk);


--
-- TOC entry 2133 (class 2606 OID 26348)
-- Dependencies: 183 183
-- Name: remedioPK; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY remedios
    ADD CONSTRAINT "remedioPK" PRIMARY KEY (cod_remedio);


--
-- TOC entry 2137 (class 2606 OID 26350)
-- Dependencies: 187 187
-- Name: tratamentoPK; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY tratamento
    ADD CONSTRAINT "tratamentoPK" PRIMARY KEY (cod_tratamento_pk);


--
-- TOC entry 2123 (class 2606 OID 26352)
-- Dependencies: 173 173
-- Name: uniqueLaboratoriais; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY laboratoriais
    ADD CONSTRAINT "uniqueLaboratoriais" UNIQUE (cod_laboratoriais);


--
-- TOC entry 2157 (class 2620 OID 26353)
-- Dependencies: 204 163
-- Name: gatilho_atualizar_cirurgia; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER gatilho_atualizar_cirurgia AFTER UPDATE ON cirurgia_enternacao FOR EACH ROW EXECUTE PROCEDURE atualiza_contacirurgia();


--
-- TOC entry 2159 (class 2620 OID 26354)
-- Dependencies: 167 203
-- Name: gatilho_atualizar_conta; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER gatilho_atualizar_conta AFTER UPDATE ON consulta FOR EACH ROW EXECUTE PROCEDURE atualiza_conta();


--
-- TOC entry 2161 (class 2620 OID 26355)
-- Dependencies: 173 205
-- Name: gatilho_atualizar_exame; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER gatilho_atualizar_exame AFTER UPDATE ON laboratoriais FOR EACH ROW EXECUTE PROCEDURE atualiza_contaexame();


--
-- TOC entry 2163 (class 2620 OID 26356)
-- Dependencies: 177 206
-- Name: gatilho_atualizar_medicacao; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER gatilho_atualizar_medicacao AFTER UPDATE ON medicacao FOR EACH ROW EXECUTE PROCEDURE atualiza_contamedicacao();


--
-- TOC entry 2158 (class 2620 OID 26357)
-- Dependencies: 163 239
-- Name: gatilho_inserir_cirurgia; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER gatilho_inserir_cirurgia AFTER INSERT ON cirurgia_enternacao FOR EACH ROW EXECUTE PROCEDURE insere_contacirurgia();


--
-- TOC entry 2160 (class 2620 OID 26358)
-- Dependencies: 238 167
-- Name: gatilho_inserir_conta; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER gatilho_inserir_conta AFTER INSERT ON consulta FOR EACH ROW EXECUTE PROCEDURE insere_conta();


--
-- TOC entry 2162 (class 2620 OID 26359)
-- Dependencies: 173 240
-- Name: gatilho_inserir_exame; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER gatilho_inserir_exame AFTER INSERT ON laboratoriais FOR EACH ROW EXECUTE PROCEDURE insere_contaexame();


--
-- TOC entry 2164 (class 2620 OID 26360)
-- Dependencies: 177 242
-- Name: gatilho_inserir_medicacao; Type: TRIGGER; Schema: public; Owner: postgres
--

CREATE TRIGGER gatilho_inserir_medicacao AFTER INSERT ON medicacao FOR EACH ROW EXECUTE PROCEDURE insere_contamedicacao();


--
-- TOC entry 2145 (class 2606 OID 26361)
-- Dependencies: 167 181 2130
-- Name: PacienteFK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY consulta
    ADD CONSTRAINT "PacienteFK" FOREIGN KEY (cod_paciente_fk) REFERENCES paciente(cod_paciente);


--
-- TOC entry 2143 (class 2606 OID 26366)
-- Dependencies: 163 161 2100
-- Name: cirurgiaFK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY cirurgia_enternacao
    ADD CONSTRAINT "cirurgiaFK" FOREIGN KEY (cod_cirurgia_fk) REFERENCES cirurgia(cod_cirurgia_pk);


--
-- TOC entry 2148 (class 2606 OID 26371)
-- Dependencies: 169 165 2106
-- Name: clientefk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY custos
    ADD CONSTRAINT clientefk FOREIGN KEY (cod_cliente_fk) REFERENCES cliente(cod_cliente);


--
-- TOC entry 2155 (class 2606 OID 26376)
-- Dependencies: 181 165 2106
-- Name: cod_cliFK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY paciente
    ADD CONSTRAINT "cod_cliFK" FOREIGN KEY (cod_cliente_fk) REFERENCES cliente(cod_cliente);


--
-- TOC entry 2149 (class 2606 OID 26381)
-- Dependencies: 169 167 2110
-- Name: consultafk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY custos
    ADD CONSTRAINT consultafk FOREIGN KEY (cod_consulta_fk) REFERENCES consulta(cod_consulta);


--
-- TOC entry 2151 (class 2606 OID 26386)
-- Dependencies: 173 171 2118
-- Name: exameFK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY laboratoriais
    ADD CONSTRAINT "exameFK" FOREIGN KEY (cod_exame_fk) REFERENCES exame(cod_exame_pk);


--
-- TOC entry 2150 (class 2606 OID 26391)
-- Dependencies: 171 175 2124
-- Name: laboratorioFK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY exame
    ADD CONSTRAINT "laboratorioFK" FOREIGN KEY (cod_laboratorio_fk) REFERENCES laboratorios(cod_laboratorio_pk);


--
-- TOC entry 2142 (class 2606 OID 26396)
-- Dependencies: 161 2128 179
-- Name: medicoFK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY cirurgia
    ADD CONSTRAINT "medicoFK" FOREIGN KEY (medico_veterinario_fk) REFERENCES medico_veterinario(codigo_medico_vet_pk);


--
-- TOC entry 2146 (class 2606 OID 26401)
-- Dependencies: 167 2128 179
-- Name: medico_veterinarioFK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY consulta
    ADD CONSTRAINT "medico_veterinarioFK" FOREIGN KEY (cod_medico_veterinario_fk) REFERENCES medico_veterinario(codigo_medico_vet_pk);


--
-- TOC entry 2153 (class 2606 OID 26406)
-- Dependencies: 2132 177 183
-- Name: remedio_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY medicacao
    ADD CONSTRAINT remedio_fk FOREIGN KEY (cod_remedio_fk) REFERENCES remedios(cod_remedio);


--
-- TOC entry 2147 (class 2606 OID 26411)
-- Dependencies: 185 2134 167
-- Name: tipo_consultaFK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY consulta
    ADD CONSTRAINT "tipo_consultaFK" FOREIGN KEY (cod_tipo_consulta_fk) REFERENCES tipo_consulta(cod_tipo_consulta);


--
-- TOC entry 2144 (class 2606 OID 26416)
-- Dependencies: 163 187 2136
-- Name: tratamentoFK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY cirurgia_enternacao
    ADD CONSTRAINT "tratamentoFK" FOREIGN KEY (cod_tratamento_fk) REFERENCES tratamento(cod_tratamento_pk);


--
-- TOC entry 2152 (class 2606 OID 26421)
-- Dependencies: 2136 173 187
-- Name: tratamentoFK; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY laboratoriais
    ADD CONSTRAINT "tratamentoFK" FOREIGN KEY (cod_tratameto_fk) REFERENCES tratamento(cod_tratamento_pk);


--
-- TOC entry 2156 (class 2606 OID 26426)
-- Dependencies: 187 2110 167
-- Name: tratamento_cod_consulta_fk_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY tratamento
    ADD CONSTRAINT tratamento_cod_consulta_fk_fkey FOREIGN KEY (cod_consulta_fk) REFERENCES consulta(cod_consulta);


--
-- TOC entry 2154 (class 2606 OID 26431)
-- Dependencies: 2136 177 187
-- Name: tratamento_fk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY medicacao
    ADD CONSTRAINT tratamento_fk FOREIGN KEY (cod_tratamento_fk) REFERENCES tratamento(cod_tratamento_pk);


--
-- TOC entry 2184 (class 0 OID 0)
-- Dependencies: 6
-- Name: public; Type: ACL; Schema: -; Owner: postgres
--

REVOKE ALL ON SCHEMA public FROM PUBLIC;
REVOKE ALL ON SCHEMA public FROM postgres;
GRANT ALL ON SCHEMA public TO postgres;
GRANT ALL ON SCHEMA public TO PUBLIC;


-- Completed on 2012-10-10 22:32:01

--
-- PostgreSQL database dump complete
--

