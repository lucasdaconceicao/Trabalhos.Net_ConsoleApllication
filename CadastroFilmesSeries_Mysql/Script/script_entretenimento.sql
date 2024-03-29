-- RODAR O SCRIPT EM UM USUARIO QUE TENHA PERMISSAO DE DBA
CREATE USER 'administrator'@'localhost' IDENTIFIED BY '1234';
GRANT ALL PRIVILEGES ON * . * TO 'administrator'@'localhost';
IF NOT EXISTS CREATE DATABASE ENTRETENIMENTO;
USE ENTRETENIMENTO;

CREATE TABLE FILMES
(
	ID INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
	NOME VARCHAR(100) NOT NULL,
	CLASSIFICACAO VARCHAR(20) NOT NULL,
	DURACAO VARCHAR(10) NOT NULL,
	DIRETOR VARCHAR(100) NOT NULL,
	ESTUDIO VARCHAR(100) NOT NULL
);

CREATE TABLE SERIES
(
	ID INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
	NOME VARCHAR(100) NOT NULL,
	CLASSIFICACAO VARCHAR(20) NOT NULL,
	DURACAO VARCHAR(10) NOT NULL,
	DIRETOR VARCHAR(100) NOT NULL,
	ESTUDIO VARCHAR(100) NOT NULL,
	TEMPORADAS VARCHAR(20) NOT NULL
);

	    