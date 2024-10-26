function isPalindrome(number) {
    var str = number.toString();
    var reversedStr = ""; 

    for (var i = str.length - 1; i >= 0; i--) {
        reversedStr += str[i]; 
    }

    if (str === reversedStr) {
        return true; 
    } else {
        return false; 
    }
}

var number = prompt("Enter a number to check if it's a palindrome: ");
number = parseInt(number); 

if (isNaN(number)) {
    console.log("Please enter a valid number.");
} else {
    if (isPalindrome(number)) {
        console.log(number + " is a palindrome.");
    } else {
        console.log(number + " is not a palindrome.");
    }
}
