Select d.department_name, e.name AS EmployeeName From departments d left join  employees e ON d.department_id = e.department_id;
