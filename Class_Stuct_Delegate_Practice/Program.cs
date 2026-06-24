namespace Class_Stuct_Delegate_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // create Store
            Store store = new Store("Mini Mart");

            //Create Product
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

            //DELETE PRODUCT
            store.DeleteProduct(milk, (product) =>
            {
                Console.WriteLine($"DELETED PRODUCT: {product.PrdName}");
                return 1;
            });

            //SHOW ALL PRODUCT
            Console.WriteLine();
            store.ShowAllProduct();

            //SELL PRODUCT
            Console.WriteLine();
            store.SellProduct("bread", (product) =>
            {
                return 2;
            });

            Console.WriteLine();

            //SHOW REMAINING PRODUCT
            store.ShowAllProduct();
        }
    }
} 
