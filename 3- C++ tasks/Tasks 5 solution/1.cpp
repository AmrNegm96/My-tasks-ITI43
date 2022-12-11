#include <iostream>

using namespace std;

class complex
{
/// since class is private by default therefore we don't have to write private before data members
    int real;
    int img;
public:

/// 4 different constructors
    complex();
    complex(int x);
    complex(int x, int y);
    complex(const complex& oldc);
/// 1 destructor
    ~complex();

/// setter and getter for real numbers
    void setreal(int r);
    int getreal();

/// setter and getter for imaginary numbers
    void setimg(int i);
    int getimg();

/// print function
    void print();

/// sum function
    complex sum (complex& c);
/// operator overloads
complex  operator+ (const complex& c);
complex  operator- (const complex& c);
complex& operator-= (const complex& c);
complex& operator-- ();  ///prefix --c
complex  operator-- (int);  ///postfix c--
bool     operator== (const complex &c);
bool     operator!= (const complex &c);
bool     operator> (const complex &c);
bool     operator>= (const complex &c);
bool     operator< (const complex &c);
bool     operator<= (const complex &c);
operator int ();
operator char* ();
complex& operator-= (int L);
};

complex sub (complex c1, complex c2);
complex operator- (int L , complex& c);
complex operator-= (int L , complex& c);


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
int main()
{
    complex c1(1,2),c2(5),c3,c4,c5,c6(100,100),c7(1,1);
    char ch;
    cout<<"/////////////////////////////////////////////////////////////////"<<endl;

    cout<< "1-Sum of c1 & c2"<<endl;
    c3=c1.sum(c2);
    c3.print();

    cout<<"/////////////////////////////////////////////////////////////////"<<endl;

    cout<< "2-Sub of c1 & c2"<<endl;
    c4=sub(c1,c2);
    c4.print();

    cout<<"/////////////////////////////////////////////////////////////////"<<endl;

    cout<< "3-sum using of c1 + c2 operator overload (+) "<<endl;
    c5=c1+c2;
    c5.print();

    cout<<"/////////////////////////////////////////////////////////////////"<<endl;

    cout<< "4-Sub using of c1 - c2 operator overload (-) "<<endl;
    c5=c1-c2;
    c5.print();

    cout<<"/////////////////////////////////////////////////////////////////"<<endl;

    cout<< "5-Sub using of 7-c1 operator overload (-) "<<endl;
    c5 = 7-c1;
    c5.print();
    cout<<"/////////////////////////////////////////////////////////////////"<<endl;

    cout<< "8-Sub using of c1-=7 operator overload (-) "<<endl;
    (c1-=7).print();
    cout<<"/////////////////////////////////////////////////////////////////"<<endl;

    cout<< "9-Sub using of 7-=c1 operator overload (-) "<<endl;
    (7-=c1).print();
    cout<<"/////////////////////////////////////////////////////////////////"<<endl;

    cout<< "10-Sub using of c6-=c2 operator overload (-=) "<<endl;
    c6-=c2;
    c6.print();
    cout<< "this is the new c6"<<endl;
    c6.print();

    cout<<"/////////////////////////////////////////////////////////////////"<<endl;

    cout<< "11-Sub using of --c2 operator overload (--pre) "<<endl;
    c1=--c2;
    c1.print();
    cout<< "this is the new c2"<<endl;
    c2.print();

    cout<<"/////////////////////////////////////////////////////////////////"<<endl;

    cout<< "12-Sub using of c2-- operator overload (post--) "<<endl;
    c1=c2--;
    c1.print();
    cout<< "this is the new c2"<<endl;
    c2.print();

    cout<<"/////////////////////////////////////////////////////////////////"<<endl;

    cout<<endl;
    cout<< "c6(100,100) & c7(1,1)"<<endl;
    cout<<endl;

    cout<<"/////////////////////////////////////////////////////////////////"<<endl;
    cout<< "Is c7==c6? "<<endl;
    if(c7==c6)
        cout<<"true"<<endl;
    else
        cout<<"false"<<endl;

    cout<<"/////////////////////////////////////////////////////////////////"<<endl;

    cout<< "print true if c7!=c6? "<<endl;
    if(c7!=c6)
        cout<<"true"<<endl;
    else
        cout<<"false"<<endl;

    cout<<"/////////////////////////////////////////////////////////////////"<<endl;

    cout<< "print true if c6>c7? "<<endl;
    if(c6>c7)
        cout<<"true"<<endl;
    else
        cout<<"false"<<endl;
    cout<<"/////////////////////////////////////////////////////////////////"<<endl;

    cout<< "print true if c6>=c7? "<<endl;
    if(c6>=c7)
        cout<<"true"<<endl;
    else
        cout<<"false"<<endl;

    cout<<"/////////////////////////////////////////////////////////////////"<<endl;

    cout<< "print true if c6<c7? "<<endl;
    if(c6<=c7)
        cout<<"true"<<endl;
    else
        cout<<"false"<<endl;

    cout<<"/////////////////////////////////////////////////////////////////"<<endl;

    cout<< "print true if c6<=c7? "<<endl;
    if(c6<=c7)
        cout<<"true"<<endl;
    else
        cout<<"false"<<endl;
    cout<<"/////////////////////////////////////////////////////////////////"<<endl;

    cout<< "get real of c1 (int casting)? "<<endl;
    cout<< ((int)c1) <<endl;

    cout<<"/////////////////////////////////////////////////////////////////"<<endl;

    /*cout<< "get char* of c1 (char* casting)? "<<endl;
    for (int i=0 ; i<2 ; i++)
    {
        cout<< (char*)c1 <<endl;
    }*/

    cout<<"/////////////////////////////////////////////////////////////////"<<endl;

    scanf("%c",&ch);
}
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/// 4 constructors///
//parameterless//
complex :: complex()
{
    real = img = 0;

   // cout<<"Constructor 3"<<endl;
}
//1 parameter//
complex :: complex(int x)
{
    real = img = x;

    //cout<<"Constructor 2"<<endl;
}
//2 parameters//
complex :: complex(int x, int y)
{
    real = x ;
    img = y;

    //cout<<"Constructor 1"<<endl;
}
//copy constructor//
complex :: complex(const complex& oldc)
{
        real = oldc.real;
        img  = oldc.img;
        //cout<<"copy constructor"<<endl;
}

