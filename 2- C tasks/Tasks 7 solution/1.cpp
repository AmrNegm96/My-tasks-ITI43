#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#include<windows.h>

#define NormPen 0x0F
#define HighPen 0XF0
#define Enter 0x0D
#define ESC 27
#define Size 3


typedef struct Emp
{
    int iD;
    int age;
    char gender;
    char name[10];
    char address[15];
    int salary;
    int overtime;
    int deduction;
} Emp;


void gotoxy( int column, int line );

void textattr(int i);

Emp* enter_emp_new_data();

void display_emp_data(Emp *e);


char** multi_line_editor(int numberOfLines, int *maxLineLength, int *xPos, int *yPos, int *Schar, int *Echar);

int main()
{
    char menu[3][8] = {" New ","Display","Exit"};
    int i, current = 0, ExitFlag = 0;
    char ch;
    Emp *e;

    do
    {
        textattr(NormPen);
        system("cls");

        for(i = 0 ; i<3; i++)
        {
            if(current == i)
                textattr(HighPen);
            else textattr(NormPen);

            gotoxy(50,10+(3*i));
            printf("%s",menu[i]);
        }

        ch = _getch();

        switch (ch)
        {
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        case Enter:
            switch (current)
            {
            case 0:///new
                e = enter_emp_new_data();
                break;
            case 1:///display
                display_emp_data(e);
                break;
            case 2:///exit
                ExitFlag = 1;
                break;
            }
            break;
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        case ESC:
            ExitFlag = 1;
            break;
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

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

    free(e);
    return 0;
}

void gotoxy( int column, int line )
{
    COORD coord;
    coord.X = column;
    coord.Y = line;
    SetConsoleCursorPosition(
        GetStdHandle( STD_OUTPUT_HANDLE ),
        coord
    );
}

void textattr(int i)
{
    SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), i);
}


Emp* enter_emp_new_data()
{
    system("cls");
    ///ID Address Age Gender Name Salary Overtime Deduction
    /// 48, 57 numbers 97, 122 letters
    Emp *e = (Emp*) malloc(sizeof(Emp));
    int numberOfLines = 8;
    int xPos[8] = {15,15,15,15,15,70,70,70};
    int yPos[8] = {5,10,15,20,25,5,10,15};
    int Schar[8] = {48,97,48,97,97,48,48,48};
    int Echar[8] = {57,122,57,122,122,57,57,57};
    int maxLineLength[8] = {5,10,2,1,10,5,5,5};

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
    ///Inputs
    ///id
    gotoxy(15,5);

    char **data = multi_line_editor(numberOfLines,maxLineLength,xPos,yPos,Schar,Echar);

    system("cls");
    gotoxy(0,3);
    printf("Press Any Key to return to Home Screen!");
    _getch();

    e->iD = atoi(data[0]);
    strcpy(e->address,data[1]);
    e->age = atoi(data[2]);
    e->gender = data[3][0];
    strcpy(e->name,data[4]);
    e->salary = atoi(data[5]);
    e->overtime = atoi(data[6]);
    e->deduction = atoi(data[7]);
    return e;
}

void display_emp_data(Emp *e)
{
    system("cls");
    //int i;
    gotoxy(50,0);
    printf("Employees Data!");
    gotoxy(0,5);
    printf("ID: %d \n Name: %s \n Gender: %c \n Net-Salary: %d \n Address: %s \n Age: %d \n ",e->iD,e->name,e->gender, e->salary + e->overtime - e->deduction,e->address,e->age);
    gotoxy(0,3);
    printf("Press Any Key to return to Home Screen!");
    _getch();
}

char** multi_line_editor(int numberOfLines, int* maxLineLength, int* xPos, int* yPos, int* Schar, int* Echar)
{
    char** line = (char**) malloc(numberOfLines*sizeof(char*));

    char current[numberOfLines], end[numberOfLines];

    char ch;
    int exit = -1;
    int i,j;
    int currentLine = 0;

    for(i = 0; i < numberOfLines; i++)
    {
        line[i] = (char*) malloc(sizeof(char)*maxLineLength[i]);
    }

    for(i = 0; i < numberOfLines; i++)
    {
        current[i] = end[i] = 0;
    }

    ///Drawing the box for the inputs
    for (i = 0; i < numberOfLines; i++)
    {
        textattr(HighPen);
        for (j = 0; j < maxLineLength[i]; j++)
        {
            gotoxy(xPos[i] + j, yPos[i]);
            printf(" ");
        }

    }

    while(exit == -1)
    {
        gotoxy(xPos[currentLine]+current[currentLine], yPos[currentLine]);
        ch = getch();
        switch (ch)
        {
        case Enter:///enter
            exit = 1;

            for(i = 0; i < numberOfLines ; i++)
                line[i][end[i]]='\0';
            break;
        case 9:///tab
            if(currentLine < numberOfLines)
            {
                currentLine++;
            }
            else currentLine = 0;
            break;
        case -32:
            ch = _getch();
            switch (ch)
            {
            case 72:///up
                if(currentLine > 0)
                {
                    currentLine--;
                }
                else currentLine = 7;
                break;
            case 80:///down
                if(currentLine < numberOfLines)
                {
                    currentLine++;
                }
                else currentLine = 0;
                break;
            case 75:///left
                if(current[currentLine] > 0)
                {
                    current[currentLine]--;
                }
                break;
            case 77:///right
                if(current[currentLine] < end[currentLine])
                {
                    current[currentLine]++;
                }
                break;
            case 71:///home
                current[currentLine] = 0;
                break;
            case 79:///end
                current[currentLine] = end[currentLine];
                break;
            }
            break;
        default:
            ///make sure to print only values between the range sent to the function( nums or letters)
            if(ch >= Schar[currentLine] && ch <= Echar[currentLine] && current[currentLine] <= end[currentLine])
            {

                line[currentLine][current[currentLine]] = ch;
                printf("%c",ch);
                current[currentLine]++;
                if(end[currentLine] < maxLineLength[currentLine]-1 && current[currentLine] == end[currentLine]+1)
                {
                    end[currentLine]++;
                }
            }
        }
    }
    textattr(NormPen);
    return line;
}

