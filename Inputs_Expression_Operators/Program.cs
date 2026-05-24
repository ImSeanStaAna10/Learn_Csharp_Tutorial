using System;
using System.Security.Cryptography.X509Certificates;

// =============================
// INPUT, EXPRESSION, OUTPUT, OPERATORS
// =============================

/*
INPUT
- Input is data that the program receives from the user or external sources.
- In C#, common input methods are:
  Console.Read()     -> reads one character (returns ASCII/Unicode value)
  Console.ReadLine() -> reads a full line of text entered by the user

Example:
string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());


EXPRESSION
- An expression is a combination of variables, values, and operators that produces a result.
- Expressions can be mathematical, logical, or string-based.

Examples:
int sum = 5 + 3;              // arithmetic/literal expression
bool result = age >= 18;      // logical expression
string full = first + last;   // string expression
int result = 2 + (4 * 2);     // compound expression
const double PI = 3.14;       // constant expression
Console.WriteLine($"The value of PI is {PI}"); // interpolated expression
Console.WriteLine("The value of PI is " + PI); // concatenated expression
Console.WriteLne();          // empty/void expression walang return value
Math.Pow(2, 3);              // Primary expression



OUTPUT
- Output is the result displayed by the program to the user.
- In C#, output is commonly done using:
  Console.WriteLine() -> prints text with a new line
  Console.Write()     -> prints text without a new line

Example:
Console.WriteLine("Hello World");


OPERATORS
- Operators are symbols used to perform operations on values or variables.

Types of Operators:

1. Arithmetic Operators:
   +  (addition)
   -  (subtraction)
   *  (multiplication)
   /  (division)
   %  (modulus / remainder)

2. Comparison Operators:
   == (equal to)
   != (not equal to)
   >  (greater than)
   <  (less than)
   >= (greater than or equal to)
   <= (less than or equal to)

3. Logical Operators:
   && (AND)
   || (OR)
   !  (NOT)

4. null-coalescing operator:
   ?? (returns the left-hand operand if it is not null; otherwise, it returns the right-hand operand)

5. Ternary operator:
   ?: (a shorthand for if-else statements) 
    () condition ? expressionIfTrue : expressionIfFalse

6. Assignment operators:
   =  (assignment)
   += (add and assign)
   -= (subtract and assign)
   *= (multiply and assign)
   /= (divide and assign)
   %= (modulus and assign)

7. unary operators:
   ++ (increment)
   -- (decrement)

8. equality operators:
   is (type checking)
   as (type conversion)


Example:
if (age >= 18 && age <= 60)
{
    Console.WriteLine("Working Age");
}
*/

