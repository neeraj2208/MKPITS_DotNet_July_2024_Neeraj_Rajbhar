select customer.customer_name, order.order_id, order.order_total
from customer
cross join order;