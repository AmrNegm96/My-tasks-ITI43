#include <iostream>

using namespace std;

int min_value_index(int* arr , int startIndex , int endIndex )
{
    int index = startIndex;
    for(int i = startIndex + 1 ; i < endIndex; i++)
    {
        if(arr[i]<arr[index])
        {
            index = i;
        }

    }
    return index;
}
void swap (int& a , int& b)
{
    int temp = b;
    b=a;
    a=temp;
}

/// selection sorting has O(n^2)

void selectionSort(int* arr, int size)
{
    int index ;

    for(int i = 0 ; i<size ; i++)
    {
        index=min_value_index(arr,i,size);
        swap(arr[i],arr[index]);
    }
}
int printArr(int* arr ,int size)
{
    for(int i = 0 ; i<size ; i++)
    {
        cout<<arr[i];cout<<endl;
    }
    cout<<endl;
}
int main()
{
    int size=10;

    int Arr[size]={10,3,9,2,8,5,7,4,6,1};

    cout<<"index of minimum value  "<<min_value_index(Arr,0,size)<<endl;
    cout<<"random array"<<endl;
    printArr(Arr,size);
    selectionSort(Arr,size);
    cout<<"sorted array"<<endl;
    printArr(Arr,size);


}
