using System;
using System.Collections.Generic;
using System.Text;

namespace OOP__Abstract__Interface_and_Generic.Abstraction
{
    public class Student2: Sean
    {
       public Student2(string name, bool Iq): base(name , Iq ) { 
           
        }
    }





    public class Sean : Person
    {
        public bool withMataasNaIQ { get; set; }

        public Sean(string name, bool IQ)
        {
            FullName = name;
            withMataasNaIQ = IQ;
        }

        public void SayName()
        {
          
            if (withMataasNaIQ)
            {
                Console.WriteLine($"My Name is {FullName}");
            }
            else
            {
                Console.WriteLine("Low IQ , So I cant display the name ");
            }
        }

        public void doThis()
        {
            doSomething();
        }
    }
}
