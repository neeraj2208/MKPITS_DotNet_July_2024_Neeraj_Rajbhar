#include <stdio.h>
#include <string.h>

int main()
{
    char str[] = "boby";
    int length = strlen(str);

    printf("String entered character-wise is:\n");
    for (int i = 0; i < length; i++)
    {
        printf("%c\n", str[i]);
    }

    printf("String entered in reverse order is:\n");
    for (int i = length - 1; i >= 0; i--)
    {
        printf("%c\n", str[i]);
    }
    return 0;
}
