using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    [Table("Order")]

    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "please enter this field")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "please enter this field")]
        public decimal TotalPrice { get; set; }

        public Customer Customer { get; set; }

        [ForeignKey("Customer")]
        public int custID { get; set; }
    }
}