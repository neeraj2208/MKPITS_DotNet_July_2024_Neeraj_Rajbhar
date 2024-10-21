<!DOCTYPE html>
<html>
<body>
<p id="neeraj"></p>
<script>

function Person(first, last, age, eye) {
  this.firstName = first;
  this.lastName = last;
  this.age = age;
  this.eyeColor = eye;
}

const myFather = new Person("Sanjay", "Rajbhar", 50);

document.getElementById("neeraj").innerHTML =
"My father Name is " + myFather.firstName + " " +myFather.lastName+ ". " + 
"My father age is " + myFather.age + "."
</script>

</body>
</html>