select MONTH(order_date) AS sales_month, AVG(total_amount) AS average_monthly_sales from orders group by  MONTH(order_date);
