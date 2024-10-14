select c.customer_name, o.order_id, o.order_total
from customer c
inner join order o
ON c.customer_id = o.customer_id
where o.order_total > 100 AND c.customer_name LIKE 'J%';
