<!DOCTYPE html>
<html>
<body>

<script>
let x = "";
const myObj = {
  cars: [
    {name:"Ford", models:["Fiesta", "Focus", "Mustang"]},
    {name:"BMW", models:["320", "X3", "X5"]},
    {name:"Fiat", models:["500", "Panda"]}
  ]
}

for (let i in myObj.cars) 
{
  x += "<h2>" + myObj.cars[i].name + "</h2>";
  for (let j in myObj.cars[i].models) 
  {
    x += myObj.cars[i].models[j] + "<br>";
  }
}
document.write(x);
</script>
</body>
</html>
