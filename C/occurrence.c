#include <stdio.h>

int main() 
{
    int size, element, count = 0;
    
    printf("Enter the number of elements in the array: ");
    scanf("%d", &size);
    int arr[size];
    
    printf("Enter the  element:\n");
    for (int i = 0; i < size; i++)
    {
        scanf("%d", &arr[i]);
    }
    
    printf("Enter the element to count occurrences: ");
    scanf("%d", &element);
    for (int i = 0; i < size; i++)
    {
        if (arr[i] == element)
        {
            count++;
        }
    }
    printf("Element %d occurs %d times in the array \n", element, count);
    
    return 0;
}
