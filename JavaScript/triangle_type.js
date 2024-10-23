function determineTriangleType(a, b, c)
{
    if (a + b > c && a + c > b && b + c > a) 
    {
        if (a === b && b === c) 
        {
            return "Equilateral triangle";
        }
  
        else if (a === b || b === c || a === c) 
        {
            return "Isosceles triangle";
        }
        else 
        {
            return "Scalene triangle";
        }
    }
    else 
    {
        return "Not a valid triangle";
    }
}

let side1 = parseFloat(prompt("Enter the length of side 1:"));
let side2 = parseFloat(prompt("Enter the length of side 2:"));
let side3 = parseFloat(prompt("Enter the length of side 3:"));

let result = determineTriangleType(side1, side2, side3);
alert(result);
