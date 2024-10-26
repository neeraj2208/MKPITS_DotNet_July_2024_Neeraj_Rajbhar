function countDigits(number) {
  const numString = number.toString();

  const digitsCount = numString.replace(/\D/g, '').length;

  return digitsCount;
}

function main() {
  const input = prompt("Enter a number: ");

  if (input !== null && !isNaN(input) && input.trim() !== '') {
    const digitCount = countDigits(input);
    alert(`The number of digits in ${input} is: ${digitCount}`);
  } else {
    alert("Invalid input. Please enter a valid number.");
  }
}

main();
