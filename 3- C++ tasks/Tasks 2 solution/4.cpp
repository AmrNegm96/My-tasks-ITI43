#include <iostream>

using namespace std;

class Queue
{
    int tos, *stk, Size;

public:
    Queue(int x)
    {
        Size=x;
        stk = new int[Size];
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

    void enqueue(int num)
    {
        if (tos < Size)
        {
            stk[tos++] = num;
            cout << "Enqueued Number " << num << endl;
        }
        else cout << "Queue is Full" << num << endl;
    }

    int dequeue()
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

    int peek()
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
    Queue q(4);
    cout << q.dequeue() << endl;
    q.enqueue(1);
    q.enqueue(2);
    cout << "Peek is : " << q.peek() << endl;
    q.enqueue(3);
    cout << "Number of Elements : " << q.getNumberOfElements() << endl;
    cout << q.dequeue() << endl;
    q.enqueue(4);
    cout << q.isFull() << endl;
    q.enqueue(5);
    cout << q.isFull() << endl;
    q.enqueue(6);
    cout << "Peek is : " << q.peek() << endl;
    cout << q.isEmpty() << endl;
    cout << q.dequeue() << endl;
    cout << q.dequeue() << endl;
    cout << "Number of Elements : " << q.getNumberOfElements() << endl;
    cout << "Peek is : " << q.peek() << endl;
    cout << q.dequeue() << endl;
    cout << q.dequeue() << endl;
    cout << q.isEmpty() << endl;
    return 0;
}
