#include <stdio.h>
#include <stdlib.h>

int a=5 , b=3;
int swapvalue (int x , int y)
{
    int temp = x;
    x = y;
    y = temp;
}

int swapaddress (int *x , int *y)
{
    int temp = *x;
    *x = *y;
    *y = temp;
}
int main()
{
    int a , b;

    a=5;
    b=3;

    swapvalue(a,b);
    printf("pass by value: a=%i , b=%i \n",a,b);

    swapaddress(&a,&b);
    printf("pass by address: a=%i , b=%i \n",a,b);
}
