Select e.name From employees e left join employees m ON e.manager_id = m.employee_id WHERE m.employee_id IS NULL;
