#include <iostream>
#include "C:\Program Files\CodeBlocks\MinGW\include\graphics.h"

using namespace std;

class Color
{
protected:
    int color;
public:
    Color()
    {
        cout<<"color Ctor"<<endl;
    }
    Color(int c)
    {
        color=c;
        setcolor(color);
        cout<<"color Ctor"<<endl;
    }
    ~Color()
    {
        cout<<"color Dtor"<<endl;
    }
};

class Point
{
private:
    int x,y;
public:
    Point()
    {
        //cout<< "parameterless point Ctor" <<endl;
    }
    Point(int a,int b)
    {
        x=a;
        y=b;
        // cout<< "point Ctor" <<endl;
    }
    int getx()
    {
        return x;
    }
    int gety()
    {
        return y;
    }
    ~Point()
    {
        //cout<< "point dtor" <<endl;
    }


};
class Line : public Color
{
private:
    ///composition: complete dependency on creation and destruction of object.
    Point p1,p2;
public:
    Line(int x1,int y1,int x2,int y2, int c): p1(x1,y1), p2(x2,y2),Color(c)   ///constructor chaining from rectangle to point Ctor(int,int) for initializing ul & lr
    {
        draw();
    }
    void draw()
    {
        line(p1.getx(),p1.gety(),p2.getx(),p2.gety());
    }
    ~Line()
    {
        //cout<< "line Dtor" <<endl;
    }
    Point& getP1() {
        return p1;
    }

    Point& getP2() {
        return p2;
    }

};

class Circle : public Color
{
private:
    int radius;
    Point origin;
public:
    Circle(int x,int y, int r, int c): origin(x,y), Color(c)
    {
        radius = r;
        draw();
    }
    void draw()
    {
        circle(origin.getx(),origin.gety(),radius);
    }
    ~Circle()
    {
        //cout << "circle Dtor" <<endl;
    }
     int getRadius() {
        return radius;
    }

    Point& getCenter() {
        return origin;
    }

};
class Rect : public Color
{
private:
    Point P1,P2;
public:
    Rect()
    {

    }
    Rect(int x1, int y1, int x2, int y2, int c): P1(x1,y1), P2(x2,y2), Color(c)
    {
        draw();
    }
    void draw()
    {
        rectangle( P1.getx(), P1.gety(), P2.getx(), P2.gety() );
    }
    ~Rect()
    {
        //cout<< "rectangle Dtor" <<endl;
    }
     Point& getP1() {
        return P1;
    }

    Point& getP2() {
        return P2;
    }

};

class Picture : public Color
{
    Rect *r;
    Circle *c;
    Line *l;
    int Sr;
    int Sc;
    int Sl;
    int color;
public:

    Picture(Rect *Rarr, int S1, Circle *Carr, int S2, Line *Larr, int S3, int color ): Color(color)
    {
        r=Rarr;
        Sr=S1;
        c=Carr;
        Sc=S2;
        l=Larr;
        Sl=S3;
        draw();
    }
    ~Picture()
    {

    }

    void draw()
    {
        Color(color);

        for (int i = 0; i < Sr ; i++)
        {
            r[i].draw();
        }
        for (int i = 0; i < Sc ; i++)
        {
             c[i].draw();
        }
        for (int i = 0; i < Sl ; i++)
        {
            l[i].draw();
        }
    }
};




int main()
{

    initgraph();

    Circle c[1] = {Circle(500, 286, 100,10)};

    Line l[7] = {Line (411,286,584,283,10),
                 Line (411,286,500,480,10),
                 Line (584,283,500,480,10),
                 Line (500,480,350,393,10),
                 Line (500,480,642,393,10),
                 Line (411,286,301,483,10),
                 Line (584,283,696,482,10)
                };

    Rect r[1] = {Rect(696,569,301,483,10)};

    Picture p(r, 1, c, 1, l, 7, 10 );

    p.draw();

    getchar();
    getchar();
    getchar();
    return 0;
}


