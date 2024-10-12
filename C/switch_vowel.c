#include<stdio.h>
void main()
{
	char ch;
	printf("Enter character");
	scanf("%c",&ch);
	switch(ch)
	{
		case'a':
			printf("It is a vowel");
			break;
		case'e':
			printf("It is a vowel");
			break;
		case'i':
			printf("It is a vowel");
			break;
		case'o':
			printf("It is a vowel");
			break;
		case'u':
			printf("It is a vowel");
			break;	
		default:
			printf("\nInvalid vowel");
			break;
	}
	
}