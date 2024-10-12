#include <stdio.h>
void main()
{
	int counter;
	int num;
	int result;
	printf("Enter table no :");
	scanf("%d",&num);
	while(counter<10)
	{
		result=num*counter;
	    counter=counter+1;	
	    printf("%d x %d = %d\n",num,counter,(num*counter));
	
	}		
}