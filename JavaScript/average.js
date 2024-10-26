function calculateAverage() {
    var count = prompt("Enter the number of values you want to average: "); 
    count = parseInt(count); 

    if (isNaN(count) || count <= 0) {
        console.log("Please enter a valid positive integer.");
        return;
    }

    var sum = 0; 
    for (var i = 0; i < count; i++) {
        var number = prompt("Enter number " + (i + 1) + ": "); 
        number = parseFloat(number); 

        if (isNaN(number)) {
            console.log("Invalid input. Please enter a valid number.");
            return;
        }

        sum += number; 
    }

    var average = sum / count; 
    console.log("The average of the entered numbers is: " + average);
}

calculateAverage();
