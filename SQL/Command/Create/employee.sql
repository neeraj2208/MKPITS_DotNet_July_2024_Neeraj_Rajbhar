CREATE TABLE Employe(Id int, Name varchar(20),Phone bigint, State varchar(20),primary key(Id,Phone))
Insert into Employe values(1,'Neeraj',8483831723,'Nagpur')
Insert into Employe values(1,'Suraj',8878355282,'Nagpur')
Insert into Employe values(2,'Piyush',9658975486,'Amravti')
Insert into Employe values(3,'dheersj',9970758709,'Pune')
Insert into Employe values(3,'Gagan',989895755,'Pune')
Insert into Employe values(4,'Lucky',8987458785,'Wardha')
select * from Employe
drop table Employe