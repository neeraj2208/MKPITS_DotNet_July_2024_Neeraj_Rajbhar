CREATE TABLE Employe (Id int primary key,Firstname varchar(20), Lastname varchar(20))
Insert into Employe values(1,'Neeraj','Rajbhar')
Insert into Employe values(2,'Suraj','Rajbhar')
Insert into Employe values(3,'dheeraj','Rajbhar')

CREATE TABLE EmployeLog(Logid int identity(1,1) not null,Id int ,Firstname varchar(20),Lastname varchar(20),Operation varchar(20),UpdateDate datetime)
------------------Insert Trigger Query---------------------------
Create Trigger T1 on Employe for insert as Insert into EmployeLog(Id,Firstname,Lastname,Operation,UpdateDate)
select Id,Firstname,Lastname,'Insert',GETDATE() from inserted;

------------------Update trigger Query---------------------------
CREATE TRIGGER T2 on Employe after update as insert into EmployeLog(Id,Firstname,Lastname,Operation,UpdateDate)
select Id,Firstname,Lastname,'Update',GETDATE() from deleted
Update Employe set Firstname='Lucky' where Id=2;
Update Employe set Firstname='David' where Id=1;

select * from Employe
select * from EmployeLog

select * from dbo.EmployeLog

drop table Employe
drop table EmployeLog