using System;
using System.Collections.Generic;
using System.Text;
using OOP__Abstract__Interface_and_Generic.Abstraction;
using OOP__Abstract__Interface_and_Generic.Abstraction_VS_Interface;
using OOP__Abstract__Interface_and_Generic.Encapsulation;
using OOP__Abstract__Interface_and_Generic.Polymorphism;
namespace OOP__Abstract__Interface_and_Generic.Generic
{
    public class SampleGeneric<T>     
        where T : TagaCompute, new()
    {
        public void Process(int num1 , int num2)
        {
            T t = new T();
            t.compute(num1 , num2);
            Console.WriteLine($"Compute {t.result}");
        }

    }

    
}
