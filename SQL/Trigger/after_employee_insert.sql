create trigger after_employee_insert
after insert ON employees
for each row
begin
    insert into employee_log(employee_id, action, action_time)
    values (NEW.employee_id, 'insert', now());
and;
