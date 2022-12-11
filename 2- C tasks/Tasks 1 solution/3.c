#include <stdio.h>
#include <stdlib.h>

int main()
{
    int x,y,xor,Lshift,Rshift,or,and;
    printf("please enter 2 numbers \n");
    printf("1st number:");
    scanf("%d",&x);
    printf("2nd number:");
    scanf("%d",&y);

    or = x | y;
    and = x&y;
    xor = x^y;
    Lshift = y<<2;
    Rshift = y>>2;

    printf("or = %d \n",or);
    printf("and = %d \n",and);
    printf("xor = %d \n",xor);
    printf("Lshift = %d \n",Lshift);
    printf("Rshift = %d \n",Rshift);
}
