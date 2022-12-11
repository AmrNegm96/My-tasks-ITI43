#include <stdio.h>
#include <stdlib.h>

int main()
{
    int x , sum=0;

    while(sum<100)
    {
        printf("please enter a number \n");
        scanf("%d",&x);
        //sum = sum + x;
        if (sum+x > 100)
        {printf("the sum+x more than 100 so sum is: %d",sum);
            break;
        }
        sum = sum + x;
        //printf("the number is: %d \n",x);//0
        printf("the sum now is: %d \n",sum);

    }
}
