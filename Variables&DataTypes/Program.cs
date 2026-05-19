// ======================================================
// VARIABLES AND DATATYPES LESSON
// ======================================================

/*
    VARIABLES
    - Containers for storing data values.
    - They have a name and datatype.

    DATATYPES
    - Define what kind of value a variable can store.

    COMMON DATATYPES
    int     -> whole numbers
    string  -> text
    double  -> decimal numbers
    bool    -> true or false
    char    -> single character
*/

using System;
using System.Security.Cryptography;

namespace VariablesAndDatatypes
{
    class Program
    {
        static void Main(String[] args)
        {
            #region ================= LOCAL VARIABLES =================

            // LOCAL VARIABLES

            int explicitVariable = 22; // EXPLICITLY TYPED VARIABLE

            var varVariable = 22; // IMPLICITLY TYPED VARIABLE

            /*
             - Implicitly typed kasi hindi natin direktang sinabi ang type.
             Inalam nalang ng compiler na int yung base sa value na 22.
             di na sya pwede bigyan ng ibang type ng value, kasi once na na-assign siya as int, int na siya forever.
            */

            // (varVariable = "Hello World";)
            // error kasi hindi pwede mag-assign ng string sa varVariable na
            // na-assign na as int before. since declared na sya as int nung una;

            dynamic dynamicVariable = 22; // DYNAMIC VARIABLE

            /*
             - Dynamic kasi pwedeng magbago ang type ng value habang runtime.
              Halimbawa, pwede muna siyang int tapos maging string later.
              Unlike sa var na once na-assign as int, hindi na pwedeng magbago ng type.
            */

            dynamicVariable = "Hello World";
            // dynamicVariable dataType changed from int to string,
            // kaya walang error dito.

            Console.WriteLine(
                "This is implicit variable declaration: "
                + explicitVariable
            );

            Console.WriteLine(
                "This is explicit variable using var declartion: "
                + varVariable
            );

            Console.WriteLine(
                "This is expliit variable using dynamic declaration: "
                + dynamicVariable
            );

            #endregion

            #region ================= OBJECT INSTANTIATION =================

            // instantiatating an object of the class scopeofVariables
            // to access its members

            scopeofVariables obj = new scopeofVariables();

            #endregion

            #region ================= INSTANCE METHODS =================

            // accessing methods through the object obj

            obj.sampleMethod1();
            obj.sampleMethod2();

            #endregion

            #region ================= STATIC MEMBERS =================

            // accessing static method directly through the class name
            // without creating an instance of the class

            scopeofVariables.sampleStaticMethod();

            // modifying static variable directly through class name

            scopeofVariables.sampleStaticVariable = 50;

            // accessing static variable directly through class name

            Console.WriteLine(
                "Accessing static variable directly through class name: "
                + scopeofVariables.sampleStaticVariable
            );

            #endregion

            #region ================= READONLY VARIABLES =================

            // accesing readOnly through contructor

            obj.showReadonlyVariables();

            #endregion

            #region ================= CONSTRUCTOR EXAMPLE =================

            // creating an object of MathOperation class and using its constructor
            // to initialize num1 and num2, then calling the Add method
            // to perform addition and display the result

            MathOperation mathObj = new MathOperation(10, 20);

            int result = mathObj.Add();

            Console.WriteLine(
                "result of math addition using constructor:"
                + result
            );

            #endregion

            #region ================PARSE & CONVERT ===============    

            // PARSE and CONVERT

            //PARSE -   converting string to int using Parse method and using it in a calculation hindi nag acccept ng null value, so dapat siguraduhin na may laman yung string
            string textOne = "3";
            var intOne = int.Parse(textOne); // converting string to int using Parse method
            int parseResult = intOne * 5; // using the converted int value in a calculation
            Console.WriteLine( "Result of parsing string to int and multiplying by 5: " + parseResult);


            // TRYPARSE - alternative way to convert string to int using TryParse method, which returns a boolean indicating whether the conversion was successful or not, and outputs the converted value through an out parameter. pwede mag accept ng null value since hindi sya nag throw ng exception kapag hindi valid yung string, instead nag return lang sya ng false.
            String textTwo = "abc"; // invalid string that cannot be converted to int
            int intTwo;
            int tryParseResult = int.TryParse(textTwo, out intTwo) ? intTwo : 0; // using TryParse to attempt conversion and providing a default value of 0 if conversion fails
            Console.WriteLine("Result of trying to parse invalid string to int using TryParse: " + tryParseResult);

           
            String textThree = ":)";
            int intThree;
            if(int.TryParse(textThree, out intThree))
            {

                Console.WriteLine("The result of the TryParse String to int is: " + intThree);
            }
            else
            {
                Console.WriteLine($"INVALID PARSING!!! Hindi naman number yung {textThree} ah");

            };




            //CONVERT - alternative way to convert string to int using Convert class pwede mag aceppt ng null value unlike sa Parse na hindi pwede mag accept ng null value, so mas safe gamitin yung Convert class
            string textFour = "5"; // pwede rin to as null since nag accept
            var intConvert =Convert.ToInt32(textFour); // converting string to int using Convert class
            int parseResult2 =  intConvert + 10; // using the converted int value in a calculation
            Console.WriteLine("Result of converting string to int and adding 10: " + parseResult2);



            // TOSTRING - converting int to string using ToString method and using it in a concatenation
            int number = 10;
            var stringNumber = number.ToString(); // converting int     to string using ToString method
            string resultString = stringNumber; // using the converted string in a concatenation
            Console.WriteLine("Conversion of int to string using ToString(): " + resultString);



            #endregion
        }
    }

