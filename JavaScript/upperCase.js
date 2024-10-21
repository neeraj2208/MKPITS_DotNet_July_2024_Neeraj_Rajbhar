<!DOCTYPE html>
<html>
<body>
<button onclick="myFunction()">Upper Case</button>
<p id="11">Hello World</p>

<script>
function myFunction() {
  let text = document.getElementById("demo").innerHTML;
  document.getElementById("11").innerHTML =
  text.toUpperCase();
}
</script>
</body>
</html>
