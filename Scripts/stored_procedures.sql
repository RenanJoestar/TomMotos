-- -----------------------------------------------------
-- procedure CriacaoProduto
-- -----------------------------------------------------
DELIMITER $$
CREATE PROCEDURE CriacaoProduto (IN DESCRICAO VARCHAR(45), IN QUANTIDADE_PRODUTO INT, QUANTIDADE_PRODUTO_VIRTUAL INT, IN VALOR_PRODUTO double, IN MARCA VARCHAR(40), IN IMAGEM LONGBLOB)
BEGIN
DECLARE CUSTOM_EXCEPTION CONDITION FOR SQLSTATE '45000';
IF EXISTS(SELECT*FROM tb_produto where tb_produto.descricao_produto = DESCRICAO AND tb_produto.valor_produto = VALOR_PRODUTO) THEN
BEGIN
SIGNAL CUSTOM_EXCEPTION
SET MESSAGE_TEXT = 'ERRO, PRODUTO JA EXISTE';
END;
ELSE 
INSERT INTO tb_produto(descricao_produto, quantidade_produto, valor_produto, marca_produto, quantidade_virtual_produto, imagem_produto)values(DESCRICAO,QUANTIDADE_PRODUTO,VALOR_PRODUTO,MARCA,QUANTIDADE_PRODUTO_VIRTUAL,IMAGEM);
END IF;
END $$
DELIMITER ;

-- -----------------------------------------------------
-- MostrarProdutoPorID
-- -----------------------------------------------------
DELIMITER $$
CREATE PROCEDURE MostrarProdutoPorID(IN ID INT) 
BEGIN
select*from tb_produto
where tb_produto.id_produto = ID;

END$$
DELIMITER ;
-- -----------------------------------------------------
-- MostrarProduto
-- -----------------------------------------------------
DELIMITER $$
CREATE PROCEDURE MostrarProduto() 
select*from tb_produto

end$$
DELIMITER ;
-- -----------------------------------------------------
-- procedure MostrarVendaPorID
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `MostrarVendaPorID`(IN ID_CLIENTE int)
BEGIN
select 
tb_venda.id_venda,
tb_venda.descricao_mao_de_obra,
tb_venda.preco_mao_de_obra, 
tb_veiculo.placa_veiculo, 
tb_veiculo.modelo_veiculo,
tb_cliente.nome_cliente,
tb_cliente.cpf_cliente, 
tb_produto_usado.quantidade_produto_usado, 
tb_produto_usado.validade_da_garantia_produto, 
tb_produto.descricao_produto,
tb_produto.valor_produto, 
tb_produto.marca_produto, 
tb_produto.imagem_produto, 
tb_funcionario.nome_funcionario,
tb_venda.data_venda,
tb_venda.validade_orcamento_servico,
tb_venda.total_venda
 from tb_venda
 inner join tb_veiculo on tb_venda.fk_veiculo_id = tb_veiculo.id_veiculo
 inner join tb_cliente on tb_venda.fk_cliente_id = tb_cliente.id_cliente
 inner join tb_produto_usado on tb_produto_usado.fk_venda_id = tb_produto_usado.id_produto_usado
 inner join tb_produto on tb_produto_usado.fk_produto_id = tb_produto.id_produto
 inner join tb_grupo_funcionarios on tb_grupo_funcionarios.fk_venda_id = tb_grupo_funcionarios.id_grupo_funcionarios
 where tb_cliente.id_cliente = ID_CLIENTE;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure MostrarVendas
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `MostrarVendas`()
BEGIN
select 
tb_venda.id_venda,
tb_venda.descricao_mao_de_obra,
tb_venda.preco_mao_de_obra, 
tb_veiculo.placa_veiculo, 
tb_veiculo.modelo_veiculo,
tb_cliente.nome_cliente,
tb_cliente.cpf_cliente, 
tb_produto_usado.quantidade_produto_usado, 
tb_produto_usado.validade_da_garantia_produto, 
tb_produto.descricao_produto,
tb_produto.valor_produto, 
tb_produto.marca_produto, 
tb_produto.imagem_produto, 
tb_funcionario.nome_funcionario,
tb_venda.data_venda,
tb_venda.validade_orcamento_servico,
tb_venda.total_venda
 from tb_venda
 inner join tb_veiculo on tb_venda.fk_veiculo_id = tb_veiculo.id_veiculo
 inner join tb_cliente on tb_venda.fk_cliente_id = tb_cliente.id_cliente
 inner join tb_produto_usado on tb_produto_usado.fk_venda_id = tb_produto_usado.id_produto_usado
 inner join tb_produto on tb_produto_usado.fk_produto_id = tb_produto.id_produto
 inner join tb_grupo_funcionarios on tb_grupo_funcionarios.fk_venda_id = tb_grupo_funcionarios.id_grupo_funcionarios;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure criacaoCargo
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `criacaoCargo`(IN NOME VARCHAR(50), IN SALARIO DOUBLE)
BEGIN DECLARE CUSTOM_EXCEPTION CONDITION FOR SQLSTATE '45000'; 
IF NOT EXISTS (

select * from tb_cargo where tb_cargo.nome_cargo = NOME) THEN BEGIN 

