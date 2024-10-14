select c.customer_name, o.order_id, p.payment_method, p.payment_date from customer c inner join order o on c.customer_id = o.customer_id inner join payment p
on o.order_id = p.order_id;
