SELECT e.name AS EmployeeName, s.salary From employees e Left join salaries s ON e.employee_id = s.employee_id;
