select * from employees FULL OUTER JOIN departments
ON employees.department_id = departments.department_id;

select employees.employee_id, employees.first_name, departments.department_name  from employees  
FULL OUTER JOIN departments  ON employees.department_id = departments.department_id  
WHERE departments.department_name IS NOT NULL;

select customers.customer_name, COUNT(orders.order_id) AS total_orders  
from customers  
FULL OUTER JOIN orders  
ON customers.customer_id = orders.customer_id  
GROUP BY customers.customer_name;

