select o.OrdersDate,o.CustomerId,o.TotalAmount,o.OrdersNumber,
p.ProductName,p.SupplierId,p.UnitPrice,p.Package,p.IsDiscontinued
From orders o cross join product p;