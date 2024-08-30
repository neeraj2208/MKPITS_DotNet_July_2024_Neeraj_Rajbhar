#include <stdio.h>

int main() {
    int iterate, count, k;
    int rows = 4;  

    for (iterate = 1; iterate <= rows; iterate++) 
   {
       for ( count = rows;  count > iterate;  count--)
        {
        printf(" ");
        }
        for (k = 1; k <= iterate; k++)
        {
            printf("%c ", 'A' + k - 1);
        }
        for (k = iterate - 1; k >= 1; k--) 
        {
            printf("%c ", 'A' + k - 1);
        }
        printf("\n");
    }
   return 0;
}
