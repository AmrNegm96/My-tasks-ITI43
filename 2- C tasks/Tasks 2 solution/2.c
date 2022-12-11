#include <stdio.h>
#include <stdlib.h>
#include <windows.h>


void gotoxy( int column, int line );
void magicbox();

void main()
{
    magicbox();

}



void magicbox()
{
    int i, r, c, x;

    r = 1;

    c = 3/2+1;

    for (i = 1; i <= 9 ; i++)
    {
        gotoxy( c, r );

        printf("%i", i);

        if ( i % 3 == 0)
        {
            r++;
            if (r==4)
                r=1;
        }
        else
        {
            r--;
            c--;
            if (r == 0)
                r=3;

            if (c == 0)
                c=3;
        }
    }
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

