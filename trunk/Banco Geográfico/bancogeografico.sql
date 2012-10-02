--criação da linguagem plpgsql utilizada pelo postgis

create language plpgsql

--criação do database geografico usando o template postgis 2.0

CREATE DATABASE tutotial_dbgeografico-- cria o database
 TEMPLATE=template_postgis_20--utiliza o template do postgis
 use tutorial_dbgeografico--poem em uso o database criado

--criação da tabela

CREATE TABLE tbgeo ( cod int, nome varchar(50) );--cria a tabela
SELECT AddGeometryColumn('public', 'tbgeo','geo',-1,'POINT',2);--adiciona uma coluna a tabela para o dado geografico
--                   schema(opcional),tabela,coluna,projeção(-1=srid),dimensão


--inserção de dados


INSERT INTO tbgeo (cod,nome, geo) VALUES (1, 'teste1',st_geomfromtext('POINT(2 3)', -1));

INSERT INTO tbgeo (cod,nome, geo) VALUES (2,'teste2',st_astext('POINT(1 1)'));


--seleção de dados

select cod,nome,st_astext(geo)  from tbgeo

select cod from tbgeo where  geo = 'POINT(1 1)'


--alterção de dados

update tbgeo set geo=st_astext('POINT(3 2)')  where  geo = 'POINT(1 1)'

--excluir dados

delete tbgeo where geo = st_astext('POINT(3 2)') 
