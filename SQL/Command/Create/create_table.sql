CREATE TABLE Person(Id int primary key,Name varchar(20),Stateid int)
Insert into Person values(1,'Neeraj',101)
Insert into Person values(2,'Suraj',102)
Insert into Person values(3,'Piyush',103)
Insert into Person values(4,'Sahil',104)
select * from Person
-------------------------------------------------------------------------------
CREATE TABLE State(Stateid int, Statename varchar(20),Zipcode int,primary key(Stateid,Zipcode))
Insert into State values(101,'Maharashtra',440010)
Insert into State values(101,'Maharashtra',440020)
Insert into State values(102,'MP',440030)
Insert into State values(103,'Gujrat',440040)
Insert into State values(103,'Gujrat',440050)
Insert into State values(104,'UP',440060)
select * from State
-------------------------------------------------------------------------------
CREATE TABLE City(Zipcode int ,City varchar(20))
Insert into City values(440010,'Nagpur')
Insert into City values(440020,'Pune')
Insert into City values(440030,'Indore')
Insert into City values(440040,'Ahemdabad')
Insert into City values(440050,'Surat')
Insert into City values(440060,'Hyderabad')
Select * from City
--------------------------------------------------------------------------------
select * from Person
select * from State
Select * from City