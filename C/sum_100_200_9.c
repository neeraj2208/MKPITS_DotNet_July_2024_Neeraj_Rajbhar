#include <stdio.h> 
void main()
{
   int iterate, sum=0; 
   printf("Numbers between 100 and 200, divisible by 9 : \n"); 
   for(iterate=101; iterate<200; iterate++)
   {
     if(iterate%9==0) 
     {
       printf("% d", iterate); 
       sum += iterate; 
     }
   }
   printf("\n\nThe sum : %d \n", sum);
}
