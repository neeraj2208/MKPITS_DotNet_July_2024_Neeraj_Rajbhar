#include <stdio.h>

int main() {
   int h1;
   printf("enter the height of person :");
   scanf("%d",&h1);
   if(h1<100 && h1>=0)
   {
       printf("the person is too short");
   }
   else if(h1>100 && h1<=200)
   {
       printf("the person is dwarf");
   }

    return 0;
}