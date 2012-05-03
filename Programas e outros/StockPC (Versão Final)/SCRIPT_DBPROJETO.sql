--SCRIPT DO BANCO DBPROJETO


--TABELA CATEGORIA
CREATE TABLE tbcategoria
(
  id serial NOT NULL,
  nome character varying(30) NOT NULL,
  descricao character varying(50) NOT NULL,
  CONSTRAINT tbcategoria_pkey PRIMARY KEY (id)
)


--TABELA CIDADE
CREATE TABLE tbcidade
(
  id serial NOT NULL,
  nome character varying(30) NOT NULL,
  estado character(2) NOT NULL,
  CONSTRAINT tbcidade_pkey PRIMARY KEY (id)
)


--TABELA FORNECEDOR
CREATE TABLE tbfornecedor
(
  id serial NOT NULL,
  nome character varying(50) NOT NULL,
  cnpj character(14) NOT NULL,
  endereco character varying(50),
  telefone character(13),
  email character varying(50),
  cidade_id_fk integer,
  CONSTRAINT tbfornecedor_pkey PRIMARY KEY (id),
  CONSTRAINT tbfornecedor_cidade_id_fk_fkey FOREIGN KEY (cidade_id_fk)
      REFERENCES tbcidade (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT ck_cnpj UNIQUE (cnpj),
  CONSTRAINT valida_email CHECK (email::text ~* '^[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+[.][A-Za-z]+$'::text),
  CONSTRAINT valida_telefone CHECK (telefone ~* '^[(][0-9][0-9][)][0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]+$'::text)
)


--TABELA FUNCIONARIO
CREATE TABLE tbfuncionario
(
  id serial NOT NULL,
  nome character varying(50) NOT NULL,
  cpf character(14) NOT NULL,
  rg character varying(12) NOT NULL,
  endereco character varying(50),
  telefone character(13),
  email character varying(50),
  cart_trabalho character varying(20),
  "login" character varying(50),
  senha character varying(50),
  sexo character(1),
  administrador boolean,
  CONSTRAINT tbfuncionario_pkey PRIMARY KEY (id),
  CONSTRAINT ck_cart_trabalho UNIQUE (cart_trabalho),
  CONSTRAINT ck_cpf UNIQUE (cpf),
  CONSTRAINT ck_email UNIQUE (email),
  CONSTRAINT ck_login UNIQUE (login),
  CONSTRAINT ck_rg UNIQUE (rg),
  CONSTRAINT valida_cpf CHECK (cpf ~* '^[0-9][0-9][0-9][.][0-9][0-9][0-9][.][0-9][0-9][0-9][-][0-9][0-9]+$'::text),
  CONSTRAINT valida_email CHECK (email::text ~* '^[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+[.][A-Za-z]+$'::text),
  CONSTRAINT valida_telefone CHECK (telefone ~* '^[(][0-9][0-9][)][0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]+$'::text),
  CONSTRAINT valida_rg CHECK (rg ~* '^[0-9][0-9][.][0-9][0-9][0-9][.][0-9][0-9][0-9][-][0-9]+$')
)


--TABELA ITEM DO PEDIDO
--  drop table tbitem_pedido
CREATE TABLE tbitem_pedido
(
  id serial NOT NULL,
  id_produto_fk integer,
  id_pedido_fk integer,
  qtde_solicitada integer NOT NULL,
  valor real NOT NULL,
  CONSTRAINT tbitem_pedido_pkey PRIMARY KEY (id),
  CONSTRAINT tbitem_pedido_id_pedido_fk_fkey FOREIGN KEY (id_pedido_fk)
      REFERENCES tbpedido (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT tbitem_pedido_id_produto_fk_fkey FOREIGN KEY (id_produto_fk)
      REFERENCES tbproduto (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT valida_qtde_solicitada CHECK (qtde_solicitada > 0),
  CONSTRAINT valida_valor CHECK (valor > 0::double precision)
)


--TABELA PEDIDO
-- drop table tbpedido
CREATE TABLE tbpedido
(
  id serial NOT NULL,
  funcionario_id_fk integer,
  fornecedor_id_fk integer,
  data date NOT NULL,
  total_pedido real NOT NULL,
  entregue boolean,
  CONSTRAINT tbpedido_pkey PRIMARY KEY (id),
  CONSTRAINT tbpedido_funcionario_id_fk_fkey FOREIGN KEY (funcionario_id_fk)
      REFERENCES tbfuncionario (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT tbpedido_produto_id_fk_fkey FOREIGN KEY (fornecedor_id_fk)
      REFERENCES tbproduto (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT valida_total_pedido CHECK (total_pedido > 0::double precision)
)

--TABELA PRODUTO
CREATE TABLE tbproduto
(
  id serial NOT NULL,
  descricao character varying(50) NOT NULL,
  valor_custo real NOT NULL,
  valor_venda real NOT NULL,
  qtde_total integer,
  categoria_id_fk integer,
  CONSTRAINT tbproduto_pkey PRIMARY KEY (id),
  CONSTRAINT tbproduto_categoria_id_fk_fkey FOREIGN KEY (categoria_id_fk)
      REFERENCES tbcategoria (id) MATCH SIMPLE
      ON UPDATE NO ACTION ON DELETE NO ACTION,
  CONSTRAINT valida_qtde_total CHECK (qtde_total > 0),
  CONSTRAINT valida_valor_venda CHECK (valor_venda >= valor_custo)
)
