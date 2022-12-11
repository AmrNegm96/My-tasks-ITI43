#include <iostream>

using namespace std;

class Queue
{
private:

    int *stk;
    int tail,head;
    int Size;

public:

    Queue(int x)
    {
        tail=0;
        head=0;
        Size=x;
        cout<< " constructor 1 "<<endl;
        stk = new int (Size);
    }

    ~Queue()
    {
        cout<< "destructor 1"<<endl;
        delete (stk);
    }

    bool isfull()
    {
        if (tail==Size || (head==tail && tail!=0))
            return true;
        else
            return false;
    }
    bool isempty()
    {
        if (tail==head && tail==0 )
            return true;
        else
            return false;
    }
    void enQ(int n)
    {
        cout<<"enqueue"<<endl;
        ///queue is full
        if (isfull() == true)
        {
            cout<< "the queue is full"<<endl;
            return ;
        }

        stk[tail++]=n;

        if (head>0)
        {
          tail=tail%Size;
        }
/// if tail reach size tail=0

        ///queue is empty
        //if (head==0 && tail==0)
        //{
            //stk[tail]=n;
            //tail++;
        //}
        /// not empty not full
        /*else
        {
            stk[tail++]=n;
        }*/

    }

    int deQ()
    {
        cout<<"dequeue"<<endl;
        int temp;
        if(isempty())
        {
           cout<< "the queue is empty"<<endl;
           return -1;
        }


        temp=stk[head++];
        head=head%(Size+1);
        if(head==tail)
        {
            head=tail=0;
        }

        cout<<"1st element is";
        cout<<peek()<<endl;
        return temp;
        /*else if ()
        {

        }*/

        /* else if(tail==head)
        {
            tail=head=0;
        }*/
}

    int getcount()
    {

    }
    int getindex(int x)
    {
        return  stk[x];
    }
    int gettail()
    {
        return  tail;
    }
    int peek()
    {
        if (!isempty())
        {
            return stk[head];
        }
    }
};
int main()
{
    Queue q(5);

    q.enQ(3);
    q.enQ(4);
    q.deQ();
    q.enQ(5);

    q.enQ(6);
    q.enQ(7);
    /*cout<<q.deQ()<<endl;*/
    q.enQ(8);
    q.deQ();
    q.deQ();
    q.deQ();
    q.deQ();
    q.deQ();
    q.deQ();
    q.deQ();
    q.enQ(9);
    //cout<< "tail is ";
    //cout<< q.gettail()<<endl;

     //cout<<q.deQ()<<endl;
     //cout<<q.deQ()<<endl;
     //cout<<q.deQ()<<endl;
     //cout<<q.deQ()<<endl;

    //q.enQ(10);

    //cout <<"the dequeued number is \n";

    //cout<<q.deQ()<<endl;
    /*q.enQ(8);
    q.enQ(9);
    q.enQ(10);
    q.enQ(11);
    q.enQ(12);
    q.enQ(13);*/



    cout<<"the contents of array"<<endl;
    cout<<q.getindex(0)<<endl;
    cout<<q.getindex(1)<<endl;
    cout<<q.getindex(2)<<endl;
    cout<<q.getindex(3)<<endl;
    cout<<q.getindex(4)<<endl;
    cout << "\n \n \n";











}
