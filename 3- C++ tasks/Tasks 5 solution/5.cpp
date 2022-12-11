#include <iostream>

using namespace std;
template<class T>
class Queue
{
    int tos,Size;
     T *stk;

public:
    Queue(int x)
    {
        Size=x;
        stk = new T[Size];
        tos = 0;
    }

    ~Queue()
    {
        delete (stk);
    }

    bool isFull()
    {
        if (tos == Size)
            return true;
        return false;
    }

    bool isEmpty()
    {
        if (tos == 0)
            return true;
        return false;
    }

    void enqueue(T num)
    {
        if (tos < Size)
        {
            stk[tos++] = num;
            cout << "Enqueued Number " << num << endl;
        }
        else cout << "Queue is Full" << num << endl;
    }

    T dequeue()
    {
        int dequeuedNum = stk[0];
        if (!isEmpty())
        {
            for (int i = 0; i < tos - 1; i++)
            {

/// shifting all cells of array one step backward

                stk[i] = stk[i + 1];
            }
            tos--;
            return dequeuedNum;
        }

        cout << "Queue is empty" << endl;
        return -1;
    }

    T peek()
    {
        if (!isEmpty())
        {
            return stk[0];
        }
    }
    int getNumberOfElements()
    {
        return tos;
    }


};

int main()
{
    Queue<int> q1(4);
    cout << q1.dequeue() << endl;
    q1.enqueue(1);
    q1.enqueue(2);
    cout << "Peek is : " << q1.peek() << endl;
    q1.enqueue(3);
    cout << "Number of Elements : " << q1.getNumberOfElements() << endl;
    cout << q1.dequeue() << endl;
    q1.enqueue(4);
    cout << q1.isFull() << endl;
    q1.enqueue(5);
    cout << q1.isFull() << endl;
    q1.enqueue(6);
    cout << "Peek is : " << q1.peek() << endl;
    cout << q1.isEmpty() << endl;
    cout << q1.dequeue() << endl;
    cout << q1.dequeue() << endl;
    cout << "Number of Elements : " << q1.getNumberOfElements() << endl;
    cout << "Peek is : " << q1.peek() << endl;
    cout << q1.dequeue() << endl;
    cout << q1.dequeue() << endl;
    cout << q1.isEmpty() << endl;

    cout<< "///////////////////////////////////////////"<<endl;

    Queue<double> q2(4);
    cout << q2.dequeue() << endl;
    q2.enqueue(1.1);
    q2.enqueue(2.2);
    cout << "Peek is : " << q2.peek() << endl;
    q2.enqueue(3.3);
    cout << "Number of Elements : " << q2.getNumberOfElements() << endl;
    cout << q2.dequeue() << endl;
    q2.enqueue(4.4);
    cout << q2.isFull() << endl;
    q2.enqueue(5.5);
    cout << q2.isFull() << endl;
    q2.enqueue(6.6);
    cout << "Peek is : " << q2.peek() << endl;
    cout << q2.isEmpty() << endl;
    cout << q2.dequeue() << endl;
    cout << q2.dequeue() << endl;
    cout << "Number of Elements : " << q2.getNumberOfElements() << endl;
    cout << "Peek is : " << q2.peek() << endl;
    cout << q2.dequeue() << endl;
    cout << q2.dequeue() << endl;
    cout << q2.isEmpty() << endl;
    return 0;
}