    /* TOPIC: SCOPE OF VARIABLES
     - Local variables are declared within a method and can only be used within that method.
     They are created when the method is called and destroyed when the method exits.
     Local variables must be initialized before they are used.

     - They are typically used to store temporary data that is needed only within
     the scope of a method, such as loop counters, intermediate results,
     or temporary values for calculations.

     - Local variables cannot be accessed outside of the method in which they are declared,
     and they do not retain their values between method calls.
     */

    #region -- demonstrating scope of variables --
    public class scopeofVariables
    {
        #region ================= CLASS LEVEL VARIABLES =================
        // class level variable (instance/object variable)

        dynamic classLevelVariable = "I am a class level variable";
        // class level variable - accessible to all methods
        // within the class. global variable
        int sampleInstanceVariable = 10; // another class level variable or instance object variable

        #endregion

        #region ================= STATIC VARIABLES =================

        public static int sampleStaticVariable = 20;
        // static variable - belongs to the class itself and is shared
        // among all instances of the class.
        // It can be accessed without creating an instance of the class.

        #endregion

        #region ================= READONLY VARIABLES =================

        readonly long sampleReadonlyVariable1 = 2220;
        // readonly variable - can only be assigned a value during declaration or in a constructor.
        // Once assigned, its value cannot be changed.
        readonly long sampleReadonlyVariable2;
        // readonly variable without initialization, can only be assigned a value in the constructor

        #endregion

        #region ================= CONSTANT VARIABLES =================

        const float mathPi = 3.14f;
        // constant variable - must be initialized at the time of declaration and cannot be modified later in the code.
        // It is implicitly static, so it belongs to the class , and can be accessed without creating an instance of the class.

        #endregion

        #region ================= NORMAL VARIABLES =================

        int num1;
        int num2;

        #endregion

        #region ================= CONSTRUCTOR =================

        // CONSTRUCTOR
        // special method that is called when an object of the class is created.
        // It is used to initialize the object's state and can also be used to assign values to readonly variables.

        public scopeofVariables()
        {
            sampleReadonlyVariable2 = 100;

            // assigning value to readonly field in constructor
            // (valid ONLY if not yet initialized at declaration)

            // sampleReadonlyVariable1 = 200;

            // ERROR:
            // readonly field can only be assigned once
            // (either at declaration OR in constructor), not both
        }