INSERT INTO tb_cargo(nome_cargo , salario_cargo) VALUES(NOME , SALARIO);
 END; 
 ELSE SIGNAL CUSTOM_EXCEPTION

SET MESSAGE_TEXT = 'ERRO, CARGO JA EXISTE'; END IF; END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure criacaoCliente
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `criacaoCliente`(IN NOME varchar(15), IN SOBRENOME varchar(40), IN DATA_NASC DATE, CPF varchar(15), CNPJ varchar(45))
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
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure criacaoEmail
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `criacaoEmail`(IN EMAIL VARCHAR(50), IN FK_USUARIO INT)
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
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure criacaoEndereco
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `criacaoEndereco`(IN CEP varchar(15), IN RUA varchar(40), IN CIDADE text, IN BAIRRO varchar(15),IN NUMERO varchar(45),IN FK_USUARIO INT )
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
END$$

DELIMITER ;


-- -----------------------------------------------------
-- procedure criacaoFornecedor
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `criacaoFornecedor`(IN NOME VARCHAR(50), IN CNPJ varchar(45))
BEGIN DECLARE CUSTOM_EXCEPTION CONDITION FOR SQLSTATE '45000'; IF NOT EXISTS (

select * from tb_fornecedor where tb_fornecedor.cnpj_fornecedor = CNPJ) THEN BEGIN 

INSERT INTO tb_fornecedor(nome_fornecedor, cnpj_fornecedor) VALUES(NOME , CNPJ); END; 
insert into tb_usuario(fk_fornecedor_id)values(LAST_INSERT_ID());

ELSE SIGNAL CUSTOM_EXCEPTION

SET MESSAGE_TEXT = 'ERRO, FORNECEDOR JA EXISTE'; END IF; END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure criacaoFuncionario
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `criacaoFuncionario`(IN NOME VARCHAR(50), IN SOBRENOME varchar(100), CPF varchar(16), DATA_NASC date, DATA_CONT date, SEXO char, FK_CARGO_ID INT)
BEGIN DECLARE CUSTOM_EXCEPTION CONDITION FOR SQLSTATE '45000'; IF NOT EXISTS (

select * from tb_funcionario where tb_funcionario.cpf_funcionario = CPF) THEN BEGIN 

INSERT INTO tb_funcionario(nome_funcionario, sobrenome_funcionario, cpf_funcionario, data_nascimento_funcionario, data_contratacao_funcionario, sexo_funcionario, fk_cargo_id) VALUES(NOME, SOBRENOME, CPF, DATA_NASC, DATA_CONT, SEXO, FK_CARGO_ID);
insert into tb_usuario(fk_funcionario_id)values(LAST_INSERT_ID());

 END; ELSE SIGNAL CUSTOM_EXCEPTION

