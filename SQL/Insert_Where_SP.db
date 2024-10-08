create or alter procedure employeProcedure
@FirstName nvarchar(50),
@LastName  nvarchar(50),
@Contact nvarchar(50),
@Salary decimal(18,2),
@deptID int,
@Address nvarchar(100),
@employeeID int,
@sal decimal
As 
Begin
insert into EmployeeDetail values(@FirstName,@LastName,@Contact,@Salary,@deptID ,@Address ,@employeeID)
select * from EmployeeDetail where Salary>@sal;