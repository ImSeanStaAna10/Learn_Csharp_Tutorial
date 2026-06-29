using System;
using System.Collections.Generic;
using System.Text;

namespace OOP__Abstract__Interface_and_Generic.Abstraction
{
    public abstract class Person
    {
        public string FullName { get; set; }

        public void doSomething()
        {
            Console.WriteLine("REF!! Do something");
        }
    }
}
