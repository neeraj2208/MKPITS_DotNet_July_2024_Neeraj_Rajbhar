#include <stdio.h>

int main() 
{
    int num;
    printf("Enter the number of elements in the array: ");
    scanf("%d", &num);

    int arr[num];
    for (int i = 0; i < num; i++) 
      {
        printf("Element %d: ", i + 1);
        scanf("%d", &arr[i]);
      }
     int max = arr[0];
     for (int i = 1; i < num; i++) 
     {
        if (arr[i] > max) 
         {
            max = arr[i];
         }
    }

    // Print the maximum element
    printf("The maximum element in the array is: %d\n", max);

    return 0;
}
