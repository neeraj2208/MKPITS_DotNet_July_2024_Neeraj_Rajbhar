#include<stdio.h>
void main()
{
	int num;
	int fact=1;
	printf("Enter num :");
	scanf("%d",&num);
	while(num>0)
	{
		fact=fact*num;
		num=num-1;
		
    }
    printf("Fact is %d",fact);
}