SET MESSAGE_TEXT = 'ERRO, FUNCIONARIO JA EXISTE'; END IF; END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure criacaoGrupoFuncionarios
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `criacaoGrupoFuncionarios`(IN FK_VENDA_ID INT, IN FK_FUNCIONARIO_ID INT)
BEGIN 
INSERT INTO tb_grupo_funcionarios(fk_venda_id, fk_funcionario_id) VALUES(FK_VENDA_ID, FK_FUNCIONARIO_ID); 
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure criacaoLogdeFornecimento
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `criacaoLogdeFornecimento`(IN QTD_PRODUTO INT, IN FK_PRODUTO_ID INT, IN FK_FORNECEDOR_ID INT)
BEGIN 
INSERT INTO tb_log_fornecimento(qtd_produto_fornecido, fk_produto_id, fk_funcionario_id) VALUES(QTD_PRODUTO, FK_PRODUTO_ID, FK_FORNECEDOR_ID); 
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure criacaoTelefone
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `criacaoTelefone`(IN TELEFONE VARCHAR(17), IN FK_USUARIO INT)
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
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure criacaoUsuario
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `criacaoUsuario`(IN FK_ALGUEM_ID INT, IN QUEM INT)
BEGIN 
IF (QUEM = 0) THEN 
INSERT INTO tb_usuario(fk_funcionario_id) VALUE (FK_ALGUEM_ID); 
END IF ;
IF (QUEM = 1) THEN 
INSERT INTO tb_usuario(fk_cliente_id) VALUE (FK_ALGUEM_ID); 
END IF ;
IF (QUEM = 2) THEN 
INSERT INTO tb_usuario(fk_fornecedor_id) VALUE (FK_ALGUEM_ID); 
END IF ;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure criacaoVeiculo
-- -----------------------------------------------------
select*from tb_cliente;
DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `criacaoVeiculo`(IN MARCA VARCHAR(30), IN MODELO VARCHAR(30), IN COR VARCHAR(30), IN ANO VARCHAR(30), IN KM VARCHAR(30), IN PLACA VARCHAR(12), IN OBS VARCHAR(300), IN FK_CLIENTE INT)
BEGIN 
DECLARE CUSTOM_EXCEPTION CONDITION FOR SQLSTATE '45000';
if exists(select marca_veiculo, modelo_veiculo, placa_veiculo, fk_cliente_id from tb_veiculo where modelo_veiculo = MODELO AND marca_veiculo = MARCA and fk_cliente_id = FK_CLIENTE)then
 SIGNAL CUSTOM_EXCEPTION
     SET MESSAGE_TEXT = 'ERRO, VEICULO JA CADASTRADO';
ELSE 
INSERT INTO tb_veiculo(marca_veiculo, modelo_veiculo, cor_veiculo, ano_veiculo, km_veiculo, placa_veiculo, obs_veiculo, fk_cliente_id) VALUES (MARCA, MODELO, COR, ANO, KM, PLACA, OBS, FK_CLIENTE);
END IF;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure criacaoVenda
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `criacaoVenda`(IN DESCRICAO TEXT, IN VALIDADE_ORCAMENTO_SERVICO date, PRECO_MAO_DE_OBRA double, IN FK_VEICULO_ID INT, IN FK_CLIENTE_ID INT)
BEGIN
INSERT INTO tb_venda /*INSERE*/ 
(tb_venda.descricao_mao_de_obra, tb_venda.validade_orcamento_servico, 
tb_venda.preco_mao_de_obra, tb_venda.fk_veiculo_id, tb_venda.fk_cliente_id) 
values 
(DESCRICAO, VALIDADE_ORCAMENTO_SERVICO, 
PRECO_MAO_DE_OBRA, FK_VEICULO_ID, FK_CLIENTE_ID); 
END$$

DELIMITER ;

