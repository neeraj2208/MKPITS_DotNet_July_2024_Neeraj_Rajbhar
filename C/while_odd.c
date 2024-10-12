#include<stdio.h>
void main()
{
	int counter=20;
	while(counter<=30)
	{
		if(counter%2==1)
		{
			printf("\n%d",counter);
		}
		counter=counter+1;
	}
}