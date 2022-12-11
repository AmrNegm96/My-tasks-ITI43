#include <iostream>

using namespace std;

int BsearchRec(int* Arr , int SearchNum, int low, int high)
{
    if(low>high)
    {
        return -1;
    }
    else
    {
        int mid=(high+low)/2;

        if (Arr[mid]==SearchNum)
        {
            return mid;
        }
        else if (SearchNum>Arr[mid]) /// go right
        {
            BsearchRec(Arr , SearchNum, mid+1, high);
        }
        else ///go left
        {
            BsearchRec(Arr , SearchNum, low , mid-1);
        }
    }

}

int main()
{
    int size = 10 ;
    int arr[size] = {1,3,5,7,9,11,13,15,17,19};

    int result = BsearchRec(arr,19,0,9);

    if (result == -1)
        printf("Not found");
    else
        printf("Element is found at index %d", result);
}
