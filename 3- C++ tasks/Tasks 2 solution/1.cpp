#include <iostream>

using namespace std;
class mystack
{
private:
    int *stk;
    int tos;
    int Size;
public:
/// constructor
mystack(int x)
{
    cout << " constructor 1" <<endl;
    Size = x;
    tos = 0;
    stk = new int[Size];
}
/// destructor
~mystack()
{
  cout << " destructor 1"<<endl;
  delete (stk);
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
void push(int n)
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

};
int main()
{
    mystack s1(7);
    s1.push(3);
    s1.push(4);
    s1.push(5);
    cout<<s1.pop()<<endl;
    cout<<s1.peek()<<endl;
    cout<<s1.peek()<<endl;
    cout<<s1.pop()<<endl;
    cout<<s1.getcount()<<endl;

    /*for (i=0;i<5;i++)
    {
       cout << s1.pop()<< endl;
    }

    for (i=0;i<4;i++)
    {
       cout << s1.peek()<< endl;
    }

    for (i=0;i<4;i++)
    {
       cout << s1.peek()<< endl;
    }

    for (i=0;i<5;i++)
    {
       cout << s1.pop()<< endl;
    }*/


}
