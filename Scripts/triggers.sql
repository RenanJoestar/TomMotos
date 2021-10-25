/*TRIGGER PARA DIMINUIÇÃO DE QUANTIDADE QUANDO ACONTECER VENDA*/ 
DELIMITER $$
CREATE TRIGGER diminuicaoDeQTD after update
ON tb_venda FOR EACH ROW BEGIN /*diminui a qtd normalmente */ 
IF (new.venda_finalizada = true AND old.venda_finalizada = false) THEN 

UPDATE tb_produto
INNER JOIN tb_produto_usado
ON tb_produto_usado.fk_produto_id = tb_produto.id_produto
SET tb_produto.quantidade_produto = tb_produto.quantidade_produto - tb_produto_usado.quantidade_produto_usado, 
tb_produto.quantidade_virtual_produto = tb_produto.quantidade_virtual_produto - tb_produto_usado.quantidade_produto_usado
WHERE tb_produto_usado.fk_venda_id = new.id_venda ;

ELSEIF(new.venda_finalizada = false AND old.venda_finalizada = true) THEN 

UPDATE tb_produto 
INNER JOIN tb_produto_usado
ON tb_produto_usado.fk_produto_id = tb_produto.id_produto
SET tb_produto.quantidade_produto = tb_produto.quantidade_produto + tb_produto_usado.quantidade_produto_usado, 
tb_produto.quantidade_virtual_produto = tb_produto.quantidade_virtual_produto + tb_produto_usado.quantidade_produto_usado
WHERE tb_produto_usado.fk_venda_id = new.id_venda ;

END IF; END $$ DELIMITER ; 

/*TRIGGER PARA DIMINUIÇÃO DE QUANTIDADE QUANDO PRODUTO FOR BUSCADO
DELIMITER $$
CREATE TRIGGER diminuicaoDeQTDqndProdutoBuscado after update
ON tb_produto_selecionado FOR EACH ROW BEGIN IF (new.buscado_produto_selecionado = true AND old.buscado_produto_selecionado = false) THEN UPDATE tb_produto
INNER JOIN tb_produto_selecionado
ON tb_produto_selecionado.fk_produto_id = tb_produto.id_produto
SET tb_produto.quantidade_produto = tb_produto.quantidade_produto - tb_produto_usado.quantidade_produto_usado
WHERE tb_produto_usado.fk_venda_id = new.id_produto_selecionado ;

ELSEIF(new.buscado_produto_selecionado = false AND old.buscado_produto_selecionado = true) THEN UPDATE tb_produto 
INNER JOIN tb_produto_selecionado
ON tb_produto_selecionado.fk_produto_id = tb_produto.id_produto
SET tb_produto.quantidade_produto = tb_produto.quantidade_produto + tb_produto_usado.quantidade_produto_usado
WHERE tb_produto_usado.fk_venda_id = new.id_produto_selecionado ; 
END IF; END $$ DELIMITER ; */