#include <stdio.h>

int main ()
{
  int num, sum = 0, remainder;
  printf("enter the number: ");
  scanf("%d",&num);
  while (num != 0)
	{
	  remainder = num % 10;
	  num = num / 10;
	  sum =sum+ remainder;
	}
  printf("sum of all the digits of number:");
  printf ("%d",sum);
  return 0;
}
