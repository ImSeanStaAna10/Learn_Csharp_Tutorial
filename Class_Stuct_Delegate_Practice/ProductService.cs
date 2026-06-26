
using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Stuct_Delegate_Practice
{
    public class ProductService 
    {
        
        public int DeleteProductService(Product product)
        {
            Console.WriteLine($"DELETED SERVICE: {product.PrdName}");
            return 1;
        }

        public int SoldProductService(Product product)
        {
            Console.WriteLine($"SOLD PRODUCT: {product.PrdName}");
            return 1;
        }
                
    }
}
