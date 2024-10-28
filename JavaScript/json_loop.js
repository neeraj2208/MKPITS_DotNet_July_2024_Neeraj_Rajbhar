<!DOCTYPE html>
<html>
<body>

<h2>Create Object from JSON String</h2>
<table>
    <tr>
        <th>FirstName</th>
        <th>LastName</th>
    </tr>
    <tbody id="demo"></tbody>
</table>

<script>
let text = '{"employees":[' +
'{"firstName":"Neeraj","lastName":"Rajbhar" },' +
'{"firstName":"Suraj","lastName":"Rajbhar" },' +
'{"firstName":"Ganesh","lastName":"Rajbhar" }]}';

const obj = JSON.parse(text);
let txt = "";

for (let i = 0; i < obj.employees.length; i++) {
    txt += "<tr><td>" + obj.employees[i].firstName + "</td><td>" + obj.employees[i].lastName + "</td></tr>";
}

document.getElementById("demo").innerHTML = txt;
</script>

</body>
</html>