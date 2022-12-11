#include <stdio.h>

int main()
{
    int x;

    printf("please enter a number \n");
    scanf("%i",&x);

    printf("the letter according to ascii code = %c \n",x);
    printf("the hexadecimal = %x \n\n",x);

    int ch;
    printf("please enter the character to get its ascii code \n");
    ch=getche();
    printf("\n the character ascii code is %d",ch);

}
