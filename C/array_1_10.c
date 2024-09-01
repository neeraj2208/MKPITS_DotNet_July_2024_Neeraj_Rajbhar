#include <stdio.h>

int main()
{
    int arr[10];
    for (int i = 0; i < 10; i++)
    {
        arr[i] = i + 1; 
    }
    printf("The values in the array are:\n");
    for (int i = 0; i < 10; i++)
    {
        printf("%d\t", arr[i]); 
    }

    return 0;
}
