Select e.name AS Employee, m.name AS Manager From employees e
Join employees m ON e.manager_id = m.employee_id Where e.salary > m.salary;
