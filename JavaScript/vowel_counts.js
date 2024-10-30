const str = "Hello World"; 
let vowelCount = 0;

for (const ch of str.toLowerCase()) {
    if ('aeiou'.includes(ch)) {
        vowelCount++;
    }
}

console.log("Number of vowels: " + vowelCount);
