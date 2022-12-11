#include <stdio.h>
#include <stdlib.h>
#include<windows.h>
#include<string.h>

#define NormalPen 0x0F
#define HighLightPen 0XF0

#define size 10
#define enter 13
#define esc 27



struct employee
{
    int id, age ;
    char name[100], address[200], gender ;
    double salary, overtime, deduct ;
};

struct employee e;
char arrline[10];

char* lineEditor(int x0, int y0, int sCh, int eCh);

void gotoxy(int x,int y);

void textattr(int i);


void enter_employees_new_data()
{
    system("cls");
    ///ID Name Age Gender Address Salary Overtime Deduction

    gotoxy(40,0);
    printf("Enter Employee Data");

    ///OutPuts
    gotoxy(5,5);
    printf("ID:");

    gotoxy(5,10);
    printf("Address:");

    gotoxy(5,15);
    printf("Age:");

    gotoxy(5,20);
    printf("Gender:");

    gotoxy(5,25);
    printf("Name:");

    gotoxy(60,5);
    printf("Salary:");

    gotoxy(60,10);
    printf("Overtime:");

    gotoxy(60,15);
    printf("Deduction:");


    //id
    gotoxy(15,5);
    e.id = atoi(lineEditor(15,5,48,57));

    //address
    gotoxy(15,10);
    strcpy(e.address, lineEditor(15,10,97,122));

    //age
    gotoxy(15,15);
    e.age = atoi(lineEditor(15,15,48,57));
    //gender
    gotoxy(15,20);
    e.gender = lineEditor(15,20,97,122);
    //name
    gotoxy(15,25);
    strcpy(e.name,lineEditor(15,25,97,122));
    //salary
    gotoxy(70,5);
    e.salary = atof(lineEditor(70,5,48,57));
    //overtime
    gotoxy(70,10);
    e.overtime = atof(lineEditor(70,10,48,57));
    //deduction
    gotoxy(70,15);
    e.deduct = atof(lineEditor(70,15,48,57));
    system("cls");

    system("cls");

    gotoxy(0,3);
    printf("Press Any Key to return to Home Screen!");
    _getch();

}

void display_employees_data()
{
    system("cls");
    int i;
    gotoxy(50,0);
    printf("Employees Data!");
    gotoxy(0,5);
    printf("ID: %d\nName: %s\nNet-Salary: %lf\nAddress: %s\nAge: %d\n",e.id,e.name, e.salary + e.overtime - e.deduct,e.address,e.age);
    gotoxy(0,3);
    printf("Press Any Key to return to Home Screen!");
    _getch();
}



int main()
{
    char menu[3][8] = {"New ","Display","Exit"};
    int i, current = 0, ExitFlag = 0;
    char ch;


    do
    {
        textattr(NormalPen);
        system("cls");

        for(i = 0 ; i<3; i++)
        {
            if(current == i)
                textattr(HighLightPen);
            else textattr(NormalPen);

            gotoxy(20,10+(3*i));
            printf("%s",menu[i]);
        }

        ch = _getch();

        switch (ch)
        {
        case enter:
            switch (current)
            {
            case 0:///new
                enter_employees_new_data();
                break;
            case 1:///display
                display_employees_data();
                break;
            case 2:///exit
                ExitFlag = 1;
                break;
            }
            break;
        case esc:
            ExitFlag = 1;
            break;
        case -32:
            ch = _getch();
            switch (ch)
            {
            case 72:///up
                current--;
                if(current<0) current = 2;
                break;
            case 80:///down
                current++;
                if(current>2) current =0;
                break;
            case 71:///home
                current = 0;
                break;
            case 79:
                current = 2;
                break;
            }
        }
    }
    while(!ExitFlag==1);
    return 0;
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

char* lineEditor(int x0, int y0, int sCh, int eCh)
{
    int editorexitflag = 0;
    int x=x0, y=y0;
    int endpos=x0;

    char ch;


    char *crntptr,*startptr,*endptr;
/// start and current and end pointer all pointing on 0 index of arrline[10]
    startptr=crntptr=endptr=arrline;
/// if the editor exit flag not true continue
    while (!editorexitflag)
    {
        ch = getch();
/// check the characters range given
/// if true check if current pointer < end pointer = start pointer + (size-1)
/// if true put character given as content in current (*current pointer)
/// also increase x by 1 and print the character also increase current pointer by 1
/// check end pointer < start pointer +(size-1) , if true increase end pointer by 1 and end position on screen by 1


        switch(ch)
        {

        case enter:
/// if user enters exit and put null in the end (*end pointer)
            editorexitflag=1;
            *endptr='\0';
            break;
/// if extended keys used
        case -32:
            ch = getch();

            switch(ch)
            {
/// right arrow
/// check that current pointer < end pointer
/// if true increase current pointer by 1 also current position on screen by 1
            case 77: //right
                if (crntptr < endptr)
                {
                    crntptr++;
                    gotoxy(++x,y);
                }
                break;
/// left arrow
/// check that current pointer > start pointer
/// if true decrease current pointer by 1 also current position on screen by 1
            case 75:  //left
                if (crntptr>startptr)
                {
                    crntptr--;
                    gotoxy(--x,y);
                }
                break;
/// home
/// make current pointer = to arrline which is the address of the array (start)
/// go to start position
            case 71: //home
                crntptr=arrline;
                gotoxy(x0,y);
                break;
/// end
/// make current pointer = to end pointer
/// go to end position
            case 79: //end
                crntptr=endptr;
                gotoxy(endpos,y);
                break;
            }
        default:
            if(ch>=sCh && ch<=eCh)
            {
                if(crntptr < startptr+9)
                {
                    *crntptr=ch;
                    //arrline = ch
                    gotoxy(x++,y);
                    printf("%c",ch);
                    crntptr++;
                    if(endptr<startptr+9&& crntptr==endptr+1)
                    {
                        endptr++;
                        endpos++;
                    }
                }
            }
        }
    }
    return arrline;
}







