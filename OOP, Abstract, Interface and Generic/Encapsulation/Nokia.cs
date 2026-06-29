using System;
using System.Collections.Generic;
using System.Text;

namespace OOP__Abstract__Interface_and_Generic.Encapsulation
{
    public class Nokia: MobilePhone
    {
        private MobilePhoneInfo _mobilePhoneInfo;
      
        //CONSTRUCTOR
        public Nokia(MobilePhoneInfo mobilePhoneInfo){
            _mobilePhoneInfo = mobilePhoneInfo;
        }

        public void run()
        {
            PowerOn(_mobilePhoneInfo);
        }
       
    }
}
