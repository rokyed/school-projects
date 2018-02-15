create database school_db;
use school_db;
create table users (id  int not null auto_increment primary key,user varchar(30),pass varchar(100),fullname varchar(100),phone varchar(15),email varchar(60),teacher bit);
use school_db;
create table enrolls ( id int not null auto_increment primary key,iduser int,idcourse int);
use school_db;
create table courses ( id  int not null auto_increment primary key,title varchar(100),length int);
use school_db;
insert into users(user,pass,teacher) values ('magister','signum',1),('test','test',1);
