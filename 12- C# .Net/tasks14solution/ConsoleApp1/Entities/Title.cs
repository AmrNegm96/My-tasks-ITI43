using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public class Title
    {



        /// <summary>
        /// 4 mapping ways
        /// 1- EF Convention (default) => name of class be name of table but prular , ID ==>PK and ID , what have ? be allow NULL
        /// 2-Attributes [Mapping attriute] , Data Annotations
        /// 3-Fluent API (OnModelCreating(ModelBuilder))
        /// 4-Configuration Classes
        /// </summary>
        // Public Numeric Attribute , ID or EntityNameID ====> PK , Identity 
        public int Id { get; set; }

      

        //NonNullable refernce type  ===> not NULL
        public /*required*/ string AuthorName { get; set; } = string.Empty;
        //required make the responsiblity to devloper who make object to initialize
        //refrence type not initialized so it gives waring
        //from c#11 by default nonNullable refrence type  
        //any refernce type accept nulls but we can state explicitly that may accept null 

        public string Name { get; set; } = string.Empty;
        //NonNullable value type
        public decimal Price { get; set; }  

        //Nullable value type ===> NULL
        public decimal? PromotionalPrice { get; set; }

        //Nullable refrence type ===> NULL
        public string? Forward { get; set; }

        public virtual Branch? Branch { get; set; }

        //public Title(int id , string authorName , decimal price , string? forward)
        //{
        //    Id = id;
        //    AuthorName = authorName;
        //    Price = price;
        //    Forward = forward;
        //}

    }
}
