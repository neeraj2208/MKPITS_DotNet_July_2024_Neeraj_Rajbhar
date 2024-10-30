const prompt = require('prompt-sync')();

const n = parseInt(prompt("Enter the Number to check Prime: "));
let flag = 0;

if (n <= 1) {
    console.log("Number is not Prime.");
} else {
    for (let i = 2; i <= n / 2; i++) {
        if (n % i === 0) {
            console.log("Number is not Prime.");
            flag = 1;
            break;
        }
    }

    if (flag === 0)
        console.log("Number is Prime.");
}
