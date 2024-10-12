#include <stdio.h>
void main()
{
	float area,circ,radius;
	printf("Enter radius");
	scanf("%f",&radius);
	area=3.14*radius*radius;
	circ=2*3.14*radius;
	printf("area=%f\n",area);
	printf("circ=%f",circ);
}