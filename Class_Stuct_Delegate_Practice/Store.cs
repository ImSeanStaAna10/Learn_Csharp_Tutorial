using Class__Struct_and_Delegate;
using System;
using System.Collections.Generic;
using System.Text;


// SERVICE LAYER or BUSINESS LAYER
namespace Class_Stuct_Delegate_Practice
{
    // class naghahandle ng products
    public class Store
    {
        #region -- FIELDS --
        private List<Product> products;
        #endregion

        #region -- PROPERTIES --
        public string StoreName { get; set; }

        #endregion

        #region -- CONSTRUCTOR -- 
        public Store(string storeName) 
        {
            StoreName = storeName;
            products = new List<Product>();
        }
        #endregion

        #region -- METHODS --
        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine($"Added Product: {product.PrdName}");
        }

        public void DeleteProduct(Product product, ProductActionDelegate action)
        {
            products.Remove(product);
            action(product);

            // INVOKE EVENT
            onProductDeleted?.Invoke(this, new ProductEventArgs
            {
                    product = product
            });
        }

        public void ShowAllProduct()
        {
            Console.WriteLine($"{StoreName} PRODUCTS: ");

            foreach (var prd in products)
            {
                Console.WriteLine($"{prd.PrdName} {prd.PrdPrice}");
            }
        }

        public void SellProduct(string ProductName, ProductActionDelegate action)
        {
            Product foundProduct = new Product();
            bool isFound = false;

            foreach (var product in products)
            {
                if (product.PrdName == ProductName)
                {
                    foundProduct = product;
                    isFound = true;
                    break;
                }
            }

            if (isFound)
            {
                products.Remove(foundProduct);

                Console.WriteLine(
                    $"SOLD: {foundProduct.PrdName} - Pesos {foundProduct.PrdPrice}");

                action(foundProduct); // BY DELEGATE
                onProductSold?.Invoke(this, new ProductEventArgs
                {
                  product = foundProduct
                });              
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }

        #endregion

        #region -- EVENT HANDLER --
        public event EventHandler<ProductEventArgs> onProductDeleted;
        public event EventHandler<ProductEventArgs> onProductSold;
        #endregion
    }

}
