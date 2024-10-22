select employee.id, employee.value, department.id, department.description  
from employee  FULL OUTER JOIN department  ON employee.id = department.id  
ORDER BY employee.id;
