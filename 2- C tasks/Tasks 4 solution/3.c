#include <stdio.h>
#include <stdlib.h>
#include<windows.h>
#include<string.h>

#define enter 13
#define esc 27

#define normpen 0x07
#define highpen 0x70

void gotoxy(int x,int y);

void textattr(int i);


int main()
{
int exitflag=0;

int current=0 , i;

char ch;

char menu[3][5] = {"new " ,"save" , "exit"};

do{

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
            printf("enter new data");
            getch();
        break;

        case 1:
            system("cls");
            printf("data saved");
            getch();
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
}while(!exitflag);


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
