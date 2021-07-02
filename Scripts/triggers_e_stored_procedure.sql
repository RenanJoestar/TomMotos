/*STORED PROCEDURE PARA CRIAÇÃO DE CLIENTE*/
DELIMITER $$
CREATE PROCEDURE criacaoCliente (IN NOME varchar(15), IN SOBRENOME varchar(40), IN DATA_NASC DATE, CPF varchar(15), CNPJ varchar(45))
BEGIN
DECLARE CUSTOM_EXCEPTION CONDITION FOR SQLSTATE '45000';
 IF EXISTS(SELECT*FROM tb_cliente where tb_cliente.cpf_cliente = CPF)THEN
    BEGIN
     SIGNAL CUSTOM_EXCEPTION
     SET MESSAGE_TEXT = 'ERRO, CPF JA EXISTE';
      END;
     
     ELSEIF EXISTS(SELECT*FROM tb_cliente where tb_cliente.cnpj_cliente = CNPJ)THEN
    BEGIN
     SIGNAL CUSTOM_EXCEPTION
     SET MESSAGE_TEXT = 'ERRO, CNPJ JA EXISTE';
      END;
	    
	ELSE  
		insert into tb_cliente(tb_cliente.nome_cliente, tb_cliente.sobrenome_cliente, tb_cliente.data_nascimento_cliente, tb_cliente.cpf_cliente, tb_cliente.cnpj_cliente) values (NOME, SOBRENOME, DATA_NASC, CPF, CNPJ);
		
        insert into tb_usuario(fk_cliente_id)values(LAST_INSERT_ID());
  END IF;
END
$$

DELIMITER ;

/*STORED PROCEDURE PARA CRIAÇÃO DE ENDERECO*/
DELIMITER $$
CREATE PROCEDURE criacaoEndereco (IN CEP varchar(15), IN RUA varchar(40), IN CIDADE text, IN BAIRRO varchar(15),IN NUMERO varchar(45),IN FK_USUARIO INT )
BEGIN
DECLARE CUSTOM_EXCEPTION CONDITION FOR SQLSTATE '45000';
IF NOT EXISTS (select tb_endereco.fk_usuario_id, tb_endereco.numero_endereco, tb_endereco.cep_endereco from tb_endereco
inner join tb_usuario on tb_endereco.fk_usuario_id = tb_usuario.id_usuario where tb_endereco.cep_endereco = CEP  and tb_endereco.numero_endereco = NUMERO and tb_endereco.fk_usuario_id = FK_USUARIO) THEN
BEGIN
INSERT INTO tb_endereco(cep_endereco,rua_endereco,cidade_endereco,bairro_endereco,numero_endereco,fk_usuario_id) VALUES(CEP,RUA,CIDADE , BAIRRO,NUMERO,FK_USUARIO);
END;
ELSE 
 SIGNAL CUSTOM_EXCEPTION
     SET MESSAGE_TEXT = 'ERRO, ENDEREÇO JA EXISTE';
END IF;
END 
$$

DELIMITER ;

/*STORED PROCEDURE PARA CRIAÇÃO DE TELEFONE*/
DELIMITER $$
CREATE PROCEDURE criacaoTelefone (IN TELEFONE VARCHAR(17), IN FK_USUARIO INT)
BEGIN
DECLARE CUSTOM_EXCEPTION CONDITION FOR SQLSTATE '45000';
IF NOT EXISTS (select tb_telefone.fk_usuario_id, tb_telefone.numero_telefone from tb_telefone
inner join tb_usuario on tb_telefone.fk_usuario_id = tb_usuario.id_usuario where tb_telefone.numero_telefone = TELEFONE and tb_telefone.fk_usuario_id = FK_USUARIO) THEN
BEGIN
INSERT INTO tb_telefone(numero_telefone,fk_usuario_id) VALUES(TELEFONE ,FK_USUARIO);
END;
ELSE 
 SIGNAL CUSTOM_EXCEPTION
     SET MESSAGE_TEXT = 'ERRO, TELEFONE JA EXISTE';
END IF;
END 
$$
DELIMITER ;

