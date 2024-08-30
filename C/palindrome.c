#include <stdio.h> 

void main(){
    int num, reverse, sum = 0, temp; 
    printf("Input a number: "); 
    scanf("%d", &num); 
    for(temp = num; num != 0; num = num / 10){ 
         reverse = num % 10; 
         sum = sum * 10 + r;
    }
    if(temp == sum) 
         printf("%d is a palindrome number.\n", temp); 
    else
         printf("%d is not a palindrome number.\n", temp); 
}
