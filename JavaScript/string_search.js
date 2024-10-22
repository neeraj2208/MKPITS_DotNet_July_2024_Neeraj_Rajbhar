<!DOCTYPE html>
<html>
<body>
<p>The position of the first occurrence of "locate" is:</p>
<p id="11"></p>
<script>
let text = "Please locate where 'locate' occurs!";
let index = text.search("locate");
document.getElementById("11").innerHTML = index; 
</script>
</body>
</html>