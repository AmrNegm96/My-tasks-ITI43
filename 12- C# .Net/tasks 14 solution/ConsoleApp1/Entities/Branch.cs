using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.Entities
{

    //2- Data anotations

    [Table("LibraryBranches")]
    public class Branch
    {

        [Key]
        public int BID { get; set; }  // not mapped by default

        [MaxLength(40)]
        public string City { get; set; } = string.Empty;

        [MaxLength(10)]
        //[Required]
        public string? ZipCode { get; set; }

        [Column(TypeName ="smallint")]
        public int OpenHour { get; set; }

        public virtual ICollection<Title> Titles { get; set; } = new HashSet<Title>();  
    }
}
