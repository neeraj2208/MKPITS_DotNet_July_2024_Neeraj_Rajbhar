#include <stdio.h>

int main() {
     int num_m;
     printf("enter the value of m: ");
     scanf("%d",&num_m);
    
    if(num_m>0)
    {
        printf("the value of n is 1");
    }
    else if(num_m==0)
    {
        printf("the value of n is 0");
    }
    else
    {
        printf("the value of n is -1");
    }

    return 0;
}