namespace Inputs_Expressions_Operators
{
    class Program
    {
        public static void Main(String[] args) 
        {

            #region -- INPUTS --
            #region --WRITE/WRITELIINE--

            Console.WriteLine("****** THIS IS WRITE/WRITELINE *********");
            Console.Write("HELLO WORLD\n");
            Console.Write($"a{Environment.NewLine}"); // new line
            Console.Write("b\n"); // newLine
            Console.WriteLine("c"); // new line
            Console.WriteLine("d"); // new line
            #endregion

            #region --READLINE--
            Console.WriteLine("****** THIS IS READLINE *********");
            Console.Write("Type anything here: ");
            var stringValue = Console.ReadLine();
            Console.WriteLine("The displayed value is " + stringValue);
            #endregion

            #region --READ--
            Console.WriteLine("****** READ ********");
            Console.Write("\n");
            //Console.WriteLine("****** EXAMPLE -  1********");
            //Console.Write("Type anythng here: ");
            //var stringValue2 = Console.Read(); // READ -  reads one character only. and returns he ASCII/Unicode number of the character.
            //Console.WriteLine("Displayed valuue using Read: " + stringValue2);
            //Console.Write("\n");
            #endregion

            #endregion

            #region --EXPRESSIONS & OPERATORS--
            #region -- ASSIGNMENT OPERATORS--
            var a = 10;
            a = 20; // assignment operator
            Console.WriteLine("Assignment Operator: " + a);
            #endregion

            Console.Write("*********** ARITHMETIC OPERATORS *********************\n");
            #region --ARITHMETIC OPERATORS--
            // ADDITION
            var add1 = 10;
            var add2 = 5;
            var add1and2result = add1 + add2; // addition operator
            add1and2result = add1 + add2 + 15; // compound expression
            Console.WriteLine("Addition Operator: " + add1and2result);


            // SUBTRACTION
            var sub1 = 10;
            var sub2 = 5;
            var sub1and2result = sub1 - sub2; // subtraction operator
            var sub1and2result2 = sub1 - sub2 - 3; // compound expression
            Console.WriteLine("Subtraction Operator: " + sub1and2result);

            // MULTIPLICATION
            var mul1 = 10;
            var mul2 = 5;
            var mul1and2result = mul1 * mul2; // multiplication operator
            mul1and2result = mul1 * mul2 * 2; // compound expression
            Console.WriteLine("Multiplication Opeator ");

            // DIVISION
            var div1 = 10;
            var div2 = 5;
            var div1and2result = div1 / div2; // division operator
            div1and2result = div1 / div2 / 2; // compound expression
            Console.WriteLine("Division Operator: " + div1and2result);

            // MODULUS
            var mod1 = 10;
            var mod2 = 3;
            var mod1and2result = mod1 % mod2; // modulus operator
            Console.WriteLine("Modulus Operator: " + mod1and2result);

            // precedence of operations - () , [] , ++ , --, * , / , % , + , -

            Console.Write("Precedence Example 1\n");
            var samplePrecedence = 10 + 5 * 2; // multiplication has higher precedence than addition
            Console.WriteLine("Precedence of Operations (10 + 5 * 2): " + samplePrecedence); // expected output is 20 not 30

            Console.Write("Precedence Example 2\n");
            var samplePrecedence2 = (10 + 5) * 2; // parentheses has higher precedence than multiplication
            Console.WriteLine("Precedence of Operations ((10 + 5) * 2): " + samplePrecedence2); // expected output is 30 not 20

            Console.Write("\n");



            #endregion
            Console.Write("*********** BOOLEAN, COMPARISON, EQUALITY OPERATORS *********************\n");
            #region --BOOLEAN , COMPARISON , EQUALITY OPERATORS--
            var isTrue = true;
            var isFalse = false;

            var andResult = isTrue && isFalse; // AND operator - returns true if both operands are true
            var orResult = isTrue || isFalse; // OR operator - returns true if at least one operand is true

            // EQUALITY OPERATORS
            var eq1 = 10;
            var eq2 = 20;

            // COMPARISON OPERATORS
            var testEqual = eq1 == eq2; // EQUAL TO operator - returns true if both operands are equal
            var testNotequal = eq1 != eq2; // NOT EQUAL TO operator - returns true if both operands are not equal

            // <, >, <=, >=
            var testGreaterThan = eq1 > eq2; // GREATER THAN operator - returns true if the left operand is greater than the right operand
            var testLessThan = eq1 < eq2; // LESS THAN operator - returns true if the left operand is less than the right operand

            var testGreaterThanOrEqual = eq1 >= eq2; // GREATER THAN OR EQUAL TO operator - returns true if the left operand is greater than or equal to the right operand
            var testLessThanOrEqual = eq1 <= eq2; // LESS THAN OR EQUAL TO operator - returns true if the left operand is less than or equal to the right operand

            #endregion
            Console.Write("*********** COALESCING OPERATOR *********************\n");
            #region -- COALESCING OPERATOR -- 
            Console.Write("*********** COALESCING OPERATOR *********************\n");
            var sampleString= "HELLO WORLD";
            string nullString = null;
            var sampleResult1 = sampleString ?? "ANO TARA??";
            var sampleResult2 = nullString ?? "ANO TARA"; // null-coalescing operator - returns the left-hand operand if it is not null; otherwise, it returns the right-hand operand
            Console.WriteLine("Coalescing Operator Example 1: " + sampleResult1);
            Console.WriteLine("Coalescing Operator Example 2: " + sampleResult2);

          

            #endregion
            Console.Write("*********** UNARY OPERATOR *********************\n");
            #region -- UNARY OPERATORS --
            Console.WriteLine("****************** UNARY OPERATORS");
            var trueValue = true;
            trueValue = !trueValue; // NOT operator - returns the opposite of the boolean value
            Console.WriteLine("Unary NOT ! Operator: " + trueValue);

            var numberIncrementDecrement = 10;

            Console.WriteLine("**************** ORIGINAL VALUE **********************");
            Console.WriteLine("Original Value: " + numberIncrementDecrement);
            // Expected: 10

            Console.WriteLine("\n**************** POST INCREMENT **********************");
            Console.WriteLine("Postfix Increment (number++): " + numberIncrementDecrement++);
            // Expected printed: 10 (then value becomes 11)

            Console.WriteLine("Value after Post Increment: " + numberIncrementDecrement);
            // Expected: 11

            Console.WriteLine("\n**************** PRE INCREMENT **********************");
            Console.WriteLine("Prefix Increment (++number): " + ++numberIncrementDecrement);
            // Expected: 12 (11 becomes 12 first)

            Console.WriteLine("Value after Pre Increment: " + numberIncrementDecrement);
            // Expected: 12

            Console.WriteLine("\n**************** POST DECREMENT **********************");
            Console.WriteLine("Postfix Decrement (number--): " + numberIncrementDecrement--);
            // Expected printed: 12 (then becomes 11)

            Console.WriteLine("Value after Post Decrement: " + numberIncrementDecrement);
            // Expected: 11

            Console.WriteLine("\n**************** PRE DECREMENT **********************");
            Console.WriteLine("Prefix Decrement (--number): " + --numberIncrementDecrement);
            // Expected: 10 (11 becomes 10 first)

            Console.WriteLine("Final Value: " + numberIncrementDecrement);
            // Expected: 10




            #endregion
            Console.Write("*********** TERNARY OPERATOR *********************\n");
            #region -- TERNARY OPERATOR --

            Console.WriteLine("*********** TERNARY OPERATOR *********************\n");
            Console.WriteLine("*********** EXAMPLE 1 *********************\n");
            var reqScore = 75;
            var score = 95;
            Console.Write("Enter your name:  ");
            var PNLEstudent = Console.ReadLine();
            Console.Write("Enter your studenId: ");
            var studentIdInput = Console.ReadLine();
            var studentPersonalIdNumber =  int.Parse(studentIdInput);
            var studentId = 22247;
            var messageTernary = (PNLEstudent !=null && score >= reqScore && studentPersonalIdNumber == studentId)
             ?$"Congratulations {PNLEstudent}!! You passed the PNLE with a scoore of {score} and your student ID is {studentId}!!" 
             :$"Sorry Please try again";
            Console.WriteLine("\n");
            Console.WriteLine(messageTernary);
            Console.WriteLine("\n");

            Console.WriteLine("*********** EXAMPLE 2 *********************\n");
            var myName = "Sean";
            var result = (myName == "Sean") ? $"Hi{myName}" : "????UNKNOWN???";
            Console.WriteLine(result);
            Console.WriteLine("\n");
            #endregion


            Console.Write("*********** SAMPLE ACTIVITY *********************\n");
            #region --EXAMPLE ACT 1--
            Console.WriteLine("****** EXAMPLE ********");

            Console.Write("Enter your age here: ");
            var ageString = Console.ReadLine(); // EXAMPLE 22                        
            var ageRequirement = 18;

            if (int.TryParse(ageString, out int age)) // TryParse - returns a boolean indicating success or failure of parsing, and outputs the parsed value through an out parameter.
            {

                Console.WriteLine("**************** NORMAL CONDITIONAL STATEMENT EXAMPLE **********************");
                Console.WriteLine("\n");
                Console.WriteLine("(ADULTS SYSTEM 18+) - Only ADULTS are Allowed: ");
                if (age >= ageRequirement) // GRETER THAN OR EQUAL TO - condition
                {
                    Console.WriteLine($"Your age is {age} greater than or equal to  {ageRequirement} ,  and your are an Adult and you are ALLOWED!!");
                }
                else
                {
                    Console.WriteLine($"Your age is {age} less than {ageRequirement} ,  and you are a Minor and you are NOT ALLOWED!!!");
                }

                Console.WriteLine("\n");
                Console.WriteLine("**************** USING TERNARY OEPRATOR IN COND STATEMENT **********************");
                Console.WriteLine("\n");
                Console.WriteLine("(MINOR SYSTEM 18-) - Only Minors are Allowed: ");
                string message = (age < ageRequirement) // LESS THAN 
                ? $"Your age is {age} less than {ageRequirement}, and you are an Minor and you are ALLOWED!!" // true part
                : $"Your age is {age} greater than {ageRequirement}, and you are Adult and you are NOT ALLOWED!!!"; // false part 
                Console.WriteLine(message);

            }
            else
            {
                Console.Write("INVALID!! please enter a valid input\n");
            }

            #endregion

            #endregion


        }
    }
}