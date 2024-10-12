#include<stdio.h>
void main()
{
	int counter=2;
	int rem=0;
	int num;
	printf("Enter num :");
	scanf("%d",&num);
	while(counter<num)
	{
		rem=num%counter;
	if(rem==0)
	{
		printf("It is a not prime num");
		break;
	}
	counter=counter+1;
	if(num==counter)
	{
		printf("It is a prime num");
	}
	}
}