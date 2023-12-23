# Task-Manager

PT-BR
----------------------------------------------------------------------------------------------------------------------------
Programa que te permite criar tarefas e gerenciar as mesmas.

Esse programa foi criado com principal objetivo de treinar os fundamentos do POO, CRUD e conexão com MySQL.
Programa possui tela de Login, permitindo o cadastro de usuário e login do mesmo, podendo também salvar o usuário para manter logado. As tarefas são separdas por cada usuário.


![image](https://github.com/brunohoske/TaskManager/assets/124783417/d3b55fa4-c316-41d4-971c-3ba515c674fc)


Também é possível configurar o BD para que todos possam testar esse programa colocando o usuário e senha do Banco de dados em "BD Config". Por padrão é root sem senha. (Lembre-se de configurar a senha e usúario com um acesso para create,update, delete e select)

![image](https://github.com/brunohoske/TaskManager/assets/124783417/73c56ebe-6999-4c34-9a0c-41edb8bec26d)




Após a configuração do BD, na sua primeira inicialização, você pode gerar o banco de dados a partir do botão "Gerar BD". (Confira se o usuario e senha estão realmente corretos em "BD Config")

![image](https://github.com/brunohoske/TaskManager/assets/124783417/0d1b55e0-a06b-43af-b9af-856c11eb33d7)




Cada tarefa consta com um nome, uma data incial e final e uma descrição.


![image](https://github.com/brunohoske/TaskManager/assets/124783417/b4dcc34c-2bde-4428-9c9f-b322d0b6bfdb)


Os usuários possuem no cadastro um nome, um username para apelido e email.
No menu inicial se tem acesso a todas as informações e caminhos de acesso, tanto de configuração quanto de gerenciamento de tarefas.
Nele também se encontra uma mensagem de boas vindas junto ao seu nome e seu apelido.

![image](https://github.com/brunohoske/TaskManager/assets/124783417/4f073849-35bb-4efb-8f35-c333d5126d64)




Tela de configurações:

![image](https://github.com/brunohoske/TaskManager/assets/124783417/9906b35c-4e10-4e75-8cb4-14611435cff1)



Caso você queira gerar as tabelas manualmente você pode utilizar os creates disponibilizados.
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
----------------------------------------------------------------------------------------------------------------------------
Program that allows you to create tasks and manage them.

This program was created with the main goal of practicing the fundamentals of OOP, CRUD, and connection with MySQL.

The program features a login screen allowing user registration and login. It also provides an option to save the user for auto-login. Tasks are separated for each user.


![image](https://github.com/brunohoske/TaskManager/assets/124783417/a8ecb80a-0e62-466c-9e62-0a6d9b7f0624)


Additionally, it's possible to configure the database so everyone can test this program by entering the database username and password in the "BD Config". By default, it uses the root user with no password. (Remember to configure the password and user with access to create, update, delete and select)

![image](https://github.com/brunohoske/TaskManager/assets/124783417/73c56ebe-6999-4c34-9a0c-41edb8bec26d)

After configuring the DB, on your first startup, you can generate the database using the "Gerar BD" button. (Check if the username and password are really correct in "BD Config")


![image](https://github.com/brunohoske/TaskManager/assets/124783417/0b5c4cc1-8fe9-4b4a-b0d9-f7ab18c45796)





Each task has a name, a start date, an end date, and a description.
![image](https://github.com/brunohoske/TaskManager/assets/124783417/b4dcc34c-2bde-4428-9c9f-b322d0b6bfdb)


Users have in their registration, a name, a username as a nickname, and an email.

In the main menu, there is access to all the information and pathways, both for configuration and task management.
Also, there's a welcome message along with your name and nickname.


![image](https://github.com/brunohoske/TaskManager/assets/124783417/4f073849-35bb-4efb-8f35-c333d5126d64)


Configuration Screen:

![image](https://github.com/brunohoske/TaskManager/assets/124783417/9906b35c-4e10-4e75-8cb4-14611435cff1)



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

