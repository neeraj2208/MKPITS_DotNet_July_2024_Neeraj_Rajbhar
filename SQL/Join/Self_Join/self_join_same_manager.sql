Select e1.name AS Employee1, e2.name AS Employee2, e1.manager_id from  employees e1
join employees e2 ON e1.manager_id = e2.manager_id where e1.employee_id != e2.employee_id;
