#include <stdio.h>

int main() {
    int n, i, flag = 0;

    printf("Enter the Number to check Prime: ");
    scanf("%d", &n);

    if (n <= 1) {
        printf("Number is not Prime.\n");
        return 0;
    }

    for (i = 2; i <= n / 2; i++) {
        if (n % i == 0) {
            printf("Number is not Prime.\n");
            flag = 1;
            break;
        }
    }

    if (flag == 0)
        printf("Number is Prime.\n");

    return 0;
}
