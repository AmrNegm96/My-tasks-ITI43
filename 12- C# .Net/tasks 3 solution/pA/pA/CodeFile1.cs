using pA;
using System.Security.Cryptography;



////////////////////////////////////////////////

Employee E1 = new Employee();
Console.WriteLine(E1);

////////////////////////////////////////////////

Employee E2 = new Employee(11, "amr negm", 20_000);
Console.WriteLine(E2);

///////////////////////////////////////////////

Employee[] empArray = new Employee[1];

for (int i = 0; i < 1; i++)
{
    Console.WriteLine($"Please enter id of employee number {i + 1}");
    empArray[i].setId(int.Parse(Console.ReadLine()));

    Console.WriteLine($"Please enter name of employee number {i + 1}");
    empArray[i].setName((Console.ReadLine()));

    Console.WriteLine($"Please enter salary of employee number {i+1}");
    empArray[i].setSalary(decimal.Parse(Console.ReadLine()));

    //////////Date/////////
    Console.WriteLine("Please enter hier date in this form (****Y/**M/**D)");
    string date = Console.ReadLine();
    string[] dateArr = date.Split("/");
    int year = int.Parse(dateArr[0]);
    int month = int.Parse(dateArr[1]);
    int day = int.Parse(dateArr[2]);
    empArray[i].setHireDate(year, month, day);

    ////////Gender///////
    Console.WriteLine("Please enter the employee gender (M/F)");
    string Gender = Console.ReadLine();

    if(Gender=="M")
    {
        empArray[i].setGender(pA.Gender.M);
    }
    else if (Gender=="F")
    {
        empArray[i].setGender(pA.Gender.F);
    }
    ////////////Security Level///////////
    Console.WriteLine("Please enter security level (g | dev | sec | dba )");
    
    string secLevel = Console.ReadLine();

    if(secLevel == "g")
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
        SecurityLevel ALL;
        ALL = (SecurityLevel) 0B_0000_1111;
        empArray[i].setSecurityLevel(ALL);
    }

    Console.WriteLine(empArray[i]);

}
