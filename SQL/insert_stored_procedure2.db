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