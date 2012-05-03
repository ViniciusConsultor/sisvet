﻿--VERIFICA SE CAMPO QTDE_TOTAL É MAIOR QUE ZERO
ALTER TABLE TBPRODUTO ADD CONSTRAINT valida_qtde_total CHECK(qtde_total >= 0);

--VERIFICA SE VALOR DE VENDA É MAIOR OU IGUAL AO VALOR DE CUSTO
ALTER TABLE TBPRODUTO ADD CONSTRAINT valida_valor_venda CHECK(valor_venda >= valor_custo);