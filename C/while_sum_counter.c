#include<stdio.h>
void main()
{
	int counter=5;
	int sum=0;
	while(counter<=20)
	{
		
		sum=sum+counter;
		counter=counter+1;
	}
	printf("sum is %d",sum);
	
}