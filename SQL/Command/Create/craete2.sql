create table jobs(
    jobid int not null primary key identity(1,1),
	jobtitle varchar(50) not null,
	MinimumSalary decimal(10,2) not null,
	MaximumSalary decimal(10,2) not null,
	);