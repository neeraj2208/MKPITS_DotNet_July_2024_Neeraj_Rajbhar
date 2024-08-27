#include <stdio.h>
int main() 
{
    char c;
    int d;
    
    printf("Enter the character : ");
    scanf("%c",&c);
    printf("Ascii value of  %c=%d",c,c );
    
    printf("\nEnter the number : ");
    scanf("%d",&d);
    printf("Ascii value of %d=%c",d,d);

    return 0;
}