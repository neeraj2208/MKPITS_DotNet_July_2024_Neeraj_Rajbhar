#include <stdio.h>
void main()
{
	int n1,n2;
	printf("Enter 1 no:");
	scanf("%d",&n1);
	printf("Enter 2 no:");
	scanf("%d",&n2);
	if (n1<n2)
	{
		printf("%d is smaller",n1);
	}
	else
	{
		printf("%d is smaller",n2);
	}
}