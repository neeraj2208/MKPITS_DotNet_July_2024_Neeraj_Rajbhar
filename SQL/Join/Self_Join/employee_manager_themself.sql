Select DISTINCT m.name AS Manager From employees e join employees m ON e.manager_id = m.employee_id;
