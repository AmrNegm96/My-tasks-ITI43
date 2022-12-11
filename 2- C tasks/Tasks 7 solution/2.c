#include <stdio.h>
#include <stdlib.h>

int main()
{
///marks is a pointer to array of pointers pointing to studN of arrays of index subN
    int **marks;
    int *sum;
    float *avg;
    int i,j,subN,studN;


///get students number
    printf("enter the number of students \n");
    scanf("%i",&studN);
///pointer to space in heap contain int** size=2bytes  .. points to student number of pointers (int*)
    marks=(int**) malloc(studN*sizeof(int*));
///pointer to space in heap contain int* size=2bytes  .. points to array of student number to put sum in it
    sum=(int*) malloc(studN*sizeof(int));
///get subjects number
    printf("enter the number of subjects \n");
    scanf("%i",&subN);

    for(i=0; i<studN; i++)
    {
///pointer to space in heap contain int* size=2bytes  .. points to subject number of real marks (ints
        marks[i]=(int*) malloc(subN*sizeof(int));
///pointer to space in heap contain float* size=2bytes  .. points to array of subject number to put average in it
        avg=(float*) malloc(subN*sizeof(float));
    }
///initialize sum array by 0
    for(i=0; i<studN; i++)
    {
        sum[i]=0;
    }
///initialize average array by 0
    for(i=0; i<subN; i++)
    {
        avg[i]=0;
    }
///double loop to get the marks of each student in each subject and fill the sum and average arrays
    for(i=0; i<studN; i++)
    {
        for(j=0; j<subN; j++)
        {
            printf("student %i subject %i \n",i+1,j+1);
            scanf("%i",&marks[i][j]);
            sum[i]+=marks[i][j];
            avg[j]+=marks[i][j];
        }
    }
///get average
    for(i=0; i<subN; i++)
    {
        avg[i] = avg[i]/studN;
    }
///print sum using loop by studN to empty the array of sum
    for(i=0; i<studN; i++)
    {
        printf("the sum of subject of student %i is %i \n",i+1,sum[i]);
    }
///print average using loop by subN to empty the array of average
    for(i=0; i<subN; i++)
    {
        printf("the average of marks of subject %i is %f \n",i+1,avg[i]);
    }
///free array of pointer marks[i] by loop because it is pointers array
    for(i=0; i<studN; i++)
    {
        free(marks[i]);
    }
 ///free pointer marks
    free(marks);
}



/*int main()
{
    int *marks[3];
    int sum[3]= {0};
    float *avg;
    int i,j,subN;


    printf("enter the number of subjects \n");
    scanf("%i",&subN);

    for(i=0; i<3; i++)
    {
        marks[i]=(int*) malloc(subN*sizeof(int));
        avg=(float*) malloc(subN*sizeof(float));
    }
    for(i=0; i<subN; i++)
    {
        avg[i]=0;
    }

for(i=0; i<3; i++)
{
   for(j=0; j<subN; j++)
            {
                printf("student %i subject %i \n",i+1,j+1);
                scanf("%i",&marks[i][j]);
                sum[i]+=marks[i][j];
                avg[j]+=marks[i][j];
            }
}

        for(i=0; i<subN; i++)
        {
            avg[i]/=3;
        }
        for(i=0; i<3; i++)
        {
            printf("the sum of subject of student %i is %i \n",i+1,sum[i]);
        }
        for(i=0; i<subN; i++)
        {
            printf("the average of subject of student %i is %f \n",i+1,avg[i]);
        }
        for(i=0; i<3; i++)
        {
            free(marks[i]);
        }
    }*/
/*
int main()
{
    int marks[3][5];
    int sum[3]= {0};
    float avg[5]={0};
    int i,j,;



    for(i=0; i<3; i++)
    {

        for(j=0; j<5; j++)
        {
            printf("student %i subject %i \n",i+1,j+1);
            scanf("%i",&marks[i][j]);
            sum[i]+=marks[i][j];
            avg[j]+=marks[i][j];
        }
    }
    for(i=0; i<5; i++)
    {
        avg[i]/=3;
    }
    for(i=0; i<3; i++)
    {
        printf("the sum of subject of student %i is %i \n",i+1,sum[i]);
    }
    for(i=0; i<5; i++)
    {
        printf("the average of subject %i of student %i is %f \n",i+1,avg[i]);
    }
}*/
