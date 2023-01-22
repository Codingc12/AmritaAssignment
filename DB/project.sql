CREATE database project01;

use project01;


#Schema

create schema if not exists Department;
CREATE TABLE DEPARTMENT.dept_(
	ID int primary key auto_increment,
    name_ VARCHAR(216) not null,
    date_created date default (CURDATE())


);