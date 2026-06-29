using System;
using System.Collections.Generic;
using System.Text;

namespace OOP__Abstract__Interface_and_Generic.Encapsulation
{
     public struct MobilePhoneInfo
    {
        public string PhoneName { get; set; }
        public string BrandName { get; set; }
        public int YearRelease { get; set; }

        public MobilePhoneInfo(string phoneName , string brandName, int yearRelease )
        {
            PhoneName = phoneName;
            BrandName = brandName;
            YearRelease = yearRelease;
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"{PhoneName} , {BrandName}, {YearRelease}");
        }

    }
}
