using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16Cont
{

    /// <summary>
    /// 1) person not abstract class 
    /// => 3 DBset => table per hirarcy
    /// </summary>
    /// 2) person is abstract => 3DBset
    /// i want to make my own discriminator
    ///<summary>
    ///3) person not abstract class and i make only 1 db set for person 
    ///</summary>

    public abstract class Person
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public bool IsEmployee { get; set; }
    }

    public class Teacher : Person
    {
        [Column(TypeName ="money")]
        public decimal Salary { get; set; }

        public Teacher()
        {
            IsEmployee = true;
        }
    }
    public class Student : Person
    {
        public DateTime EnrollmentDate { get; set; }
        public Student()
        {
            IsEmployee = false;
        }
    }
}
