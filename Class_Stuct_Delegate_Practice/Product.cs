using System;
using System.Collections.Generic;
using System.Text;
// DATA LAYER -  MODEL
namespace Class_Stuct_Delegate_Practice
{
    // "Template ng product data (name + price)"
    public struct Product
    {
        // PROPERTIES (mas clean kaysa fields)
        public string PrdName { get; set; }
        public int PrdPrice { get; set; }

        // CONSTRUCTOR
        public Product(string prdName, int prdPrice)
        {
            PrdName = prdName;
            PrdPrice = prdPrice;
        }
    }
}
