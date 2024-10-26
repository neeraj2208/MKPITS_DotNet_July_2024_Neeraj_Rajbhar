function reverseString() {
    console.log("Reverse a String");
    var str = "Hello";
    var reversedStr = "";
    for (var i = str.length - 1; i >= 0; i--) {
        reversedStr += str[i];
    }
    console.log("Reversed string: " + reversedStr);
}