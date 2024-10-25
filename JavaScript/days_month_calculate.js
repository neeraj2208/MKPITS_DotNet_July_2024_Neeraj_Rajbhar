<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Days in Month Calculator</title>
</head>
<body>

    <h2>Calculate Days in a Month</h2>
    <label for="monthNumber">Enter Month Number (1-12): </label>
    <input type="number" id="monthNumber" min="1" max="12">
    <br><br>
    <label for="year">Enter Year: </label>
    <input type="number" id="year" min="1">
    <br><br>
    <button onclick="calculateDays()">Calculate Days</button>

    <p id="result"></p>

    <script>
        function calculateDays() {
            const monthNumber = parseInt(document.getElementById("monthNumber").value);
            const year = parseInt(document.getElementById("year").value);
            let daysInMonth;

            switch (monthNumber) {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    daysInMonth = 31;
                    break;
                case 4: case 6: case 9: case 11:
                    daysInMonth = 30;
                    break;
                case 2:
    
                    if ((year % 4 === 0 && year % 100 !== 0) || (year % 400 === 0)) {
                        daysInMonth = 29;
                    } else {
                        daysInMonth = 28;
                    }
                    break;
                default:
                    daysInMonth = "Invalid month number! Please enter a number between 1 and 12.";
            }

            document.getElementById("result").innerText = `Days in month: ${daysInMonth}`;
        }
    </script>

</body>
</html>
