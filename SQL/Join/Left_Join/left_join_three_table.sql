select c.customer_name, o.order_id, o.order_total, p.payment_amount from customer c left join order o
ON c.customer_id = o.customer_id left join payment p ON o.order_id = p.order_id;
