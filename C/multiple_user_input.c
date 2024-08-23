#include<stdio.h>
int main()
{
    int Multiple,num;
    printf("Enter any number:");
    scanf("%d",&num);
    for(int counter=1;counter<=10;counter++)
    {
       if(counter==5)
       {
           continue;
       }
       Multiple=num*counter;
       printf("%d\n",Multiple);
    }
    return 0;
}