#include<stdio.h>
void main()
{
	char name [20];
	char designation;
	int salary;
	printf("Enter Employee name:");
	scanf("%s",&name);
	printf("Enter designation(m,c,p)");
	fflush(stdin);
	scanf("%c",&designation);
	switch(designation)
	{
		case'm':
			salary=50000;
			break;
		case'c':
			salary=20000;
			break;
		case'p':
			salary=10000;
			break;
		default:
			printf("Invalid");
			break;
	}
	printf("\nemploye name=%s",name);
	printf("\nsalary=%d",salary);
}