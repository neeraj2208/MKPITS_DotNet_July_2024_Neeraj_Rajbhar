create table jobhistory(
    empID int not null primary key Identity(1,1),
	StartDate date not null,
	EndDate date not null,
	jobid int not null,
	deptid int not null);