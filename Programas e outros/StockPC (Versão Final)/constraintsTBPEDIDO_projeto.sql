﻿--VERIFICA SE CAMPO TOTAL_PEDIDO É MAIOR QUE ZERO
ALTER TABLE TBPEDIDO ADD CONSTRAINT valida_total_pedido CHECK(total_pedido > 0);