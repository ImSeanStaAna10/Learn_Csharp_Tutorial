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
            
            //NORMAL INSTANTIATON
            var pdf = new PDF();
            var word = new WORD();
            //ASBTRACTED document class and inherited by its subclass
            pdf.Process();
            word.Print();




            #endregion

            #region--INTERFACE--
            //UPCASTING nirereference natin yung base class na Document means maacess lang natin yung members/method ng class nato
            Document pdfDoc = new PDF();
            Document wordDoc = new WORD();
            pdfDoc.Print();
            wordDoc.Print();


            //NORMAL INSTANTIATION
            var excel = new Excel();
            excel.Process();

            //UPCASTING
            IDokumento document = new Excel();
            document.Process();


            WORD newWord = new WORD();
            newWord.Process();
            newWord.Print();

            //UPCASTING
            IDoc1 document1 = new newDocument();
            document1.sayName();

            //UPCASTING
            newDocument bagongDocument = new newDocument();
            Console.WriteLine("Example instantiation newDocument class");
            bagongDocument.Print();
            bagongDocument.sayName();

            Console.WriteLine();
            #endregion


            #endregion

            #region--GENERIC--
            Console.WriteLine("GENERIC....");

            Console.WriteLine("Generic with 1type parameter");
            var processor = new SampleGeneric<tagaAdd>(); // yung T now is  tagaAdd which is childClass ng TagaCompute baseclass natin
            processor.Process(5, 5);

            var procesor = new SampleGeneric<tagaMinus>();
            processor.Process(5, 5);

            Console.WriteLine("Generic With MultipleTypes of paramater");
            var newProcessor = new SampleMultiType<tagaAdd, SampleGeneric<tagaMinus>>();
            newProcessor.startexecute(10, 5);

            #endregion
        }
    }
}
