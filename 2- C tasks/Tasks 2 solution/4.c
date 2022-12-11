#include <stdio.h>
#include <stdlib.h>

int main()
{
    int num;

    printf("1st choice \n");

    printf("2nd choice \n");

    printf("3rd choice \n");

    printf("please choose your number \n");

    scanf("%d",&num);

    switch (num)
{
    case 1:
        printf("your choice is 1st");
    break;

    case 2:
        printf("your choice is 2nd");
    break;

    case 3:
        printf("your choice is 3rd");
    break;

    default:
        printf("please choose from 1 to 3");
    break;
}


}