/*STORED PROCEDURE PARA CRIAÇÃO DE EMAIL*/
DELIMITER $$
CREATE PROCEDURE criacaoEmail (IN EMAIL VARCHAR(50), IN FK_USUARIO INT)
BEGIN
DECLARE CUSTOM_EXCEPTION CONDITION FOR SQLSTATE '45000';
IF NOT EXISTS (select tb_email.fk_usuario_id, tb_email.nome_email from tb_email
inner join tb_usuario on tb_email.fk_usuario_id = tb_usuario.id_usuario where tb_email.nome_email = EMAIL and tb_email.fk_usuario_id = FK_USUARIO) THEN
BEGIN
INSERT INTO tb_email(nome_email ,fk_usuario_id) VALUES(EMAIL ,FK_USUARIO);
END;
ELSE 
 SIGNAL CUSTOM_EXCEPTION
     SET MESSAGE_TEXT = 'ERRO, EMAIL JA EXISTE';
END IF;
END 
$$
DELIMITER ;


/*STORE PROCEDURE PARA MOSTRAR DADOS DA VENDA*/
DELIMITER $$
CREATE PROCEDURE MostrarVenda()
BEGIN
select 
tb_venda.id_venda, 
tb_venda.descricao_venda, 
tb_venda.preco_mao_de_obra, 
tb_venda.validade_orcamento_servico, 
tb_venda.data_venda,
tb_venda.total_venda, 
tb_cliente.nome_cliente, 
tb_cliente.cpf_cliente,
tb_produto.descricao_produto,
tb_veiculo.marca_veiculo,
tb_veiculo.placa_veiculo,
tb_funcionario.nome_funcionario
from tb_venda
 inner join tb_usuario on tb_venda.fk_usuario_id = tb_usuario.id_usuario
 inner join tb_cliente on tb_cliente.id_cliente = tb_usuario.fk_cliente_id
 inner join tb_produto_usado on tb_produto_usado.fk_venda_id = tb_venda.id_venda
 inner join tb_produto on tb_produto_usado.fk_produto_id = tb_produto.id_produto
 inner join tb_grupo_funcionarios on tb_grupo_funcionarios.fk_venda_id = tb_venda.id_venda
 inner join tb_funcionario on tb_grupo_funcionarios.fk_funcionario_id = tb_funcionario.id_funcionario
 inner join tb_veiculo on tb_veiculo.id_veiculo = tb_venda.fk_veiculo_id ; 
END 
$$
DELIMITER ;

/* CALLS */
CALL MostrarVenda;
call criacaoEndereco('1234','pereira','santana','germano','284',5);
call criacaoTelefone('123','5');
call criacaoEmail('samuel@gmail.com','5');
call criacaoCliente('Samuel', 'Santos Souza', null,null,null);
call criacaoCliente('Matheus', 'Santos', null,null,null);


/*INSERTS */
insert into tb_veiculo(marca_veiculo, modelo_veiculo, placa_veiculo,fk_cliente_id) values("honda","fazer","12345",9);
insert into tb_venda(descricao_venda, preco_mao_de_obra, total_venda, fk_usuario_id, fk_veiculo_id) values ('DESCRIÇÃO', 10, 150, 5, null);
insert tb_cargo(nome_cargo, salario_cargo) values ('MECANICO', 1000);
insert tb_funcionario(nome_funcionario, sobrenome_funcionario, fk_cargo_id) values ('JOÃO', 'SANTOS', 3);
insert tb_funcionario(nome_funcionario, sobrenome_funcionario, fk_cargo_id) values ('ANDRÉ', 'SOUZA', 3);
insert tb_grupo_funcionarios(fk_venda_id, fk_funcionario_id) values (3, 3);
insert tb_grupo_funcionarios(fk_venda_id, fk_funcionario_id) values (3, 4);
insert into tb_produto(tb_produto.imagem_produto, tb_produto.descricao_produto, tb_produto.quantidade_produto, tb_produto.quantidade_virtual_produto, tb_produto.valor_produto, tb_produto.marca_produto) values('', "Oléo semi sintético", 200, 200, 22, "Mobil");
insert into tb_produto(tb_produto.imagem_produto, tb_produto.descricao_produto, tb_produto.quantidade_produto, tb_produto.quantidade_virtual_produto,tb_produto.valor_produto, tb_produto.marca_produto) values ('', "Filtro de ar", 200, 200, 100, "Honda");
insert into tb_produto_usado(quantidade_produto_usado, fk_produto_id, fk_venda_id) values (4, 5, 3);
insert into tb_produto_usado(quantidade_produto_usado, fk_produto_id, fk_venda_id) values (5, 5, 3);


