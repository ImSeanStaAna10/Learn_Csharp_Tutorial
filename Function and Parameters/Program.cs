
// FUNCTION - code of block that contains a series of statements A program causes statements to be executed by calling methods

using System.Reflection.Metadata.Ecma335;
using System.Linq;

namespace Function_and_Parameters
{

     class Program
    {
        // main entry point
        static void Main(string[] args)
        {
            var program = new Program();

            #region -- INITIAL CODING --
            program.PrintName();

            program.PrintNameWithParameters("Sean");
            program.PrintNameWithAge("Chandrick", 22);

            #endregion

            #region -- FUNCTION , VOID, WITH PARAMETERS

            // using params
            program.PrintParams("Params" , "2", "3", "4" ); // maraming arguments

            // using optional params
            program.ProcessNumbers(2);
            Console.WriteLine("***************");
            program.ProcessNumbers(5, num2: 3);
            Console.WriteLine("*************");
            program.ProcessNumbers(7, myName: "Seansaints");


            // using shortHand function
            program.ShortHandFunction("SeanPogi");
            // statuc shorthandFunction
            Program.shortHandStatic("ChandrickPogi");

            #endregion

            #region -- FUNCTION WITH RETURN
            // function with return
            var result = program.AddTwoNumbers(5,5);
            Console.WriteLine(result);

            // with return
            Console.WriteLine($"SAMPLE RESULT: {program.AddNumbers(5, Operator.Add , 2,3,4)}");

            // Void function with return
            program.ReturnRightAwaySample(0);

            #endregion

            #region -- Using Ref Keyword --
            var string1 = "Demo";
            var string2 = "Demo";

            program.ModifyText(ref string2); // it reference string2 as argument that references the parameters
            Console.WriteLine($"{string1} {string2}");
            #endregion

            #region -- USING OUT KEYWORD --
            string errorMessage;
            var result1 = program.Process(10 , 0 , out errorMessage);
            if (string.IsNullOrEmpty(errorMessage))
            {
                Console.WriteLine(result1);
            }
            else
            {
                Console.WriteLine(errorMessage);
            }

            #endregion

            #region -- RECURSIVE FUNCTION --
            //factorial of 3 = 3 * 2 * 1
            Console.WriteLine($"Factorial of 3: {program.sampleFactorial(3)}");
            //Factorial of 5 = 5 * 4 * 3 * 2 * 1
            Console.WriteLine($"Factorial of 5: {program.sampleFactorial(5)}");
            #endregion

        }

        #region -- FOR INITIAL CODING -- 
        //Void without parameter
        public void PrintName()
        {
            Console.WriteLine($"using PrintName()");
            var name = "any name";
            Console.WriteLine($"NAME: {name}");
        }

        //Funtions with parameters
        public void PrintNameWithParameters(string Name)
        {
            Console.WriteLine("Using PrintNameWithParamaeters (string Name): ");
            Console.WriteLine($"Name: {Name}");
        }

        public void PrintNameWithAge(string Name, int Age)
        {
            Console.WriteLine("PRINT NAME WITH AGE: ");
            Console.WriteLine($"Name: {Name}, Age{Age}");
        }

        #endregion

        #region -- PARAMS KEYWORD --
        // Using params keyword - ginagamit kapag gusto mong tumanggap ng maraming arguments sa isang parameter
        public void PrintParams( params string[] numbers)
        {
           
            Console.WriteLine($"This is using {numbers[0]} example: ");
            Console.WriteLine(string.Join(", " , numbers));
        }

        #endregion

        #region -- optional params with default --

        //OPTIONAL
        public void ProcessNumbers(int num1, int? num2 = null, string myName = "Sean Sta Ana")
        {
            
            Console.WriteLine($"Number 1: {num1} , Number 2: {(num2.HasValue ? num2.Value : string.Empty)}");
            Console.WriteLine($"Name: {myName}");
        }

        #endregion

        #region -- SHORTHAND FUNCTIONS -- 
        public void ShortHandFunction(string sampName) => Console.WriteLine($"I am {sampName} and This is a shorthand Function");

        public static void shortHandStatic(string sampName2) => Console.WriteLine($"I am {sampName2} and this is a static shortHand Fucntion");
        #endregion

        #region -- FUNCTION WITH RETURN --
        public int AddTwoNumbers(int value1, int value2)
        {
            Console.WriteLine($"{value1} + {value2}");
            return value1 + value2; 
        }

        // sample 2
        public int AddNumbers(int num1, Operator op = Operator.Add, params int[] otherNumbers)
        {
            var sumOfOtherNumber = otherNumbers.Sum();
            switch (op)
            {
                case Operator.Add: return num1 + sumOfOtherNumber;
                case Operator.Subtract: return num1 - sumOfOtherNumber;
                case Operator.Multiply: return num1 * sumOfOtherNumber;
                case Operator.Divide: return num1 / sumOfOtherNumber;
                default: return 0;
            }
        }

        public enum Operator
        {
            Add,
            Subtract,
            Multiply,
            Divide,
        }


        #endregion

        #region -- VOID FUNCTION THAT HAS RETURN --
        public void ReturnRightAwaySample(int num)
        {
            Console.WriteLine("Start Processs...");
            if (num == 0)
            {
                Console.WriteLine("Terminating process...");
                return;
            }
            Console.WriteLine($"End Process for {num}");
        }

        #endregion

        #region -- REF AND OUT -- 
        // ref = dapat may value na ang variable bago ipasa
        // out = hindi kailangan may value ang variable, pero dapat lagyan ng value sa loob ng method
        #region-- REF KEYWORD/PARAMETER --
        // ref = passes a variable by reference, allowing the method to modify the original value

        public void ModifyText(ref string demo)
        {
            demo = "New";
        }
        #endregion

        #region -- OUT KEYWORD/PARAMETER --
        // out = used when a method needs to return multiple values
        public int Process(int a, int b, out string messages)
        {
            messages = null;
            if (b == 0 )
            {
                messages = "Cannot Divide by 0";
                return 0;
            }
            return a / b;
        }
        #endregion
        #endregion

        #region -- RECURSIVE FUNCTION --
        // recursive - Ang recursive function ay function na tinutawag ang sarili niya para ulit-ulitin ang process hanggang sa maabot ang base condition.
        public int sampleFactorial(int number)
        {
            if (number == 1)
            {
                return number;
            }
            return number * sampleFactorial(number - 1);
        }
        #endregion
    }
}
