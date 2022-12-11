#include <stdio.h>
#include <stdlib.h>
#include<windows.h>
#include<string.h>

#define enter 13
#define esc 27

#define normpen 0x07
#define highpen 0x70



struct employee
{
    int id, age ;
    char name[100], address[200], gender ;
    double salary, overtime, deduct ;
};

struct employee e;

char* lineEditor(int x0, int y0, int sCh, int eCh)
{
    int editorexitflag = 0;
    int x=x0, y=y0;
    int endpos=x0;




    char ch;
    char arrline[10];

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
        if(ch>=sCh && ch<=eCh)
        {
            if(crntptr < startptr+9)
            {
                *crntptr=ch;
                gotoxy(x++,y);
                printf("%c",ch);
                crntptr++;
                if(endptr<startptr+9)
                {
                    endptr++;
                    endpos++;
                }
            }
        }

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
        }
    }
    return arrline;
}






void gotoxy(int x,int y);

void textattr(int i);


int main()
{
    int exitflag=0;

    int current=0, i;

    char ch;

    char menu[3][8] = {"new ","display", "exit"};

    do
    {

        textattr(normpen);
        system("cls");

        for (i=0 ; i<3 ; i++)
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
            case 0:
                system("cls");

                    gotoxy(50,0);
                    printf("Employee details");

                    gotoxy(5,10);
                    printf("enter id      : ");

                    gotoxy(5,13);
                    printf("enter name    : ");

                    gotoxy(5,16);
                    printf("enter salary  : ");

                    gotoxy(5,19);
                    printf("enter tax     : ");

                    gotoxy(5,22);
                    printf("enter address : ");

                    gotoxy(40,10);
                    printf("enter age     : ");

                    gotoxy(40,13);
                    printf("enter gender  : ");

                    gotoxy(40,16);
                    printf("enter overtime: ");

//id
                    e.id = atoi(lineEditor(20, 10, 48, 57));
//name
                    strcpy(e.name,lineEditor(20, 13, 97, 122));
//salary
                    e.salary = atoi(lineEditor(20, 16, 48, 57));
//deduct
                    e.deduct = atoi(lineEditor(20, 19, 48, 57));
//address
                    strcpy(e.address,lineEditor(20, 22, 97, 122));
//age
                    e.age = atoi(lineEditor(55, 13, 48, 57));
//gender
                    e.gender = lineEditor(55, 16, 97, 122);
//overtime
                    e.overtime = atoi(lineEditor(15, 19, 97, 122));

                   /* gotoxy(20,10);
                    scanf("%i",&eArr[i].id);

                    _flushall();
                    gotoxy(20,13);
                    gets(eArr[i].name);

                    _flushall();
                    gotoxy(20,16);
                    scanf("%lf",&eArr[i].salary);

                    _flushall();
                    gotoxy(20,19);
                    scanf("%lf",&eArr[i].deduct);

                    _flushall();
                    gotoxy(20,22);
                    scanf("%c",&eArr[i].address);

                    _flushall();
                    gotoxy(55,10);
                    scanf("%i",&eArr[i].age);

                    _flushall();
                    gotoxy(55,13);
                    scanf("%c",&eArr[i].gender);

                    _flushall();
                    gotoxy(55,16);
                    scanf("%lf",&eArr[i].overtime);*/

                    gotoxy(5,25);

                    system("cls");

                break;

            case 1:
                system("cls");

                    printf("Name:%s , id: %i , salary:%lf \n\n",e.name,e.id,(e.salary+e.overtime-e.deduct));

                getche();
                break;

            case 2:
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
                    current = 2;
                break;

            case 80:  //down
                current++;
                if(current>2)
                    current = 0;
                break;

            case 71: //home
                current=0;
                break;

            case 79: //end
                current=2;
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






//struct employee E; // allocation 333 byte in the stack








