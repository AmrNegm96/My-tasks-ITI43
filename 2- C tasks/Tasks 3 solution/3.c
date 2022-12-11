#include <stdio.h>
#include <stdlib.h>

int main()
{
    int i , j ;

    int sum[3]={0};

    int arr[3][3]={{2,2,2},{4,4,4},{8,8,8}};

    for (i = 0 ; i < 3 ; i++) //i is row
        {
            for (j = 0 ; j < 3 ; j++)
                sum[i] += arr[i][j];
        }
    for (i = 0 ; i < 3 ; i++) //i is row
        {
            printf("sum is %i \n", sum[i]);
        }

}

