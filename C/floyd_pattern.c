#include <stdio.h>

int main() {
    int iterate = 5; 
    int num = 1; 

    for (int i = 1; i <= iterate; i++) 
        {
        for (int j = 1; j <= i; j++)
        {
            printf("%d ", num++);
        }
        printf("\n");
    }

    return 0;
}
