#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include <string.h>

#define size 10
#define enter 13
#define esc 27

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






struct employee
{
    int id , age ;
    char name[100] , address[200] , gender ;
    double salary , overtime , deduct ;
};


void gotoxy(int x,int y);


int main()
{
    //int i=0;

    //char c[8][20]={"id","name","salary","tax","address","age","gender","overtime"};

    struct employee E; // allocation 333 byte in the stack

    E.id=0;

    E.salary=0;

    /*for (i=0 ; i<5 ; i++)
    {
       gotoxy(5,10+(i*3));
       printf("enter your %s: ", &c[i]);
    }
    for (i=5 ; i<8 ; i++)
    {
       gotoxy(40,10+((i-5)*3));
       printf("enter your %s: ", &c[i]);
    }*/

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




        //gotoxy(20,10);
        lineEditor(20, 10, 48, 57);

        //scanf("%i",&E.id);

       // _flushall();
        //gotoxy(20,13);
        lineEditor(20, 13, 97, 122);
       // gets(E.name);


        //gotoxy(20,16);
        lineEditor(20, 16, 48, 57);
        //scanf("%lf",&E.salary);

        //gotoxy(20,19);
        lineEditor(20, 16, 48, 57);
        //scanf("%lf",&E.deduct);

        //_flushall();
        //gotoxy(20,22);
        lineEditor(20, 13, 97, 122);
        //scanf("%c",&E.address);

        //_flushall();
        //gotoxy(55,10);
        lineEditor(20, 16, 48, 57);
        //scanf("%i",&E.age);

        //_flushall();
        //gotoxy(55,13);
        lineEditor(20, 13, 97, 122);
        //scanf("%c",&E.gender);

        //gotoxy(55,16);
        lineEditor(20, 16, 48, 57);
        //scanf("%lf",&E.overtime);

        gotoxy(5,25);

        printf("Name:%s , id: %i , salary:%lf \n\n" ,E.name ,E.id ,(E.salary+E.overtime-E.deduct));


}



void gotoxy(int x,int y)
 {
   COORD coord={0,0};
   coord.X=x;
   coord.Y=y;
   SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE),coord);
 }

 void textattr(int i)
{
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), i);
}