/*STORED PROCEDURE PARA MOSTRAR CLIENTES*/
DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarClientes`()
BEGIN
select 
tb_cliente.id_cliente,
tb_cliente.nome_cliente,
tb_cliente.sobrenome_cliente,
tb_cliente.data_nascimento_cliente,
tb_cliente.cpf_cliente,
tb_cliente.cnpj_cliente,
tb_email.nome_email,
tb_telefone.numero_telefone,
tb_endereco.rua_endereco,
tb_endereco.numero_endereco,
tb_endereco.cep_endereco,
tb_veiculo.modelo_veiculo,
tb_veiculo.cor_veiculo,
tb_veiculo.placa_veiculo
 from tb_cliente
 inner join tb_usuario on tb_cliente.id_cliente = tb_usuario.fk_cliente_id
 inner join tb_telefone on tb_usuario.id_usuario = tb_telefone.fk_usuario_id
 inner join tb_endereco on tb_usuario.id_usuario = tb_endereco.fk_usuario_id
 inner join tb_email on tb_usuario.id_usuario = tb_email.fk_usuario_id
inner join tb_veiculo on tb_cliente.id_cliente = tb_veiculo.fk_cliente_id;
END $$
DELIMITER ;
;

/*STORED PROCEDURE PARA MOSTRAR CLIENTE POR ID*/
DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarClientePorID`(IN ID_CLIENTE int)
BEGIN
select 
tb_cliente.id_cliente,
tb_cliente.nome_cliente,
tb_cliente.sobrenome_cliente,
tb_cliente.data_nascimento_cliente,
tb_cliente.cpf_cliente,
tb_cliente.cnpj_cliente,
tb_email.nome_email,
tb_telefone.numero_telefone,
tb_endereco.rua_endereco,
tb_endereco.numero_endereco,
tb_endereco.cep_endereco,
tb_veiculo.modelo_veiculo,
tb_veiculo.cor_veiculo,
tb_veiculo.placa_veiculo
 from tb_cliente
 inner join tb_usuario on tb_cliente.id_cliente = tb_usuario.fk_cliente_id
 inner join tb_telefone on tb_usuario.id_usuario = tb_telefone.fk_usuario_id
 inner join tb_endereco on tb_usuario.id_usuario = tb_endereco.fk_usuario_id
 inner join tb_email on tb_usuario.id_usuario = tb_email.fk_usuario_id
 inner join tb_veiculo on tb_cliente.id_cliente = tb_veiculo.fk_cliente_id
 where tb_cliente.id_cliente = ID_CLIENTE;
END $$
DELIMITER ;
;

/*STORED PROCEDURE PARA MOSTRAR FUNCIONARIOS*/
DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarFuncionarios`()
BEGIN
select 
tb_funcionario.id_funcionario,
tb_funcionario.nome_funcionario,
tb_funcionario.sobrenome_funcionario,
tb_funcionario.cpf_funcionario,
tb_funcionario.data_nascimento_funcionario,
tb_funcionario.data_contratacao_funcionario,
tb_funcionario.sexo_funcionario,
tb_email.nome_email,
tb_telefone.numero_telefone,
tb_endereco.rua_endereco,
tb_endereco.numero_endereco,
tb_endereco.cep_endereco,
tb_cargo.nome_cargo,
tb_cargo.salario_cargo
 from tb_funcionario
 inner join tb_usuario on tb_funcionario.id_funcionario = tb_usuario.fk_funcionario_id
 inner join tb_telefone on tb_usuario.id_usuario = tb_telefone.fk_usuario_id
 inner join tb_endereco on tb_usuario.id_usuario = tb_endereco.fk_usuario_id
 inner join tb_email on tb_usuario.id_usuario = tb_email.fk_usuario_id
 inner join tb_cargo on tb_cargo.id_cargo = tb_funcionario.fk_cargo_id;
END $$
DELIMITER ;
;

/*STORED PROCEDURE PARA MOSTRAR FUNCIONARIOS POR ID*/
DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarFuncionarioPorID`(IN ID_FUNCIONARIO int)
BEGIN
select 
tb_funcionario.id_funcionario,
tb_funcionario.nome_funcionario,
tb_funcionario.sobrenome_funcionario,
tb_funcionario.cpf_funcionario,
tb_funcionario.data_nascimento_funcionario,
tb_funcionario.data_contratacao_funcionario,
tb_funcionario.sexo_funcionario,
tb_email.nome_email,
tb_telefone.numero_telefone,
tb_endereco.rua_endereco,
tb_endereco.numero_endereco,
tb_endereco.cep_endereco,
tb_cargo.nome_cargo,
tb_cargo.salario_cargo
 from tb_funcionario
 inner join tb_usuario on tb_funcionario.id_funcionario = tb_usuario.fk_funcionario_id
 inner join tb_telefone on tb_usuario.id_usuario = tb_telefone.fk_usuario_id
 inner join tb_endereco on tb_usuario.id_usuario = tb_endereco.fk_usuario_id
 inner join tb_email on tb_usuario.id_usuario = tb_email.fk_usuario_id
 inner join tb_cargo on tb_cargo.id_cargo = tb_funcionario.fk_cargo_id
 where tb_funcionario.id_funcionario = ID_FUNCIONARIO;
