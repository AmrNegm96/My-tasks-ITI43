#include <stdio.h>
#include <stdlib.h>

int main()
{
    char name[20];
    int i;
    char ch;

    printf("please enter your name \n");

    for ( i=0 ; i<20 ; i++)
    {
        ch = _getche();
        if(ch==0x0d)
        {
            name[i] = '\0';
            break;
        }
        name[i] = ch;
    }

    printf("\n \nhello ");

    i=0;

    while (name[i] != '\0')
    {
       printf("%c" , name[i]);
       i++;
    }
    printf("\n \n");
}
