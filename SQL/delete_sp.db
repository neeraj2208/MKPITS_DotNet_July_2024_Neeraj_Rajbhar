create procedure DeleteLogs
@inputDate DATE
AS
Begin
delete from jobhistory
WHERE  StartDate< @inputDate;
End;
exec DeleteLogs @inputDate='2024-9-21'