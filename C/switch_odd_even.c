#include <stdio.h>
void main()
{
	int num;
	printf("Enter num");
	scanf("%d",&num);
	switch(num%2==0)
	{
		case 1:
			printf("number is even");
			break;
		default:
		    printf("number is odd");
		    break;
		
			
	}
}