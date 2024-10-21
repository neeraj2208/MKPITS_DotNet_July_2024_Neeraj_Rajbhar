<!DOCTYPE html>
<html>
<body>
<button onclick="myFunction()">lower case</button>
<p id="11">Hello World!</p>
<script>
function myFunction() {
  let text = document.getElementById("11").innerHTML;
  document.getElementById("demo").innerHTML =
  text.toLowerCase();
}
</script>
</body>
</html>