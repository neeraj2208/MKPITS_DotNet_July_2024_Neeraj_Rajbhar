select c.customer_name, o.order_id
from customer c
right join order o
ON c.customer_id = o.customer_id
where c.customer_id IS NULL;
