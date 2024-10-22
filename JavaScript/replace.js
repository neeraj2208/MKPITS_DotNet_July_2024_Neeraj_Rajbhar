<!DOCTYPE html>
<html>
<body>
<button onclick="myFunction()">Try it</button>
<p id="11">welcome to MKPIT</p>
<script>
function myFunction() 
{
  let text = document.getElementById("demo").innerHTML;
  document.getElementById("11").innerHTML =
  text.replace("MKPIT","my office");
}
</script>
</body>
</html>


