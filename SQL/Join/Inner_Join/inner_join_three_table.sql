select c.customer_name, o.order_id, o.order_total, p.payment_amount from customer c inner join  order o on  c.customer_id = o.customer_id inner join  payment p
ON o.order_id = p.order_id;
