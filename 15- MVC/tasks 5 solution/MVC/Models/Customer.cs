using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "please enter this field")]
        public string Name { get; set; }

        [Required(ErrorMessage = "please enter this field")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "please enter this field")]
        [MaxAge(35)]
        public int Age { get; set; }

        [Required(ErrorMessage = "please enter this field")]
        public string Email { get; set; }

        [Required(ErrorMessage = "please enter this field")]
        public string PhoneNum { get; set; }
        public List<Order> orders { get; set; }
    }
}