Create or alter procedure totalsale
@Id INT
As
declare @TotalSales DECIMAL(18, 2)
begin
Select @TotalSales = SUM(UnitPrice)
From Product
WHERE Id = @Id;
Select  @TotalSales AS TotalSales;
End;
EXEC totalsale 101;
