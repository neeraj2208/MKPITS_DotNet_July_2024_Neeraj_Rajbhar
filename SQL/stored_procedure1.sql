create  procedure details
@FirstName varchar(50),
@LastName varchar(50),
@City varchar(50),
@Country varchar(50),
@Phone varchar(50),
@Email varchar(25),
@countryname varchar(50),
@regionid varchar(50)
as
begin
insert into Customerdetail(FirstName,LastName,City,Country,Phone,Email) values(@FirstName,@LastName,@City,@Country,@Phone,@Email)
insert into countries(countryname,regionid) values(@countryname,@regionid)
end
exec details @FirstName='Neeraj',@LastName='Rajbhar',@City='Nagpur',@Country='India',@Phone='987654',@Email='rajbha@2002',@countryname='India',@regionid='259285';

create or alter procedure details
@jobtitle varchar(50),
@MinimumSalary decimal(10,2),
@MaximumSalary decimal(10,2),
@countryname varchar(50),
@regionid varchar(50)
as
begin
insert into jobs values(@jobtitle,@MinimumSalary,@MaximumSalary)
insert into countries(countryname,regionid) values(@countryname,@regionid)
select * from jobs;
select * from countries;
end
exec details @jobtitle='developer',@MinimumSalary=773,@MaximumSalary=4853,@countryname='India',@regionid='259285';
