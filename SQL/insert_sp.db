create procedure Orderinsert 
@OrdersDate datetime,
@CustomerId int,
@TotalAmount decimal(18,2),
@OrdersNumber bigint
as
begin
insert into Orders values(@OrdersDate,@CustomerId,@TotalAmount,@OrdersNumber)
end
Exec Orderinsert  @OrdersDate = '2024-10-04', @CustomerId = 1, @TotalAmount = 1000.50, @OrdersNumber = 123456789;   