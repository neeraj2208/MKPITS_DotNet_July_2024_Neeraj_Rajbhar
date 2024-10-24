
function categorizeBMI(weight, height) 
{
    let bmi = weight / (height * height);

    if (bmi < 18.5) 
    {
        console.log("Your BMI is " + bmi + " You are underweight.");
    } 
    else if (bmi >= 18.5 && bmi < 24.9) 
    {
    console.log("Your BMI is " +bmi+ "You have a normal weight.");
    } 
    else if (bmi >= 25 && bmi < 29.9)
    {
    console.log("Your BMI is " + bmi+ " You are overweight.");
    } 
    else 
    {
    console.log("Your BMI is " + bmi+ ". You are obese.");
    }
}

function getUserData() 
{
    let weight = parseFloat(prompt("Enter your weight in kilograms: "));
    let height = parseFloat(prompt("Enter your height in meters: ")); 

    if (isNaN(weight) || isNaN(height) || weight <= 0 || height <= 0)
    {
    console.log("Please enter valid positive numbers for weight and height.");
    } 
    else
    {
        categorizeBMI(weight, height);
    }
}
getUserData();
