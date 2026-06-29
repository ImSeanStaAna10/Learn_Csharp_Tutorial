using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP__Abstract__Interface_and_Generic.Encapsulation
{
    // ENCAPSULATION
    public abstract class MobilePhone
    {
        private string _microChip;  // encapsulated field accesbile within the class only
   
        public MobilePhone(string MicroChip = "SSD")
        {

            _microChip = MicroChip;
         

        }
        public void PowerOn(MobilePhoneInfo mobilePhoneInfo)
        {
            connectMainBoardToPwerSupply();
            openWifiChip();
            DisplayInfo(mobilePhoneInfo);
        }

        public void DisplayInfo(MobilePhoneInfo mobilePhoneINFO)
        {
            mobilePhoneINFO.DisplayInfo();
            Console.WriteLine(_microChip);
        }

        //encapsulated methods - accesible within the class
        private void connectMainBoardToPwerSupply() {
            Console.WriteLine();
            Console.WriteLine("Power Runnin.....");
        }
        private void openWifiChip() {
            Console.WriteLine("Opening Wifi....");

        }
    }
}
