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

    int max = arr[0];
    int min = arr[0];

    for(i = 0 ; i < size ; i++)
    {
       if (min > arr[i])
       {
           min = arr[i];
       }

       if (max < arr[i])
       {
           max = arr[i];
       }

    }

    printf("Maximum element = %i \n", max);
    printf("Minimum element = %i", min);
}
