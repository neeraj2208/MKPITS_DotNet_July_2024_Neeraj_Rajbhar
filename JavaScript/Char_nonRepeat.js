const str = prompt("Enter a string: ");
const charCount = {};

for (const ch of str) {
    charCount[ch] = (charCount[ch] || 0) + 1;
}

for (const ch of str) {
    if (charCount[ch] === 1) {
        console.log("First non-repeating character: " + ch);
        break;
    }
}
