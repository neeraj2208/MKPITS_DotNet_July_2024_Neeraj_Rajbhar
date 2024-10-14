select e.name as Employee, m.name as Manager from employees e join employees m on e.manager_id = m.employee_id;
