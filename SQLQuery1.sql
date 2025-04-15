create database rental;


create table users(
id int primary key identity(1,1) not null,
username varchar(255),
password varchar(255)
)

select * from users;