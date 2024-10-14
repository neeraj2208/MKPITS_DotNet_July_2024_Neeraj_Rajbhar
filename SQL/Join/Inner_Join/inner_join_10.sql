select customer.customer_name, order.order_id, order.order_total
from customer
inner join order
ON customer.customer_id = order.customer_id
WHERE order.order_total > 100;
