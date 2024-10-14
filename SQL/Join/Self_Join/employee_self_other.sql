Select e.name AS ManagerEmployee FROM employees e Join employees m ON e.employee_id = m.manager_id WHERE e.manager_id IS NOT NULL;
