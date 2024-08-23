
#include <stdio.h>

int main()
{
  int row, col,r_limit,c_limit;
  printf("enter the row limit:");
  scanf("%d",&r_limit);
  
  printf("enter the column limit:");
  scanf("%d",&c_limit);
  
  printf("****The butterfly pattern***");
    for(row = 1; row <= r_limit; row++)
    {
        for(col = 1; col <= c_limit; col++) 
      {
          if((col == 1 || col == 6) && (row == 1))
          {
              printf("*");
          }
          else
          {
              printf(" ");
          }
         
          if((col == 1 || col == 2|| col == 5|| col == 6) && (row == 2))
          {
              printf("*");
          }
          else
          {
              printf(" ");
          }
          
          if((col == 1 || col == 3|| col == 4 || col == 6 ) && (row ==3 ))
          {
              printf("*");
          }
          else
          {
              printf(" ");
          }
          
          if((col ==1 || col == 3 || col == 4 || col == 6 ) && ( row == 4))
          {
              printf("*");
          }
          else
          {
              printf(" ");
          }
          
          if((col == 1 || col == 2 || col == 5 || col == 6) && (row == 5))
          {
              printf("*");
          }
          else
          {
              printf(" ");
          }
          
          if((col == 1 || col == 6) && ( row == 6))
          {
              printf("*");
          }
          else
          {
              printf(" ");
          }
          
      }
      printf("\n");
  }
  return 0;
}
