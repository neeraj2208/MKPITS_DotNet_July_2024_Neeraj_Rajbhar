<!DOCTYPE html>
<html>
<body>
<h1> Fruits Market </h1>

<script>
const fruits = ["Banana", "Orange", "Apple"];
fruits[6] = "Lemon";
let fruitLen = fruits.length;
let text = "";
for (i = 0; i < fruitLen; i++)
{
  text += fruits[i] + "<br>";
}

document.write(text);
</script>
</body>
</html>
