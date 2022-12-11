#include <stdio.h>
#include <stdlib.h>
#include<windows.h>
#include<string.h>

#define size 10
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




void gotoxy(int x,int y);

void textattr(int i);


int main()
{


    //int size=10;

    struct employee eArr[size]= {0};

    //char username[100];

    int exitflag=0;
    int flag_userfound;

    int current=0, i, index,id;

    char ch;

    char menu[6][20] = {"new ","display all","display by id","delete by id","delete by name", "exit"};

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

                system("cls");
                index=0;
                printf("please enter the index: \n");
                scanf("%i",&index);
                system("cls");


///form appear to user

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

///user inputs data

                _flushall();
                gotoxy(20,10);
                scanf("%i",&eArr[index].id);

                _flushall();
                gotoxy(20,13);
                gets(eArr[index].name);

                _flushall();
                gotoxy(20,16);
                scanf("%lf",&eArr[index].salary);

                _flushall();
                gotoxy(20,19);
                scanf("%lf",&eArr[index].deduct);

                _flushall();
                gotoxy(20,22);
                scanf("%c",&eArr[index].address);

                _flushall();
                gotoxy(55,10);
                scanf("%i",&eArr[index].age);

                _flushall();
                gotoxy(55,13);
                scanf("%c",&eArr[index].gender);

                _flushall();
                gotoxy(55,16);
                scanf("%lf",&eArr[index].overtime);

                gotoxy(5,25);

                system("cls");

                break;

///display all button

            case 1:
                system("cls");
                for (i=0 ; i<size ; i++)
                {
                    if (eArr[i].id != 0)
                    {
                        printf("Name:%s , id: %i , salary:%lf \n\n",eArr[i].name,eArr[i].id,(eArr[i].salary+eArr[i].overtime-eArr[i].deduct));
                    }
                }
                getche();
                break;

///display by id button

            case 2:
                system("cls");
                flag_userfound=0;
                printf("please enter the id: ");
                scanf("%i",&id);

                system("cls");

                for (i=0 ; i<size ; i++)
                {
                    if(id == eArr[i].id)
                    {
                        flag_userfound=1;
                        printf("Name:%s , id: %i , salary:%lf \n\n",eArr[i].name,eArr[i].id,(eArr[i].salary+eArr[i].overtime-eArr[i].deduct));
                    }

                }

                if(flag_userfound==0)
                {
                    printf("no record saved for this id \n");
                }

                getche();
                break;

///delete by id

            case 3:
                system("cls");
                index=0;
                printf("please enter the id: ");
                scanf("%i",&id);

                for (i=0 ; i<size ; i++)
                {
                    if(id == eArr[i].id)
                    {
                        eArr[i].id = 0;
                        eArr[i].gender = '\0';
                        eArr[i].name[0] = '\0';
                        eArr[i].age = 0;
                        eArr[i].address[0]='\0';
                        eArr[i].salary = 0;
                        eArr[i].overtime = 0;
                        eArr[i].deduct = 0;
                        break;
                    }
                }
                printf("record is deleted");
                getche();
                break;

///delete by name

            case 4:

                index=0;
                char username[100];

                system("cls");

                printf("please enter the name:");

                /*gets(username);
                _flushall();*/

                scanf("%s",&username);

                for (i=0 ; i<size ; i++)
                {
                    if( (strcmp(username,eArr[i].name)==0) )
                    {
                        eArr[i].id = 0;
                        eArr[i].gender = '\0';
                        eArr[i].name[0] = '\0';
                        eArr[i].age = 0;
                        eArr[i].address[0]='\0';
                        eArr[i].salary = 0;
                        eArr[i].overtime = 0;
                        eArr[i].deduct = 0;
                        break;
                    }
                }
                printf("record is deleted");
                /*index=0;
                i=0;
                char username[100];
                printf("please enter the name: ");
                gets(username);
                system("cls");
                while ( (strcmp(username,eArr[i].name)!=0) && i<size)
                {
                    i++;
                }

                if (i >= size-1)
                    printf("the name is not in our company");
                else
                {
                        eArr[i].id = 0;
                        eArr[i].gender = '\0';
                        eArr[i].name[0] = '\0';
                        eArr[i].age = 0;
                        eArr[i].address[0]='\0';
                        eArr[i].salary = 0;
                        eArr[i].overtime = 0;
                        eArr[i].deduct = 0;
                }*/

                getche();
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









