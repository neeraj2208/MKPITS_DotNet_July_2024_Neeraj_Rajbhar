<!DOCTYPE html>
<html>
<body>
<h2>Fruit Market</h2>
<script>
const fruits = ["Banana", "Orange", "Apple", "Mango"];
let fruitLen = fruits.length;

let text = "";
for (let i = 0; i < fruitLen; i++) 
{
  text += "<li>" + fruits[i] + "</li>";
}

document.write(text);
</script>
</body>
</html>
