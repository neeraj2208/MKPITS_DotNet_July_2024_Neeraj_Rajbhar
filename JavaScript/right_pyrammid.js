function rightPyramid(rows) {
    for (let i = 1; i <= rows; i++) {
        let spaces = " ".repeat((rows - i) * 2);
        let pattern = "";
        for (let j = 1; j <= i; j++) {
            pattern += j + " ";
        }
        console.log(spaces + pattern);
    }
}

rightNumberPyramid(5);
