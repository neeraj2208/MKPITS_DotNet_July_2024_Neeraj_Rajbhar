#include <stdio.h>

int main() {
    int first = 2000; 
    int size = 6;    
    int arr[size];   

   
    for (int i = 0; i < size; i++)
    {
        arr[i] = first + i; 
    }
    for (int i = 0; i < size; i++) {
        printf("%d\n", arr[i]);
    }

    return 0;
}
