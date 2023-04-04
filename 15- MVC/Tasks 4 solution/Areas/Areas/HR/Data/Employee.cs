using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Areas.Areas.HR.Data
{

    public enum Gender : byte { male, female }
    [Table("EmployeeInfo")]
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }

        [Required(ErrorMessage = "You must put a name")]
        [MaxLength(30, ErrorMessage = "user shorter name")]
        [Display(Name = "EmployeeName")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must put user name")]
        [MaxLength(10)]
        public string Username { get; set; }

        [Required(ErrorMessage = "You must put passsword")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }

        [Required]
        [DataType("money")]
        public decimal Salary { get; set; }


        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}}")]
        public DateTime JoinDate { get; set; }



        [Required(ErrorMessage = "enter your email")]
        [DataType(DataType.EmailAddress)]
        //[RegularExpression(@" ^\w + ([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }



        [Required(ErrorMessage = "retype your email agian")]
        [Compare("Email", ErrorMessage = "email does not match")]
        //[NotMapped]
        public string ConfirmEmail { get; set; }



        [DataType(DataType.PhoneNumber)]
        public string PhoneNum { get; set; }
    }
}