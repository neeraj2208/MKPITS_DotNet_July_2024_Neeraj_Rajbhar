select c.customer_name, o.order_id
from customer c
left join order o
ON c.customer_id = o.customer_id
where o.order_id IS NULL;
