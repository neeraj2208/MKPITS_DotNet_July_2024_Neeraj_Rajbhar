create trigger before_employee_delete
before delete on employees
for each on
begin
    insert into employee_archive(employee_id, name, position, delete_time)
    values (OLD.employee_id, OLD.name, OLD.position, now());
end;
