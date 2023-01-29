using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;

namespace main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("///////////POINTS///////////");
            #region Points
            Point3D pA = new Point3D(10, 10, 10);

            //Console.WriteLine(Point3D.toString());


            Point3D[] pntArr = new Point3D[2];

            for (int i = 0; i < 2; i++)
            {
                int x, y, z;
                do
                {
                    Console.WriteLine($"Please enter point {i + 1} xCoord");
                } while (!int.TryParse(Console.ReadLine(), out x));
                do
                {
                    Console.WriteLine($"Please enter point {i + 1} yCoord");

                } while (!int.TryParse(Console.ReadLine(), out y));
                do
                {
                    Console.WriteLine($"Please enter point {i + 1} zCoord");
                } while (!int.TryParse(Console.ReadLine(), out z));

                Point3D p = new Point3D(x, y, z);
                pntArr[i] = p;
            }

            Console.WriteLine(pntArr[0]);
            Console.WriteLine(pntArr[1]);

            //Point3D p1 = new Point3D(3,3,3);
            //Point3D p2 = new Point3D(4,4,4);

            if (pntArr[0] == pntArr[1])
            {
                Console.WriteLine($"Yes, {pntArr[0]} is equal to {pntArr[1]}");
            }
            else
            {
                Console.WriteLine($"No, {pntArr[0]} is not equal to {pntArr[1]}");
            }
            #endregion

            Console.WriteLine("");
            Console.WriteLine("///////////MATH///////////");

            #region Math
            Math m = new Math();
            Console.WriteLine(m.add1(5, 5));
            Console.WriteLine(m.subtract1(5, 5));
            Console.WriteLine(m.multiply1(5, 5));
            Console.WriteLine(m.divide1(5, 0));
            Console.WriteLine("//////////////////////////");
            Console.WriteLine(Math.add(5, 5));
            Console.WriteLine(Math.subtract(5, 5));
            Console.WriteLine(Math.multiply(5, 5));
            Console.WriteLine(Math.divide(5, 0));

            #endregion

            Console.WriteLine("////////////SINGLETON//////////");

            #region SingleTon NIC
            NIC o1 = NIC.SingleTon_NIC();
            NIC o2 = NIC.SingleTon_NIC();
            //NIC o3 = new NIC(); //not valid

            Console.WriteLine("this is NIC O1"+o1);
            Console.WriteLine("this is NIC O2"+o2);
            #endregion

            Console.WriteLine("///////////DURATION///////////");

            #region Duration
            Duration D1 = new Duration(7800);
            Console.WriteLine($"D1: {D1}");

            Duration D2 = new Duration(666);
            Console.WriteLine($"D2: {D2}");

            Duration D3 = new Duration(3600);
            Console.WriteLine($"D3: {D3}");

            Duration D4 = new Duration(1,10,15);
            Console.WriteLine($"D4: {D4}");

            Console.WriteLine("//////////////////////");

            Duration D5 = new Duration(7800);
            Console.WriteLine($"D5: {D5}");

            Duration D6 = new Duration(3666);
            Console.WriteLine($"D6: {D6}");
            Console.WriteLine("//////////////////////");

            Duration D7;
            D7 = D6 + D5;
            Console.WriteLine($"The sum D7 is  : {D7}");

            Console.WriteLine("//////////////////////");
            Duration D8;
            D8 = D1 + 7800;
            Console.WriteLine($"The sum D8 is : {D8}");

            Console.WriteLine("//////////////////////");
            Duration D9;
            D9 = 666 + D3;
            Console.WriteLine($"The sum D9 is : {D9}");

            Console.WriteLine("//////////////////////");
            Duration D10;
            D10 = D2++;
            Console.WriteLine($"The sum D10 is : {D10}");
            Console.WriteLine($"The sum D2 is : {D2}");


            Console.WriteLine("//////////////////////");
            Duration D11;
            D11 = --D2;
            Console.WriteLine($"The sum D11 is : {D11}");
            Console.WriteLine($"The sum D2 is : {D2}");

            Console.WriteLine("//////////////////////");

            Duration D100 = new Duration(6000);
            D100 = -D2;
            Console.WriteLine($"The D100 is : {D100}");

            Console.WriteLine("//////////////////////");
            if (D1>D2)
            {
                Console.WriteLine($"{D1} bigger than {D2}");
            }
            else
            {
                Console.WriteLine($"{D1} smaller than {D2}");
            }
            Console.WriteLine("//////////////////////");
            if (D1 < D2)
            {
                Console.WriteLine($"{D1} smaller than {D2}");
            }
            else
            {
                Console.WriteLine($"{D1} bigger than {D2}");
            }
            Console.WriteLine("//////////////////////");
            Duration D12 = new Duration(0, 0, 0);
            if(D12)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.WriteLine("//////////////////////");

            Duration D101 = new Duration(11,11,11);

            DateTime D = (DateTime)D101;


            Console.WriteLine($"{D.Hour} ,{D.Minute},{D.Second}");
            #endregion

            Console.WriteLine("//////////////////////");
        }
    }
}