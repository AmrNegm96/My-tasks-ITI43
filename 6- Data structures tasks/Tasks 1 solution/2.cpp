#include <iostream>

using namespace std;

struct employee
{
    int id, age ;
    string name;
};

struct node
{
    employee data;
    node* Pnext;
    node* Pprev;
};

node* new_node(employee e)
{
    node* Pnew = new node();
    if (Pnew==NULL)
    {
        exit(0);
    }
    else
    {
        Pnew->data=e;
        Pnew->Pnext=NULL;
        Pnew->Pprev=NULL;
    }
    return Pnew;
}

node* Pstart;
node* Plast;

class mystack
{
private:
    int size;
public:
/// constructor
    mystack()
    {
        //cout << " constructor 1" <<endl;
        size=0;
    }
/// destructor
    ~mystack()
    {
        //cout << " destructor 1"<<endl;

    }
    /*bool isfull()
    {
        if (Pstart==Size)
            return true;
        else
            return false;
    }*/
    bool isempty()
    {
        if (Pstart==NULL)
            return true;
        else
            return false;
    }
    void push(employee e)
    {
        node* Pnew = new_node(e);
        if (Pstart==NULL)
        {
            Plast=Pstart=Pnew;
        }
        else
        {
            Plast->Pnext=Pnew;
            Pnew->Pprev=Plast;
            Plast=Pnew;
        }
        size++;
    }
    employee pop()
    {
        employee r;
        if(!isempty())
        {

            node* Pdelete = Plast;
            r = Pdelete->data;
            if(Pstart==Plast)
            {
                Pstart=Plast=NULL;
            }
            else if(Pdelete==Plast)
            {
                Plast=Plast->Pprev;
                Plast->Pnext=NULL;
            }
            delete Pdelete;
            size--;
        }
        else
        {
    cout <<"Stack is Empty \n";

        }
        return r;
    }
    employee peek()
    {
        if(!isempty())
        {
            return Plast->data;
        }
    }
    int getcount()
    {
        return size;
    }

};
int main()
{
    struct employee e1,e2,e3;

    e1.id=1;
    e1.name="amr";
    e1.age=26;
    e2.id=2;
    e2.name="joe";
    e2.age=24;
    e3.id=3;
    e3.name="mosaad";
    e3.age=26;

    mystack s1;
    s1.push(e1);
    s1.push(e2);
    s1.push(e3);
    cout<<s1.pop().name<<endl;
    cout<<s1.peek().name<<endl;
    cout<<s1.peek().name<<endl;
    cout<<s1.pop().name<<endl;
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
