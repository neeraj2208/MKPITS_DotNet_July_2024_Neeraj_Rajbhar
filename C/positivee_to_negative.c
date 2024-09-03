#include <stdio.h>

int main() {
    int number;
    printf("Enter a positive number: ");
    scanf("%d", &number);
   
    if (number > 0)
    {
        int negativeNumber = -number;
        printf("The negative of the number is: %d\n", negativeNumber);
    } 
else {
        printf("The number entered is not positive.\n");
     }
    return 0;
}
