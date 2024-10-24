
function checkEligibility(examScore, gpa)
{
    var minExamScore = 70;
    var minGpa = 5.0;

    if (examScore >= minExamScore && gpa >= minGpa) 
    {
    console.log("Congratulations! You are eligible for admission.");
    } 
    else if (examScore < minExamScore && gpa >= minGpa)
    {
    console.log("You are not eligible.");
    } 
    else if (gpa < minGpa && examScore >= minExamScore)
    {
    console.log("You are not eligible because your GPA is too low.");
    }
    else
    {
    console.log("You are not eligible due to both low exam score and GPA.");
    }
}

var examScore = parseFloat(prompt("Enter your entrance exam score:"));
var gpa = parseFloat(prompt("Enter your GPA from previous academic performance:"));


checkEligibility(examScore, gpa);
