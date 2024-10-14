select department_id, count(*) from employees  group by department_id  having COUNT(*) > 5;
