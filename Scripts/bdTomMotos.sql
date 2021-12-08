CREATE SCHEMA IF NOT EXISTS `bd_tommotos` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `bd_tommotos` ;

-- -----------------------------------------------------
-- Table `bd_tommotos`.`tb_cargo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_tommotos`.`tb_cargo` (
  `id_cargo` INT NOT NULL AUTO_INCREMENT,
  `nome_cargo` VARCHAR(100) NULL DEFAULT NULL,
  `salario_cargo` DOUBLE NULL DEFAULT NULL,
  PRIMARY KEY (`id_cargo`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

-- -----------------------------------------------------
-- Table `bd_tommotos`.`tb_cliente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_tommotos`.`tb_cliente` (
  `id_cliente` INT NOT NULL AUTO_INCREMENT,
  `nome_cliente` VARCHAR(15) NOT NULL,
  `sobrenome_cliente` VARCHAR(40) NULL DEFAULT NULL,
  `data_nascimento_cliente` varchar(15) NULL DEFAULT NULL,
  `cpf_cliente` VARCHAR(15) NULL DEFAULT NULL,
  `cnpj_cliente` VARCHAR(20) NULL DEFAULT NULL,
  PRIMARY KEY (`id_cliente`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

-- -----------------------------------------------------
-- Table `bd_tommotos`.`tb_fornecedor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_tommotos`.`tb_fornecedor` (
  `id_fornecedor` INT NOT NULL AUTO_INCREMENT,
  `nome_fornecedor` VARCHAR(100) NULL DEFAULT NULL,
  `cnpj_fornecedor` VARCHAR(20) NULL DEFAULT NULL,
  PRIMARY KEY (`id_fornecedor`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

/*ALTER TABLE tb_cliente  MODIFY COLUMN data_nascimento_cliente varchar(15);*/
-- -----------------------------------------------------
-- Table `bd_tommotos`.`tb_funcionario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_tommotos`.`tb_funcionario` (
  `id_funcionario` INT NOT NULL AUTO_INCREMENT,
  `nome_funcionario` VARCHAR(50) NOT NULL,
  `sobrenome_funcionario` VARCHAR(40) NULL DEFAULT NULL,
  `cpf_funcionario` VARCHAR(15) NOT NULL,
  `data_nascimento_funcionario` varchar(15) NULL DEFAULT NULL,
  `data_contratacao_funcionario` varchar(15) NULL DEFAULT NULL,
  `sexo_funcionario` CHAR(1) NULL DEFAULT '?',
  `fk_cargo_id` INT NULL DEFAULT NULL,
  PRIMARY KEY (`id_funcionario`),
  INDEX `fk_cargo_idx` (`fk_cargo_id` ASC) VISIBLE,
  CONSTRAINT `fk_cargo`
    FOREIGN KEY (`fk_cargo_id`)
    REFERENCES `bd_tommotos`.`tb_cargo` (`id_cargo`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bd_tommotos`.`tb_usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_tommotos`.`tb_usuario` (
  `id_usuario` INT NOT NULL AUTO_INCREMENT,
   `senha` VARCHAR(45) NULL,
  `fk_funcionario_id` INT NULL DEFAULT NULL,
  `fk_cliente_id` INT NULL DEFAULT NULL,
  `fk_fornecedor_id` INT NULL DEFAULT NULL,
  PRIMARY KEY (`id_usuario`),
  INDEX `fk_tb_usuario_tb_funcionario1_idx` (`fk_funcionario_id` ASC) VISIBLE,
  INDEX `fk_tb_usuario_tb_cliente1_idx` (`fk_cliente_id` ASC) VISIBLE,
  INDEX `fk_tb_usuario_tb_fornecedor1_idx` (`fk_fornecedor_id` ASC) VISIBLE,
  CONSTRAINT `fk_tb_usuario_tb_cliente1`
    FOREIGN KEY (`fk_cliente_id`)
    REFERENCES `bd_tommotos`.`tb_cliente` (`id_cliente`)ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_tb_usuario_tb_fornecedor1`
    FOREIGN KEY (`fk_fornecedor_id`)
    REFERENCES `bd_tommotos`.`tb_fornecedor` (`id_fornecedor`)ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_tb_usuario_tb_funcionario1`
    FOREIGN KEY (`fk_funcionario_id`)
    REFERENCES `bd_tommotos`.`tb_funcionario` (`id_funcionario`)ON DELETE CASCADE ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bd_tommotos`.`tb_email`
-- -----------------------------------------------------


CREATE TABLE IF NOT EXISTS `bd_tommotos`.`tb_email` (
  `id_email` INT NOT NULL AUTO_INCREMENT,
  `nome_email` VARCHAR(50) NULL DEFAULT NULL,
  `fk_usuario_id` INT NOT NULL,
  PRIMARY KEY (`id_email`),
  INDEX `fk_tb_email_tb_usuario1_idx` (`fk_usuario_id` ASC) VISIBLE,
  CONSTRAINT `fk_tb_email_tb_usuario1`
    FOREIGN KEY (`fk_usuario_id`)
    REFERENCES `bd_tommotos`.`tb_usuario` (`id_usuario`)ON DELETE CASCADE ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

-- -----------------------------------------------------
-- Table `bd_tommotos`.`tb_endereco`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_tommotos`.`tb_endereco` (
  `id_endereco` INT NOT NULL AUTO_INCREMENT,
  `cep_endereco` VARCHAR(20) NULL DEFAULT NULL,
  `rua_endereco` VARCHAR(100) NOT NULL,
  `cidade_endereco` VARCHAR(50) NULL DEFAULT NULL,
  `bairro_endereco` VARCHAR(70) NULL DEFAULT NULL,
  `numero_endereco` VARCHAR(20) NOT NULL,
  `fk_usuario_id` INT NOT NULL,
  PRIMARY KEY (`id_endereco`),
  INDEX `fk_tb_endereco_tb_usuario1_idx` (`fk_usuario_id` ASC) VISIBLE,
  CONSTRAINT `fk_tb_endereco_tb_usuario1`
    FOREIGN KEY (`fk_usuario_id`)
    REFERENCES `bd_tommotos`.`tb_usuario` (`id_usuario`)ON DELETE CASCADE ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;
-- -----------------------------------------------------
-- Table `bd_tommotos`.`tb_veiculo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_tommotos`.`tb_veiculo` (
  `id_veiculo` INT NOT NULL AUTO_INCREMENT,
  `marca_veiculo` VARCHAR(30) NOT NULL,
  `modelo_veiculo` VARCHAR(30) NOT NULL,
  `cor_veiculo` VARCHAR(30) NULL DEFAULT NULL,
  `ano_veiculo` VARCHAR(15) NULL DEFAULT NULL,
  `km_veiculo` varchar(30) NULL DEFAULT NULL,
  `placa_veiculo` VARCHAR(12) NULL DEFAULT NULL,
  `obs_veiculo` VARCHAR(300) NULL DEFAULT NULL,
  `fk_cliente_id` INT NULL DEFAULT NULL,
  PRIMARY KEY (`id_veiculo`),
  INDEX `fk_cliente_idx` (`fk_cliente_id` ASC) VISIBLE,
  CONSTRAINT `fk_cliente`
    FOREIGN KEY (`fk_cliente_id`)
    REFERENCES `bd_tommotos`.`tb_cliente` (`id_cliente`)ON DELETE CASCADE ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bd_tommotos`.`tb_venda`
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Table `bd_tommotos`.`tb_venda`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_tommotos`.`tb_venda` (
  `id_venda` INT NOT NULL AUTO_INCREMENT,
  `validade_orcamento_servico` DATE NULL DEFAULT NULL,
  `desconto_venda` DOUBLE NULL DEFAULT 0.00,
  `valor_pago` DOUBLE NULL DEFAULT 0.00,
  `total_venda` DOUBLE NULL DEFAULT 0.00,
  `data_venda` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `venda_finalizada` BOOL DEFAULT FALSE,
  `e_orcamento` BOOL DEFAULT FALSE,
  `fk_veiculo_id` INT NULL DEFAULT NULL,
  `fk_cliente_id` INT NULL DEFAULT NULL,
  PRIMARY KEY (`id_venda`),
  INDEX `fk_veiculo` (`fk_veiculo_id` ASC) VISIBLE,
  INDEX `fk_cliente` (`fk_cliente_id` ASC) VISIBLE,
  CONSTRAINT `fk_tb_venda_tb_cliente1`
    FOREIGN KEY (`fk_cliente_id`)
    REFERENCES `bd_tommotos`.`tb_cliente` (`id_cliente`)ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_veiculo`
    FOREIGN KEY (`fk_veiculo_id`)
    REFERENCES `bd_tommotos`.`tb_veiculo` (`id_veiculo`)ON DELETE CASCADE ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

-- -----------------------------------------------------
-- Table `bd_tommotos`.`tb_grupo_funcionarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_tommotos`.`tb_grupo_funcionarios` (
  `id_grupo_funcionarios` INT NOT NULL AUTO_INCREMENT,
  `fk_venda_id` INT NOT NULL,
  `fk_funcionario_id` INT NOT NULL,
  PRIMARY KEY (`id_grupo_funcionarios`),
  INDEX `fk_venda` (`fk_venda_id` ASC) VISIBLE,
  INDEX `fk_tb_grupo_funcionarios_tb_funcionario1_idx` (`fk_funcionario_id` ASC) VISIBLE,
  CONSTRAINT `fk_tb_grupo_funcionarios_tb_funcionario1`
    FOREIGN KEY (`fk_funcionario_id`)
    REFERENCES `bd_tommotos`.`tb_funcionario` (`id_funcionario`)ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_venda`
    FOREIGN KEY (`fk_venda_id`)
    REFERENCES `bd_tommotos`.`tb_venda` (`id_venda`)ON DELETE CASCADE ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bd_tommotos`.`tb_produto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_tommotos`.`tb_produto` (
  `id_produto` INT NOT NULL AUTO_INCREMENT,
  `descricao_produto` VARCHAR(45) NOT NULL,
  `quantidade_produto` DOUBLE NOT NULL,
  `valor_produto` DOUBLE NOT NULL,
  `marca_produto` VARCHAR(30) NULL DEFAULT NULL,
  `quantidade_virtual_produto` INT NULL DEFAULT NULL,
  `imagem_produto` LONGBLOB NULL DEFAULT NULL,
  PRIMARY KEY (`id_produto`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

-- -----------------------------------------------------
-- Table `bd_tommotos`.`tb_log_fornecimento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_tommotos`.`tb_log_fornecimento` (
  `id_log_fornecimento` INT NOT NULL AUTO_INCREMENT,
  `data_log_fornecimento` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `qtd_produto_fornecido` INT NOT NULL,
  `fk_produto_id` INT NOT NULL,
  `fk_fornecedor_id` INT NOT NULL,
  PRIMARY KEY (`id_log_fornecimento`),
  INDEX `fk_produto_id` (`fk_produto_id` ASC) VISIBLE,
  INDEX `fk_tb_log_fornecimento_tb_funcionario1_idx` (`fk_fornecedor_id` ASC) VISIBLE,
  CONSTRAINT `fk_produto_id`
    FOREIGN KEY (`fk_produto_id`)
    REFERENCES `bd_tommotos`.`tb_produto` (`id_produto`)ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_tb_log_fornecimento_tb_fornecedor1`
    FOREIGN KEY (`fk_fornecedor_id`)
    REFERENCES `bd_tommotos`.`tb_fornecedor` (`id_fornecedor`)ON DELETE CASCADE ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

-- -----------------------------------------------------
-- Table `bd_tommotos`.`tb_produto_usado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_tommotos`.`tb_produto_usado` (
  `id_produto_usado` INT NOT NULL AUTO_INCREMENT,
  `quantidade_produto_usado` DOUBLE NOT NULL,
  `desconto_produto_usado` DOUBLE NULL DEFAULT NULL,
  `fk_produto_id` INT NULL DEFAULT NULL,
  `fk_venda_id` INT NULL DEFAULT NULL,
  `validade_da_garantia_produto` DATE NULL DEFAULT NULL,
  PRIMARY KEY (`id_produto_usado`),
  INDEX `fk_produto_idx` (`fk_produto_id` ASC) VISIBLE,
  INDEX `fk_venda_id` (`fk_venda_id` ASC) VISIBLE,
  CONSTRAINT `tb_prroduto_usado_ibfk_1`
    FOREIGN KEY (`fk_produto_id`)
    REFERENCES `bd_tommotos`.`tb_produto` (`id_produto`)ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `tb_prroduto_usado_ibfk_2`
    FOREIGN KEY (`fk_venda_id`)
    REFERENCES `bd_tommotos`.`tb_venda` (`id_venda`)ON DELETE CASCADE ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bd_tommotos`.`tb_servico_prestado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_tommotos`.`tb_servico_prestado` (
  `id_servico_prestado` INT NOT NULL AUTO_INCREMENT,
  `descricao_servico_prestado` VARCHAR(100) NOT NULL,
  `valor_servico_prestado` DOUBLE NULL DEFAULT 0.00,
  `fk_venda_id` INT NULL DEFAULT NULL,
  PRIMARY KEY (`id_servico_prestado`),
  INDEX `fk_venda_id` (`fk_venda_id` ASC) VISIBLE,
  CONSTRAINT `tb_servico_prestrado_ibfk_1`
    FOREIGN KEY (`fk_venda_id`)
    REFERENCES `bd_tommotos`.`tb_venda` (`id_venda`)ON DELETE CASCADE ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

-- -----------------------------------------------------
-- Table `bd_tommotos`.`tb_telefone`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_tommotos`.`tb_telefone` (
  `id_telefone` INT NOT NULL AUTO_INCREMENT,
  `numero_telefone` VARCHAR(17) NULL DEFAULT NULL,
  `fk_usuario_id` INT NOT NULL,
  PRIMARY KEY (`id_telefone`),
  INDEX `fk_tb_telefone_tb_usuario1_idx` (`fk_usuario_id` ASC) VISIBLE,
  CONSTRAINT `fk_tb_telefone_tb_usuario1`
    FOREIGN KEY (`fk_usuario_id`)
    REFERENCES `bd_tommotos`.`tb_usuario` (`id_usuario`)ON DELETE CASCADE ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

USE `bd_tommotos` ;



-- -----------------------------------------------------
-- procedure CriacaoProduto
-- -----------------------------------------------------
DELIMITER $$
CREATE PROCEDURE criacaoProduto (IN DESCRICAO VARCHAR(45), IN QUANTIDADE_PRODUTO INT, QUANTIDADE_PRODUTO_VIRTUAL INT, IN VALOR_PRODUTO double, IN MARCA VARCHAR(40), IN IMAGEM LONGBLOB)
BEGIN
DECLARE CUSTOM_EXCEPTION CONDITION FOR SQLSTATE '45000';
IF EXISTS(SELECT*FROM tb_produto where tb_produto.descricao_produto = DESCRICAO AND tb_produto.valor_produto = VALOR_PRODUTO) THEN
BEGIN
SIGNAL CUSTOM_EXCEPTION
SET MESSAGE_TEXT = 'ERRO, PRODUTO JA CADASTRADO';
END;
ELSE 
INSERT INTO tb_produto(descricao_produto, quantidade_produto, valor_produto, marca_produto, quantidade_virtual_produto, imagem_produto)values(DESCRICAO,QUANTIDADE_PRODUTO,VALOR_PRODUTO,MARCA,QUANTIDADE_PRODUTO_VIRTUAL,IMAGEM);
END IF;
END $$
DELIMITER ;

DELIMITER $$
CREATE PROCEDURE UpdateProduto (IN DESCRICAO VARCHAR(45), IN QUANTIDADE_PRODUTO INT, QUANTIDADE_PRODUTO_VIRTUAL INT, IN VALOR_PRODUTO double, IN MARCA VARCHAR(40), IN IMAGEM LONGBLOB, in ID INT)
BEGIN
DECLARE CUSTOM_EXCEPTION CONDITION FOR SQLSTATE '45000';
IF EXISTS(SELECT*FROM tb_produto where tb_produto.descricao_produto = DESCRICAO AND tb_produto.valor_produto = VALOR_PRODUTO AND tb_produto.imagem_produto = IMAGEM AND tb_produto.marca_produto = MARCA) THEN
BEGIN
SIGNAL CUSTOM_EXCEPTION
SET MESSAGE_TEXT = 'ERRO, PRODUTO JA EXISTE';
END;
ELSE 
update tb_produto set descricao_produto = DESCRICAO, quantidade_produto = QUANTIDADE_PRODUTO, valor_produto = VALOR_PRODUTO, marca_produto = MARCA, quantidade_virtual_produto = QUANTIDADE_PRODUTO_VIRTUAL, imagem_produto = IMAGEM where tb_produto.id_produto = ID;
END IF;
END $$
DELIMITER ;

-- -----------------------------------------------------
-- procedure CriacaoProdutoUsado
-- -----------------------------------------------------
DELIMITER $$
CREATE PROCEDURE criacaoProdutoUsado (IN qtd_produto_usado INT, IN fk_produto_id INT, fk_venda_id INT, IN validade_da_garantia_produto DATE, IN desconto_produto_usado DOUBLE)
BEGIN
DECLARE CUSTOM_EXCEPTION CONDITION FOR SQLSTATE '45000';
INSERT INTO tb_produto_usado(quantidade_produto_usado, fk_produto_id, fk_venda_id, validade_da_garantia_produto, desconto_produto_usado) values (qtd_produto_usado, fk_produto_id, fk_venda_id, validade_da_garantia_produto, desconto_produto_usado);
END $$
DELIMITER ;

-- -----------------------------------------------------
-- procedure CriacaoServicoPrestado
-- -----------------------------------------------------
DELIMITER $$
CREATE PROCEDURE criacaoServicoPrestado (IN DESCRICAO varchar(100), IN VALOR double, FK_VENDA_ID INT)
BEGIN
DECLARE CUSTOM_EXCEPTION CONDITION FOR SQLSTATE '45000';
INSERT INTO tb_servico_prestado(descricao_servico_prestado, valor_servico_prestado, fk_venda_id) 
			values (DESCRICAO, VALOR, FK_VENDA_ID);
END $$
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
-- procedure Updatecargo
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateCargo`(IN NOME VARCHAR(50), IN SALARIO DOUBLE, in ID INT)
BEGIN DECLARE CUSTOM_EXCEPTION CONDITION FOR SQLSTATE '45000'; 
IF NOT EXISTS (
select * from tb_cargo where tb_cargo.nome_cargo = NOME AND tb_cargo.salario_cargo = SALARIO) THEN BEGIN 

update tb_cargo set nome_cargo = NOME , salario_cargo = SALARIO where tb_cargo.id_cargo = ID;
 END; 
 ELSE SIGNAL CUSTOM_EXCEPTION

SET MESSAGE_TEXT = 'ERRO, CARGO JA EXISTE'; END IF; END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure criacaoCliente
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `criacaoCliente`(IN NOME varchar(15), IN SOBRENOME varchar(40), IN DATA_NASC varchar(15), CPF varchar(15), CNPJ varchar(45))
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
-- procedure UpdateCliente
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateCliente`(IN NOME varchar(15), IN SOBRENOME varchar(40), IN DATA_NASC varchar(15), CPF varchar(15), CNPJ varchar(45), IN ID INT)
BEGIN
DECLARE CUSTOM_EXCEPTION CONDITION FOR SQLSTATE '45000';
 IF EXISTS(SELECT*FROM tb_cliente where cpf_cliente = CPF and id_cliente != ID)THEN
    BEGIN
     SIGNAL CUSTOM_EXCEPTION
     SET MESSAGE_TEXT = 'ERRO, CPF JA EXISTE';
      END;
     
     ELSEIF EXISTS(SELECT*FROM tb_cliente where cnpj_cliente = CNPJ and id_cliente != ID)THEN
    BEGIN
     SIGNAL CUSTOM_EXCEPTION
     SET MESSAGE_TEXT = 'ERRO, CNPJ JA EXISTE';
      END;
	    
	ELSE  
		update tb_cliente set tb_cliente.nome_cliente = NOME, tb_cliente.sobrenome_cliente = SOBRENOME, tb_cliente.data_nascimento_cliente = DATA_NASC, tb_cliente.cpf_cliente = CPF, tb_cliente.cnpj_cliente =CNPJ where tb_cliente.id_cliente = ID;

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
IF NOT EXISTS (select tb_email.nome_email from tb_email where tb_email.nome_email = EMAIL) THEN
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
-- procedure UpdateEmail
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateEmail`(IN EMAIL VARCHAR(50), in ID INT)
BEGIN
DECLARE CUSTOM_EXCEPTION CONDITION FOR SQLSTATE '45000';
IF NOT EXISTS (select tb_email.nome_email from tb_email where tb_email.nome_email = EMAIL ) THEN
BEGIN
update tb_email set nome_email = EMAIL where tb_email.id_email = ID;
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
CREATE DEFINER=`root`@`localhost` PROCEDURE `criacaoEndereco`(IN CEP varchar(15), IN RUA varchar(40), IN CIDADE text, IN BAIRRO varchar(70),IN NUMERO varchar(45),IN FK_USUARIO INT )
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
-- procedure UpdateEndereco
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateEndereco`(IN CEP varchar(15), IN RUA varchar(40), IN CIDADE text, IN BAIRRO varchar(70),IN NUMERO varchar(45),IN FK_USUARIO INT, IN ID INT )
BEGIN
DECLARE CUSTOM_EXCEPTION CONDITION FOR SQLSTATE '45000';
IF NOT EXISTS (select tb_endereco.fk_usuario_id, tb_endereco.numero_endereco, tb_endereco.cep_endereco from tb_endereco
inner join tb_usuario on tb_endereco.fk_usuario_id = tb_usuario.id_usuario where tb_endereco.cep_endereco = CEP  and tb_endereco.rua_endereco = RUA and tb_endereco.cidade_endereco = CIDADE and tb_endereco.bairro_endereco = BAIRRO and tb_endereco.numero_endereco = NUMERO and tb_endereco.fk_usuario_id = FK_USUARIO) THEN
BEGIN
update tb_endereco set cep_endereco = CEP,rua_endereco = RUA,cidade_endereco = CIDADE,bairro_endereco = BAIRRO,numero_endereco= NUMERO where tb_endereco.id_endereco = ID;
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

SET MESSAGE_TEXT = 'ERRO, CNPJ JA EXISTE'; END IF; END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure UpdateFornecedor
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateFornecedor`(IN NOME VARCHAR(50), IN CNPJ varchar(45),IN ID INT)
BEGIN DECLARE CUSTOM_EXCEPTION CONDITION FOR SQLSTATE '45000'; IF NOT EXISTS (

select * from tb_fornecedor where tb_fornecedor.cnpj_fornecedor = CNPJ and tb_fornecedor.id_fornecedor != ID ) THEN BEGIN 

update tb_fornecedor set nome_fornecedor = NOME, cnpj_fornecedor = CNPJ where tb_fornecedor.id_fornecedor = ID; END;

ELSE SIGNAL CUSTOM_EXCEPTION

SET MESSAGE_TEXT = 'ERRO, CNPJ JÁ EXISTE'; END IF; END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure criacaoFuncionario
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `criacaoFuncionario`(IN NOME VARCHAR(50), IN SOBRENOME varchar(100), CPF varchar(16), DATA_NASC varchar(15), DATA_CONT varchar(15), SEXO char, FK_CARGO_ID INT)
BEGIN DECLARE CUSTOM_EXCEPTION CONDITION FOR SQLSTATE '45000'; IF NOT EXISTS (

select * from tb_funcionario where tb_funcionario.cpf_funcionario = CPF) THEN BEGIN 

INSERT INTO tb_funcionario(nome_funcionario, sobrenome_funcionario, cpf_funcionario, data_nascimento_funcionario, data_contratacao_funcionario, sexo_funcionario, fk_cargo_id) VALUES(NOME, SOBRENOME, CPF, DATA_NASC, DATA_CONT, SEXO, FK_CARGO_ID);
insert into tb_usuario(fk_funcionario_id)values(LAST_INSERT_ID());

 END; ELSE SIGNAL CUSTOM_EXCEPTION

SET MESSAGE_TEXT = 'ERRO, CPF JA CADASTRADO'; END IF; END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure UpdateFuncionario
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateFuncionario`(IN NOME VARCHAR(50), IN SOBRENOME varchar(100), CPF varchar(16), DATA_NASC varchar(15), DATA_CONT varchar(15), SEXO char, FK_CARGO_ID INT, IN ID INT)
BEGIN DECLARE CUSTOM_EXCEPTION CONDITION FOR SQLSTATE '45000'; IF EXISTS (
select * from tb_funcionario where cpf_funcionario = CPF and id_funcionario != ID) THEN BEGIN 
SIGNAL CUSTOM_EXCEPTION
SET MESSAGE_TEXT = 'ERRO, CPF JA EXISTE';
 END; ELSE
 update tb_funcionario set nome_funcionario = NOME, sobrenome_funcionario = SOBRENOME, cpf_funcionario = CPF, data_nascimento_funcionario= DATA_NASC, data_contratacao_funcionario = DATA_CONT, sexo_funcionario = SEXO, fk_cargo_id = FK_CARGO_ID where tb_funcionario.id_funcionario = ID;
END IF; END$$

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
-- procedure criacaoLogFornecimento
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `criacaoLogFornecimento`(IN QTD_PRODUTO INT, IN FK_PRODUTO_ID INT, IN FK_FORNECEDOR_ID INT)
BEGIN 
INSERT INTO tb_log_fornecimento(qtd_produto_fornecido, fk_produto_id, fk_fornecedor_id) VALUES(QTD_PRODUTO, FK_PRODUTO_ID, FK_FORNECEDOR_ID); 
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
IF NOT EXISTS (select tb_telefone.numero_telefone from tb_telefone where tb_telefone.numero_telefone = TELEFONE ) THEN
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
-- procedure UpdateTelefone
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateTelefone`(IN TELEFONE VARCHAR(17), in ID INT)
BEGIN
DECLARE CUSTOM_EXCEPTION CONDITION FOR SQLSTATE '45000';
IF NOT EXISTS (select * from tb_telefone where tb_telefone.numero_telefone = TELEFONE ) THEN
BEGIN
update tb_telefone set numero_telefone = TELEFONE where tb_telefone.id_telefone = ID;
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
if exists(select * from tb_veiculo where placa_veiculo=PLACA and fk_cliente_id = FK_CLIENTE)then
 SIGNAL CUSTOM_EXCEPTION
     SET MESSAGE_TEXT = 'ERRO, VEICULO JA CADASTRADO';
ELSE 
INSERT INTO tb_veiculo(marca_veiculo, modelo_veiculo, cor_veiculo, ano_veiculo, km_veiculo, placa_veiculo, obs_veiculo, fk_cliente_id) VALUES (MARCA, MODELO, COR, ANO, KM, PLACA, OBS, FK_CLIENTE);
END IF;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure UpdateVeiculo
-- -----------------------------------------------------
select*from tb_cliente;
DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateVeiculo`(IN MARCA VARCHAR(30), IN MODELO VARCHAR(30), IN COR VARCHAR(30), IN ANO VARCHAR(30), IN KM VARCHAR(30), IN PLACA VARCHAR(12), IN OBS VARCHAR(300), IN FK_CLIENTE INT,IN ID INT)
BEGIN 
DECLARE CUSTOM_EXCEPTION CONDITION FOR SQLSTATE '45000';
if exists(select * from tb_veiculo where modelo_veiculo = MODELO AND marca_veiculo = MARCA and cor_veiculo= COR and ano_veiculo = ANO and km_veiculo=KM and placa_veiculo=PLACA and obs_veiculo=OBS and fk_cliente_id = FK_CLIENTE)then
 SIGNAL CUSTOM_EXCEPTION
     SET MESSAGE_TEXT = 'ERRO, VEICULO JA EXISTE';
ELSE 
update tb_veiculo set marca_veiculo = MARCA, modelo_veiculo = MODELO, cor_veiculo = COR, ano_veiculo = ANO, km_veiculo = KM, placa_veiculo = PLACA, obs_veiculo = OBS, fk_cliente_id  = FK_CLIENTE where tb_veiculo.id_veiculo = ID;
END IF;
END$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure criacaoVenda
-- -----------------------------------------------------
DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `criacaoVenda`(IN VALIDADE_ORCAMENTO_SERVICO date, DESCONTO double, VALOR_PAGO double,TOTAL double, IN FK_VEICULO_ID INT, IN FK_CLIENTE_ID INT)
BEGIN
INSERT INTO tb_venda /*INSERE*/ 
(tb_venda.validade_orcamento_servico, 
tb_venda.desconto_venda,tb_venda.valor_pago, tb_venda.total_venda, tb_venda.fk_veiculo_id, tb_venda.fk_cliente_id) 
values 
(VALIDADE_ORCAMENTO_SERVICO, 
DESCONTO, VALOR_PAGO, TOTAL, FK_VEICULO_ID, FK_CLIENTE_ID); 
END$$

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

-- -----------------------------------------------------
-- procedure criacaoOrcamento
-- -----------------------------------------------------

DELIMITER $$
USE `bd_tommotos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `criacaoOrcamento`(IN VALIDADE_ORCAMENTO_SERVICO date, DESCONTO double,VALOR_PAGO double,TOTAL double, IN FK_VEICULO_ID INT, IN FK_CLIENTE_ID INT, IN E_ORCAMENTO BOOL)
BEGIN
INSERT INTO tb_venda /*INSERE*/ 
(tb_venda.validade_orcamento_servico, 
tb_venda.desconto_venda,tb_venda.valor_pago, tb_venda.total_venda, tb_venda.fk_veiculo_id, tb_venda.fk_cliente_id, tb_venda.e_orcamento) 
values 
(VALIDADE_ORCAMENTO_SERVICO, 
DESCONTO,VALOR_PAGO, TOTAL, FK_VEICULO_ID, FK_CLIENTE_ID, E_ORCAMENTO); 
END$$

DELIMITER ;



/*STORED PROCEDURE PARA MUDAR A QUANTIDADE DO PRODUTO*/
DELIMITER $$
CREATE PROCEDURE acrescentarQTDProduto(IN idProduto INT, IN qtdProduto INT, IN idFornecedor INT)
BEGIN
		UPDATE tb_produto
		set tb_produto.quantidade_produto = tb_produto.quantidade_produto + qtdProduto,
		tb_produto.quantidade_virtual_produto = tb_produto.quantidade_virtual_produto + qtdProduto
		WHERE tb_produto.id_produto = idProduto;
        
		insert into tb_log_fornecimento (qtd_produto_fornecido, fk_produto_id, fk_fornecedor_id) values
        (qtdProduto, idProduto, idFornecedor);
END$$
DELIMITER ; 

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
END IF; END $$ DELIMITER ;*/

call criacaoCliente('DESCONHECIDO', '', null, null, null);
call criacaoFornecedor('DESCONHECIDO', '000000');
call criacaoVeiculo('null','null','null',null,null,null,null,null);
call criacaoCargo('MECÂNICO', 2500);
call criacaoFuncionario('ANDRE', 'LINARES', '341,479,140-74', '01/01/1980', null, 'M', 1);
call criacaoProduto('OLEO', 0, 0, 20.00, 'MOBIL', null);
call acrescentarQTDProduto(1, 10, 1);

select*from tb_cargo;
select*from tb_cliente;
select*from tb_email;
select*from tb_endereco;
select*from tb_fornecedor;
select*from tb_funcionario;
select*from tb_produto;
select*from tb_telefone;
select*from tb_usuario;
select*from tb_veiculo;
select*from tb_venda;
select*from tb_servico_prestado;
select*from tb_produto_usado;
select*from tb_log_fornecimento;
select*from tb_grupo_funcionarios;