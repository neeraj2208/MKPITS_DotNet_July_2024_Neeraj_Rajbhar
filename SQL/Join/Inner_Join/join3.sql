Select avg(orders.TotalAmount) as Average from Orders Join OrderItem on Orders.Id=OrderItem.OrderId 