END $$
DELIMITER ;
;

/*STORED PROCEDURE PARA MOSTRAR FORNECEDORES*/
DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarFornecedores`()
BEGIN
select 
tb_fornecedor.nome_fornecedor,
tb_fornecedor.cnpj_fornecedor,
tb_email.nome_email,
tb_telefone.numero_telefone,
tb_endereco.rua_endereco,
tb_endereco.numero_endereco,
tb_endereco.cep_endereco
 from tb_fornecedor
 inner join tb_usuario on tb_fornecedor.id_fornecedor = tb_usuario.fk_fornecedor_id
 inner join tb_telefone on tb_usuario.id_usuario = tb_telefone.fk_usuario_id
 inner join tb_endereco on tb_usuario.id_usuario = tb_endereco.fk_usuario_id
 inner join tb_email on tb_usuario.id_usuario = tb_email.fk_usuario_id;
END $$
DELIMITER ;
;

/*STORED PROCEDURE PARA MOSTRAR FORNECEDORES POR ID*/
DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `mostrarFornecedorPorID`(IN IF_FORNECEDOR int)
BEGIN
select 
tb_fornecedor.nome_fornecedor,
tb_fornecedor.cnpj_fornecedor,
tb_email.nome_email,
tb_telefone.numero_telefone,
tb_endereco.rua_endereco,
tb_endereco.numero_endereco,
tb_endereco.cep_endereco
 from tb_fornecedor
 inner join tb_usuario on tb_fornecedor.id_fornecedor = tb_usuario.fk_fornecedor_id
 inner join tb_telefone on tb_usuario.id_usuario = tb_telefone.fk_usuario_id
 inner join tb_endereco on tb_usuario.id_usuario = tb_endereco.fk_usuario_id
 inner join tb_email on tb_usuario.id_usuario = tb_email.fk_usuario_id
 where tb_fornecedor.id_fornecedor = IF_FORNECEDOR;
END $$
DELIMITER ;

/*STORED PROCEDURE PARA MUDAR STATUS DA VENDA*/
DELIMITER $$
CREATE PROCEDURE mudarStatusVenda(IN idVenda INT, IN novoStatusProduto bool)
BEGIN
		UPDATE tb_venda
		set tb_venda.venda_finalizada = novoStatusProduto
		WHERE tb_venda.id_venda = idVenda;
END$$
DELIMITER ;

/*STORED PROCEDURE PARA MUDAR STATUS DO PRODUTO*/
DELIMITER $$
CREATE PROCEDURE mudarStatusProduto(IN idProdutoSelecionado INT, IN novoStatusProduto bool)
BEGIN
		UPDATE tb_produto_selecionado
		set tb_produto_selecionado.buscado_produto_selecionado = novoStatusProduto
		WHERE tb_produto_selecionado.id_produtoUsado = idProdutoSelecionado;
END$$
DELIMITER ;