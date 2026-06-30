using System;
using System.Collections.Generic;
using System.Text;

namespace OOP__Abstract__Interface_and_Generic.Polymorphism
{
   public abstract class TagaCompute
    {

        private string _secureData; // accesible only within this class encapsulated fields
        protected int _result; // protected - accesible only within this class and those who inherited this

        public int result
        {
            get
            {
                return _result;
            }
        }

        // virtual - hinhayaan neto na ma ovveride sa mga subclass tong method na to 
        public virtual void compute(int num1, int num2)
        {
            _result = num1 + num2;
        }

    }
}
