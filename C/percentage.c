#include <stdio.h>
void main()
{
	float sub1,sub2,sub3,total,per;
	printf("Enter 3 subject marks");
	scanf("%f,%f,%f",&sub1,sub2,sub3);
	total=sub1+sub2+sub3;
	per=total/300.0f*100;
	printf("total_marks=%f\n",total);
	printf("percentage=%f",per);
}