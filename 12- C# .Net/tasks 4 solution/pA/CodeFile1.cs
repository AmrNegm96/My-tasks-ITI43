using pA;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;



//////////////////////////////////////////////

Employee E1 = new Employee();
E1.setHireDate(2000, 12, 12);
E1.setSecurityLevel(SecurityLevel.guest);
Console.WriteLine(E1);

//////////////////////////////////////////////

Employee E2 = new Employee(11, "amr negm", 20_000);
E2.setHireDate(2000, 12, 12);
E2.setSecurityLevel(SecurityLevel.guest);
Console.WriteLine(E2);

/////////////////////////////////////////////

Employee[] empArray = new Employee[1];

for (int i = 0; i < 1; i++)
{
    int x;
    do
    {
        Console.WriteLine($"Please enter id of employee number {i + 1} (integer)");
    } while (!int.TryParse(Console.ReadLine(), out x));

    empArray[i].id = x;


    Console.WriteLine($"Please enter name of employee number {i + 1}");
    empArray[i].name = Console.ReadLine();

    decimal y;
    do
    {
        Console.WriteLine($"Please enter salary of employee number {i + 1} (decimal)");
    } while (!Decimal.TryParse(Console.ReadLine(), out y));

    empArray[i].salary = y;

    //////////Date/////////


    int yr;
    int mn;
    int dy;
    string[] dateArr;
    do
    {
        Console.WriteLine("Please enter hier date in this form (****Y/**M/**D)");
        string date = Console.ReadLine();
        dateArr = date.Split("/");
    } while (!(int.TryParse(dateArr[0], out yr) & int.TryParse(dateArr[1], out mn) & int.TryParse(dateArr[2], out dy)));
    int year = yr;
    int month = mn;
    int day = dy;
    empArray[i].setHireDate(year, month, day);

    ////////Gender///////
    string Gender;
    do
    {
        Console.WriteLine("Please enter the employee gender (M/F)");
        Gender = Console.ReadLine();
    } while (!(Gender == "M" || Gender == "F"));

    if (Gender == "M")
    {
        empArray[i].gender = (pA.Gender.M);
    }
    else if (Gender == "F")
    {
        empArray[i].gender = (pA.Gender.F);
    }

    ////////////Security Level///////////

    Console.WriteLine("Please enter security level (g | dev | sec | dba )");

    string secLevel = Console.ReadLine();

    if (secLevel == "g")
    {
        empArray[i].setSecurityLevel(SecurityLevel.guest);
    }
    else if (secLevel == "dev")
    {
        empArray[i].setSecurityLevel(SecurityLevel.developer);
    }
    else if (secLevel == "sec")
    {
        empArray[i].setSecurityLevel(SecurityLevel.secretary);
    }
    else if (secLevel == "dba")
    {
        empArray[i].setSecurityLevel(SecurityLevel.DBA);
    }
    else
    {
        SecurityLevel SecurityGuard;
        SecurityGuard = (SecurityLevel)0B_0000_1111;
        empArray[i].setSecurityLevel(SecurityGuard);
    }
    Console.WriteLine(empArray[i]);

    //    /////////// index with old way ///////////////////
    //    //EmployeeSearch employeeSearch = new EmployeeSearch(5);

    //    //employeeSearch.SetEntry(0, "abc", 101);
    //    //employeeSearch.SetEntry(1, "xyz", 102);
    //    //employeeSearch.SetEntry(2, "klm", 103);

    //    //Console.WriteLine(employeeSearch.GetId("abc"));

    //    /////// indexer deal with object as array ////////

    EmployeeSearch employeeSearch = new EmployeeSearch(5);


    employeeSearch.SetEntry(0, "abc", 101);
    employeeSearch.SetEntry(1, "xyz", 102);
    employeeSearch.SetEntry(2, "klm", 103);
    employeeSearch.SetEntry(3, "kkk", 111);

    employeeSearch["kkk"] = 222;

    Console.WriteLine($"abc id is {employeeSearch["abc"]}");
    Console.WriteLine($"kkk id is {employeeSearch["kkk"]}");
}






