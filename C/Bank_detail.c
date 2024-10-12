#include<stdio.h>
#include<string.h>
struct bank
{
	char name[20];
	int acnt,bal;
};
void main()
{
	struct bank b1[3];
	int counter;
	for(counter=0;counter<3;counter++)
	{
		printf("Name and Account no and Balance :");
		scanf("%s%d%d",&b1[counter].name,&b1[counter].acnt,&b1[counter].bal);
		
	}
	printf("\nAccount with balance minimum less than 100");
	for(counter=0;counter<3;counter++)
	{
		if(b1[counter].bal<100)
		{
			printf("\nname=%s, balance=%d",b1[counter].name,b1[counter].bal);
		}
	}
}
