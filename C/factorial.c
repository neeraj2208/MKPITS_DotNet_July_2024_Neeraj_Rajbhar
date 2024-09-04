#include <stdio.h>

int main() 
{
    int number;
    long factorial = 1;

    printf("Input the number: ");
    scanf("%d", &number);

    if (number < 0) 
    {
        printf("Factorial is not defined for negative numbers.\n");
    }
    for (int i = 1; i <= number; ++i) 
    {
        factorial *= i;
    }
    printf("The Factorial of %d is: %d\n", number, factorial);
    return 0;
}
