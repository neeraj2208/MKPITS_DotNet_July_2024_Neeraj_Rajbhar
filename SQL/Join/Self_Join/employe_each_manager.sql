Select m.name AS Manager, COUNT(e.employee_id) AS NumEmployees From employees e Join employees m ON e.manager_id = m.employee_id GROUP BY m.name;
