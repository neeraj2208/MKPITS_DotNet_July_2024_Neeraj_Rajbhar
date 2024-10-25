<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Month Finder</title>
</head>
<body>

    <h2>Find the Month Name</h2>
    <label for="monthNumber">Enter a number (1-12): </label>
    <input type="number" id="monthNumber" min="1" max="12">
    <button onclick="findMonth()">Show Month</button>

    <p id="result"></p>

    <script>
        function findMonth() {
            const monthNumber = parseInt(document.getElementById("monthNumber").value);
            let monthName;

            switch (monthNumber) {
                case 1:
                    monthName = "January";
                    break;
                case 2:
                    monthName = "February";
                    break;
                case 3:
                    monthName = "March";
                    break;
                case 4:
                    monthName = "April";
                    break;
                case 5:
                    monthName = "May";
                    break;
                case 6:
                    monthName = "June";
                    break;
                case 7:
                    monthName = "July";
                    break;
                case 8:
                    monthName = "August";
                    break;
                case 9:
                    monthName = "September";
                    break;
                case 10:
                    monthName = "October";
                    break;
                case 11:
                    monthName = "November";
                    break;
                case 12:
                    monthName = "December";
                    break;
                default:
                    monthName = "Invalid month number! Please enter a number between 1 and 12.";
            }

            document.getElementById("result").innerText = monthName;
        }
    </script>

</body>
</html>
