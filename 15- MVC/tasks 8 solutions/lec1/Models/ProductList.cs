using System.Collections.Generic;

namespace lec1.Models
{
    public class ProductList
    {
        public static List<Product> products = new List<Product>()
        {
            new Product{ Id = 1, Name= "prd1" , Price=100},
            new Product{ Id = 2, Name= "prd2" , Price=200},
            new Product{ Id = 3, Name= "prd3" , Price=300},
            new Product{ Id = 4, Name= "prd4" , Price=400},
            new Product{ Id = 5, Name= "prd5" , Price=500},
        };
    }
}
