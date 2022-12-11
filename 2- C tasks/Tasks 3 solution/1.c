#include <stdio.h>
#include <stdlib.h>

int main()
{
    int size , i ;

    printf("please enter the size of array: \n");
    scanf("%i",&size);

    int arr[size];

    for(i = 0 ; i < size ; i++)
    {
       printf("please enter a number %i \n" , i+1);
       scanf("%i",&arr[i]);
    }

    for(i = 0 ; i < size ; i++)
    {
       printf("The number you entered are %i \n" , arr[i]);

    }

}
