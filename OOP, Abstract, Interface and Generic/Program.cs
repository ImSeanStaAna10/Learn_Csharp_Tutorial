using OOP__Abstract__Interface_and_Generic.Abstraction;
using OOP__Abstract__Interface_and_Generic.Abstraction_VS_Interface;
using OOP__Abstract__Interface_and_Generic.Encapsulation;
using OOP__Abstract__Interface_and_Generic.Generic;
using OOP__Abstract__Interface_and_Generic.Polymorphism;


namespace OOP__Abstract__Interface_and_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region-- INHERITANCE & ABSTRATION
            Console.WriteLine("Student 1....");
            Student1 student1 = new Student1("Chandrick", true);
            student1.doThis();
            student1.SayName();

            Console.WriteLine();

            Console.WriteLine("STUDENT 2...");
            Student2 student2 = new Student2("Seean", false);
            student2.doThis();
            student2.SayName();
            Console.WriteLine();
            #endregion

            #region--ENCAPSULATION--
            Console.WriteLine("Encapsulation....");
            MobilePhoneInfo mobilePhoneInfo = new MobilePhoneInfo("S21", "Samsung", 2928);
            Nokia nokia = new Nokia(mobilePhoneInfo);
            nokia.PowerOn(mobilePhoneInfo);
            Console.WriteLine();
            #endregion

            #region--POLYMORPHISM--
            Console.WriteLine("POLYMORPHISM...");
            SampleOperation operation = new SampleOperation();
            operation.Process();
            Console.WriteLine();
            #endregion

            #region--ABSTRACT VS INTERFACE--

            Console.WriteLine("ABSTRACT VS INTERFACE");

            #region--ABSTRACT--
            var pdf = new PDF();
            var word = new WORD();
            Document pdfDoc = new PDF();
            Document wordDoc = new WORD();

            var excel = new Excel();
            IDokumento document = new Excel();
            document.Print();


            WORD newWord = new WORD();
            IDoc1 document1 = new newDocument();
            IDoc2 document2 = new newDocument();

            Console.WriteLine();


            #endregion




            #endregion

            #region--GENERIC--
            Console.WriteLine("GENERIC....");
            var processor = new SampleGeneric<tagaAdd>();
            processor.Process(5, 5);

            var procesor = new SampleGeneric<tagaMinus>();
            processor.Process(5, 5);

            #endregion
        }
    }
}
