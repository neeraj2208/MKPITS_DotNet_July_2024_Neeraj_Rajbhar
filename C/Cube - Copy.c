#include <stdio.h>

int main()
 {
    int terms;

    printf("Input number of terms: ");
    scanf("%d", &terms);

    for (int i = 1; i <= terms; ++i) 
    {
        int cube = i * i * i;  
        printf("Number is : %d and cube of the %d is : %d\n", i, i, cube);
    }

    return 0;
}
