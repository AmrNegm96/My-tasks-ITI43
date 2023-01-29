using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace main
{
    internal class Point3D
    {
        int x;
        int y;
        int z;

        public int X
        {
            set
            {
                x = value;
            }
            get
            {
                return x;
            }
        }
        public int Y
        {
            set
            {
                y = value;
            }
            get
            {
                return y;
            }
        }
        public int Z
        {
            set
            {
                z = value;
            }
            get
            {
                return z;
            }
        }
        //static Point3D()
        //{

        //}
        public Point3D()
        {
        }
        public Point3D(int _X, int _Y, int _Z)
        {
            this.x = _X;
            this.y = _Y;
            this.z = _Z;
        }

        public override string ToString()
        {
            return $"The point coordinates is ({this.x},{this.y},{this.z})";
        }

        public static bool operator ==(Point3D a, Point3D b)
        {
            if (a.x == b.x & a.y == b.y & a.z == b.z)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Point3D a, Point3D b)
        {
            if (a.x == b.x || a.y == b.y || a.z == b.z)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    internal class Math
    {
        public int add1(int a,int b)
        {
            return a + b;
        }
        public int subtract1(int a, int b)
        {
            return a - b;
        }
        public int multiply1(int a, int b)
        {
            return a * b;
        }
        public int divide1(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("can't divide by zero");
                return -1;
            }
            else
            {
                return a / b;
            }
        }

        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int subtract(int a, int b)
        {
            return a - b;
        }
        public static int multiply(int a, int b)
        {
            return a * b;
        }
        public static int divide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("can't divide by zero");
                return -1;
            }
            else
            {
                return a / b;
            }
        }
    }

    internal class NIC
    {
        string manufacture;
        string macAddress;
        Type tnic;

        public string Manufacture
        {
            set { this.manufacture = value; }
            get { return this.manufacture; }
        }
        public string MacAddress
        {
            set { this.macAddress = value; }
            get { return this.macAddress; }
        }
        public Type Type
        {
            set { this.tnic = value; }
            get { return this.tnic; }
        }

        NIC(string _manufacture, string _mac, Type _type)
        {
            manufacture = _manufacture;
            macAddress = _mac;
            tnic = _type;
            Console.WriteLine("private Ctor");
        }
        static NIC myNIC;
        public static NIC SingleTon_NIC()
        {
            if (myNIC == null)
            {
                return myNIC = new NIC("Dell", "1000DELL1000", Type.ethernet);
            }
            else
            {
                return myNIC;
            }
        }
        public override string ToString()
        {
            return $"manfacture: {this.manufacture} , mac address: {this.macAddress} , type : {this.Type}";
        }
    }
    enum Type : byte
    {
        ethernet = 0B_0000_0001,
        ringToken = 0B_0000_0010
    }

    internal class Duration
    {
        int hours;
        int minutes;
        int seconds;
        public Duration()
        {
            this.hours = 0;
            this.minutes = 0;
            this.seconds = 0;
        }
        public Duration(int _hours, int _minutes, int _seconds)
        {
            this.hours = _hours;
            this.minutes = _minutes;
            this.seconds = _seconds;
        }

        public Duration(int _seconds)
        {
            float M = (float)_seconds / 60;

            int H = 0;

            float S = 0;

            while (M >= 60)
            {
                M = M - 60;
                H++;
            }
            S = (M - (int)M) * 60 ;
            
            M = M - (M - (int)M);


            this.hours = H;
            this.minutes = (int)M;
            this.seconds = (int)S;

        }

        public override string ToString()
        {
            if (this.hours == 0)
            {
                return $"Minutes: {this.minutes} , Seconds: {this.seconds}";

            }
            else
            {
                return $"Hours: {this.hours} , Minutes: {this.minutes} , Seconds: {this.seconds}";
            }
        }
        public static Duration operator +(Duration a, Duration b)
        {
            float S = 0, H = 0, M = 0;

            S = S + a.seconds + b.seconds;
            while (S >= 60)
            {
                S = S - 60;
                M++;
            }
            M = M + a.minutes + b.minutes;
            while (M >= 60)
            {
                M = M - 60;
                H++;
            }
            H = H + a.hours + b.hours;

            Duration Sum = new Duration((int)H, (int)M, (int)S);
            return Sum;

        }
        public static Duration operator +  (Duration a, int b)
        {
            Duration B = new Duration(b);

            return a + B;
            
        }
        public static Duration operator +(int b , Duration a)
        {
            Duration B = new Duration(b);

            return B + a;

        }

        public static Duration operator ++(Duration X)
        {
            Duration result = new Duration(X.hours, X.minutes + 1, X.seconds);

            if (X.minutes >= 60)
            {
                X.minutes = X.minutes - 60;
                X.hours = X.hours + 1;
            }
            if (result.minutes >= 60)
            {
                result.minutes = result.minutes - 60;
                result.hours= result.hours +1;
            }
            return result;
            //return new Duration(X.hours,X.minutes + 1,X.seconds);
        }
        public static Duration operator -- (Duration X)
        {
            Duration result = new Duration(X.hours, X.minutes - 1, X.seconds);

            if (X.minutes == 0)
            {
                X.hours--;
                X.minutes = 59;
            }
            if (result.minutes == 0)
            {
                result.hours--;
                result.minutes = 59;
            }
            return result;
            //return new Duration(X.hours,X.minutes + 1,X.seconds);
        }


        public static Duration operator -(Duration a)
        {
            Duration temp = new Duration();
            temp.hours = -a.hours;
            temp.minutes = -a.minutes;
            temp.seconds = -a.seconds;
            return temp;
        }
        public static bool operator > (Duration a, Duration b)
        {
            if(a.hours==b.hours)
            {
                if(a.minutes==b.minutes)
                {
                    return (a.seconds>b.seconds);
                }
                return (a.minutes > b.minutes);
            }
            return (a.hours>b.hours);
        }
        public static bool operator <(Duration a, Duration b)
        {
            if (a.hours == b.hours)
            {
                if (a.minutes == b.minutes)
                {
                    return (a.seconds < b.seconds);
                }
                return (a.minutes < b.minutes);
            }
            return (a.hours < b.hours);
        }

        public static bool operator false(Duration a)
        {
            if ((a.hours == 0) && (a.minutes == 0) && (a.seconds == 0))
                return false;
            else
                return true;
        }

        public static bool operator true(Duration a)
        {
            if ((a.hours > 0) || (a.minutes > 0) || (a.seconds >0))
                return true;
            else
                return false;
        }

        public static explicit operator DateTime(Duration a)
        {
            DateTime date = new();
            return date.AddHours(a.hours).AddMinutes(a.minutes).AddSeconds(a.seconds);
        }

    }
}
