#include<stdio.h>
void main()
{
	int row,col,space,k;
	space=row+3-1;
	for(row=1;row<=3;row++)
	{
		for(k=space;k>=1;k--)
		{
			printf("  ");
		}
		for(col=1;col<=row;col++)
		{
			printf("%d  ",col);
		}
		space--;
		printf("\n");
	}
}