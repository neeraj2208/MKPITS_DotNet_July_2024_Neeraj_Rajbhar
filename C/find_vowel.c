#include<stdio.h>
int main()
{
	int count=0;
	char name[20];
	char *ptr;
	printf("Enter name :");
    gets(name);
    ptr=name;
	while(*ptr!='\0')
	{
		if(*ptr=='a' || *ptr=='e' || *ptr=='i' || *ptr=='o' || *ptr=='u')
		{
			count=count+1;
		}
		ptr++;
		
	}
	printf("Number of vowels in string = %d",count);	
}