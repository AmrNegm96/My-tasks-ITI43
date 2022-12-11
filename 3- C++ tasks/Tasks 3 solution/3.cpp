#include <iostream>

using namespace std;

class complex
{
/// since class is private by default therefore we don't have to write private before data members
    int real;
    int img;
public:

/// 3 different constructors

    complex(int x, int y)
    {
        real = x ; img = y;

        cout<<"Constructor 1"<<endl;
    }

    complex(int x)
    {
        real = img = x;

        cout<<"Constructor 2"<<endl;
    }

    complex()
    {
        real = img = 0;

        cout<<"Constructor 3"<<endl;
    }
     complex(const complex &a)
    {
        real= 50;
        img = 100;
        cout<<"copy constructor"<<endl;
    }

/// 1 destructor
    ~complex()
    {
        cout<<"destructor"<<endl;
    }

/// setter and getter for real numbers

    void setreal(int r)
    {
        real=r;
    }

    int getreal()
    {
        return real;
    }

/// setter and getter for imaginary numbers

    void setimg(int i)
    {
        img=i;
    }
    int getimg()
    {
        return img;
    }

/// print function

    void print()
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


/// sum function

    complex& sum (complex &c)
    {

/// real and img are for caller
/// we dont have to get because sum is method which can access all objects of same class
        //c3.real = real + c.getreal();
        //c3.img = img + c.getimg();

        real = real + c.real;
        img = img + c.img;

        return *this;
    }

     /*   complex sum (complex &c)
    {
        complex result;

/// real and img are for caller
/// we dont have to get because sum is method which can access all objects of same class
        //c3.real = real + c.getreal();
        //c3.img = img + c.getimg();

        result.real = real + c.real;
        result.img = img + c.img;

        return result;
    }*/
};



/*complex sub (complex c1, complex c2)
{
///declaration of  c4 because it is out of scoop of main
    complex c4;
///set c4 real part to be equal [(c1.getreal ... return real part of c1)-(c2.getreal ... return real part of c2)]
    c4.setreal(c1.getreal()-c2.getreal());
///set c4 imaginary part to be equal [(c1.getimg ... return img. part of c1)-(c2.geimg ... return img. part of c2)]
    c4.setimg(c1.getimg()-c2.getimg());
    return c4;
}*/


int main()
{
    complex c1(1,2),c2(5),c3,c4(c1);


    c3=c1.sum(c2);
    c1.print();
    c3.print();

    cout<<"c4 is   ";

    c4.print();

    //sub(c1,c2).print();

    //int xr1,xi1,xr2,xi2;

    //cout<<"please enter real number 1"<<endl;
    //cin>>xr1;
    //scanf("%i",&xr1);

    //cout<<"please enter img number 1"<<endl;

    //cin>>xi1;

    //c1.setreal();
    //c1.setimg();

    //cout<<"please enter real number 2"<<endl;
    //cin>>xr2;

    //cout<<"please enter img number 2"<<endl;
    //cin>>xi2;

    //c2.setreal();
    //c2.setimg();

    //cout<<"you entered"<<endl;

    //c1.print();

    //c2.print();

    //c3 = c1.sum(c2);

    //cout<<"sum is"<<endl;

    //c3.print();


    //cout<<"subtraction is"<<endl;
    //c4=sub(c1,c2);

    //c4.print();
}
