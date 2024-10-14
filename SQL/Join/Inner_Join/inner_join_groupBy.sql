select c.customer_name, SUM(o.order_total) AS total_spent
from customer c
inner join order o
ON c.customer_id = o.customer_id
GROUP BY c.customer_name;
