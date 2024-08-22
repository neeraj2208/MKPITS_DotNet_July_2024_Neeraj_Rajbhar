
#include <stdio.h>

int main() {
    int i,sum=0;
    printf("The first 10 natural numbers are:");
    for(i=1;i<=10;i++)
    {
        sum=sum+i;
        printf("%d\t",i);
        
    }
    
        printf("\nThe sum is %d",sum);
        
    return 0;
}