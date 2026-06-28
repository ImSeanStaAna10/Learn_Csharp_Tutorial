using Debugging__Error_Handling_and_Unit_Test;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Debugging_Error_Handling_and_Unit_Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            // every exception may nag ti trigger na event so pwwede tayo mag subscribe using and event
            AppDomain.CurrentDomain.FirstChanceException += (sender, args) =>
            {
                if (args.Exception is WalangFirstNameException)
                {
                    Console.WriteLine("(From Event) nag ka error na walang FirstNameException");
                }
            };

            #region--DEBUGGING DEMO--
            
            var binary1 = "00001111"; // 15
            var binary2 = "01000001"; // 65

            var firstBits = GetBitValues(binary1);
            var secondBits = GetBitValues(binary2);

            Console.WriteLine("DEBUGGING DEMO: ");

            Console.WriteLine($"Binary1: {binary1}, {string.Join(",", firstBits)} = {firstBits.Sum()}");
            Console.WriteLine($"Binary2: {binary2}, {string.Join(",", secondBits)} = {secondBits.Sum()}");
            Console.WriteLine();

            #endregion

            #region--ERROR/EXCEPTION HANDLING DEMO --
            var number1 = 100;
            var number2 = 50;
            var number3 = 0;

            #region -- USING TRY CATCH FINALLY --
            Console.WriteLine("ERROR/EXCEPTION HANDLING DEMO: ");
            try
            {
                Console.WriteLine($"Addition result: {number1 + number2}");
                Console.WriteLine($"Division result: {number1 / number3}"); // cant divide by 0 so it errors
            }
            catch(DivideByZeroException ex) // more specific catch class message
            {
                Console.WriteLine("Hindi Pwede mag divide by zero");
            }

            catch(Exception ex) // base catch exception clas variable na nag hohold ng exception
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Yehey tapos na ang try catch");
            }

            #endregion

            #region -- USING CUSTOM EXCEPTION --
            Console.WriteLine("USING CUSTOM EXCEPTION ... EXAMPLE 1");
            string firstName = null;
            string LastName = "Sta Ana";

            try
            {
                
                if (string.IsNullOrWhiteSpace(firstName))
                    throw new WalangFirstNameException();

                Console.WriteLine(firstName.ToLower());
                Console.WriteLine(LastName.ToLower());
            }
            catch(WalangFirstNameException ex)
            {
                Console.WriteLine("Walang first name");
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("Hindi pwede mag gamit ng function pag null");
            }
            catch
            {
                Console.WriteLine("Ako bahala sa ibang catch");
            }



            Console.WriteLine("USING CUSTOM EXCEPTION ... EXAMPLE 2");
            try
            {
                int num1 = 20;
                int num2 = 0;

                if (num2 == 0 )
                    throw new CannotDivideByZeroException();

                Console.WriteLine(num1 / num2);
            }
            catch(CannotDivideByZeroException ex)
            {
                Console.WriteLine("Cannot Divide by 0");
            }
            finally
            {
                Console.WriteLine("done handling exceptions....");
            }
            


            #endregion
            #endregion

        }

        #region -- DEBUGGING DEMO --
        public static IEnumerable<int> GetBitValues(string binaryValue)
        {
            return binaryValue
                .Reverse()
                .Select((value, index) =>
                {
                    return value == '1'
                        ? (int)Math.Pow(2, index)
                        : 0;
                }).Reverse();
        }
        #endregion
    }
}