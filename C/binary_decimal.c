#include <stdio.h> 
#include <math.h> 

void main()
{
    int num1, num;
    int dec = 0, i = 0, j, d; 

    printf("enter the binary number:"); 
    scanf("%d", &num); 
    num1 = num; 

    while (num != 0)
    {  
        d = num % 10; 
        dec = dec + d * pow(2, i); 
        num = num / 10; 
        i++; 
    }
    printf("\nThe Binary Number: %d\nThe equivalent Decimal Number is: %d\n\n", num1, dec);
}
