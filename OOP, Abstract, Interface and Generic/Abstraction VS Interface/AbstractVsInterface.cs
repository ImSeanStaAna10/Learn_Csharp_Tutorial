using System;
using System.Collections.Generic;
using System.Text;

namespace OOP__Abstract__Interface_and_Generic.Abstraction_VS_Interface
{
    public abstract class Document
    {
        public string Name { get; set; }
        public void Process(){
            Console.WriteLine("Processing ... This is a Method come from base abstract class document");
        }
        public abstract void Print(); // ABSTRACT METHOD - need Ioveride ng mga nag inherit and make own implementation
    }   

    public class PDF: Document
    {
        public override void Print() {
            Console.WriteLine("Printing PDF....");
        }
    }

    public class WORD: Document
    {
        public override void Print() {
            Console.WriteLine("Printing Word.....");
        }
    }




    // INTERFACE - parang contract - so subclass must have whats the interface given req
    public interface IDokumento
    {
        string name { get; set;  }
        void Process();
        void Print();
    }

    public class Excel : IDokumento
    {
        public string name { get; set; }

        public void Print() { }
        public void Process() { }
    }

    public interface IDoc1 {

        //contract requirement to have kung sino man mag iinherit neto 
        string myName { get; set; } 
        void sayName();
    
    }
    


    //COMBINATION OF Inheritance , abstraction ,  interface
    //lIMTED lang sa oneclass ang pwede Iinherit 
    public class newDocument : WORD, IDoc1 {

        public string myName { get; set; }

        public newDocument(string MyName = "Sean")
        {
            myName = MyName;
        }
        public override void Print()
        {
            Console.WriteLine("Printing from (newDocument) class");
        }

        public void sayName()
        {
            Console.WriteLine($"My Name is {myName}");
        }


    
    
    }
}
