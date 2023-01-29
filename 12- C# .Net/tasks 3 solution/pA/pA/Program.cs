using pA;
using System;
using System.Reflection.Emit;
using System.Security.Cryptography;
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

        public void setId(int _id)
        {
            Id = _id;
        }
        public int getId()
        {
            return Id;
        }

        public void setName(string _name)
        {
            Name = _name;
        }
        public string getName()
        {
            return Name;
        }

        public void setSalary(decimal _salary)
        {
            Salary = _salary;
        }
        public decimal getSalary()
        {
            return Salary;
        }

        public void setGender(Gender _gender)
        {
            this.Gender = _gender;
        }

        public Gender GetGender()
        {
            return this.Gender;
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


