
namespace Class_Stuct_Delegate_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANCE OF STORE CLASS
            Store store = new Store("Mini Mart");

            //INSTANCE OF PRODUCT STRUCT
            Product milk = new Product("Milk" , 50);
            Product bread = new Product("bread", 20);
            Product soda = new Product("Soda", 40);
            Product crackers = new Product("crakers", 10);

            //ADD PRODUCTS
            Console.WriteLine("THIS IS PRODUCT LIST: ");
            store.AddProduct(milk);
            store.AddProduct(bread);
            store.AddProduct(soda);
            store.AddProduct(crackers);

            Console.WriteLine();

            //INSTANCE OF PRODUCT SERVICE CLASS
            ProductService service = new ProductService();

            //SUBSCRIBE TO EVENT
            store.onProductDeleted += service.onDeleteProduct; 
            store.onProductSold += service.onProductSold;


            // DELETE PRODUCT
            Console.WriteLine();
          
            store.DeleteProduct(bread, service.DeleteProductService); // USING DELAGATE

            //SHOW ALL PRODUCT
            Console.WriteLine();
            store.ShowAllProduct();

            //SELL PRODUCT
            Console.WriteLine();
            store.SellProduct("crakers" , service.SoldProductService); // USING DELEGATE
            store.SellProduct("Milk", service.SoldProductService);

            //SHOW REMAINING PRODUCT
            Console.WriteLine();
            store.ShowAllProduct();

      
        }
    }
} 
