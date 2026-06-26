
using Class__Struct_and_Delegate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Class_Stuct_Delegate_Practice
{
    public class ProductService 
    {

        #region -- FOR DELEGATE --
        // PANG DELEGATE
        public int DeleteProductService(Product product)
        {
            Console.WriteLine($"DELETED SERVICE/using DELIGATE.....: {product.PrdName}");
            return 1;
        }

        public int SoldProductService(Product product)
        {
            Console.WriteLine($"SOLD PRODUCT/using DELIGATE......: {product.PrdName}");
            return 1;
        }

        #endregion

        #region -- FOR EVENT --

        public void onDeleteProduct(object sender , ProductEventArgs args)
        {
            Console.WriteLine($"DELETING PRODUCT/using EVENT....: {args.product.PrdName}");
        }

        public void onProductSold(object sender, ProductEventArgs args)
        {
            Console.WriteLine($"SOLD PRODUCT/using EVENT....: {args.product.PrdName}");

        }
        
        #endregion

    }
}
