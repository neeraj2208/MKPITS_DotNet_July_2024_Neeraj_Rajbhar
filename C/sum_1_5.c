#include <stdio.h>

int main()
 {
    int arr[10] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

    int first_element = arr[0];
    int fifth_element = arr[4];
    int sum = first_element + fifth_element;

    printf("The sum of the 1st element and the 5th element is: %d\n", sum);
    return 0;
}
