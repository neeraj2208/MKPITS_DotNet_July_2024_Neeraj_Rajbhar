<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Day of the Week Finder</title>
</head>
<body>

    <h2>Find the Day of the Week</h2>
    <label for="dayNumber">Enter a number (1-7): </label>
    <input type="number" id="dayNumber" min="1" max="7">
    <button onclick="findDay()">Show Day</button>

    <p id="result"></p>

    <script>
        function findDay() {
            const dayNumber = parseInt(document.getElementById("dayNumber").value);
            let dayName;

            switch (dayNumber) {
                case 1:
                    dayName = "Sunday";
                    break;
                case 2:
                    dayName = "Monday";
                    break;
                case 3:
                    dayName = "Tuesday";
                    break;
                case 4:
                    dayName = "Wednesday";
                    break;
                case 5:
                    dayName = "Thursday";
                    break;
                case 6:
                    dayName = "Friday";
                    break;
                case 7:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid day number! Please enter a number between 1 and 7.";
            }

            document.getElementById("result").innerText = dayName;
        }
    </script>

</body>
</html>
