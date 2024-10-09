CREATE TABLE EmployeeDetail (
    EmpId int NOT NULL PRIMARY KEY Identity(1,1),
    FirstName nvarchar(50),
    LastName nvarchar(50),
    Contact nvarchar(50),
	Salary decimal(18,2),
	deptID int Not null,
);   --create a table using crate command                                      

create table departmentdetails (
    deptID int Not null identity(1,1),
	Departmentname nvarchar(30),
	primary key (deptID),
	);

create table mydetail(
     userid int primary key not null identity(1,1),
	 username varchar(50) not null,
	 );