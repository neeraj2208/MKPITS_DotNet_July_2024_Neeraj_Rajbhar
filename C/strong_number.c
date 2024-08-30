#include <stdio.h> 

void main()  
{  
    int i, num, num1, s1 = 0, j; 
    long fact; 
    
    printf("Input a number to check whether it is Strong number: ");
    scanf("%d", &num); 

    num1 = num; 
    for (j = num; j > 0; j = j / 10) 
    {  
        fact = 1; 
        for (i = 1; i <= j % 10; i++)  
        {  
            fact = fact * i;  
        }  
        s1 = s1 + fact; 
    }  

    if (s1 == num1)  
    {  
        printf("\n%d is Strong number.\n\n", num1);  
    }  
    else  
    {  
        printf("\n%d is not Strong number.\n\n", num1);  
    }  
}
