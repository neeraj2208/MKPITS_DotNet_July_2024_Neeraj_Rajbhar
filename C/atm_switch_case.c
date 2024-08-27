#include <stdio.h>
int main()
{
  char op;
  int pin=123, ava_cash=8000,u_pin,cash_with,dep_cash;
  
  printf("Enter the user atm pin:");
  scanf("%d",&u_pin);
  
  if(pin==u_pin)
  {
      printf("Go for futher operation\n");
  }
  else
  {
      printf("Terminate the operation\n");
  } 
  printf("--State bank of INDIA--\n");
  printf("Enter number to perform operation: ");
  scanf("%s",&op);
  
  switch(op)
  {
      case'a':
      printf("Check the balance in account %d\n",ava_cash);
      break;
      
      case 'b':
      printf("Enter the cash withdrawl amount: ");
      scanf("%d",&cash_with);
      if(cash_with<=ava_cash)
      {
          printf("The cash withdrawl amount is %d\n",cash_with);
          printf("The balance amount is %d\n",ava_cash-cash_with);
      }
      else
      {
          printf("Did not having sufficient balance");
      }
      break;
      
     case 'c':
     printf("Enter the amount to deposit:");
     scanf("%d",&dep_cash);
     printf("The updated amount of bank account %d\n",ava_cash+dep_cash);
      
  }
   return 0;
}