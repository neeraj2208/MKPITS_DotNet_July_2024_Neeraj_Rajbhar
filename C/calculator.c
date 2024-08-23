// Online C compiler to run C program online
#include <stdio.h>

int main() {
    int num1 , num2 ;
    int add, sub, multi,divi;
    printf("Enter first number:");
    scanf("%d",&num1);
    
    printf("Enter second number:");
    scanf("%d",&num2);
    
    add=num1+num2;
    sub=num1-num2;
    multi=num1*num2;
    divi=num1/num2;
    
    printf("Addition of two number is: %d\n",add);
    printf("Substraction of two number is: %d\n",sub);
    printf("Multplication of two number is: %d\n",multi);
    printf("Division of two number is: %d\n",divi);
    
    return 0;
}