/*SELECTS

select * from tb_cliente;
select * from tb_cargo;
select * from tb_funcionario;
select * from tb_grupo_funcionarios;
select * from tb_usuario;
select * from tb_venda;
select * from tb_produto;
select * from tb_produto_usado;
select * from tb_veiculo;



/*TRIGGER PARA DIMINUIÇÃO DE QUANTIDADE QUANDO ACONTECER VENDA*/
DELIMITER $$ 
CREATE TRIGGER diminuicaoDeQTD after insert on tb_venda FOR EACH ROW
BEGIN

/*diminui a qtd normalmente */
		UPDATE tb_produto 
        inner join tb_produto_usado
        on tb_produto_usado.fk_produto_id = tb_produto.id_produto 
        inner join tb_cliente
        on tb_produto_selecionado.fk_cliente_id = tb_cliente.id_cliente
		set tb_produto.quantidade_produto = tb_produto.quantidade_produto - tb_produto_usado.quantidade_produto_usado
		where fk_produto_id = tb_produto.id_produto
        AND   fk_cliente_id = tb_cliente.id_cliente;

END
$$
DELIMITER ;

/*STORED PROCEDURE PARA ACRESCENTAR VENDA*/
DELIMITER $$
CREATE PROCEDURE acrescentarVenda(IN descricao VARCHAR(300), IN dataVenda date, IN validade date /*nao tenho certeza se é date*/, precoMaoDeObra double)
BEGIN
		insert into tb_venda /*INSERE*/
					(tb_venda.descricao_venda,
					tb_venda.validade_orcamento_servico,
					tb_venda.data_venda, 
					tb_venda.precoMaoDeObra) 
                    /* variavel da mao de obra*/
				values (descricao , dataVenda, validade, precoMaoDeObra); 

END$$
DELIMITER ;
/* usar um foreach para chamar acrescentarProdutoUsado e acrescentar todos os produtos usados na venda */

/*STORED PROCEDURE PARA ACRESCENTAR PRODUTOS USADOS*/
DELIMITER $$
CREATE PROCEDURE acrescentarProdutoUsado(IN qtdProdutoUsado INT, IN idProdutoUsado INT, IN idVenda INT)
BEGIN
		insert into tb_produto_usado /*INSERE*/
					(tb_produto_usado.quantidade_produto_usado, 
					tb_produto_usado.fk_produto_id, 
					tb_produto_usado.fk_venda_id 
					)
				values (qtdProdutoUsado, idProdutoUsado, idVenda); 
END$$
DELIMITER ;

/*TRIGGER PARA DIMINUIÇÃO DE QUANTIDADE QUANDO PRODUTO FOR BUSCADO*/
DELIMITER $$ 
CREATE TRIGGER diminuicaoDeQTDqndProdutoBuscado after update on tb_produto_selecionado FOR EACH ROW
BEGIN
	IF (new.buscado_produto_selecionado = true AND old.buscado_produto_selecionado = false) THEN
		UPDATE tb_produto 
        inner join tb_produto_selecionado 
        on tb_produto_selecionado.fk_produto_id = tb_produto.id_produto 
        inner join tb_cliente
        on tb_produto_selecionado.fk_cliente_id = tb_cliente.id_cliente
		set tb_produto.quantidade_produto = tb_produto.quantidade_produto - tb_produto_selecionado.qtd_produto_selecionado
		where new.fk_produto_id = tb_produto.id_produto
        AND   new.fk_cliente_id = tb_cliente.id_cliente;
	ELSEIF (new.buscado_produto_selecionado = false AND old.buscado_produto_selecionado = true) THEN
    UPDATE tb_produto 
        inner join tb_produto_selecionado 
        on tb_produto_selecionado.fk_produto_id = tb_produto.id_produto 
        inner join tb_cliente
        on tb_produto_selecionado.fk_cliente_id = tb_cliente.id_cliente
		set tb_produto.quantidade_produto = tb_produto.quantidade_produto + tb_produto_selecionado.qtd_produto_selecionado
		where new.fk_produto_id = tb_produto.id_produto
        AND   new.fk_cliente_id = tb_cliente.id_cliente;
    END IF;
END
$$
DELIMITER ;