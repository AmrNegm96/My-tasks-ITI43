#include <iostream>
#include "C:\Program Files\CodeBlocks\MinGW\include\graphics.h"


using namespace std;


class Shape
{
public:
    virtual void draw() = 0;
};

class Color
{
    int color;
public:
    Color() {}

    Color(int _color)
    {
        color = _color;
        setcolor(color);
    }
};

class Point
{
    int x, y;
public:
    Point()
    {
        //cout << "parameterless Point ctor" << endl;
    }

    Point(int _x, int _y)
    {
        //cout << "Point Constructor" << endl;
        x = _x;
        y = _y;
    }

    int getX()
    {
        return x;
    }

    int getY()
    {
        return y;
    }

    ~Point()
    {
        //cout << "Point Destructor" << endl;
    }

};

class Line : public Shape
{
    Point p1, p2;
    Color c;
public:
    Line(int x1, int y1, int x2, int y2, int color)
        : p1(x1, y1), p2(x2, y2), c(color)
    {
    }

    void draw()
    {
        line(p1.getX(), p1.getY(), p2.getX(), p2.getY());
    }

    Point& getP1()
    {
        return p1;
    }

    Point& getP2()
    {
        return p2;
    }

    ~Line()
    {
        // cout << "Line Destructor" << endl;
    }
};

class Circle : public Shape
{
    int radius;
    Point origin;
    Color c;

public:
    Circle(int x, int y, int _radius, int color)
        : origin(x, y), c(color)
    {
        radius = _radius;
        draw();
    }

    int getRadius()
    {
        return radius;
    }

    Point& getOrigin()
    {
        return origin;
    }

    void draw()
    {
        circle(origin.getX(), origin.getY(), radius);

    }

    ~Circle()
    {
        //cout << "Circle Destructor" << endl;
    }
};

class rect : public Shape
{
    Point p1, p2;
    Color c;

public:
    rect(int x1, int y1, int x2, int y2, int color)
        : p1(x1, y1), p2(x2, y2), c(color)
    {
    }

    void draw()
    {
        rectangle(p1.getX(), p1.getY(), p2.getX(), p2.getY());

    }

    ~rect()
    {
        //cout << "Rectangle Destructor" << endl;
    }

    Point& getP1()
    {
        return p1;
    }

    Point& getP2()
    {
        return p2;
    }

};

class Picture : public Shape
{
    Color clr;
    Shape **Sh;
    int noShapes;

public:
    Picture(Shape **_Sh, int _noShapes,  int color): clr(color)
    {
        Sh = _Sh;
        noShapes = _noShapes;
    }

    void draw()
    {
        for (int i = 0; i < noShapes; i++)
        {
            Sh[i]->draw();
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
    Line (584,283,696,482,10)};
    rect r[1] = {rect(696,569,301,483,10)};

    Shape* s[9] = {c,l,&l[1],&l[2],&l[3],&l[4],&l[5],&l[6],r};
    Picture p(s,9,10);
    p.draw();



    getchar();
    getchar();
    getchar();

    return 0;
}
