#include <iostream>

using namespace std;


void printArray(int array[], int size)
{
    for (int i = 0; i < size; i++)
    {
        cout << array[i] << " ";
    }
    cout << endl;
}

void insertionSort(int array[], int size)
{
    for (int i = 1; i < size; i++)
    {
        int key = array[i];
        int j = i - 1;

        // Compare key with each element on the left of it until an element smaller than
        // it is found.
        // For descending order, change key<array[j] to key>array[j].
        while (key < array[j] && j >= 0)
        {
            array[j + 1] = array[j];
            --j;
        }
        array[j + 1] = key;
    }
}

int main()
{
    int size=10;
    int Arr[size]= {10,3,9,2,8,5,7,4,6,1};

    cout<<"random array"<<endl;
    printArray(Arr,size);

    insertionSort(Arr, size);

    cout<<"sorted array"<<endl;
    printArray(Arr, size);
}
