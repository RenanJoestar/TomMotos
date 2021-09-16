/*TRIGGER PARA DIMINUIÇÃO DE QUANTIDADE QUANDO ACONTECER VENDA*/ 
DELIMITER $$
CREATE TRIGGER diminuicaoDeQTD after insert
ON tb_venda FOR EACH ROW BEGIN /*diminui a qtd normalmente */ UPDATE tb_produto
INNER JOIN tb_produto_usado
ON tb_produto_usado.fk_produto_id = tb_produto.id_produto
INNER JOIN tb_cliente
ON tb_produto_selecionado.fk_cliente_id = tb_cliente.id_cliente

SET tb_produto.quantidade_produto = tb_produto.quantidade_produto - tb_produto_usado.quantidade_produto_usado, 
tb_produto.quantidade_virtual_produto = tb_produto.quantidade_virtual_produto - tb_produto_usado.quantidade_produto_usado

WHERE fk_produto_id = tb_produto.id_produto 
AND fk_cliente_id = tb_cliente.id_cliente; END $$ DELIMITER ; 

DELIMITER $$
CREATE TRIGGER logfornecimentoQTDProduto after insert
ON tb_log_fornecimento FOR EACH ROW BEGIN /* aumenta a qtd de produto fornecido */ UPDATE tb_produto
INNER JOIN tb_log_fornecimento
ON tb_produto.id_produto = tb_log_fornecimento.fk_produto_id
SET tb_produto.quantidade_produto = tb_produto.quantidade_produto + tb_log_fornecimento.qtd_produto_fornecido, 
tb_produto.quantidade_virtual_produto = tb_produto.quantidade_virtual_produto + tb_log_fornecimento.qtd_produto_fornecido
WHERE fk_produto_id = tb_produto.id_produto; END $$ DELIMITER;

/*TRIGGER PARA DIMINUIÇÃO DE QUANTIDADE QUANDO PRODUTO FOR BUSCADO*/
DELIMITER $$
CREATE TRIGGER diminuicaoDeQTDqndProdutoBuscado after update
ON tb_produto_selecionado FOR EACH ROW BEGIN IF (new.buscado_produto_selecionado = true AND old.buscado_produto_selecionado = false) THEN UPDATE tb_produto
INNER JOIN tb_produto_selecionado
ON tb_produto_selecionado.fk_produto_id = tb_produto.id_produto
INNER JOIN tb_cliente
ON tb_produto_selecionado.fk_cliente_id = tb_cliente.id_cliente

SET tb_produto.quantidade_produto = tb_produto.quantidade_produto - tb_produto_usado.quantidade_produto_usado, 
tb_produto.quantidade_virtual_produto = tb_produto.quantidade_virtual_produto - tb_produto_usado.quantidade_produto_usado

WHERE new.fk_produto_id = tb_produto.id_produto 
AND new.fk_cliente_id = tb_cliente.id_cliente; ELSEIF(new.buscado_produto_selecionado = false AND old.buscado_produto_selecionado = true) THEN UPDATE tb_produto 
INNER JOIN tb_produto_selecionado
ON tb_produto_selecionado.fk_produto_id = tb_produto.id_produto
INNER JOIN tb_cliente
ON tb_produto_selecionado.fk_cliente_id = tb_cliente.id_cliente


SET tb_produto.quantidade_produto = tb_produto.quantidade_produto + tb_produto_usado.quantidade_produto_usado, 
tb_produto.quantidade_virtual_produto = tb_produto.quantidade_virtual_produto + tb_produto_usado.quantidade_produto_usado
WHERE new.fk_produto_id = tb_produto.id_produto 
AND new.fk_cliente_id = tb_cliente.id_cliente; END IF; END $$ DELIMITER ; 