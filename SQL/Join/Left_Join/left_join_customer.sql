SELECT customer.customer_name, order.order_id, order.order_total
FROM customer
LEFT JOIN order
ON customer.customer_id = order.customer_id;