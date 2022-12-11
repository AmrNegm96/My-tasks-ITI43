#include <stdio.h>
#include <stdlib.h>
#include <windows.h>
#include <string.h>

#define size 10
#define enter 13
#define esc 27



void gotoxy(int x,int y)
{
    COORD coord= {0,0};
    coord.X=x;
    coord.Y=y;
    SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE),coord);
}


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
int main()
{
    lineEditor(10, 0, 97, 122);
}
