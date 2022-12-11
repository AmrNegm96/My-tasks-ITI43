#include <stdio.h>
#include <stdlib.h>

int main()
{
    int r1,c1,r2,c2,i,j,k,sum;

    printf("please enter the rows of first matrix \n");
    scanf("%i",&r1);
    printf("please enter the columns of first matrix \n");
    scanf("%i",&c1);
    printf("please enter the rows of second matrix \n");
    scanf("%i",&r2);
    printf("please enter the columns of second matrix \n");
    scanf("%i",&c2);

    if (c1 == r2)
    {
        int arr1[r1][c1];
        int arr2[r2][c2];
        int mult[r1][c2];

        printf("please enter the elements of the first matrix \n");
        for (i=0 ; i<r1 ; i++)
        {
            for (j=0 ; j<c1 ; j++)
                scanf("%i",&arr1[i][j]);
        }
        printf("please enter the elements of the second matrix \n");
        for (i=0 ; i<r2 ; i++)
        {
            for (j=0 ; j<c2 ; j++)
                scanf("%i",&arr2[i][j]);
        }


        printf("multiply of the matrix= \n");
        for(i=0;i<r1;i++) //row 3 because result will be like matrix 1 rows
        {
        for(j=0;j<c2;j++) //col 1 because result will be like matrix 2 columnx
        {
        sum=0;
        for(k=0;k<c1;k++)   // k take the value of middle numbers of matrix c1 or r2
        {
        sum = sum + arr1[i][k] * arr2[k][j];
        }
        mult[i][j] = sum;
        }
        }



        for(i=0;i<r1;i++)
        {
            for(j=0;j<c2;j++)
        {
            printf("%i          ",mult[i][j]);
        }
            printf("\n");
        }
    }
    else
        printf("please enter new numbers");


}
