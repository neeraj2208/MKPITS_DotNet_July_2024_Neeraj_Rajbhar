select sum(your_column) AS total_sum
From ( select your_column FROM your_table  order by date_column desc LIMIT 10) AS last_10_records;
