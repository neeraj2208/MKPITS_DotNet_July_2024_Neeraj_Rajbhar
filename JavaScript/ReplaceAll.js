<!DOCTYPE html>
<html>
<body>
<p id="11"></p>
<script>
let text = "I love cats. Cats are very easy to love. Cats are very popular."
text = text.replaceAll("Cats","Dogs");
text = text.replaceAll("cats","dogs");
document.getElementById("11").innerHTML = text;
</script>
</body>
</html>
