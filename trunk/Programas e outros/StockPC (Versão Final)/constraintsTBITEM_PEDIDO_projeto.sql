--VERIFICA SE CAMPO VALOR É MAIOR QUE ZERO
ALTER TABLE TBITEM_PEDIDO ADD CONSTRAINT valida_valor CHECK(valor > 0);

--VERIFICA SE CAMPO QTDE_SOLICITADA É MAIOR QUE ZERO
ALTER TABLE TBITEM_PEDIDO ADD CONSTRAINT valida_qtde_solicitada CHECK(qtde_solicitada > 0);

--VERIFICA SE CAMPO QTDE_COMPRADA É MAIOR QUE ZERO
ALTER TABLE TBITEM_PEDIDO ADD CONSTRAINT valida_qtde_comprada CHECK(qtde_comprada > 0);

--TESTAR
insert into tbitem_pedido (valor, qtde_solicitada, qtde_comprada, baixa) values (0, 0, 0, 'N');