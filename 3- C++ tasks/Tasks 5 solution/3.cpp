#include <iostream>

using namespace std;
template <class T>
class intArr
{
    T *arr;
    int Size;
    static int arrNum;
public:
    intArr()
    {
        arrNum++;
    }

    intArr(int s)
    {
        Size = s;
        arr = new T [Size];
        arrNum++;
    }

    ///copy constructor
    intArr(const intArr &a)
    {
        Size = a.Size;
        arr = new T [Size];
        for (int i = 0; i < Size; i++)
        {
            arr[i] = a.arr[i];
        }
        arrNum++;
    }

    void setvalue(int index, T value)
    {
        if (index < Size && index >= 0)
            arr[index] = value;
        else cout << "Index out of size!" << endl;
    }

    int getSize() //const
    {
        return Size;
    }
    static int getarrNum()
    {
        return arrNum;
    }

    intArr &operator=(const intArr &a)
    {
        delete[]arr; //////////////////////////
        Size = a.Size;
        arr = new T [Size];
        for (int i = 0; i < Size; i++)
        {
            arr[i] = a.arr[i];
        }
        return *this;
    }

    T &operator[](int index)
    {
        if (index < Size && index >= 0)
            return arr[index];
        cout << "Index out of size!" << endl;
    }

    intArr operator+(const intArr &a)
    {
        intArr sum(Size > a.Size ? *this : a); ///deep copy using copy ctor the array with bigger size
        int smallerSize = (Size < a.Size ? Size : a.Size);

        for (int i = 0; i < smallerSize; ++i)
        {
            sum.arr[i] += (Size < a.Size ? arr[i] : a.arr[i]);///add the values of the array with smaller size to the sum array
        }
        return sum;
    }

    ~intArr()
    {
        for (int i = 0; i < Size; i++)
        {
            arr[i] = 0;
        }
        delete[]arr;
        arrNum--;
    }

};

template <class T>
int intArr<T>::arrNum=0;

int main()
{

    intArr<double> myA(7);
    cout << "myA Array:" << endl;
    for (int i = 0; i < myA.getSize(); ++i)
    {
        myA[i] = 2.5 * i;
        cout << myA[i] << endl;
    }
    cout<<"arrays number double= "<<intArr<double>::getarrNum()<<endl;
    cout<<"arrays number Int = "<<intArr<int>::getarrNum()<<endl;

    cout << "/////////////////////////////////////////////" << endl;

    intArr<double> myA2(5);
    cout << "myA2 Array:" << endl;
    for (int i = 0; i < myA2.getSize(); ++i)
    {
        myA2[i] = 5.5 + i;
        cout << myA2[i] << endl;
    }
    cout<<"arrays number double = "<<intArr<double>::getarrNum()<<endl;
    cout<<"arrays number Int = "<<intArr<int>::getarrNum()<<endl;

    cout << "////////////////////////////////////////////" << endl;

    intArr<double> sum = myA + myA2;
    cout << "sum Array:" << endl;
    for (int i = 0; i < sum.getSize(); ++i)
    {
        cout << sum[i] << endl;
    }
    cout<<"arrays number double = "<<intArr<double>::getarrNum()<<endl;
    cout<<"arrays number Int = "<<intArr<int>::getarrNum()<<endl;

    cout << "//////////////////////////////////////////" << endl;

    intArr<int> myB(7);
    cout << "myA Array:" << endl;
    for (int i = 0; i < myB.getSize(); ++i)
    {
        myB[i] = 3 * i;
        cout << myB[i] << endl;
    }
    cout<<"arrays number int= "<<intArr<int>::getarrNum()<<endl;

    cout << "//////////////////////////////////////////" << endl;

    intArr<int> myB2(4);
    cout << "myA2 Array:" << endl;
    for (int i = 0; i < myB2.getSize(); ++i)
    {
        myB2[i] = 3 + i;
        cout << myB2[i] << endl;
    }
    cout<<"arrays number int= "<<intArr<int>::getarrNum()<<endl;

    cout << "/////////////////////////////////////////////" << endl;

    intArr<int> sum1;
    sum1= myB + myB2;
    cout << "sum Array:" << endl;
    for (int i = 0; i < sum.getSize(); ++i)
    {
        cout << sum1[i] << endl;
    }
    cout<<"arrays number int= "<<intArr<int>::getarrNum()<<endl;

    cout << "/////////////////////////////////////////////" << endl;

    intArr<char> myA4(7);
    cout << "myA4 Array: " << endl;
    string s = "hahaha";
    for (int i = 0; i < myA4.getSize(); ++i) {
        myA4[i] = s[i];
        cout << myA4[i] << endl;
    }
    cout<<"Snum char = "<<intArr<char>::getarrNum()<<endl;
    cout<<"Snum Int = "<<intArr<int>::getarrNum()<<endl;
    cout << "/////////////////////////////////////////////" << endl;


}