/// 1 destructor///
complex :: ~complex()
{
    //cout<<"destructor"<<endl;
}

/// setter and getter for real numbers///

void complex ::setreal(int r)
{
    real=r;
}

int complex ::  getreal()
{
    return real;
}

/// setter and getter for imaginary numbers///

void complex ::  setimg(int i)
{
    img=i;
}
int complex ::  getimg()
{
    return img;
}

/// print function///
void complex ::  print()
{
    if (real==0 && img==0)
        cout<< 0 <<endl;
    else if (real==0 && img>0)
        cout<<   img << "i" <<endl;
    else if (real>0 && img==0)
        cout<< real <<endl;
    else if ( img<0)
        cout<< real <<  img << "i" <<endl;
    else
        cout << real << "+" << img << "i" << endl;
}

/// sum function///
complex complex ::  sum (complex& c)
{
/// real and img are for caller
/// we don't have to get because sum is method which can access all objects of same class
//c3.real = real + c.getreal();
//c3.img = img + c.getimg();
        complex result;
        result.real = real + c.real;
        result.img = img + c.img;

        return result;
}

///Standalone subtraction function///
complex sub (complex c1, complex c2)
{
///declaration of  c4 because it is out of scoop of main
    complex result;
///set c4 real part to be equal [(c1.getreal ... return real part of c1)-(c2.getreal ... return real part of c2)]
    result.setreal(c1.getreal()-c2.getreal());
///set c4 imaginary part to be equal [(c1.getimg ... return img. part of c1)-(c2.geimg ... return img. part of c2)]
    result.setimg(c1.getimg()-c2.getimg());
    return result;
}

///operator overloading///
complex complex:: operator+ (const complex& c)
{
    complex result(real+c.real,img+c.img);
    return result;
}
complex complex:: operator- (const complex& c)
{
    complex result(real-c.real,img-c.img);
    return result;
}
complex operator- (int L , complex& c)
{
    complex result;
    result.setreal(L-c.getreal());
    result.setimg(c.getimg());
    return result;
}
complex& complex :: operator-= (const complex& c)
{
    real-=c.real;
    img-=c.img;
    return *this;
}
complex operator-= (int L ,complex& c)
{
    complex result;
    result.setreal(L-c.getreal());
    result.setimg(c.getimg());
    return result;
}
complex& complex :: operator-= (int L)
{

    real-=L;
    return *this;
}
complex& complex :: operator-- ()  ///prefix --c
{
    real--;
    return *this;
}
complex complex :: operator-- (int)  ///postfix c--
{
    complex temp(*this); ///deep copy of the caller object
    real--;
    return temp;
}
bool complex :: operator== (const complex &c)
{
    return ((c.real==real)&&(c.img==img));
}
bool complex :: operator!= (const complex &c)
{
    return ((c.real!=real)||(c.img!=img));
}
bool complex :: operator> (const complex &c)
{
    return ((real>c.real)||(img>c.img));
}
bool complex :: operator>= (const complex &c)
{
    return ((real>=c.real)||(img>=c.img));
}
bool complex :: operator< (const complex &c)
{
    return ((real<c.real)||(img<c.img));
}
bool complex :: operator<= (const complex &c)
{
    return ((real<=c.real)||(img<=c.img));
}
complex :: operator int ()
{
    return real;
}
/*complex :: operator char* ()
{
    char arr[2];
    arr[0] = (char) real;
    arr[1]=(char) img;
    return arr;
}*/


