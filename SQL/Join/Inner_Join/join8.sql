select c.FirstName,c.LastName,c.City,c.Country,c.Phone,c.Email,o.OrdersDate,o.CustomerId,o.TotalAmount,o.OrdersNumber
from Customerdetail c join  Orders o  on c.Id = o.CustomerId ; 