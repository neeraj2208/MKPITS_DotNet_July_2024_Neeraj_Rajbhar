select c.customer_name, o.order_id, o.order_total, p.payment_amount from customer c right join order o
ON c.customer_id = o.customer_id right jon payment p
ON o.order_id = p.order_id;
