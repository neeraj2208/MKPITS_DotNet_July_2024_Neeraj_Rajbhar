#include<stdio.h>
void main()
{
	int counter=1,num,result;
	printf("Enter table ");
	scanf("%d",&num);
	while(counter<=10)
	{
		result=num*counter;
		counter=counter+1;
		printf("%d\n",result);
	}
}