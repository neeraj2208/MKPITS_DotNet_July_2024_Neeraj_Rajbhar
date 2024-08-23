#include <stdio.h>
int main() {
  int num1,num2,num3;
  printf("enter the first number:");
  scanf("%d",&num1);
  printf("enter the second number:");
  scanf("%d",&num2);
  printf("enter the third number:");
  scanf("%d",&num3);
  
  if(num1>num2 && num1>num3)
  {
      printf("num1 is greatest among three");
  }
  
  else if(num2>num1 && num2>num3)
  {
      printf("num2 is greatest among three");
  }
  else
  {
      printf("num3 is greatest among three");
  }

    return 0;
}