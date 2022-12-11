#include <stdio.h>
#include <stdlib.h>

int main()
{
    int i , j ;

    int avg [3]={0};

    int arr[3][3]={{1,2,3},{4,5,6},{7,8,9}};

    for (i = 0 ; i < 3 ; i++) //i is row
        {
            for (j = 0 ; j < 3 ; j++)
                avg[j] += arr[i][j];
        }
    for (i = 0 ; i < 3 ; i++) //i is row
        {
            avg[i]/= 3;
            printf("avg is %i \n", avg[i]);
        }

}
