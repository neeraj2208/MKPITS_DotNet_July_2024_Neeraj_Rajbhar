#include <stdio.h>
void main()
{
	int num1,num2,result=0;
	char op;
	printf("Enter 2 num:\n");
	scanf("%d%d",&num1,&num2);
	printf("Enter (+,-,*,/)");
	fflush(stdin);
	scanf("%c",&op);
	switch(op)
	{
		case'+':
			result=num1+num2;
			break;
		case'-':
		    result=num1-num2;
			break;
		case'*':
			result=num1*num2;
			break;
		case'/':
			result=num1/num2;
			break;
		default:
			printf("Invalid op");
			break;
			
	}
	printf("result=%d",result);
}
