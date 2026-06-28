using System;
using System.Collections.Generic;
using System.Text;

namespace Debugging__Error_Handling_and_Unit_Test
{
    public class SampleComputation
    {
            
        public int Compute(int num1, int num2, SampleOperator op)
        {
            switch (op)
            {
                case SampleOperator.Add: return num1 + num2;
                case SampleOperator.Subtract: return num1 - num2;
                case SampleOperator.Divide:
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException();
                    }

                    return num1 / num2;
            }
            return 0;
        }


        public enum SampleOperator
        {
            Add,
            Subtract,
            Divide,
            Multiply
        }
    }
}
