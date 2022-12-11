#include <iostream>

using namespace std;

int BsearchItr(int* arr, int SearchNum, int low, int high)
{
    while(low<=high)
    {
        int mid=(high+low)/2;

        if (arr[mid]==SearchNum)
        {
            return mid;

        }
        else if (SearchNum>arr[mid]) /// go right
        {
            low=mid+1;
        }
        else ///go left
        {
            high=mid-1;
        }
    }
    return -1;
}
int main()
{
    int size = 10 ;
    int arr[size] = {1,3,5,7,9,11,13,15,17,19};
    BsearchItr(arr,2,0,9);
    int result = BsearchItr(arr,9,0,9);

    if (result == -1)
        printf("Not found");
    else
        printf("Element is found at index %d", result);
}
