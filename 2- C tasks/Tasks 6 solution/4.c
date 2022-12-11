#include <stdio.h>
#include <stdlib.h>

int main()
{
   int arr[5];
   int i;
   int *ptr;
   ptr=arr;
   //printf("%i",ptr);
   //printf("%i",&arr[0]);
   for(i=0;i<5;i++)
   {
     printf("please enter the a number %i: ", i+1);
     scanf("%i",ptr+i);
     //sum += *ptr;
     //printf("sum is %i: \n", sum);
   }
   for(i=0;i<5;i++)
   {
     printf("%i \n", *ptr+i );
   }

}
