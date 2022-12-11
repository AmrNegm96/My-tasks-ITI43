#include <iostream>

using namespace std;
class geoshape
{
protected:
    int dim1,dim2;
public:
    /*geoshape()
    {

    }*/
    geoshape(int x=0 , int y=0)
    {
        dim1=x;
        dim2=y;
    }
    ~geoshape()
    {
        //cout<<"geo shape dtor"<<endl;
    }
    virtual double cArea()
    {
        return 0;
    }
};
class rectangle : public geoshape
{

public:
    rectangle()
    {

    }
    rectangle (int w , int h) : geoshape(w,h)
    {
        //cout<< "rectangle ctor" <<endl;
    }
    ~rectangle()
    {
        //cout<<"rectangle dtor"<<endl;
    }
    double cArea() //override
    {
        return dim1*dim2;
    }

};
class square : public rectangle
{

public:
    square(){}
    square (int l) : rectangle(l,l)
    {
        //cout<< "square ctor" <<endl;
    }
    ~square()
    {
        //cout<<"squar dtor"<<endl;
    }
    double cArea() //override
    {
        return dim1*dim2;
    }
};
class circle : public geoshape
{

public:
    circle(){}
    circle (int r) : geoshape(r,r)
    {
        //cout<< "circle ctor" <<endl;
    }
    ~circle()
    {
        //cout<<"circle dtor"<<endl;
    }
    double cArea() //override
    {
        return 3.14*dim1*dim2;
    }
};
class triangle : public geoshape
{

public:
    triangle(){}
    triangle (int b , int h) : geoshape(b,h)
    {
        //cout<< "triangle ctor" <<endl;
    }
    ~triangle()
    {
        //cout<<"triangle dtor"<<endl;
    }
    double cArea() //override
    {
        return 0.5*dim1*dim2;
    }
};

/*double sumAreas(square* sq,int s1,rectangle* rect,int s2,circle* cir,int s3,triangle* tri,int s4)
{
    int sumOfareas=0;
    for (int i=0 ; i<s1 ; i++)
    {
        sumOfareas+=sq[i].cArea();
    }
    for (int i=0 ; i<s2 ; i++)
    {
        sumOfareas+=rect[i].cArea();
    }
    for (int i=0 ; i<s3 ; i++)
    {
        sumOfareas+=cir[i].cArea();
    }
    for (int i=0 ; i<s4 ; i++)
    {
        sumOfareas+=tri[i].cArea();
    }
    return sumOfareas;
}*/


double sumAllAreas (geoshape** GeoArr, int counter )
{
    double sum = 0;
    for(int i=0 ; i< counter ; i++)
    {
        sum += GeoArr[i]->cArea();
    }
    return sum;
}

int main()
{


    rectangle arr1[3] = {rectangle(10,15),rectangle(15,20),rectangle(20,25)};
    square arr2[2] = {square(5),square(10)};
    triangle arr3[2] = {triangle(5,10),triangle(10,20)};
    circle arr4[2] = {circle(10),circle(20)};

    geoshape* Gptr[9] = {arr1, &arr1[1] , &arr1[2] , arr2 , &arr2[1] , arr3 , &arr3[1] , arr4 , &arr4[1] };
    cout<<"the sum of shapes ";
    cout<<sumAllAreas(Gptr,9)<<endl;

    rectangle rect[3];
    square sq[2];
    circle cir[2];
    triangle tri[3];

    rectangle r1(10, 15);
    cout << "Rectangle 1 Area: " << r1.cArea() << endl;
    cout <<"//////////////////////////////////"<< endl;
    rectangle r2(5, 10);
    cout << "Rectangle 2 Area: " << r2.cArea() << endl;
    cout <<"//////////////////////////////////"<< endl;
    rectangle r3(20, 25);
    cout << "Rectangle 3 Area: " << r3.cArea() << endl;
    cout <<"//////////////////////////////////"<< endl;
    rect[0] = r1;
    rect[1] = r2;
    rect[2] = r3;

    square s1(5);
    cout << "Square 1 Area: " << s1.cArea() << endl;
    cout <<"//////////////////////////////////"<< endl;
    square s2(10);
    cout << "Square 2 Area: " << s2.cArea() << endl;
    cout <<"//////////////////////////////////"<< endl;
    sq[0] = s1;
    sq[1] = s2;


    /// 3 Triangles
    triangle t1(2.5, 5);
    cout << "Triangle 1 Area: " << t1.cArea() << endl;
    cout <<"//////////////////////////////////"<< endl;
    triangle t2(5, 10);
    cout << "Triangle 2 Area: " << t2.cArea() << endl;
    cout <<"//////////////////////////////////"<< endl;
    triangle t3(10, 15);
    cout << "Triangle 3 Area: " << t3.cArea() << endl;
    cout <<"//////////////////////////////////"<< endl;
    tri[0] = t1;
    tri[1] = t2;
    tri[2] = t3;


    circle c1(10);
    cout << "Circle 1 Area: " << c1.cArea() << endl;
    cout <<"//////////////////////////////////"<< endl;
    circle c2(20);
    cout << "Circle 2 Area: " << c2.cArea() << endl;
    cout <<"//////////////////////////////////"<< endl;
    cir[0] = c1;
    cir[0] = c2;


    cout << "Total Area of Shapes is : " << sumAreas(sq, 2, rect, 3, cir, 2, tri, 3) << endl;
    cout <<"//////////////////////////////////"<< endl;

    /*rectangle r (5,3);
    cout<< r.cArea() <<endl;

    circle c (5);
    cout<< c.cArea() <<endl;

    triangle t (3,4);
    cout<< t.cArea() <<endl;

    square s (5);
    cout<< s.cArea() <<endl;*/


}
