select department_id, (select COUNT(*) from employees where department_id = d.department_id) AS employee_count
from departments d;
