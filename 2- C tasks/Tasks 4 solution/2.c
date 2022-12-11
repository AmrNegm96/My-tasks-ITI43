#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main()
{
    char str_full[20] , str_1st[20] , str_2nd[20] ;

    printf("please enter your first name \n");

    gets(str_1st);

    printf("please enter your second name \n");

    gets(str_2nd);

    strcat(str_1st , " ");

    strcpy(str_full , strcat(str_1st , str_2nd));

    printf("hello ");

    puts(str_full);

}
