#include <stdio.h>

int main() {
    int day;
    printf("enter the day number: ");
    scanf("%d",&day);
    switch(day)
    
    {
        case 1:
        printf("Today is MOnday");
        break;
        
        case 2:
        printf("Today is Tuesday");
        break;
        
        case 3:
        printf("Today is Wednesday");
        break;
        
        case 4:
        printf("Today is Thursday");
        break;
        
        case 5:
        printf("Today is Friday");
        break;
        
        case 6:
        printf("Today is Saturday");
        break;
        
        case 7:
        printf("Today is Sunday");
        break;
        
    }
    
    return 0;
}