using System;
using System.Collections.Generic;
using System.Text;


// SERVICE LAYER or BUSINESS LAYER
namespace Class_Stuct_Delegate_Practice
{
    // class naghahandle ng products
    public class Store
    {
        // FIELDS
        private List<Product> products;

        // PROPERTIES
        public string StoreName { get; set; }

        // CONSTRUCTOR
        public Store(string storeName)
        {
            StoreName = storeName;
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine($"Added Product: {product.PrdName}");
        }

        public void DeleteProduct(Product product , ProductSaleActionDelegate action)
        {
            products.Remove(product);
            action(product);
           
        }

        public void ShowAllProduct()
        {
            Console.WriteLine($"{StoreName} PRODUCTS: ");

            foreach (var prd in products)
            {
                Console.WriteLine($"{prd.PrdName} {prd.PrdPrice}");
            }
        }

        public void SellProduct(string ProductName, ProductSaleActionDelegate action)
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

                action(foundProduct);
            }
            else
            {
                Console.WriteLine("Product not found!");
            }
        }
    }
}
