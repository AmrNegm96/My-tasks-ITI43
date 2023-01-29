using pA;
using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Xml.Linq;

////////////////////////////////////////////////////////////////////////////////////////////////
namespace pA
{
    struct Employee
    {
        private int Id;
        private string Name;
        private decimal Salary;
        private SecurityLevel S_L;
        private Date HireDate;
        private Gender Gender;

        public int id
        {
            get
            {
                return this.Id;
            }
            set
            {
                this.Id = value;
            }
        }
        public string name
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
            }
        }
        public decimal salary
        {
            get
            {
                return this.Salary;
            }
            set
            {
                this.Salary = value;
            }
        }
        public Gender gender
        {
            get
            {
                return this.Gender;
            }
            set
            {
                this.Gender = value;
            }
        }
        public void setHireDate(int y, int m, int d)
        {
            this.HireDate.year = y;
            this.HireDate.month = m;
            this.HireDate.day = d;
        }
        public Date getHireDate()
        {
            return this.HireDate;
        }
        public void setSecurityLevel(SecurityLevel _securityLevel)
        {
            this.S_L = _securityLevel;
        }
        public SecurityLevel getSecurityLevel()
        {
            return this.S_L;
        }
        public override string ToString()
        {
            return $"the employee id is {Id} and his name {Name} and his salary {Salary} $ and was hired at {HireDate} and his gender is {Gender} and his security level is {S_L}";
        }
        public Employee()
        {
            this.Id = 1;
            this.Name = "amr";
            this.Salary = 40_000;
        }
        public Employee(int _id, string _name, decimal _Salary)
        {
            this.Id = _id;
            this.Name = _name;
            this.Salary = _Salary;
        }
    }
    //////////////////////////////////////////Date struct////////////////////////////////
    struct Date
    {
        public int year;
        public int month;
        public int day;
        public Date(int _year, int _month, int _day)
        {
            this.year = _year;
            this.month = _month;
            this.day = _day;
        }
        public override string ToString()
        {
            return $"{day}-{month}-{year}";
        }
    }



    ////////////////////////////////// Enum of gender //////////////////////////////////

    enum Gender : byte
    {
        M, F,
    }

    ////////////////////////////////////////enum of security level ////////////////////
    [Flags]
    enum SecurityLevel : byte
    {
        guest = 0B_0000_0001,
        developer = 0B_0000_0010,
        secretary = 0B_0000_0100,
        DBA = 0B_0000_1000,
    }

}


struct EmployeeSearch
{
    string[] Names;
    int[] Ids; 
    readonly int size;

    public int Size
    {
        get { return size; }
    }

    public EmployeeSearch(int _size)
    {
        size = _size;
        Names = new string[size];
        Ids = new int[size];
    }

    public void SetEntry(int index, string Name, int id)
    {
        if ((index >= 0) && (index < size))
        {
            Names[index] = Name;
            Ids[index] = id;
        }
    }

    public int GetId(string Name)
    {
        for (int i = 0; i < size; i++)
        {
            if (Names[i] == Name)
                return Ids[i];
        }
        return -1;
    }
    //////////// indexer ////////////////

    ///Set(int value and string name) .. int get(string name)
    public int this[string Name]
    {
        set 
        {
            for (int i = 0; i < size; i++)
            {
                if (Names[i] == Name)
                    Ids[i] = value;
            }
        }
        get 
        {
            for (int i = 0; i < size; i++)
            {
                if (Names[i] == Name)
                    return Ids[i];
            }
            return -1;
        }
    }

     
}


