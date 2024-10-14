select c.customer_name, o.order_id, o.order_total from customer c
inner join order o
on c.customer_id = o.customer_id AND o.order_total > 150;
