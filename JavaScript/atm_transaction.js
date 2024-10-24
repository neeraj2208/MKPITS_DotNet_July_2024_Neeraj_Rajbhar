var balance = 1000; 

function atmMachine() {
    while (true) { 
var action = prompt("Welcome to the ATM! Please choose an option: \n1: Check Balance \n2: Deposit \n3: Withdraw \n4: Exit");

 if (action === "1") 
 {
 console.log("Your current balance is: " + balance);
 
 } else if (action === "2") 
 {
 var depositAmount = parseFloat(prompt("Enter amount to deposit:"));
  if (isNaN(depositAmount) || depositAmount <= 0) 
  {
 console.log("Invalid amount. Please enter a valid positive number.");
} else
{
    balance += depositAmount;
console.log("You have successfully deposited " + depositAmount);
console.log("Your new balance is: " + balance);
 }
} 
else if (action === "3") 
{
 var withdrawAmount = parseFloat(prompt("Enter amount to withdraw:"));
if (isNaN(withdrawAmount) || withdrawAmount <= 0) 
{
console.log("Invalid amount. Please enter a valid positive number.");
} else if (withdrawAmount > balance) 
{
console.log("Insufficient funds! Your balance is: " + balance);
 } else {
  balance -= withdrawAmount;
                console.log("You have successfully withdrawn " + withdrawAmount);
                console.log("Your new balance is: " + balance);
            }
        
        } else if (action === "4") {
            console.log("Thank you for using the ATM. Goodbye!");
            break;  
        
        } else {
            console.log("Invalid option. Please select 1, 2, 3, or 4.");
        }
    }
}

atmMachine();
