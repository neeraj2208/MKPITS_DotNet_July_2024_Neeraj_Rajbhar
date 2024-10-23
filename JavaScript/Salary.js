function calculateNetSalary(basicSalary, allowances, deductions)
{
    if (basicSalary >= 0 && allowances >= 0 && deductions >= 0) 
    {
        let netSalary = basicSalary + allowances - deductions;
        console.log('The net salary is: ' + netSalary);
    } 
    else
    {
        console.log("Please enter valid positive numbers.");
    }
}

let basicSalary = parseFloat(prompt("Enter the basic salary:"));
let allowances = parseFloat(prompt("Enter the total allowances:"));
let deductions = parseFloat(prompt("Enter the total deductions:"));

calculateNetSalary(basicSalary, allowances, deductions);
