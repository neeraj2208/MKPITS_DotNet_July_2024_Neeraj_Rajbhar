function fibonacciSequence() {
    console.log("Fibonacci Sequence up to 10 Terms");
    var n1 = 0, n2 = 1, nextTerm;
    console.log("Fibonacci Series:");
    for (var i = 1; i <= 10; i++) {
        console.log(n1); 
        nextTerm = n1 + n2; 
        n1 = n2; 
        n2 = nextTerm;
    }
}