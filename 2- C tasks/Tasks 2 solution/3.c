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
    int i, r, c, size;
    printf("please enter the size of the box \n");
    scanf("%i",&size);

    if(size%2 != 0 && size>1)
    {
        r = 1;

        c = size/2+1;

        for (i = 1; i <= (size*size) ; i++)
        {
            gotoxy( c*5 , r*5 );

            printf("%i", i);

            if ( i % size == 0)
            {
                r++;
                if (r>size)
                    r=1;
            }
            else
            {
                r--;
                c--;
                if (r == 0)
                    r=size;

                if (c == 0)
                    c=size;
            }
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

