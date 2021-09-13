-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema bd_tommotos
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema bd_tommotos
-- -----------------------------------------------------
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
AUTO_INCREMENT = 3
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
AUTO_INCREMENT = 9
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
AUTO_INCREMENT = 2
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
AUTO_INCREMENT = 3
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
AUTO_INCREMENT = 6
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
AUTO_INCREMENT = 2
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
AUTO_INCREMENT = 9
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
AUTO_INCREMENT = 8
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bd_tommotos`.`tb_venda`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_tommotos`.`tb_venda` (
  `id_venda` INT NOT NULL AUTO_INCREMENT,
  `descricao_mao_de_obra` TEXT NOT NULL,
  `preco_mao_de_obra` DOUBLE NULL DEFAULT 0.00,
  `validade_orcamento_servico` DATE NULL DEFAULT NULL,
  `data_venda` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `venda_finalizada` BOOL DEFAULT FALSE,
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
AUTO_INCREMENT = 3
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
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bd_tommotos`.`tb_produto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_tommotos`.`tb_produto` (
  `id_produto` INT NOT NULL AUTO_INCREMENT,
  `descricao_produto` VARCHAR(45) NOT NULL,
  `quantidade_produto` INT NOT NULL,
  `valor_produto` DOUBLE NOT NULL,
  `marca_produto` VARCHAR(30) NULL DEFAULT NULL,
  `quantidade_virtual_produto` INT NULL DEFAULT NULL,
  `imagem_produto` LONGBLOB NULL DEFAULT NULL,
  PRIMARY KEY (`id_produto`))
ENGINE = InnoDB
AUTO_INCREMENT = 4
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
  CONSTRAINT `fk_tb_log_fornecimento_tb_funcionario1`
    FOREIGN KEY (`fk_fornecedor_id`)
    REFERENCES `bd_tommotos`.`tb_funcionario` (`id_funcionario`)ON DELETE CASCADE ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 5
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bd_tommotos`.`tb_produto_selecionado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_tommotos`.`tb_produto_selecionado` (
  `id_produto_selecionado` INT NOT NULL AUTO_INCREMENT,
  `buscado_produto_selecionado` TINYINT(1) NOT NULL,
  `data_produto_selecionado` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `qtd_produto_selecionado` INT NOT NULL,
  `fk_produto_id` INT NULL DEFAULT NULL,
  `fk_cliente_id` INT NULL DEFAULT NULL,
  PRIMARY KEY (`id_produto_selecionado`),
  INDEX `fk_produto_idx` (`fk_produto_id` ASC) VISIBLE,
  INDEX `fk_cliente_id` (`fk_cliente_id` ASC) VISIBLE,
  CONSTRAINT `tb_produto_selecionado_ibfk_1`
    FOREIGN KEY (`fk_produto_id`)
    REFERENCES `bd_tommotos`.`tb_produto` (`id_produto`)ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `tb_produto_selecionado_ibfk_2`
    FOREIGN KEY (`fk_cliente_id`)
    REFERENCES `bd_tommotos`.`tb_cliente` (`id_cliente`)ON DELETE CASCADE ON UPDATE CASCADE)
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bd_tommotos`.`tb_produto_usado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_tommotos`.`tb_produto_usado` (
  `id_produto_usado` INT NOT NULL AUTO_INCREMENT,
  `quantidade_produto_usado` INT NOT NULL,
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
AUTO_INCREMENT = 5
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
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

USE `bd_tommotos` ;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

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

/*TRIGGER PARA DIMINUIÇÃO DE QUANTIDADE QUANDO PRODUTO FOR BUSCADO*/
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
END IF; END $$ DELIMITER ; 

call criacaoCliente('null','null', null, null, null);
call criacaoCliente('samuel','santos','2002/04/22','99999999',null);
call criacaoCliente('matheus','santos','2002/04/23','99929999',null);
call criacaoCliente('pedro','santos','2002/04/20','99929959',null);
call criacaoEmail('samuca@gmail.com','6');
call criacaoEmail('matheus@gmail.com','7');
call criacaoEmail('pedro@gmail.com','8');
call criacaoEndereco('006666600','rua limonada','santana de parnaiba','germano','23','6');
call criacaoEndereco('006666600','rua aquario','santana de parnaiba','parque santana','20','7');
call criacaoEndereco('0066655','rua touro','santana de parnaiba','parque santana','20','8');
call criacaoTelefone('1199999999',6);
call criacaoTelefone('1199994444',7);
call criacaoTelefone(null,8);
call criacaoVeiculo('kawasaki','honda','preto',null,null,'00000001',null,'9');
call criacaoVeiculo('xt','yamaha','preto',null,null,'00000001',null,'10');
call criacaoVeiculo('xtz','yamaha','azul',null,null,'0000022',null,'11');

/* fornecedor*/

call criacaoFornecedor('Jose silvio','222222');
call criacaoEmail('samuca@gmail.com','9');
call criacaoEndereco('006666655','rua cachoeira','santana de parnaiba','imperial','13','9');
call criacaoTelefone('119988888',9);

/*Funcionario*/

call criacaoCargo('mecanico','1200');
call criacaoFuncionario('João','blindo',007733133,'2003-10-22','2019-11-22','m','3');
call criacaoEmail('blindo@gmail.com','10');
call criacaoEndereco('00663332','rua alemão','santana de parnaiba','isaura','11','10');
call criacaoTelefone('11998444',10);
call criacaoFuncionario('Alemao','Santos',0077333322,'2002-12-22','2019-12-22','m','3');
call criacaoEmail('Alemao@gmail.com','10');
call criacaoEndereco('00660000','rua indio','santana de parnaiba','baruru','12','11');
call criacaoTelefone('119981114',11);

/*CRIACAO PRODUTO*/

call criacaoProduto('oleo preto','0','0','15','mobil',null);
call criacaoProduto('oleo','0','0','12','mobil',null);

call mostrarClientePorID(11);
call mostrarFornecedores();
call mostrarFornecedorPorID(3);