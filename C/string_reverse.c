#include <stdio.h>  
#include <string.h>

void main()
{
   
char str1[100], tmp;
int l, count, count1, i;
   
printf("\n\nPrint a string in reverse order:\n ");
printf("-------------------------------------\n");
   
printf("Input a string to reverse : ");
scanf("%s", str1);
 
l = strlen(str1);
   
count = 0;
count1 = l - 1;
  
for(i = count; i< count1; i++)
{
tmp = str1[i];
str1[i] = str1[count1];
str1[count1] = tmp;
count1--;
}
printf("Reversed string is: %s\n\n", str1);
}
