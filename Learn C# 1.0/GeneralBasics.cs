using System; // ginagamit para ma-access ang Console at ibang basic tools

namespace Learn_Csharp // group/folder ng code para organized
{
    class HelloWorld // class na naglalaman ng program
    {
        static void Main(String[] args) // dito nagsisimula ang program
        {
            // VARIABLE DECLARATIONS
            string fullName ="Sean Chandrick Sta Ana"; 
            int age = 21; 
            string course = "Bachelor of Science in Computer Science";
            int student_Id = 22 - 0019;

            // variables for math operation
            int num1 = 5; 
            int num2 = 5;

            // PRINTING OUTPUT
            Console.WriteLine("Hello World"); 
            Console.WriteLine("My Age is " + age);
            Console.WriteLine("My Full Name is " + fullName);
            Console.WriteLine("My Course is " + course);
            Console.WriteLine("My Student ID is " + student_Id);
            Console.WriteLine(10 + 10); // DIRECT MATH OPERATION

            Console.WriteLine(num1 + num2); // USING VARIABLES FOR MATH OPERATIONS CONCAT 

            Console.WriteLine("My name is " + fullName + " I am " + age + "years old"); // CONCATENATION - PAGSAMA NG MGA STRING AT VARIABLES

        }  
    }
}