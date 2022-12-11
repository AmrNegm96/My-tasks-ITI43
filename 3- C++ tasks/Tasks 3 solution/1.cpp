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
///copy constructor
mystack(mystack &olds)
{
    cout << " copy constructor" <<endl;
    Size=olds.Size;
    tos =olds.tos;
    for (int i=0; i<tos;i++)
    {
        stk[i] = olds.stk[i];
    }
}
/// destructor
~mystack()
{
  cout << " destructor 1"<<endl;
  for(int i=0; i<tos;i++)
  {
      stk[i] = -1;
  }
  delete [] stk;
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
mystack reversestk(mystack &s)
{
    int k=0;

    mystack s[Size];
                                     ///reverse[k++] = array[i--];
    for (int i = Size-1 ; i>=0 ; )
    {
        s[k++]=stk[i--];
    }

    return result;
}
friend void viewcontent(const mystack &s);
};

 void viewcontent(const mystack &s)
{
    int i;
    for (i=0;i<s.tos;i++)
    {
        cout<< s.stk[i];
        cout<<endl;
    }
    s.tos=5;
    s.Size=20;
    s.stk=new int[10];

}



int main()
{
    mystack s1(7);
    s1.push(3);
    s1.push(4);
    s1.push(5);
    s1.push(6);
    s1.push(7);
    cout<<"view content of stk"<<endl;
    viewcontent(s1);
    cout<<endl;

    cout<<"reverse content of stk"<<endl;
    s1.reversestk().pop();
    cout<<endl;
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
