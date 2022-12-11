#include <iostream>

#include <stdio.h>
#include <stdlib.h>
#include<windows.h>
#include<string.h>
#include<conio.h>

#define size 10
#define enter 13
#define esc 27

#define normpen 0x07
#define highpen 0x70

using namespace std;

struct employee
{
    int id, age ;
    char name[100];
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

    /*if (Pnew==NULL)
    {
        exit(0);
    }
    else
    {

    }*/
    Pnew->data=e;
    Pnew->Pnext=NULL;
    Pnew->Pprev=NULL;

    return Pnew;
}

node* Pstart;
node* Plast;


void gotoxy(int x,int y);
void textattr(int i);

void addEmp();
void display_all();
node* searchList(int id);
void display();
void deleteall();
void deleteID();
void insertFront(employee e);
void insertAfter(node* thePrevEmployee, employee e);
void insertEnd(employee e);
int main()
{

    int exitflag = 0;
    int flag_userfound;
    int current=0, i,id;
    char ch;
    char menu[6][20] = {"Add node","display all","display","delete all","delete node", "exit"};

    do
    {

        textattr(normpen);
        system("cls");

        for (i=0 ; i<6 ; i++)
        {
            if(current==i)
                textattr(highpen);
            else
                textattr(normpen);

            gotoxy(15,10+(i*3));

            printf("%s", menu[i]);
        }


        ch = getch();

        switch(ch)
        {
        case enter:
            switch(current)
            {

///new button

            case 0:
                addEmp();
                break;

///display all button

            case 1:
                display_all();
                break;

///display

            case 2:
                display();
                break;

///delete all

            case 3:
                deleteall();
                break;

///delete id

            case 4:
                deleteID();
                break;

            case 5:
                exitflag=1;
                break;
            }
            break;

        case esc:
            exitflag=1;
            break;

        case -32:
            ch = getch();
            switch(ch)
            {
            case 72: //up
                current--;
                if(current<0)
                    current = 5;
                break;

            case 80:  //down
                current++;
                if(current>5)
                    current = 0;
                break;

            case 71: //home
                current=0;
                break;

            case 79: //end
                current=5;
                break;

            }
            break;
        }
    }
    while(!exitflag);


}

void gotoxy(int x,int y)
{
    COORD coord= {0,0};
    coord.X=x;
    coord.Y=y;
    SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE),coord);
}

void textattr(int i)
{
    SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), i);

}

void addEmp()
{
    struct employee e;

    system("cls");

    //int index=0;
    //printf("please enter the index: \n");
    //scanf("%i",&index);

    system("cls");


///form appear to user

    gotoxy(50,0);
    printf("Employee details");

    gotoxy(5,10);
    printf("enter id      : ");

    gotoxy(5,13);
    printf("enter name    : ");

    gotoxy(40,10);
    printf("enter age     : ");

///user inputs data

    _flushall();
    gotoxy(20,10);
    scanf("%i",&e.id);

    _flushall();
    gotoxy(20,13);
    gets(e.name);

    _flushall();
    gotoxy(55,10);
    scanf("%i",&e.age);

    gotoxy(5,25);

    system("cls");




    node* Pnew = new_node(e);

    if (Pstart==NULL)
    {
        Plast=Pstart=Pnew;
        cout<<"1"<<endl;
        getch();
    }
    else if(Pnew->data.id < Pstart->data.id)
    {
        insertFront(e);
        cout<<"2"<<endl;
        getch();
    }
    else if (Pnew->data.id > Plast->data.id)
    {
        insertEnd(e);
        cout<<"3"<<endl;
        getch();
    }
    else if ( (searchList(Pnew->data.id))!= NULL && Pnew->data.id == (searchList(Pnew->data.id))->data.id )
    {
        cout<<"4"<<endl;
        cout<<"this id is already in the company"<<endl;
        getch();
    }
    else
    {
        cout<<"5"<<endl;
        getch();
        node* theprevemployee;
        //int id = (Pnew->data.id)-1 ;
        node* temp = Plast;
        while(temp->data.id > Pnew->data.id)
        {
            //theprevemployee = searchList(Pnew->data.id);
            temp = temp->Pprev;
        }
        theprevemployee = temp;
        insertAfter(theprevemployee, e);
    }
}

