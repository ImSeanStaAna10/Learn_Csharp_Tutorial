using System;
using System.Collections.Generic;
using System.Text;

namespace OOP__Abstract__Interface_and_Generic.Polymorphism
{
    public class SampleOperation
    {
        public void Process()
        {
            TagaCompute add = new tagaAdd();
            add.compute(5, 5);
            Console.WriteLine($"{add.result}");
                        
            var addWith10 = new tagaAddWith10();
            TagaCompute tagaCompute = addWith10;
            tagaCompute.compute(1,2);
            Console.WriteLine($"Add: {tagaCompute.result}");


        }
    }

    public class tagaAdd : TagaCompute { }
    public class tagaMinus: TagaCompute {
        public override void compute(int num1, int num2) // inooveride naten yung compute method sa base class naten
        {
            _result = num1 - num2;
        }

    }

    public class tagaMultiply: TagaCompute
    {
        public override void compute(int num1, int num2)
        {
           _result = num1 * num2;
        }
    }

    public class tagaDivide : TagaCompute {

        public override void compute(int num1, int num2)
        {
            if ((num1 / num2) == 0)
            {
                _result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Cannot Divide to 0");
                
            }

        }
    }

    public class tagaAddWith10 : TagaCompute {

        public override void compute(int num1, int num2)
        {
            num1 += 10;
            num2 += 10;

            base.compute(num1, num2);
        }
    }
}
