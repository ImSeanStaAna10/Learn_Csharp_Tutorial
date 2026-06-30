using System;
using System.Collections.Generic;
using System.Text;
using OOP__Abstract__Interface_and_Generic.Abstraction;
using OOP__Abstract__Interface_and_Generic.Abstraction_VS_Interface;
using OOP__Abstract__Interface_and_Generic.Encapsulation;
using OOP__Abstract__Interface_and_Generic.Polymorphism;
namespace OOP__Abstract__Interface_and_Generic.Generic
{

    #region--GENERIC 1TYPED PARAMETER--
    // sample generic class na may 1 type parameter
    public class SampleGeneric<T>     // T is placeholder
        where T : TagaCompute, new() // Where T is tagaCompute - so All inherited  and ovveride methdod ng tagaCompute is accesible - new() means we can instatiate it
    {
        public void Process(int num1 , int num2)
        {
            T t = new T(); //Instantiation of T or TagaComputeClass(Which Have access to its childClass members)
            t.compute(num1 , num2); 
            Console.WriteLine($"Compute {t.result}");
            Console.WriteLine("");
        }
      
    }
    #endregion

    #region--GENERIC MULTITYPED PARAMETER--
    // sample generic na may multiple type of paramater
    public class SampleMultiType<T1, T2>  // 2 parameters
        where T1 : TagaCompute, new()
        where T2:  SampleGeneric<tagaMinus>, new() // can reference other class as parameter so we can Access its members
    {
        public void startexecute(int num1, int num2)
        {
            T1 t1 = new T1();
            T2 t2 = new T2();

            t1.compute(num1, num2);
            Console.WriteLine($"Compute T1 result: {t1.result}");

            Console.Write("T2 result: ");
            t2.Process(num1, num2);
            
        }
    }
    #endregion
}