void display_all()
{
    system("cls");
    node* Pdisplay = Pstart;
    while(Pdisplay!=NULL)
    {
        cout<<" ID: "<<Pdisplay->data.id<<" Name: "<<Pdisplay->data.name<<" Age: "<<Pdisplay->data.age<<endl;
        Pdisplay=Pdisplay->Pnext;
    }
    getche();
}

node* searchList(int id)
{
    system("cls");

    node* Psearch = Pstart;
    while(Psearch!=NULL)
    {
        if(Psearch->data.id == id)
            break;
        else
            Psearch = Psearch->Pnext;
    }
    return Psearch;

}
void display()
{
    system("cls");
    int id=0;
    printf("please enter the id: ");
    scanf("%i",&id);
    system("cls");
    node* Pdisplay = searchList(id);
    if (Pdisplay==NULL)
    {
        cout<<"not found"<<endl;
        getch();
    }

    else
    {
        cout<<" ID : "<<Pdisplay->data.id <<" Name : "<<Pdisplay->data.name<<" Age : "<<Pdisplay->data.age<<endl;
        getch();
    }

}

void deleteall()
{
    node* Ptemp;
    while(Pstart!=NULL)
    {
        Ptemp = Pstart;
        Pstart = Pstart->Pnext;
        delete Ptemp;
    }
    Plast=NULL;
}

void deleteID()
{
    system("cls");
    int id=0;
    printf("please enter the id: ");
    scanf("%i",&id);
    system("cls");

    node* Pdelete = searchList(id);

    if(Pdelete==NULL)
    {
        cout<<"not Found"<<endl;
    }
    else
    {
        if(Pstart==Plast)
        {
            Plast=Pstart=NULL;
        }
        else if (Pdelete == Pstart)
        {
            Pstart=Pstart->Pnext;
            Pstart->Pprev=NULL;
        }
        else if (Plast==Pdelete)
        {
            Plast=Plast->Pprev;
            Plast->Pnext=NULL;
        }
        else
        {
            Pdelete->Pprev->Pnext = Pdelete->Pnext;
            Pdelete->Pnext->Pprev = Pdelete->Pprev;
        }
        delete Pdelete;
    }
}


/// insert node at the front
void insertFront( employee e)
{

    node* Pnew = new_node(e);

    /// point next of newNode to the first node of the doubly linked list
    Pnew->Pnext = Pstart;

    /// point prev to NULL
    Pnew->Pprev = NULL;

    /// point previous of the first node (now first node is the second node) to newNode
    if ( Pstart->Pprev != NULL)
        Pstart->Pprev = Pnew;

    /// head points to newNode
    Pstart = Pnew;
}

/// insert a node after a specific node
void insertAfter(node* thePrevEmployee, employee e)
{

    ///check if previous node is NULL
    if (thePrevEmployee == NULL)
        {
            cout << "previous node cannot be NULL";
            return;
        }

    /// allocate memory for newNode
    node* Pnew = new_node(e);

    /// set next of newNode to next of prev node
    Pnew->Pnext = thePrevEmployee->Pnext;

    /// set next of prev node to newNode
    thePrevEmployee->Pnext = Pnew;

    /// set prev of newNode to the previous node
    Pnew->Pprev = thePrevEmployee;

    /// set prev of newNode's next to newNode
    ////////if (Pnew->next != NULL)
    Pnew->Pnext->Pprev=Pnew;

    /// theNextEmployee->Pprev=Pnew (if I send the next node to the function)
}

/// insert a newNode at the end of the list
void insertEnd(employee e)
{
    /// allocate memory for newNode
    node* Pnew = new_node(e);
    Plast->Pnext=Pnew;
    Pnew->Pprev=Plast;
    Plast=Pnew;
}



