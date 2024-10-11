CREATE TABLE Teacher(Id int primary key, Name varchar(20),Age int)
Insert into Teacher values(1,'Neeraj',25)
Insert into Teacher values(2,'Suraj',30)
Insert into Teacher values(3,'Virat',35)
Insert into Teacher values(4,'Rohit',40)
Insert into Teacher values(5,'Shewag',45)
select * from Teacher


CREATE TABLE Details(Id int, Name varchar(20),Subject varchar(20),foreign key (Id) references Teacher(Id))
Insert into Details values(1,'Neeraj','Java')
Insert into Details values(1,'Suraj','C++')
Insert into Details values(2,'Dheeraj','Php')
Insert into Details values(3,'Virat','Python')
Insert into Details values(3,'Suraj','Sql')
Insert into Details values(4,'Rohit','Mysql')
Insert into Details values(5,'Shewag','htm;')

select * from Teacher
select * from Details