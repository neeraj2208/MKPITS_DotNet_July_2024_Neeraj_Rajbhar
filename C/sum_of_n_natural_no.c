#include <stdio.h>

int main() {
    int i,j,sum=0;
    scanf("%d",&j);
    printf("The first  %d natural numbers are:",j);
    for(i=1;i<=j;i++)
    {
        sum=sum+i;
        printf("%d\t",i);
        
    }
    
        printf("\nThe sum is %d",sum);
        
    return 0;
}