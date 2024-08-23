#include <stdio.h>

int main() {
  int num1,num2;
  printf("Enter any two numbers : ");
  scanf("%d%d",&num1,&num2);
   
   if(num1%2==0 && num2%2==0)
   {
       printf("%d %d is even",num1,num2);
   }
   else
   {
       printf("%d %d is odd",num1,num2);
   }
    return 0;
}