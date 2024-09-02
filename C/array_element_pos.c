#include <stdio.h>

int main()
{
    int size, element, found = 0;
    
    printf("Enter the number of elements in the array: ");
    scanf("%d", &size);
    
    int arr[size];
    printf("Enter the elements:\n");
    for (int i = 0; i < size; i++)
    {
        scanf("%d", &arr[i]);
    }

    printf("Enter the element to search for: ");
    scanf("%d", &element);
 
    for (int i = 0; i < size; i++)
    {
        if (arr[i] == element) 
        {
        printf("Element %d found at position %d \n", element, i);
               found = 1;
           // break;  Stop searching after finding the first occurrence
        }
    }
    
    if (!found)
    {
        printf("Element %d not found in the array \n", element);
    }
    
    return 0;
}
