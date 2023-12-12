# Task-Manager

PT-BR
-------
Programa que te permite criar tarefas e gerenciar as mesmas.

Esse programa foi criado com principal objetivo de treinar os fundamentos do POO, CRUD e conexão com MySQL.
Programa possui tela de Login, permitindo o cadastro de usuário e login do mesmo, podendo também salvar o usuário para manter logado. As tarefas são separdas por cada usuário.
![image](https://github.com/brunohoske/TaskManager/assets/124783417/17ddecef-55bf-41ce-a792-ee39ac7b659d)

Também é possível configurar o BD para que todos possam testar esse programa colocando o usuário e senha do Banco de dados em "BD config". Por padrão é root sem senha.

![image](https://github.com/brunohoske/TaskManager/assets/124783417/73c56ebe-6999-4c34-9a0c-41edb8bec26d)


Cada tarefa consta com um nome, uma data incial e final e uma descrição.

![image](https://github.com/brunohoske/TaskManager/assets/124783417/b4dcc34c-2bde-4428-9c9f-b322d0b6bfdb)



Segue o CREATE da database e das tables:

DATABASE:
CREATE DATABASE IF NOT EXISTS `taskmanager` DEFAULT CHARACTER SET utf8 ;

TABLES:
CREATE TABLE IF NOT EXISTS `taskmanager`.`Usuarios` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `Username` VARCHAR(45) NOT NULL,
  `Nome` VARCHAR(80) NOT NULL,
  `Email` VARCHAR(80) NOT NULL,
  `Senha` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`ID`));


CREATE TABLE IF NOT EXISTS `taskmanager`.`Tarefas` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `NomeTarefa` VARCHAR(20) NOT NULL,
  `DataInicio` DATETIME NOT NULL,
  `DataFim` DATETIME NOT NULL,
  `Descricao` VARCHAR(300) NOT NULL,
  `UserID` INT NOT NULL,
  PRIMARY KEY (`ID`),
  INDEX `fk_Tarefas_Usuarios_idx` (`UserID` ASC) );


EN-US
-------
Program that allows you to create tasks and manage them.

This program was created with the main goal of practicing the fundamentals of OOP, CRUD, and connecting with MySQL.

The program features a login screen allowing user registration and login. It also provides an option to save the user for auto-login. Tasks are separated for each user.
![image](https://github.com/brunohoske/TaskManager/assets/124783417/17ddecef-55bf-41ce-a792-ee39ac7b659d)

Additionally, it's possible to configure the database so everyone can test this program by entering the database username and password in the "DB Config" section. By default, it uses the root user with no password.
![image](https://github.com/brunohoske/TaskManager/assets/124783417/73c56ebe-6999-4c34-9a0c-41edb8bec26d)


Each task has a name, a start date, an end date, and a description.

![image](https://github.com/brunohoske/TaskManager/assets/124783417/b4dcc34c-2bde-4428-9c9f-b322d0b6bfdb)

Here's the CREATE of the database and tables.

DATABASE:
CREATE DATABASE IF NOT EXISTS `taskmanager` DEFAULT CHARACTER SET utf8 ;

TABLES:
CREATE TABLE IF NOT EXISTS `taskmanager`.`Usuarios` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `Username` VARCHAR(45) NOT NULL,
  `Nome` VARCHAR(80) NOT NULL,
  `Email` VARCHAR(80) NOT NULL,
  `Senha` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`ID`));


CREATE TABLE IF NOT EXISTS `taskmanager`.`Tarefas` (
  `ID` INT NOT NULL AUTO_INCREMENT,
  `NomeTarefa` VARCHAR(20) NOT NULL,
  `DataInicio` DATETIME NOT NULL,
  `DataFim` DATETIME NOT NULL,
  `Descricao` VARCHAR(300) NOT NULL,
  `UserID` INT NOT NULL,
  PRIMARY KEY (`ID`),
  INDEX `fk_Tarefas_Usuarios_idx` (`UserID` ASC) );

