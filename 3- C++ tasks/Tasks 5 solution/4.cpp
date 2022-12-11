#include <iostream>

using namespace std;

template<class T>
class mystack
{
private:
    T *stk;
    int tos;
    int Size;
    static int Snum;
public:
/// constructor
    mystack(int x)
    {
        //cout << " constructor 1" <<endl;
        Size = x;
        tos = 0;
        stk = new T [Size];
        Snum++;
    }
    mystack()
    {
        //cout << " constructor 1" <<endl;
        Size = 0;
        tos = 0;
        Snum++;
        //stk = new int[Size];
    }
///copy constructor
    mystack(mystack &olds)
    {
        // cout << " copy constructor" <<endl;
        Size=olds.Size;
        tos =olds.tos;
        stk=new T [Size];
        for (int i=0; i<tos; i++)
        {
            stk[i] = olds.stk[i];
        }
        Snum++;
    }
/// destructor
    ~mystack()
    {
        cout << " destructor 1"<<endl;
        for(int i=0; i<tos; i++)
        {
            stk[i] = -1;
        }
        delete [] stk;
        Snum--;
    }
    bool isfull()
    {
        if (tos==Size)
            return true;
        else
            return false;
    }
    bool isempty()
    {
        if (tos==0)
            return true;
        else
            return false;
    }
    void push(T n)
    {
        if(!isfull())
        {
            stk[tos++] = n;
        }
        else
            cout <<"Stack is Full \n";
    }
    int pop()
    {
        if(!isempty())
        {
            return stk[--tos];
        }
        else
        {
            cout <<"Stack is Empty \n";
            return -1;
        }
    }
    int peek()
    {
        if(!isempty())
        {
            return stk[tos-1];
        }
    }
    int getcount()
    {
        return tos;
    }



    mystack reversestk()
    {
        mystack R(*this);

        for (int i=0 ; i<tos ; i++ )
        {
            R.stk[i] = stk[tos-i-1];
        }

        for (int i = 0 ; i<tos ; i++ )
        {
            cout<<R.stk[i]<<endl;
        }
        return R;
    }

    mystack operator+(const mystack&s)
    {
        mystack tempS;
        tempS.Size=Size+s.Size;
        tempS.stk=new T [tempS.Size];
        tempS.tos=0;


        for(int i=0 ; i<tos ; i++)
        {
            tempS.stk[i] = stk[i];
            tempS.tos++;
        }


        for(int i=0 ; i<s.tos ; i++)
        {
            tempS.stk[tos+i] = s.stk[i];
            tempS.tos++;
        }



        return tempS;
    }

    mystack& operator=(const mystack &s)
    {

        Size=s.Size;
        tos=s.tos;
        stk=new T [Size];
        for (int i=0; i<s.tos; i++)
        {
            stk[i] = s.stk[i];
        }
        return *this;

    }

    T& operator[](int index)
    {
        if ((index>=0)&&(index<Size))
            return stk[index];

    }
    static int getSnum()
    {
        return Snum;
    }

    friend void viewcontent(const mystack<T> &s);
};

template <class T>
int mystack <T> ::Snum=0;

template <class T>
void viewcontent(const mystack <T> &s)
{
    int i;
    for (i=0; i<s.tos; i++)
    {
        cout<< s.stk[i];
        cout<<endl;
    }
    //s.tos=5; /// will not do anything
    //s.Size=20;  /// will not do anything
    //s.stk=new int[10];  /// will not do anything

}



int main()
{
    cout<< "counter is i " <<mystack<int>::getSnum()<<endl;
    mystack<int> s1(4);
    s1.push(1);
    s1.push(2);
    s1.push(3);

    mystack<int> s2(3);
    s2.push(4);
    s2.push(5);

    mystack<int> s3;


    cout<< "counter is i " <<mystack<int>::getSnum()<<endl;

    cout<< "object s1 as an array"<<endl;

    cout<<s1[0]<<endl;
    cout<<s1[1]<<endl;
    cout<<s1[2]<<endl;


    cout<< "object s2 as an array"<<endl;

    cout<<s2[0]<<endl;
    cout<<s2[1]<<endl;
    cout<<"////////////////////////////////////////////////////////////////////////////////////////////"<<endl;
    cout<< "sum of s1 and s2"<<endl;
    s3=s1+s2;

    //viewcontent(s3);

    cout<<"////////////////////////////////////////////////////////////////////////////////////////////"<<endl;


    cout<< "counter is d  " <<mystack<double>::getSnum()<<endl;
    cout<< "counter is i " <<mystack<int>::getSnum()<<endl;
    mystack<double> s4(4);
    s4.push(1.1);
    s4.push(2.2);
    s4.push(3.3);

    mystack<double> s5(3);
    s5.push(4.4);
    s5.push(5.5);

    mystack<double> s6;


    cout<< "counter is d  " <<mystack<double>::getSnum()<<endl;
    cout<< "counter is i " <<mystack<int>::getSnum()<<endl;

    cout<< "object s4 as an array"<<endl;

    cout<<s4[0]<<endl;
    cout<<s4[1]<<endl;
    cout<<s4[2]<<endl;


    cout<< "object s5 as an array"<<endl;

    cout<<s5[0]<<endl;
    cout<<s5[1]<<endl;
    cout<<"////////////////////////////////////////////////////////////////////////////////////////////"<<endl;
    cout<< "sum of s4 and s5"<<endl;
    s6=s4+s5;

    //viewcontent(s6);

    cout<<"////////////////////////////////////////////////////////////////////////////////////////////"<<endl;
    cout<< "counter is d  " <<mystack<double>::getSnum()<<endl;
    cout<< "counter is i " <<mystack<int>::getSnum()<<endl;

}
