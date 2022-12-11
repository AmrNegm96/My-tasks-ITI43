#include <iostream>

using namespace std;

void Merge(int* arr , int lfirst , int llast , int rfirst , int rlast)
{

    int* tempArr = new int[sizeof(arr)];

    int index = lfirst;

    int save1stindex=lfirst;

    while( (lfirst<=llast) && (rfirst<=rlast) )
    {

        if(arr[lfirst]<arr[rfirst])
        {
            tempArr[index++] = arr[lfirst++];
        }
        else
        {
            tempArr[index++] = arr[rfirst++];
        }
    }
    while(lfirst<=llast)
    {

        tempArr[index++]=arr[lfirst++];
    }
    while(rfirst<=rlast)
    {
        tempArr[index++]=arr[rfirst++];
    }
    for(int i=save1stindex ; i<=rlast ; i++)
    {
        arr[i]=tempArr[i];
    }
}
void mergeSort(int* arr , int first , int last)
{


    if(first<last)
    {

        int middle = (first+last)/2 ;

        mergeSort(arr,first,middle);
        mergeSort(arr,middle+1,last);

        Merge(arr,first,middle,middle+1,last);
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

    mergeSort(Arr,0,9);
    cout<<"sorted array"<<endl;
    printArr(Arr,size);
}
