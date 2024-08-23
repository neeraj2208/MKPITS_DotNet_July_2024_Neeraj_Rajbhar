#include <stdio.h>

int main() {
    int name[15],qual[10] ;
    int age;
    
    printf("enter your name:");
    scanf("%s",&name);
    
    printf("enter your age :");
    scanf("%d",&age);
    
    printf("enter your  qualification :");
    scanf("%s",&qual);
    
    printf("my name is %s\n",name);
    printf("my age is %d\n",age);
    printf("my qualification is %s\n",qual);
    
    return 0;
}