select e.FirstName,e.LastName,e.Contact,e.Salary,e.deptID,e.Address,d.Departmentname
from EmployeeDetail e Left Join  departmentdetails d on e.deptID = d.deptID