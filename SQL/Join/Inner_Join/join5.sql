
select e.FirstName,e.LastName,e.Contact,e.Salary,e.Address,d.Departmentname
from EmployeeDetail e Inner Join  departmentdetails d on e.deptID = d.deptID