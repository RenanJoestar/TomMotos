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
    REFERENCES `bd_tommotos`.`tb_cliente` (`id_cliente`),
  CONSTRAINT `fk_tb_usuario_tb_fornecedor1`
    FOREIGN KEY (`fk_fornecedor_id`)
    REFERENCES `bd_tommotos`.`tb_fornecedor` (`id_fornecedor`),
  CONSTRAINT `fk_tb_usuario_tb_funcionario1`
    FOREIGN KEY (`fk_funcionario_id`)
    REFERENCES `bd_tommotos`.`tb_funcionario` (`id_funcionario`))
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
    REFERENCES `bd_tommotos`.`tb_usuario` (`id_usuario`))
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
    REFERENCES `bd_tommotos`.`tb_usuario` (`id_usuario`))
ENGINE = InnoDB
AUTO_INCREMENT = 9
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;
CALL criacaoVeiculo("ASGFG", "ASGFG", null ,null, null, null, null, null);

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
    REFERENCES `bd_tommotos`.`tb_cliente` (`id_cliente`))
ENGINE = InnoDB
AUTO_INCREMENT = 8
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bd_tommotos`.`tb_venda`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_tommotos`.`tb_venda` (
  `id_venda` INT NOT NULL AUTO_INCREMENT,
  `descricao_venda` TEXT NOT NULL,
  `preco_mao_de_obra` DOUBLE NULL DEFAULT NULL,
  `validade_orcamento_servico` DATE NULL DEFAULT NULL,
  `data_venda` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `fk_veiculo_id` INT NULL DEFAULT NULL,
  `fk_cliente_id` INT NOT NULL,
  PRIMARY KEY (`id_venda`),
  INDEX `fk_veiculo` (`fk_veiculo_id` ASC) VISIBLE,
  INDEX `fk_tb_venda_tb_cliente1_idx` (`fk_cliente_id` ASC) VISIBLE,
  CONSTRAINT `fk_tb_venda_tb_cliente1`
    FOREIGN KEY (`fk_cliente_id`)
    REFERENCES `bd_tommotos`.`tb_cliente` (`id_cliente`),
  CONSTRAINT `fk_veiculo`
    FOREIGN KEY (`fk_veiculo_id`)
    REFERENCES `bd_tommotos`.`tb_veiculo` (`id_veiculo`))
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
    REFERENCES `bd_tommotos`.`tb_funcionario` (`id_funcionario`),
  CONSTRAINT `fk_venda`
    FOREIGN KEY (`fk_venda_id`)
    REFERENCES `bd_tommotos`.`tb_venda` (`id_venda`))
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
    REFERENCES `bd_tommotos`.`tb_produto` (`id_produto`),
  CONSTRAINT `fk_tb_log_fornecimento_tb_funcionario1`
    FOREIGN KEY (`fk_fornecedor_id`)
    REFERENCES `bd_tommotos`.`tb_funcionario` (`id_funcionario`))
ENGINE = InnoDB
AUTO_INCREMENT = 5
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `bd_tommotos`.`tb_produto_selecionado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_tommotos`.`tb_produto_selecionado` (
  `id_produto_usado` INT NOT NULL AUTO_INCREMENT,
  `buscado_produto_selecionado` TINYINT(1) NOT NULL,
  `data_produto_selecionado` TIMESTAMP NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `qtd_produto_selecionado` INT NOT NULL,
  `fk_produto_id` INT NULL DEFAULT NULL,
  `fk_cliente_id` INT NULL DEFAULT NULL,
  PRIMARY KEY (`id_produto_usado`),
  INDEX `fk_produto_idx` (`fk_produto_id` ASC) VISIBLE,
  INDEX `fk_cliente_id` (`fk_cliente_id` ASC) VISIBLE,
  CONSTRAINT `tb_produto_selecionado_ibfk_1`
    FOREIGN KEY (`fk_produto_id`)
    REFERENCES `bd_tommotos`.`tb_produto` (`id_produto`),
  CONSTRAINT `tb_produto_selecionado_ibfk_2`
    FOREIGN KEY (`fk_cliente_id`)
    REFERENCES `bd_tommotos`.`tb_cliente` (`id_cliente`))
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
    REFERENCES `bd_tommotos`.`tb_produto` (`id_produto`),
  CONSTRAINT `tb_prroduto_usado_ibfk_2`
    FOREIGN KEY (`fk_venda_id`)
    REFERENCES `bd_tommotos`.`tb_venda` (`id_venda`))
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
    REFERENCES `bd_tommotos`.`tb_usuario` (`id_usuario`))
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

USE `bd_tommotos` ;