        #endregion

        #region ================= METHODS =================

        public void showReadonlyVariables()
        {
            Console.WriteLine("Readonly variable 1: " + sampleReadonlyVariable1);
            Console.WriteLine("Readonly variable 2: " + sampleReadonlyVariable2);
        }

        public void sampleMethod1()
        {
            #region ----- LOCAL VARIABLES -----

            int localVariable1 = 10;
            // local variable declared within sampleMethod1
            Console.WriteLine("This is local variable in sampleMethod1: " + localVariable1);

            #endregion

            #region ----- CLASS LEVEL VARIABLES -----

            classLevelVariable = "I can be accessed and modified in sampleMethod1";
            // class level variable can be accessed and modified within sampleMethod1
            Console.WriteLine("This is class level variable in sampleMethod1: " + classLevelVariable);

            #endregion

            #region ----- CONSTANT VARIABLES -----

            // mathPi = 3.14159f;

            // error, since mathPi is a constant variable
            // and cannot be modified after it has been assigned
            // a value at declaration.

            // Constant variables are immutable and their values
            // cannot be changed once set.
            // Even in constrctor bawal
            Console.WriteLine("This is constant variable cannot be change once declared: " + mathPi);

            #endregion
        }

        public void sampleMethod2()
        {
            #region ----- LOCAL VARIABLES -----

            int localVariable2 = 10;

            Console.WriteLine(
                "This is local variable in sampleMethod2: "
                + localVariable2
            );

            #endregion

            #region ----- CLASS LEVEL VARIABLES -----

            classLevelVariable = "I can be accessed and modified in sampleMethod2";

            // class level variable can be accessed and modified
            // within sampleMethod2

            Console.WriteLine(
                "This is class level variable in sampleMethod2: "
                + classLevelVariable
            );

            #endregion

            #region ----- INVALID ACCESS EXAMPLE -----

            // (localVariable1 = 10;)

            // error, since localVariable1 is declared in sampleMethod1
            // and cannot be accessed in sampleMethod2.

            // Local variables are only accessible within the method
            // they are declared in.

            #endregion
        }

        /*
           KEYWORDS

          STATIC - used to declare a member that belongs to the type itself
           rather than to a specific object.

           Static members can be accessed without creating an instance
           of the class.

          READONLY
           - used to declare a field that can only be assigned a value
           during its declaration or in a constructor.

           Once assigned, the value of a readonly field cannot be changed.

          CONST
           - used to declare a constant field or local variable.

           A constant is a value that cannot be changed after it is assigned.

           Constants must be initialized at the time of declaration
           and cannot be modified later in the code.
        */

        public static void sampleStaticMethod()
        {
            #region ----- INVALID ACCESS -----

            // ERROR FIXED:
            // cannot access instance/object based variable in static method
            // sampleInstanceVariable = 0;

            #endregion

            #region ----- INSTANCE/OBJECT ACCESS INSIDE STATIC METHOD -----

            // you can still accessed instance variable(not static ones)
            // and non static methods here basta gawa ka ng object first
            // or mag instanciate ka ng object

            scopeofVariables obj = new scopeofVariables();

            Console.WriteLine(
                "Accessing instance variable in static method: "
                + obj.sampleInstanceVariable
            );

            // accessing instance variable through an object

            #endregion

            #region ----- STATIC ACCESS -----

            sampleStaticVariable = 30;

            // static variable can be accessed and modified
            // within a static method

            Console.WriteLine(
                "Accesing directly the static variable: "
                + sampleStaticVariable
            );

            #endregion
        }

        #endregion
    }

    public class MathOperation
    {
        #region ================= VARIABLES =================

        public int num1;
        public int num2;

        #endregion

        #region ================= CONSTRUCTOR =================

        // CONSTRUCTOR
        public MathOperation(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        #endregion

        #region ================= MATH METHODS =================

        // MATH OPERATIONS METHODS

        public int Add()
        {
            return num1 + num2;
        }

        #endregion
    }

    #endregion
}