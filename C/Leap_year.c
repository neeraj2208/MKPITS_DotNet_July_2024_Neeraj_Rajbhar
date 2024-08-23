#include <stdio.h>

int main() {
     int num1;
     printf("enter the first number: ");
     scanf("%d",&num1);
    
    if(num1%4==0)
    {
        printf("these is a leap year");
    }
    else
    {
        printf("this is not a leap year");
    }

    return 0;
}