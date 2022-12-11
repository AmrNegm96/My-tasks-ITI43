#include <iostream>

using namespace std;


void swap (int& a , int& b)
{
    int temp = b;
    b=a;
    a=temp;
}

void bubbleSortASC(int* arr , int size)
{
    bool sorted = false;

    for(int i=0 ; (i<size)&&(!sorted) ; i++)
    {
        sorted=true;

        for(int j=0 ; j<size-i-1 ;j++)
        {
            if(arr[j]>arr[j+1])
            {
                swap(arr[j],arr[j+1]);
                sorted = false ;
            }
        }
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


    cout<<"random array"<<endl;
    printArr(Arr,size);
    bubbleSortASC(Arr,size);
    cout<<"sorted array"<<endl;
    printArr(Arr,size);
}
